using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab
{
    public partial class EditRiskForm : Form
    {
        public Risk createdRisk;

        public EditRiskForm()
        {
            InitializeComponent();
        }

        private void frequencyTableButton_Click(object sender, EventArgs e)
        {
            ShowTableForm table = new ShowTableForm(Properties.Resources.Quadro3, "Classificação quanto à frequência");
            table.ShowDialog();
        }

        private void severityTableButotn_Click(object sender, EventArgs e)
        {
            ShowTableForm table = new ShowTableForm(Properties.Resources.Quadro1, "Classificação quanto à severidade");
            table.ShowDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            createdRisk = null;
            Close();
        }

        private void concludeButton_Click(object sender, EventArgs e)
        {
            createdRisk = new Risk(
                riskComboBox.Text,
                dangerComboBox.Text,
                safetyGuardComboBox.Text,
                frequencyClassificationComboBox.Text,
                severityClassificationComboBox.Text);

            try
            {
                createdRisk.CheckValidity();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                createdRisk = null;
            }
        }
    }
}
