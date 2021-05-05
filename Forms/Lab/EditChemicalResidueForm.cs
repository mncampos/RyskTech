using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class EditChemicalResidueForm : Form
    {
        public ChemicalResidue createdAgent;

        public EditChemicalResidueForm(ChemicalResidue agent)
        {
            InitializeComponent();
            if (agent != null)
            {
                residueNameTextBox.Text = agent.name;
                physicalStateComboBox.Text = agent.physicalState;
                quantityUpDown.Value = (decimal)agent.quantity;
                measurementUnitComboBox.Text = agent.measurementUnit;
                if (agent.inert)
                    inertRadioButton.Checked = true;
                else
                    activeRadioButton.Checked = true;
                isDangerousCheckBox.Checked = agent.dangerCharacteristics.Length > 0;
                storageLocationTextBox.Text = agent.storageDetails;
            }
        }

        private void concludeButton_Click(object sender, EventArgs e)
        {
            string container = "";
            if (transparentGlassRadioButton.Checked)
                container += Resources.Language.pt_local.TemperedGlassContainer + "\n";
            if (amberGlassRadioButton.Checked)
                container += Resources.Language.pt_local.AmberGlassContainer + "\n";
            if (plasticRadioButton.Checked)
                container += Resources.Language.pt_local.PlasticContainer + "\n";


            string origins = "";
            foreach (string item in originCheckedListBox.CheckedItems)
                origins += item + "\n";


            string dangers = "";
            foreach (string item in dangerCharacteristicsListBox.CheckedItems)
                dangers += item + "\n";


            // Create agent
            ChemicalResidue new_agent =
                new ChemicalResidue(
                    residueNameTextBox.Text,
                    physicalStateComboBox.Text,
                    inertRadioButton.Checked,
                    (float)quantityUpDown.Value,
                    measurementUnitComboBox.Text,
                    origins,
                    isDangerousCheckBox.Checked,
                    dangers,
                    container,
                    storageLocationTextBox.Text
                );

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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.createdAgent = null;
            this.Close();
        }

        private void inertRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (inertRadioButton.Checked)
            {
                dangerCharacteristicsListBox.Enabled = false;
            }
        }

        private void activeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (activeRadioButton.Checked)
            {
                dangerCharacteristicsListBox.Enabled = true;
            }
        }
    }
}
