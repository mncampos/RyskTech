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
                inertRadioButton.Checked);

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
