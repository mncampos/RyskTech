using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class LabWelcomeControl : UserControl
    {
        private LabScope data;

        public LabWelcomeControl()
        {
            InitializeComponent();
        }

        private void LabWelcomeControl_Load(object sender, EventArgs e)
        {
            data = new LabScope();
        }

        private void unitNameTextBox_TextChanged(object sender, EventArgs e)
        {
            data.belongingUnitName = unitNameTextBox.Text;
        }

        private void labNameTextBox_TextChanged(object sender, EventArgs e)
        {
            data.labName = labNameTextBox.Text;
        }

        private void chemicalAgentsUsedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.manipulatesChemicalAgents = chemicalAgentsUsedCheckBox.Checked;
        }

        private void biologicalAgentsUsedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.manipulatesBiologicalAgents = biologicalAgentsUsedCheckBox.Checked;
        }

        private void physicalAgentsUsedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.manipulatesPhysicalAgents = physicalAgentsUsedCheckBox.Checked;
        }

        private void mechanicalAgentsUsedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.manipulatesMechanicalAgents = mechanicalAgentsUsedCheckBox.Checked;
        }

        private void concludeButton_Click(object sender, EventArgs e)
        {
            ((LabMainForm)this.TopLevelControl).Complete();
        }

        public void ValidateData()
        {
            if (data != null)
                data.CheckValidity();
            else
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);
        }
    }
}
