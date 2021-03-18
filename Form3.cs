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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UnitNameTextBox_Enter(object sender, EventArgs e)
        {
            if (UnitNameTextBox.Text == "Nome da sua unidade")
            {
                UnitNameTextBox.Text = "";

                UnitNameTextBox.ForeColor = Color.Black;
            }
        }

        private void UnitNameTextBox_Leave(object sender, EventArgs e)
        {
            if (UnitNameTextBox.Text == "")
            {
                UnitNameTextBox.Text = "Nome da sua unidade";

                UnitNameTextBox.ForeColor = Color.Silver;
            }
        }
    }
}
