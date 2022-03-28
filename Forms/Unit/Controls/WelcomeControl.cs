using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Unit.Controls
{
    public partial class WelcomeControl : UserControl
    {
        public UnitScope data;

        public WelcomeControl()
        {
            InitializeComponent();
        }

        private void TestWelcomeControl_Load(object sender, EventArgs e)
        {
            data = new UnitScope();
        }

        private void unitNameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.name = unitNameTextBox.Text;
        }

        public void ValidateData()
        {
            data.CheckValidity();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            data.date = dateTimePicker1.Value;
        }
    }
}
