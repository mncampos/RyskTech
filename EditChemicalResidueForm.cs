using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void concludeButton_Validating(object sender, CancelEventArgs e)
        {
            //?
        }

        private void concludeButton_Click(object sender, EventArgs e)
        {
            // TODO Validate?

            string container="";
            if (transparentGlassRadioButton.Checked)
                container = "Vidro temperado transparente";
            if (amberGlassRadioButton.Checked)
                container = "Vidro temperado âmbar";
            if (plasticRadioButton.Checked)
                container = "Bombona plástica";


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

            this.createdAgent = new_agent;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.createdAgent = null;
            this.Close();
        }
    }
}
