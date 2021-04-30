using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab
{
    public partial class EditPhysicalAgentForm : Form
    {
        public PhysicalAgent createdAgent;

        public EditPhysicalAgentForm()
        {
            InitializeComponent();
        }

        private void noiseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (noiseCheckBox.Checked)
                noiseTextBox.Enabled = true;
            else
                noiseTextBox.Enabled = false;
        }

        private void extremeTemperatureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (extremeTemperatureCheckBox.Checked)
                temperatureTextBox.Enabled = true;
            else
                temperatureTextBox.Enabled = false;
        }

        private void pressureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pressureCheckBox.Checked)
                pressureTextBox.Enabled = true;
            else
                pressureTextBox.Enabled = false;
        }

        private void radiationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (radiationCheckBox.Checked)
            {
                ionizingCheckBox.Enabled = true;
                notIonizingCheckBox.Enabled = true;
            }
            else
            {
                ionizingCheckBox.Enabled = false;
                notIonizingCheckBox.Enabled = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            createdAgent = null;
            Close();
        }

        private void concludeButton_Click(object sender, EventArgs e)
        {
            PhysicalAgent agent = new PhysicalAgent();

            string usageScenarios = "";
            if (teachingCheckBox.Checked)
                usageScenarios += "Ensino\n";

            if (researchCheckBox.Checked)
                usageScenarios += "Pesquisa\n";

            if (productiveProcessCheckBox.Checked)
                usageScenarios += "Processo Produtivo\n";

            if (extensionCheckBox.Checked)
                usageScenarios += "Extensão\n";

            string risks = "";

            if (noiseCheckBox.Checked)
                risks += "Ruídos: " + noiseTextBox.Text +  "\n";

            if (extremeTemperatureCheckBox.Checked)
                risks += "Temperaturas Extremas: " + temperatureTextBox.Text + "\n";

            if (pressureCheckBox.Checked)
                risks += "Pressões Extremas: " + pressureTextBox.Text + "\n";

            if (radiationCheckBox.Checked)
                risks += "Radiação " + (ionizingCheckBox.Checked ? "Ionizante" : "") + (ionizingCheckBox.Checked && notIonizingCheckBox.Checked? " e " : "") + (notIonizingCheckBox.Checked ? "Não Ionizante" : "") + "\n";

            if (intensemagnecticFieldCheckBox.Checked)
                risks += "Campos magnéticos intensos\n";

            if (infraSoundCheckBox.Checked)
                risks += "Infrassom";

            if (ultrasoundCheckBox.Checked)
                risks += "Ultrassom\n";

            if (humidityCheckBox.Checked)
                risks += "Umidade\n";

            agent.generatedRisks = risks;            
            agent.equipment = equipmentTextBox.Text;
            agent.usage = usageScenarios;
            
            try
            {
                agent.CheckValidity();
                createdAgent = agent;
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                createdAgent = null;
            }
        }
    }
}
