using RyskTech.Forms.Lab.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab
{
    public partial class RiskCalculateForm : Form
    {
        private Data.Lab data;
        private int progress;
        private bool saved;
        private string path;

        private LabWelcomeControl welcomeControl;
        private GeneralInformationControl generalInformationControl;
        private CalculateControl calculateControl;

        public RiskCalculateForm()
        {
            InitializeComponent();
        }

        public RiskCalculateForm(bool saved, string path)
        {
            this.saved = saved;
            this.path = path;
            InitializeComponent();
        }


        private void RiskCalculateFormBetter_Load(object sender, EventArgs e)
        {
            calculateControl = new CalculateControl();
            calculateControl.Dock = DockStyle.Fill;

            welcomeControl = new LabWelcomeControl();
            welcomeControl.Dock = DockStyle.Fill;

            generalInformationControl = new GeneralInformationControl();
            generalInformationControl.Dock = DockStyle.Fill;

            activeControlPanel.Controls.Add(welcomeControl);
            welcomeTabButton.BackColor = Color.DarkGray;
        }

        private void saveProgress()
        {
            try
            {
                string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string newfolder = Path.Combine(appdata, "Rysktech");
                Directory.CreateDirectory(newfolder);
                string filename = "progress.rysklab";
                newfolder = Path.Combine(newfolder, filename);
                using (System.IO.FileStream fs = System.IO.File.Create(newfolder))
                {

                    if (welcomeControl.data.manipulatesChemicalAgents == true)
                    {
                        if (!activeControlPanel.Controls.Contains(calculateControl))
                            activeControlPanel.Controls.Add(calculateControl);
                        calculateControl.writeChemicalInfo(fs);
                    }




                    MessageBox.Show("Progresso salvo com sucesso!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void clearTabButtonColors()
        {
            welcomeTabButton.BackColor = Color.LightGray;
            chemicalAgentsButton.BackColor = Color.LightGray;
            generalInfoButton.BackColor = Color.LightGray;
            
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
        private void generalInfoButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(generalInformationControl);

            clearTabButtonColors();
            generalInfoButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Informações Gerais";
            nextConcludeButton.Text = "Próximo";
        }

        private void chemicalAgentsButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(calculateControl);

            clearTabButtonColors();
            chemicalAgentsButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Agentes Químicos";
            nextConcludeButton.Text = "Próximo";
        }
        private void saveButton_Click(object sender, EventArgs e)
        {

        }

    }
}
