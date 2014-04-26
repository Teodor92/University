namespace _01.SimpleXml
{
    using System;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml;

    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "File Path";
            this.label1.SetBounds(8, 8, 50, 20);

            this.textBox1.Text = @"..\..\XmlSource\FamilyTree.xml";
            this.textBox1.SetBounds(64, 8, 580, 20);

            this.button1.Text = "Load TreaView";
            this.button1.SetBounds(658, 8, 150, 20);

            this.button2.Text = "Write Xml";
            this.button2.SetBounds(658, 28, 150, 20);

            this.treeView1.SetBounds(8, 72, 800, 500);

            this.Text = "Tree View With XML";
            this.Width = 840;
            this.Height = 670;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var xmlDom = new XmlDocument();
                xmlDom.Load(this.textBox1.Text);

                this.treeView1.Nodes.Clear();
                this.treeView1.Nodes.Add(new TreeNode(xmlDom.DocumentElement.Name));
                var treeNode = new TreeNode();
                treeNode = this.treeView1.Nodes[0];

                this.AddNode(xmlDom.DocumentElement, treeNode);
                this.treeView1.ExpandAll();
            }
            catch (XmlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            if (inXmlNode.HasChildNodes)
            {
                var nodeList = inXmlNode.ChildNodes;
                for (int i = 0; i < nodeList.Count; i++)
                {
                    var currentNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(currentNode.Name));
                    var currentTreeNode = inTreeNode.Nodes[i];
                    this.AddNode(currentNode, currentTreeNode);
                }
            }
            else
            {
                inTreeNode.Text = inXmlNode.OuterXml.Trim();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new XmlTextWriter(@"../../XmlSource/CratedXml.xml", Encoding.GetEncoding("utf-8")))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.IndentChar = '\t';
                    writer.Indentation = 1;

                    writer.WriteStartDocument();

                    writer.WriteStartElement("bookstore");
                    writer.WriteStartElement("book");
                    writer.WriteElementString("title", "Sample Title");
                    writer.WriteElementString("author", "Ivano Ivanov");
                    writer.WriteElementString("price", "123");
                    writer.WriteEndElement();

                    writer.WriteStartElement("book");
                    writer.WriteElementString("title", "Sample Title");
                    writer.WriteElementString("author", "Pesho Peshev");
                    writer.WriteElementString("price", "123");
                    writer.WriteEndElement();

                    writer.WriteStartElement("book");
                    writer.WriteElementString("title", "Sample Title");
                    writer.WriteElementString("author", "Georgi Georrgiev");
                    writer.WriteElementString("price", "123");
                    writer.WriteEndElement();
                    writer.WriteEndElement();

                    writer.WriteEndDocument();

                    MessageBox.Show("Done!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
    }
}
