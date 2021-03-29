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
    public partial class SafetyControl : UserControl
    {
        public SafetyControl()
        {
            InitializeComponent();
        }

        private void glassesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.EPIS[0] = !APR.lab_info.safety_info.EPIS[0];
        }

        private void concreteWallCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.EPIS[1] = !APR.lab_info.safety_info.EPIS[1];
        }

        private void glovesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.EPIS[2] = !APR.lab_info.safety_info.EPIS[2];
        }

        private void doserCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.EPIS[3] = !APR.lab_info.safety_info.EPIS[3];
        }

        private void dustProcetorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.EPIS[4] = !APR.lab_info.safety_info.EPIS[4];
        }

        private void maskCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.EPIS[5] = !APR.lab_info.safety_info.EPIS[5];
            
            if (APR.lab_info.safety_info.EPIS[5])
                masksEPITextBox.Enabled = true;
            else
                masksEPITextBox.Enabled = false;
        }

        private void otherEPICheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.EPIS[6] = !APR.lab_info.safety_info.EPIS[6];

            if (APR.lab_info.safety_info.EPIS[6])
                otherEPITextBox.Enabled = true;
            else
                otherEPITextBox.Enabled = false;
        }

        private void otherEPITextBox_TextChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.otherEPI = otherEPITextBox.Text;
        }

        private void masksEPITextBox_TextChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.maskEPI = masksEPITextBox.Text;
        }

        private void sandobxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.EPCS[0] = !APR.lab_info.safety_info.EPCS[0];
        }

        private void vermiculitaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.EPCS[1] = !APR.lab_info.safety_info.EPCS[1];
        }

        private void calboxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.EPCS[2] = !APR.lab_info.safety_info.EPCS[2];
        }

        private void shovelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.EPCS[3] = !APR.lab_info.safety_info.EPCS[3];
        }

        private void chapelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.EPCS[4] = !APR.lab_info.safety_info.EPCS[4];
        }

        private void exhaustCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.EPCS[5] = !APR.lab_info.safety_info.EPCS[5];
        }

        private void otherEPCCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.EPCS[6] = !APR.lab_info.safety_info.EPCS[6];

            if (APR.lab_info.safety_info.EPCS[6])
                otherEPCTextBox.Enabled = true;
            else
                otherEPCTextBox.Enabled = false;
        }

        private void otherEPCTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.otherEPC = otherEPCTextBox.Text;
        }

        private void gazeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.firstAidObjects[0] = !APR.lab_info.safety_info.firstAidObjects[0];
        }

        private void scisorsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.firstAidObjects[1] = !APR.lab_info.safety_info.firstAidObjects[1];
        }

        private void waterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.firstAidObjects[2] = !APR.lab_info.safety_info.firstAidObjects[2];
        }

        private void microporeTapeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.firstAidObjects[3] = !APR.lab_info.safety_info.firstAidObjects[3];
        }

        private void otherFirstAidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.firstAidObjects[4] = !APR.lab_info.safety_info.firstAidObjects[4];

            if (APR.lab_info.safety_info.firstAidObjects[4])
                otherFirstAidTextBox.Enabled = true;
            else
                otherFirstAidTextBox.Enabled = false;
        }

        private void otherFirstAidTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.otherFirstAid = otherFirstAidTextBox.Text;
        }

        private void noEmergentyBoxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.noFirstAid = !APR.lab_info.safety_info.noFirstAid;
        }

        private void yesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            periodicityGroupBox.Enabled = true;
            personnelGroupBox.Enabled = true;
            APR.lab_info.safety_info.providesTraining = true;
        }

        private void noRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            periodicityGroupBox.Enabled = false;
            personnelGroupBox.Enabled = false;
            APR.lab_info.safety_info.providesTraining = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.periodicityAmount = (int)numericUpDown1.Value;
        }

        private void daysRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.periodicityUnit = "Dias";
        }

        private void weeksRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.periodicityUnit = "Semanas";
        }

        private void monthsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.periodicityUnit = "Meses";
        }

        private void yearsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.periodicityUnit = "Anos";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            APR.lab_info.safety_info.involvedPersonel = textBox1.Text;
        }
    }
}
