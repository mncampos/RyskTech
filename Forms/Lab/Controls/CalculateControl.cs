using RyskTech.Data;
using RyskTech.Forms.Lab.RiskCalculate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class CalculateControl : UserControl
    {
        public List<ChemicalReactor> reactorData;
        public Storage storageInfo;

        public CalculateControl()
        {
            InitializeComponent();
        }

        private void addReactorButton_Click(object sender, EventArgs e)
        {
            EditChemicalReatorForm2 newChemical = new EditChemicalReatorForm2(null);
            newChemical.ShowDialog();
            addReactorDataToTable(newChemical.createdAgent);
        }

        private void editReactorButton_Click(object sender, EventArgs e)
        {
            if (chemicalReactorData.SelectedRows.Count > 0)
            {
                DataGridViewRow row = chemicalReactorData.SelectedRows[0];

                ChemicalReactor agent = new ChemicalReactor();
                agent.name = row.Cells[0].Value.ToString();                
                agent.casNumber = row.Cells[1].Value.ToString();
                agent.quantity = (float)row.Cells[2].Value;
                agent.measurementUnit = row.Cells[3].Value.ToString();
                agent.riskIndice = (float)row.Cells[4].Value;

                EditChemicalReactorForm editReactorForm = new EditChemicalReactorForm(agent);
                editReactorForm.ShowDialog();

                if (editReactorForm.createdAgent != null)
                {
                    chemicalReactorData.Rows[row.Index].Cells[0].Value = editReactorForm.createdAgent.name;                     
                    chemicalReactorData.Rows[row.Index].Cells[1].Value = editReactorForm.createdAgent.casNumber;
                    chemicalReactorData.Rows[row.Index].Cells[2].Value = editReactorForm.createdAgent.quantity;
                    chemicalReactorData.Rows[row.Index].Cells[3].Value = editReactorForm.createdAgent.measurementUnit;
                    chemicalReactorData.Rows[row.Index].Cells[4].Value = editReactorForm.createdAgent.riskIndice;
                }
            }

        }

        private void CalculateControlBetter_Load(object sender, EventArgs e)
        {
            reactorData = new List<ChemicalReactor>();
            storageInfo = new Storage();
        }

        private void removeReactorButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in chemicalReactorData.SelectedRows)
                chemicalReactorData.Rows.RemoveAt(row.Index);
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
                    agent.casNumber = row.Cells[1].Value.ToString();
                    agent.quantity = (float)row.Cells[2].Value;
                    agent.measurementUnit = row.Cells[3].Value.ToString();
                    agent.riskIndice = (float)row.Cells[4].Value;
                    
                    reactorData.Add(agent);
                }
            }
        }

        private void addReactorDataToTable(ChemicalReactor createdAgent)
        {
            if (createdAgent != null)
            {
                this.chemicalReactorData.Rows.Add(
                     createdAgent.name,
                     createdAgent.casNumber,
                     createdAgent.quantity,
                     createdAgent.measurementUnit,
                     createdAgent.riskIndice
                     );
            }
        }

        public void ValidateData()
        {
            CreateReactorList();

            if (storageInfo != null)
                storageInfo.CheckValidity();
        }

        private void parseReagentLine(string line)
        {
            string[] information = line.Split('£');

            ChemicalReactor loadedReagent = new ChemicalReactor();
            loadedReagent.name = information[0];
            loadedReagent.casNumber = information[1];
            loadedReagent.quantity = (float)Convert.ToDouble(information[2]);
            loadedReagent.measurementUnit = information[3];
            loadedReagent.riskIndice = (float)Convert.ToDouble(information[4]);

            this.addReactorDataToTable(loadedReagent);
        }

        public float calculateRiskIndice(float FD) //Calcula o indice de risco de cada reagente, e retorna o risco geral (média de todos)
        {
            float indiceGeral = 0;
            int index = 0;

            foreach (ChemicalReactor CR in this.reactorData)
            {
                CR.riskIndice = CR.dangerFactor / FD;
                indiceGeral += CR.riskIndice;
                index++;
            }

            return indiceGeral = indiceGeral / index;

        }

        public void writeChemicalInfo(System.IO.FileStream fs)
        { 
            CreateReactorList();            
        }
    }
}
