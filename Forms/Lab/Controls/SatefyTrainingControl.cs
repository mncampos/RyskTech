using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class SatefyTrainingControl : UserControl
    {
        public Training data;

        public SatefyTrainingControl()
        {
            InitializeComponent();
        }

        private void SatefyTrainingControl_Load(object sender, System.EventArgs e)
        {
            data = new Training();
        }

        private void yesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            data.providesTraining = true;
            periodicityGroupBox.Enabled = true;
            personnelGroupBox.Enabled = true;
        }

        private void noRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            data.providesTraining = false;
            periodicityGroupBox.Enabled = false;
            personnelGroupBox.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            data.periodicityAmount = (int)numericUpDown1.Value;
        }

        private void daysRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            data.periodicityUnit = "Dias";
        }

        private void monthsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            data.periodicityUnit = "Meses";
        }

        private void weeksRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            data.periodicityUnit = "Semanas";
        }

        private void yearsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            data.periodicityUnit = "Anos";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            data.involvedPersonel = textBox1.Text;
        }

        public void ValidateData()
        {
            if (data != null)
                data.CheckValidity();
            else
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);
        }
    }
}
