using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class GeneralInformationControl : UserControl
    {
        public Characteristics data;

        public GeneralInformationControl()
        {
            InitializeComponent();
        }

        private void GeneralInformationControlBetter_Load(object sender, EventArgs e)
        {
            data = new Characteristics();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // TODO EMAIL
        }

        private void responsiblePersonTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.responsiblePersonName = responsiblePersonTextBox.Text;
        }

        private void spaceCharacterizationTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.usageCharacterization = spaceCharacterizationTextBox.Text;
        }

        private void buildingTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.building = buildingTextBox.Text;
        }

        private void roomTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.room = roomTextBox.Text;
        }

        private void responsiblePersonContactTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.responsiblePersonContact = responsiblePersonContactTextBox.Text;
        }

        public void ValidateData()
        {
            data.CheckValidity();
        }

        private void teachersNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.teachersCount = (int)teachersNumericUpDown.Value;
        }

        private void technicsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.technicsCount = (int)technicsNumericUpDown.Value;
        }

        private void studentsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.studentsCount = (int)studentsNumericUpDown.Value;
        }

        private void publicNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.generalPublicCount = (int)publicNumericUpDown.Value;
        }
    }
}
