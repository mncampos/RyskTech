using System;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class ChemicalResidueControl : UserControl
    {
        public ChemicalResidueControl()
        {
            InitializeComponent();
        }

        private void nbrLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.abntcatalogo.com.br/norma.aspx?ID=374798";
            System.Diagnostics.Process.Start(url);
        }

        private void addResidueButton_Click(object sender, EventArgs e)
        {
            EditChemicalResidueForm new_chemical = new EditChemicalResidueForm();
            new_chemical.Show();

            if (new_chemical.createdAgent != null)
            {
                this.chemicalResidueData.Rows.Add(
                    new_chemical.createdAgent.name,
                    new_chemical.createdAgent.physicalState,
                    new_chemical.createdAgent.origin, //
                    new_chemical.createdAgent.quantity + new_chemical.createdAgent.measurementUnit,
                    new_chemical.createdAgent.dangerCharacteristics, //
                    new_chemical.createdAgent.inert,
                    new_chemical.createdAgent.storageDetails,
                    new_chemical.createdAgent.container
                    );
            }
        }

        private void editResidueButton_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void removeResidueButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in chemicalResidueData.SelectedRows)
                this.chemicalResidueData.Rows.RemoveAt(row.Index);
        }
    }
}
