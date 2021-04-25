using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab
{
    public partial class EditBiologicalAgentForm : Form
    {
        public BiologicalAgent createdAgent;

        public EditBiologicalAgentForm()
        {
            InitializeComponent();
        }

        private void showRiskClassTableButton_Click(object sender, EventArgs e)
        {
            ShowTableForm table = new ShowTableForm(Properties.Resources.Quadro1, "Classificação de risco");
            table.ShowDialog();
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            createdAgent = null;
            Close();
        }

        private void concludeButton_Click(object sender, System.EventArgs e)
        {
            BiologicalAgent new_agent = new BiologicalAgent();

            string usageScenarios = "";
            if (productiveProcessCheckBox.Checked)
                usageScenarios += "Processo Produtivo\n";

            if (researchCheckBox.Checked)
                usageScenarios += "Pesquisa\n";

            if (extensionCheckBox.Checked)
                usageScenarios += "Extensão\n";

            if (teachingCheckBox.Checked)
                usageScenarios += "Ensino\n";

            new_agent.name = agentNameTextBox.Text;
            new_agent.riskClassification = riskClassificationTextBox.Text;
            new_agent.usageScenarios = usageScenarios;

            try
            {
                new_agent.CheckValidity();
                this.createdAgent = new_agent;
                this.Close();
            }
            catch (Exception ex)
            {
                this.createdAgent = null;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
