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
    public partial class Form3 : Form
    {
        private uint unit_info_progress = 1;

        public Form3()
        {
            InitializeComponent();
        }

        private void UnitNameTextBox_Enter(object sender, EventArgs e)
        {
            if (UnitNameTextBox.Text == "Nome da sua unidade")
            {
                UnitNameTextBox.Text = "";

                UnitNameTextBox.ForeColor = Color.Black;
            }
        }

        private void UnitNameTextBox_Leave(object sender, EventArgs e)
        {
            if (UnitNameTextBox.Text == "")
            {
                UnitNameTextBox.Text = "Nome da sua unidade";

                UnitNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void UnitNextButton_OnClick(object sender, EventArgs e)
        {
            if (unit_info_progress == 3)
            {
                // DO nothing, should never happen
            }
            else
            {
                // Increase information progress
                unit_info_progress++;
                UnitInformationProgressBar.Value++;

                switch (unit_info_progress)
                {
                    case 2: // Unit director and communication

                        // Enable return button
                        UnitPreviousButton.Enabled = true;

                        // Hide other controls
                        unitLocationControl1.Hide();

                        // Set label
                        UnitStepLabel.Text = "Equipe";
                        
                        break;
                    case 3: // Unit structure and layout

                        // Disable this button
                        UnitNextButton.Enabled = false;
                            
                        // Hide other controls
                        unitLocationControl1.Hide();

                        // Set label
                        UnitStepLabel.Text = "Estrutura";
                        break;
                    default:
                        break;
                }

                // Enable return button
                UnitPreviousButton.Enabled = true;
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            if (unit_info_progress == 1)
            {
                // DO nothing, should never happen
            }
            else
            {
                // Decrease information progress
                unit_info_progress--;
                UnitInformationProgressBar.Value--;

                switch (unit_info_progress)
                {
                    case 1: // Unit location information

                        // Disable this button
                        UnitPreviousButton.Enabled = false;

                        // Hide other controls
                        unitLocationControl1.Show();

                        // Set label
                        UnitStepLabel.Text = "Localização";

                        break;
                    case 2: // Unit director and communication

                        // Enable the next button
                        UnitNextButton.Enabled = true;

                        // Hide other controls
                        unitLocationControl1.Hide();

                        // Set label
                        UnitStepLabel.Text = "Equipe";
                        break;
                    default:
                        break;
                }

                // Enable next button
                UnitNextButton.Enabled = true;
            }
        }
    }
}
