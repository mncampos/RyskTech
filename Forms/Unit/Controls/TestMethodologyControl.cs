﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyskTech.Forms.Unit.Controls
{
    public partial class TestMethodologyControl : UserControl
    {
        public string methodology;

        public TestMethodologyControl()
        {
            InitializeComponent();
            MethodologyTextBox.Text = Properties.Resources.default_methodology;
        }

        private void showTable1Button_Click(object sender, EventArgs e)
        {
            ShowTableForm table1 = new ShowTableForm(Properties.Resources.Quadro1, "Quadro 1");
            table1.ShowDialog();
        }

        private void showTable2Button_Click(object sender, EventArgs e)
        {
            ShowTableForm table1 = new ShowTableForm(Properties.Resources.Quadro2, "Quadro 2");
            table1.ShowDialog();
        }

        private void showTable3Button_Click(object sender, EventArgs e)
        {
            ShowTableForm table1 = new ShowTableForm(Properties.Resources.Quadro3, "Quadro 3");
            table1.ShowDialog();
        }

        private void showTable4Button_Click(object sender, EventArgs e)
        {
            ShowTableForm table1 = new ShowTableForm(Properties.Resources.Quadro4, "Quadro 4");
            table1.ShowDialog();
        }

        private void MethodologyTextBox_TextChanged(object sender, EventArgs e)
        {
            methodology = MethodologyTextBox.Text;
        }

        public void ValidateData()
        {
            // nil
        }
    }
}