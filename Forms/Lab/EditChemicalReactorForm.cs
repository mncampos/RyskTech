using System;
using System.Linq;
using System.Windows.Forms;
using RyskTech.Data;

namespace RyskTech.Forms.Lab
{
    public partial class EditChemicalReactorForm : Form
    {
        public ChemicalReactor createdAgent;

        public EditChemicalReactorForm()
        {
            InitializeComponent();
        }

        private void pureRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mixedSubstanceTextBox.Enabled = false;
        }

        private void mixedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mixedSubstanceTextBox.Enabled = true;
        }

        private void concludeButton_Click(object sender, EventArgs e)
        {
            string container = "";
            if (transparentGlassRadioButton.Checked)
                container = Resources.Language.pt_local.TemperedGlassContainer;
            if (amberGlassRadioButton.Checked)
                container = Resources.Language.pt_local.AmberGlassContainer;
            if (plasticRadioButton.Checked)
                container = Resources.Language.pt_local.PlasticContainer;


            string[] origins = new string[originCheckedListBox.CheckedItems.Count];
            foreach (string item in originCheckedListBox.CheckedItems)
                origins.Append(item);


            string[] dangers = new string[dangerCharacteristicsListBox.CheckedItems.Count];
            foreach (string item in dangerCharacteristicsListBox.CheckedItems)
                dangers.Append(item);


            // Create agent
            ChemicalReactor new_agent = new ChemicalReactor(
                residueNameTextBox.Text,
                physicalStateComboBox.Text,
                (float)quantityUpDown.Value,
                measurementUnitComboBox.Text,
                origins,
                casNumberTextBox.Text,
                mixedRadioButton.Checked ? mixedSubstanceTextBox.Text : "Pura",
                dangers, 
                container,
                storageLocationTextBox.Text,
                inertCheckbox.Checked);

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
    }
}
