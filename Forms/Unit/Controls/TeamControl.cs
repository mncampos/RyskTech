using System;
using System.Windows.Forms;
using RyskTech.Data;

namespace RyskTech
{
    public partial class TeamControl : UserControl
    {
        private Team data;

        public TeamControl()
        {
            InitializeComponent();
        }

        private void TeamControl_Load(object sender, EventArgs e)
        {
            data = new Team();
        }

        private void DirectorNameTextBox_TextChanged(object sender, EventArgs e)
        {
            data.director.name = DirectorNameTextBox.Text;
        }

        private void DirectorEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            data.director.eMail = DirectorEmailTextBox.Text;
        }

        private void DirectorPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            data.director.phone = DirectorPhoneTextBox.Text;
        }

        private void ViceNameTextBox_TextChanged(object sender, EventArgs e)
        {
            data.viceDirector.name = ViceNameTextBox.Text;
        }

        private void ViceEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            data.viceDirector.eMail = ViceEmailTextBox.Text;
        }

        private void VicePhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            data.viceDirector.phone = VicePhoneTextBox.Text;
        }

        private void UnitContactTextBox_TextChanged(object sender, EventArgs e)
        {
            data.contactPhone = UnitContactTextBox.Text;
        }

        private void OtherTextBox_TextChanged(object sender, EventArgs e)
        {
            data.otherDescription = OtherTextBox.Text;
        }

        private void PublicNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.generalPublicCount = (int)PublicNumericUpDown.Value;
        }

        private void OtherNumericUpDownCounter_ValueChanged(object sender, EventArgs e)
        {
            data.otherCount = (int)OtherNumericUpDownCounter.Value;
        }

        private void StudentsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.studentsCount = (int)StudentsNumericUpDown.Value;
        }

        private void ProfessionalNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.technicsCount = (int)ProfessionalNumericUpDown.Value;
        }

        private void TeachersNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.teachersCount = (int)TeachersNumericUpDown.Value;
        }

        public void ValidateData()
        {
            // TODO
        }
    }
}
