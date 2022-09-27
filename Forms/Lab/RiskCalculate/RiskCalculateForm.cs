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

namespace RyskTech.Forms.Lab
{
    public partial class RiskCalculateForm : Form
    {
        private LabWelcomeControl welcomeControl;
        private CalculateControl calculateControl;

        public RiskCalculateForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void RiskCalculateFormBetter_Load(object sender, EventArgs e)
        {
            calculateControl = new CalculateControl();
            calculateControl.Dock = DockStyle.Fill;

            welcomeControl = new LabWelcomeControl();
            welcomeControl.Dock = DockStyle.Fill;

            activeControlPanel.Controls.Add(welcomeControl);
            welcomeTabButton.BackColor = Color.DarkGray;
        }

        private void clearTabButtonColors()
        {
            welcomeTabButton.BackColor = Color.LightGray;
            chemicalAgentsButton.BackColor = Color.LightGray;
            
        }

        private void welcomeTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(welcomeControl);

            clearTabButtonColors();
            welcomeTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Bem Vindo!";
            nextConcludeButton.Text = "Próximo";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(calculateControl);

            clearTabButtonColors();
            chemicalAgentsButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Agentes Químicos";
            nextConcludeButton.Text = "Próximo";
        }
    }
}
