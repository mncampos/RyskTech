using RyskTech.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class EditChemicalResidueForm : Form
    {
        public ChemicalResidue createdAgent;

        public EditChemicalResidueForm()
        {
            InitializeComponent();
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
                    isInertCheckBox.Checked,
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
            catch(Exception ex)
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
