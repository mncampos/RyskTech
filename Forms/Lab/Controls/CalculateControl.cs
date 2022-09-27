using RyskTech.Forms.Lab.RiskCalculate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class CalculateControl : UserControl
    {
        public CalculateControl()
        {
            InitializeComponent();
        }

        private void addReactorButton_Click(object sender, EventArgs e)
        {
            Form editReator = new EditChemicalReatorForm2();
            editReator.ShowDialog();
        }

        private void editReactorButton_Click(object sender, EventArgs e)
        {
            var substance = chemicalReactorData.SelectedRows[0].Cells["Substância"].Value;

        }
    }
}
