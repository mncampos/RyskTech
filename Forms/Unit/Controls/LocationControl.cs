using System;
using System.Text;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class LocationControl : UserControl
    {
        public LocationControl()
        {
            InitializeComponent();
        }

        private void UnitSearchButton_Click(object sender, EventArgs e)
        {

            string street = StreetTextBox.Text;
            string city = "Porto Alegre";
            string state = "RS";

            try
            {
                StringBuilder address = new StringBuilder();
                address.Append("https://maps.google.com/maps?q=");

                if (street != string.Empty)
                {
                    address.Append(street + "," + "+");
                }

                address.Append(city + "," + "+");
                address.Append(state + "," + "+");

                // Temporary fix until I find out why javascript is giving errors
                webBrowser1.ScriptErrorsSuppressed = true;

                webBrowser1.Navigate(address.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void RodoviaButton_CheckedChanged(object sender, EventArgs e)
        {
            APR.unit_info.location.prefix = RyskTech.LocationPrefix.Rodovia;
        }

        private void TravessaButton_CheckedChanged(object sender, EventArgs e)
        {
            APR.unit_info.location.prefix = RyskTech.LocationPrefix.Travessa;
        }

        private void AlamedaButton_CheckedChanged(object sender, EventArgs e)
        {
            APR.unit_info.location.prefix = RyskTech.LocationPrefix.Alameda;
        }

        private void AvenidaButton_CheckedChanged(object sender, EventArgs e)
        {
            APR.unit_info.location.prefix = RyskTech.LocationPrefix.Avenida;
        }

        private void RuaButton_CheckedChanged(object sender, EventArgs e)
        {
            APR.unit_info.location.prefix = RyskTech.LocationPrefix.Rua;
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.unit_info.location.street_name = StreetTextBox.Text;
        }

        private void NeighborHoodTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.unit_info.location.neighborhood = NeighborhoodTextBox.Text;
        }

        private void ZIPTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.unit_info.location.ZIP = ZIPTextBox.Text;
        }

        private void ComplementTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.unit_info.location.complement = ComplementTextBox.Text;
        }

        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.unit_info.location.number = uint.Parse(NumberTextBox.Text);
        }
    }
}
