namespace WindowsFormsApplication
{
    using System;
    using System.Windows.Forms;

    public partial class ColorChanger : Form
    {
        public ColorChanger()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = this.colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                switch (this.listBox1.SelectedIndex)
                {
                    case 0: this.BackColor = this.colorDialog1.Color;
                        break;
                    case 1: this.button1.BackColor = this.colorDialog1.Color;
                        break;
                    case 2: this.button1.ForeColor = this.colorDialog1.Color;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
