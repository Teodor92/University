namespace BasicControls
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class frm1 : Form
    {
        public frm1()
        {
            this.InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var personalData = string.Format(
                @"{0} {1} {2} {1} {3} {1}", 
                this.names.Text,
                Environment.NewLine,
                this.phone.Text,
                this.birthCity.Text);

            this.richTextBoxDisplay.Text = this.richTextBoxDisplay.Text + personalData;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var uniData = string.Format(
                @"{0} {1} {2} {1} {3} {1}",
                this.facNumber.Text,
                Environment.NewLine,
                this.group.Text,
                this.direction.Text);

            this.richTextBoxDisplay.Text = this.richTextBoxDisplay.Text + uniData;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.Red.Checked)
            {
                this.richTextBoxDisplay.ForeColor = Color.Red;
            }

            if (this.Green.Checked)
            {
                this.richTextBoxDisplay.ForeColor = Color.Green;
            }

            if (this.Blue.Checked)
            {
                this.richTextBoxDisplay.ForeColor = Color.Blue;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.richTextBoxDisplay.Clear();
            this.names.Clear();
            this.phone.Clear();
            this.birthCity.Clear();
            this.facNumber.Clear();
            this.group.SelectedIndex = -1;
            this.direction.SelectedIndex = -1;
        }
    }
}
