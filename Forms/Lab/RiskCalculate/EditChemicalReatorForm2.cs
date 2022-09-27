using RyskTech.Data;
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
        public ChemicalReactor createdAgent;
        private bool isEditMode;

        private Dictionary<string, string> substancesCasNumber = new Dictionary<string, string>();
        private Dictionary<string, string> referenceMass = new Dictionary<string, string>();

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
        public EditChemicalReatorForm2(ChemicalReactor agent = null)
        {
            InitializeComponent();
            this.Text = "Adicionar Reagente";

            getAgentNames();
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
            string CAS = casNumberTextBox.Text;
            // Create agent
            ChemicalReactor new_agent = new ChemicalReactor(
                chemicalAgentComboBox.Text,
                (float)agentQuantity.Value,
                measurementUnitComboBox.Text,
                CAS
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
