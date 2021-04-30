using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class SafetyControl : UserControl
    {
        public Equipment data;
        public Training trainingData;

        public SafetyControl()
        {
            InitializeComponent();
        }

        private void SafetyControlBetter_Load(object sender, EventArgs e)
        {
            data = new Equipment();
            trainingData = new Training();
        }

        private void glassesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPIS[0] = !data.EPIS[0];
        }

        private void concreteWallCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPIS[1] = !data.EPIS[1];
        }

        private void glovesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPIS[2] = !data.EPIS[2];
        }

        private void doserCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPIS[3] = !data.EPIS[3];
        }

        private void dustProcetorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPIS[4] = !data.EPIS[4];
        }

        private void maskCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPIS[5] = !data.EPIS[5];

            if (data.EPIS[5])
                masksEPITextBox.Enabled = true;
            else
                masksEPITextBox.Enabled = false;
        }

        private void otherEPICheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPIS[6] = !data.EPIS[6];

            if (data.EPIS[6])
                otherEPITextBox.Enabled = true;
            else
                otherEPITextBox.Enabled = false;
        }

        private void otherEPITextBox_TextChanged(object sender, EventArgs e)
        {
            data.otherEPI = otherEPITextBox.Text;
        }

        private void masksEPITextBox_TextChanged(object sender, EventArgs e)
        {
            data.maskEPI = masksEPITextBox.Text;
        }

        private void sandobxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPCS[0] = !data.EPCS[0];
        }

        private void vermiculitaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPCS[1] = !data.EPCS[1];
        }

        private void calboxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPCS[2] = !data.EPCS[2];
        }

        private void shovelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPCS[3] = !data.EPCS[3];
        }

        private void chapelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPCS[4] = !data.EPCS[4];
        }

        private void exhaustCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPCS[5] = !data.EPCS[5];
        }

        private void otherEPCCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.EPCS[6] = !data.EPCS[6];

            if (data.EPCS[6])
                otherEPCTextBox.Enabled = true;
            else
                otherEPCTextBox.Enabled = false;
        }

        private void otherEPCTextBox_TextChanged(object sender, EventArgs e)
        {
            data.otherEPC = otherEPCTextBox.Text;
        }

        private void gazeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.firstAidObjects[0] = !data.firstAidObjects[0];
        }

        private void scisorsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.firstAidObjects[1] = !data.firstAidObjects[1];
        }

        private void waterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.firstAidObjects[2] = !data.firstAidObjects[2];
        }

        private void microporeTapeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.firstAidObjects[3] = !data.firstAidObjects[3];
        }

        private void otherFirstAidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.firstAidObjects[4] = !data.firstAidObjects[4];

            if (data.firstAidObjects[4])
                otherFirstAidTextBox.Enabled = true;
            else
                otherFirstAidTextBox.Enabled = false;
        }

        private void otherFirstAidTextBox_TextChanged(object sender, EventArgs e)
        {
            data.otherFirstAid = otherFirstAidTextBox.Text;
        }

        private void noEmergentyBoxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.noFirstAid = !data.noFirstAid;

            if (data.noFirstAid)
                panel3.Enabled = false;
            else
                panel3.Enabled = true;
        }

        private void yesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            trainingData.providesTraining = true;
            textBox1.Enabled = true;
            panel2.Enabled = true;
            numericUpDown1.Enabled = true;
            label7.Enabled = true;
        }

        private void noRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            trainingData.providesTraining = false;
            textBox1.Enabled = false;
            panel2.Enabled = false;
            numericUpDown1.Enabled = false;
            label7.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trainingData.periodicityAmount = (int)numericUpDown1.Value;
        }

        private void daysRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            trainingData.periodicityUnit = "Dias";
        }

        private void monthsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            trainingData.periodicityUnit = "Meses";
        }

        private void weeksRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            trainingData.periodicityUnit = "Semanas";
        }

        private void yearsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            trainingData.periodicityUnit = "Anos";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            trainingData.involvedPersonel = textBox1.Text;
        }


        public void ValidateData()
        {
            if (data != null)
                data.CheckValidity();
            else
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);

            if (trainingData != null)
                trainingData.CheckValidity();
            else
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);
        }
    }
}
