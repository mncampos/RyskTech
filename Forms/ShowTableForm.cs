using System;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class ShowTableForm : Form
    {
        public ShowTableForm(string imgPath, string title)
        {
            InitializeComponent();

            this.Text = title;
            this.pictureBox1.Load(imgPath);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
