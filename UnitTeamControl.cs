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
    public partial class UnitTeamControl : UserControl
    {
        public UnitTeamControl()
        {
            InitializeComponent();
        }

        private void OtherTextBox_Leave(object sender, EventArgs e)
        {
            if (OtherTextBox.Text == "")
            {
                OtherTextBox.Text = "Outros...";

                OtherTextBox.ForeColor = Color.Silver;
            }
        }

        private void OtherTextBox_Enter(object sender, EventArgs e)
        {
            if (OtherTextBox.Text == "Outros...")
            {
                OtherTextBox.Text = "";

                OtherTextBox.ForeColor = Color.Black;
            }
        }
    }
}
