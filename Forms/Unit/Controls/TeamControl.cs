using System;
using System.Drawing;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class TeamControl : UserControl
    {
        public TeamControl()
        {
            InitializeComponent();
        }

        private void OtherTextBox_Leave(object sender, EventArgs e)
        {
            if (OtherTextBox.Text == "")
            {
                OtherTextBox.Text = "Outros...";

                OtherTextBox.ForeColor = Color.Silver;
            }
        }

        private void OtherTextBox_Enter(object sender, EventArgs e)
        {
            if (OtherTextBox.Text == "Outros...")
            {
                OtherTextBox.Text = "";

                OtherTextBox.ForeColor = Color.Black;
            }
        }

        private void DirectorNameTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.unit.team.director.name = DirectorNameTextBox.Text;
        }

        private void DirectorEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.unit.team.director.e_mail = DirectorEmailTextBox.Text;
        }

        private void DirectorPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.unit.team.director.phone = DirectorPhoneTextBox.Text;
        }

        private void ViceNameTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.unit.team.vice_director.name = ViceNameTextBox.Text;
        }

        private void ViceEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.unit.team.vice_director.e_mail = ViceEmailTextBox.Text;
        }

        private void VicePhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.unit.team.vice_director.phone = VicePhoneTextBox.Text;
        }

        private void UnitContactTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.unit.contactPhone = UnitContactTextBox.Text;
        }

        private void OtherTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.unit.team.other = new Unit.TeamInformation.CivilianInformation(CivilianType.Outros, OtherTextBox.Text);
            APR.unit.team.other.count = (uint)OtherNumericUpDownCounter.Value;
        }

        private void PublicNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            APR.unit.team.general_public.count = (uint)PublicNumericUpDown.Value;
        }

        private void OtherNumericUpDownCounter_ValueChanged(object sender, EventArgs e)
        {
            if (APR.unit.team.other != null)
                APR.unit.team.other.count = (uint)OtherNumericUpDownCounter.Value;
        }

        private void StudentsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            APR.unit.team.students.count = (uint)StudentsNumericUpDown.Value;
        }

        private void ProfessionalNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            APR.unit.team.technics.count = (uint)ProfessionalNumericUpDown.Value;
        }

        private void TeachersNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            APR.unit.team.teachers.count = (uint)TeachersNumericUpDown.Value;
        }
    }
}
