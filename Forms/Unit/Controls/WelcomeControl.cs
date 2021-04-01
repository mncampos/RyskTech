using RyskTech.Data;
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

        private void WelcomeControl_Load(object sender, System.EventArgs e)
        {
            data = new UnitScope();
        }

        private void concludeButton_Click(object sender, System.EventArgs e)
        {
            ((UnitMainForm)this.TopLevelControl).Complete();
        }

        private void unitNameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.name = unitNameTextBox.Text;
        }

        private void chemicalAgentsUsedCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            data.manipulatesChemicalAgents = chemicalAgentsUsedCheckBox.Checked;
        }

        private void biologicalAgentsUsedCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            data.manipulatesBiologicalAgents = biologicalAgentsUsedCheckBox.Checked;
        }

        private void physicalAgentsUsedCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            data.manipulatesPhysicalAgents = physicalAgentsUsedCheckBox.Checked;
        }

        private void mechanicalAgentsUsedCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            data.manipulatesMechanicalAgents = mechanicalAgentsUsedCheckBox.Checked;
        }

        public void ValidateData()
        {
            data.CheckValidity();
        }
    }
}
