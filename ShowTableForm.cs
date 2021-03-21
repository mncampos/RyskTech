using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class ShowTableForm : Form
    {
        private String impgPath;

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
