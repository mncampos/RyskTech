using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab
{
    public partial class EditMechanicalAgentForm : Form
    {
        public MechanicalAgent createdAgent;

        public EditMechanicalAgentForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            createdAgent = null;
            Close();
        }

        private void agentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (agentComboBox.Text == "Outros")
                otherNameTextBox.Enabled = true;
            else
                otherNameTextBox.Enabled = false;
        }

        private void riskComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (riskComboBox.Text == "Outros")
                otherRiskTextBox.Enabled = true;
            else
                otherRiskTextBox.Enabled = false;
        }

        private void concludeButton_Click(object sender, EventArgs e)
        {
            MechanicalAgent agent = new MechanicalAgent();

            agent.name = agentComboBox.Text == "Outros" ? otherNameTextBox.Text : agentComboBox.Text;
            agent.associatedRisk = riskComboBox.Text == "Outros" ? otherRiskTextBox.Text : riskComboBox.Text;
            agent.additionalInfo = additionalInfoTextBox.Text;

            try 
            {
                agent.CheckValidity();
                createdAgent = agent;
                Close();
            }
            catch(Exception ex)
            {
                this.createdAgent = null;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
