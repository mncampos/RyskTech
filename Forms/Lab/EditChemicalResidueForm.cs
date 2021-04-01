using RyskTech.Data;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class EditChemicalResidueForm : Form
    {
        public ChemicalAgent createdAgent;

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


            string[] origins = new string[originCheckedListBox.CheckedItems.Count];
            foreach (string item in originCheckedListBox.CheckedItems)
                origins.Append(item);


            string[] dangers = new string[dangerCharacteristicsListBox.CheckedItems.Count];
            foreach (string item in dangerCharacteristicsListBox.CheckedItems)
                dangers.Append(item);


            // Create agent
            ChemicalAgent new_agent =
                new ChemicalAgent(
                    residueNameTextBox.Text,
                    physicalStateComboBox.Text,
                    isInertCheckBox.Checked,
                    (float)quantityUpDown.Value,
                    measurementUnitComboBox.Text,
                    origins,
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
