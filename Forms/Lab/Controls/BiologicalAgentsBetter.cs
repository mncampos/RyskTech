using RyskTech.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class BiologicalAgentsBetter : UserControl
    {
        public BiologicalInfo data;
        public string storage;
        public string destination;

        public BiologicalAgentsBetter()
        {
            InitializeComponent();
        }

        private void BiologicalAgentsBetter_Load(object sender, EventArgs e)
        {
            data = new BiologicalInfo();
        }

        private void AddAgentDataToTable(BiologicalAgent createdAgent)
        {
            if (createdAgent != null)
            {
                bioAgentData.Rows.Add(
                    createdAgent.name,
                    createdAgent.riskClassification,
                    createdAgent.usageScenarios);
            }
        }

        private void addBiologicalResidueButton_Click(object sender, EventArgs e)
        {
            EditBiologicalAgentForm newAgentForm = new EditBiologicalAgentForm();
            newAgentForm.ShowDialog();

            AddAgentDataToTable(newAgentForm.createdAgent);
        }

        private void removeBioResidueButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in bioAgentData.SelectedRows)
                bioAgentData.Rows.RemoveAt(row.Index);
        }

        private void addSampleButton_Click(object sender, EventArgs e)
        {
            if (newProcessedSampleTextBox.Text != null && newProcessedSampleTextBox.Text.Length > 0)
                processedSamplesListBox.Items.Add(newProcessedSampleTextBox.Text);

            newProcessedSampleTextBox.Text = "";
        }

        private void removeSampleButton_Click(object sender, EventArgs e)
        {
            if (processedSamplesListBox.SelectedIndex >= 0)
                processedSamplesListBox.Items.RemoveAt(processedSamplesListBox.SelectedIndex);
        }

        private void sisgenRegistryNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            data.SISGEN = sisgenRegistryNumberTextBox.Text;
        }

        private void ogmYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            data.hasOGM = true;
        }

        private void ogmNoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            data.hasOGM = false;
        }

        private void certificateYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            data.hasBioSecurityCertificate = true;
        }

        private void certificateNoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            data.hasBioSecurityCertificate = false;
        }

        private void CreateBiologicalAgentList()
        {
            data.biologicalAgentList = new List<BiologicalAgent>();
            foreach (DataGridViewRow row in bioAgentData.Rows)
            {
                if (row.Cells[0] != null)
                {
                    BiologicalAgent agent = new BiologicalAgent(
                        row.Cells[0].Value.ToString(),
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString()
                    );
                    data.biologicalAgentList.Add(agent);
                }
            }
        }

        private void bioResidueDestinationTextBox_TextChanged(object sender, EventArgs e)
        {
            destination = bioResidueDestinationTextBox.Text;
        }

        private void bioStorageTextBox_TextChanged(object sender, EventArgs e)
        {
            storage = bioStorageTextBox.Text;
        }

        public void ValidateData()
        {

            if (this.data == null)
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);

            CreateBiologicalAgentList();
            if (processedSamplesListBox.Items == null || processedSamplesListBox.Items.Count <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoProcessedSamples);

            data.processedSamples = processedSamplesListBox.Items.Cast<String>().ToList();

            data.CheckValidity();

            if (storage == null || destination == null)
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);

            if (storage.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoResidueStorageDescription);

            if (destination.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoResidueDestination);

        }
    }
}
