using System;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class ShowTableForm : Form
    {
        public ShowTableForm(System.Drawing.Bitmap table, string title)
        {
            InitializeComponent();

            this.Text = title;
            this.pictureBox1.Image = table;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
