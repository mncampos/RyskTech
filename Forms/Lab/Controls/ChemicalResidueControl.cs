using RyskTech.Data;
using RyskTech.Forms.Lab;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class ChemicalResidueControl : UserControl
    {
        public List<ChemicalResidue> residueData;
        public List<ChemicalReactor> reactorData;
        public Storage storageInfo;

        public ChemicalResidueControl()
        {
            InitializeComponent();
        }

        private void ChemicalResidueControl_Load(object sender, EventArgs e)
        {
            residueData = new List<ChemicalResidue>();
            reactorData = new List<ChemicalReactor>();
            storageInfo = new Storage();
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

        private void addResidueButton_Click(object sender, EventArgs e)
        {
            EditChemicalResidueForm new_chemical = new EditChemicalResidueForm();
            new_chemical.ShowDialog();

            addResidueDataToTable(new_chemical.createdAgent);
        }

        private void addReactorButton_Click(object sender, EventArgs e)
        {
            EditChemicalReactorForm new_chemical = new EditChemicalReactorForm();
            new_chemical.ShowDialog();

            addReactorDataToTable(new_chemical.createdAgent);
        }

        private void editResidueButton_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void editReactorButton_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void removeResidueButton_Click(object sender, EventArgs e)
        {
            // TODO Confirm if user really wants to do this
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
                    agent.dangerous = (bool)row.Cells[5].Value;
                    agent.dangerCharacteristics = row.Cells[6].Value.ToString();
                    agent.inert = (bool)row.Cells[7].Value;
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
                    agent.inert = (bool)row.Cells[8].Value;
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
                    createdAgent.dangerous,
                    createdAgent.dangerCharacteristics, //
                    createdAgent.inert,
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
                    createdAgent.inert,
                    createdAgent.storageDetails,
                    createdAgent.container
                    );
            }
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

        private void fispqExplanation_TextChanged(object sender, EventArgs e)
        {
            storageInfo.FISPQExplanation = fispqExplanation.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            storageInfo.storageDescription = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            storageInfo.residueDestination = textBox2.Text;
        }

        public void ValidateData()
        {
            if (residueData == null)
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);

            // I think only this is necessary, because it's possible
            // that no chemical agents are manipulated on the lab
            CreateResidueList();

            CreateReactorList();

            if (storageInfo != null)
                storageInfo.CheckValidity();
        }
    }
}
