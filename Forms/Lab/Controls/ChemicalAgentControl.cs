using RyskTech.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class ChemicalAgentControl : UserControl
    {
        public List<ChemicalResidue> residueData;
        public List<ChemicalReactor> reactorData;
        public Storage storageInfo;

        public ChemicalAgentControl()
        {
            InitializeComponent();
        }

        private void ChemicalAgentControlBetter_Load(object sender, EventArgs e)
        {
            residueData = new List<ChemicalResidue>();
            reactorData = new List<ChemicalReactor>();
            storageInfo = new Storage();
        }

        private void addResidueButton_Click(object sender, EventArgs e)
        {
            EditChemicalResidueForm new_chemical = new EditChemicalResidueForm(null);
            new_chemical.ShowDialog();

            addResidueDataToTable(new_chemical.createdAgent);
        }

        private void addReactorButton_Click(object sender, EventArgs e)
        {
            EditChemicalReactorForm new_chemical = new EditChemicalReactorForm(null);
            new_chemical.ShowDialog();

            addReactorDataToTable(new_chemical.createdAgent);
        }

        private void editReactorButton_Click(object sender, EventArgs e)
        {
            if (chemicalReactorData.SelectedRows.Count > 0)
            {
                DataGridViewRow row = chemicalReactorData.SelectedRows[0];

                ChemicalReactor agent = new ChemicalReactor();
                agent.name = row.Cells[0].Value.ToString();
                agent.physicalState = row.Cells[1].Value.ToString();
                agent.origin = row.Cells[2].Value.ToString();
                agent.quantity = (float)row.Cells[3].Value;
                agent.measurementUnit = row.Cells[4].Value.ToString();
                agent.mixtureDescription = row.Cells[5].Value.ToString();
                agent.casNumber = row.Cells[6].Value.ToString();
                agent.dangerCharacteristics = row.Cells[7].Value.ToString();
                agent.inert = row.Cells[8].Value.Equals("Sim");
                agent.storageDetails = row.Cells[9].Value.ToString();
                agent.container = row.Cells[10].Value.ToString();

                EditChemicalReactorForm editReactorForm = new EditChemicalReactorForm(agent);
                editReactorForm.ShowDialog();

                if (editReactorForm.createdAgent != null)
                {
                    chemicalReactorData.Rows[row.Index].Cells[0].Value = editReactorForm.createdAgent.name;
                    chemicalReactorData.Rows[row.Index].Cells[1].Value = editReactorForm.createdAgent.physicalState;
                    chemicalReactorData.Rows[row.Index].Cells[2].Value = editReactorForm.createdAgent.origin; //
                    chemicalReactorData.Rows[row.Index].Cells[3].Value = editReactorForm.createdAgent.quantity;
                    chemicalReactorData.Rows[row.Index].Cells[4].Value = editReactorForm.createdAgent.measurementUnit;
                    chemicalReactorData.Rows[row.Index].Cells[5].Value = editReactorForm.createdAgent.mixtureDescription;
                    chemicalReactorData.Rows[row.Index].Cells[6].Value = editReactorForm.createdAgent.casNumber;
                    chemicalReactorData.Rows[row.Index].Cells[7].Value = editReactorForm.createdAgent.dangerCharacteristics; //
                    chemicalReactorData.Rows[row.Index].Cells[8].Value = editReactorForm.createdAgent.inert ? "Sim" : "Não";
                    chemicalReactorData.Rows[row.Index].Cells[9].Value = editReactorForm.createdAgent.storageDetails;
                    chemicalReactorData.Rows[row.Index].Cells[10].Value = editReactorForm.createdAgent.container;
                }
            }
        }

        private void editResidueButton_Click(object sender, EventArgs e)
        {
            if (chemicalResidueData.SelectedRows.Count > 0)
            {
                DataGridViewRow row = chemicalResidueData.SelectedRows[0];

                ChemicalResidue agent = new ChemicalResidue();
                agent.name = row.Cells[0].Value.ToString();
                agent.physicalState = row.Cells[1].Value.ToString();
                agent.origin = row.Cells[2].Value.ToString();
                agent.quantity = (float)row.Cells[3].Value;
                agent.measurementUnit = row.Cells[4].Value.ToString();
                agent.dangerous = row.Cells[5].Value.Equals("Sim");
                agent.dangerCharacteristics = row.Cells[6].Value.ToString();
                agent.inert = row.Cells[7].Value.Equals("Sim");
                agent.storageDetails = row.Cells[8].Value.ToString();
                agent.container = row.Cells[9].Value.ToString();

                EditChemicalResidueForm editResidueForm = new EditChemicalResidueForm(agent);
                editResidueForm.ShowDialog();

                if (editResidueForm.createdAgent != null)
                {
                    chemicalResidueData.Rows[row.Index].Cells[0].Value = editResidueForm.createdAgent.name;
                    chemicalResidueData.Rows[row.Index].Cells[1].Value = editResidueForm.createdAgent.physicalState;
                    chemicalResidueData.Rows[row.Index].Cells[2].Value = editResidueForm.createdAgent.origin; //
                    chemicalResidueData.Rows[row.Index].Cells[3].Value = editResidueForm.createdAgent.quantity;
                    chemicalResidueData.Rows[row.Index].Cells[4].Value = editResidueForm.createdAgent.measurementUnit;
                    chemicalResidueData.Rows[row.Index].Cells[5].Value = editResidueForm.createdAgent.dangerous ? "Sim" : "Não";
                    chemicalResidueData.Rows[row.Index].Cells[6].Value = editResidueForm.createdAgent.dangerCharacteristics; //
                    chemicalResidueData.Rows[row.Index].Cells[7].Value = editResidueForm.createdAgent.inert ? "Sim" : "Não";
                    chemicalResidueData.Rows[row.Index].Cells[8].Value = editResidueForm.createdAgent.storageDetails;
                    chemicalResidueData.Rows[row.Index].Cells[9].Value = editResidueForm.createdAgent.container;
                }
            }
        }



        private void removeResidueButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in chemicalResidueData.SelectedRows)
                chemicalResidueData.Rows.RemoveAt(row.Index);
        }

        private void removeReactorButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in chemicalReactorData.SelectedRows)
                chemicalReactorData.Rows.RemoveAt(row.Index);
        }

        private void CreateResidueList()
        {
            residueData = new List<ChemicalResidue>();
            foreach (DataGridViewRow row in chemicalResidueData.Rows)
            {
                if (row.Cells[0] != null)
                {
                    ChemicalResidue agent = new ChemicalResidue();
                    agent.name = row.Cells[0].Value.ToString();
                    agent.physicalState = row.Cells[1].Value.ToString();
                    agent.origin = row.Cells[2].Value.ToString();
                    agent.quantity = (float)row.Cells[3].Value;
                    agent.measurementUnit = row.Cells[4].Value.ToString();
                    agent.dangerous = row.Cells[5].Value.Equals("Sim");
                    agent.dangerCharacteristics = row.Cells[6].Value.ToString();
                    agent.inert = row.Cells[7].Value.Equals("Sim");
                    agent.storageDetails = row.Cells[8].Value.ToString();
                    agent.container = row.Cells[9].Value.ToString();

                    residueData.Add(agent);
                }
            }
        }

        private void CreateReactorList()
        {
            reactorData = new List<ChemicalReactor>();
            foreach (DataGridViewRow row in chemicalReactorData.Rows)
            {
                if (row.Cells[0] != null)
                {
                    ChemicalReactor agent = new ChemicalReactor();
                    agent.name = row.Cells[0].Value.ToString();
                    agent.physicalState = row.Cells[1].Value.ToString();
                    agent.origin = row.Cells[2].Value.ToString();
                    agent.quantity = (float)row.Cells[3].Value;
                    agent.measurementUnit = row.Cells[4].Value.ToString();
                    agent.mixtureDescription = row.Cells[5].Value.ToString();
                    agent.casNumber = row.Cells[6].Value.ToString();
                    agent.dangerCharacteristics = row.Cells[7].Value.ToString();
                    agent.inert = row.Cells[8].Value.Equals("Sim");
                    agent.storageDetails = row.Cells[9].Value.ToString();
                    agent.container = row.Cells[10].Value.ToString();

                    reactorData.Add(agent);
                }
            }
        }

        public void addResidueDataToTable(ChemicalResidue createdAgent)
        {
            if (createdAgent != null)
            {
                this.chemicalResidueData.Rows.Add(
                    createdAgent.name,
                    createdAgent.physicalState,
                    createdAgent.origin, //
                    createdAgent.quantity,
                    createdAgent.measurementUnit,
                    createdAgent.dangerous ? "Sim" : "Não",
                    createdAgent.dangerCharacteristics, //
                    createdAgent.inert ? "Sim" :"Não",
                    createdAgent.storageDetails,
                    createdAgent.container
                    );
            }
        }

        private void addReactorDataToTable(ChemicalReactor createdAgent)
        {
            if (createdAgent != null)
            {
                this.chemicalReactorData.Rows.Add(
                     createdAgent.name,
                     createdAgent.physicalState,
                     createdAgent.origin, //
                     createdAgent.quantity,
                     createdAgent.measurementUnit,
                     createdAgent.mixtureDescription,
                     createdAgent.casNumber,
                     createdAgent.dangerCharacteristics, //
                     createdAgent.inert ? "Sim" : "Não",
                     createdAgent.storageDetails,
                     createdAgent.container
                     );
            }
        }

        private void nbrLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.abntcatalogo.com.br/norma.aspx?ID=374798";
            System.Diagnostics.Process.Start(url);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.abntcatalogo.com.br/norma.aspx?ID=374798";
            System.Diagnostics.Process.Start(url);
        }

        private void yesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            storageInfo.NBRCompliant = true;
        }

        private void noRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            storageInfo.NBRCompliant = false;
        }

        private void noFISPQRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            storageInfo.FISPQCompliant = false;
        }

        private void hasFISPQRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            storageInfo.FISPQCompliant = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            storageInfo.residueDestination = textBox2.Text;
        }

        public void ValidateData()
        {
            if (residueData == null)
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);

            CreateResidueList();
            CreateReactorList();

            if (storageInfo != null)
                storageInfo.CheckValidity();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(residuosCheckbox.Checked == true)
            {
                label3.Visible = true;
                chemicalResidueData.Visible = true;
                addResidueButton.Visible = true;
                editResidueButton.Visible = true;
                removeResidueButton.Visible = true;
                chemicalReactorData.Width = 252;
            }

            if(residuosCheckbox.Checked == false)
            {
                label3.Visible = false;
                chemicalResidueData.Visible = false;
                addResidueButton.Visible = false;
                editResidueButton.Visible = false;
                removeResidueButton.Visible = false;
                chemicalReactorData.Width = 557;

            }

        }
    }
}
