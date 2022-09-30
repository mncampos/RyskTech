using RyskTech.Data;
using RyskTech.Forms.Lab.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.RiskCalculate
{
    public partial class EditChemicalReatorForm2 : Form
    {
        public GeneralInformationControl generalInformationControl;
        public ChemicalReactor createdAgent;
        private bool isEditMode;

        private Dictionary<string, string> substancesCasNumber = new Dictionary<string, string>();
        private Dictionary<string, string> referenceMass = new Dictionary<string, string>();

        private void EditChemicalReatorForm2_Load(object sender, EventArgs e)
        {
            generalInformationControl = new GeneralInformationControl();
        }
        private void getAgentNames()
        {
            string substanceString = Properties.Resources.substances;
            string numbersString = Properties.Resources.cas_numbers;
            string referenceMasses = Properties.Resources.massaReferencia;

            string[] substances = substanceString.Split('\n');
            string[] casNumbers = numbersString.Split('\n');
            string[] masses = referenceMasses.Split('\n');

            // Populate combo box
            foreach (var substance in substances)
                chemicalAgentComboBox.Items.Add(String.Concat(substance.Trim()));

            // Build dictoinary
            for (int i = 0; i < substances.Count(); i++)
            {
                string substance = String.Concat(substances[i].Trim());
                string casNumber = String.Concat(casNumbers[i].Trim());
                substancesCasNumber.Add(substance, casNumber);
            }

            for (int i = 0; i < substances.Count(); i++)
            {
                string substance = String.Concat(substances[i].Trim());
                string referenceMassNumber = String.Concat(masses[i].Trim());
                referenceMass.Add(substance, referenceMassNumber);

            }

        }
        private float riskIndiceCalculation()
        {
            float distanceFactor = generalInformationControl.data.vulnerableAreaDistance;
            float dangerFactor = (float)0.2 / (float)referenceMassUpDown.Value;
            return dangerFactor / distanceFactor;
        }

        public EditChemicalReatorForm2(ChemicalReactor agent)
        {
            InitializeComponent();
            this.Text = "Adicionar Reagente";

            getAgentNames();

            if (agent != null)
            {
                string[] origins = agent.origin.Split('\n');
                string[] dangers = agent.dangerCharacteristics.Split('\n');
                string[] containers = agent.container.Split('\n');            

                chemicalAgentComboBox.Text = agent.name;
                agentQuantity.Value = (decimal)agent.quantity;
                measurementUnitComboBox.Text = agent.measurementUnit;
                casNumberTextBox.Text = agent.casNumber;
            }
        }

        private void chemicalAgentComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string substance = chemicalAgentComboBox.Text;

            foreach (string name in substancesCasNumber.Keys)
            {
                if (name == substance)
                {
                    casNumberTextBox.Text = substancesCasNumber[name];
                }
            }

            foreach (string name in referenceMass.Keys)
            {
                if (name == substance)
                {
                    referenceMassUpDown.Value = Convert.ToDecimal(referenceMass[name]);
                }
            }
        }

        private void concludeButton_Click(object sender, EventArgs e)
        {
            // Create agent
            ChemicalReactor new_agent = new ChemicalReactor(
                chemicalAgentComboBox.Text,
                (float)agentQuantity.Value,
                measurementUnitComboBox.Text,
                casNumberTextBox.Text,
                riskIndiceCalculation()
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

    }
}
