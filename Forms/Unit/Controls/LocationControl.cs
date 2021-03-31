using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class LocationControl : UserControl
    {
        public Location data;

        public LocationControl()
        {
            InitializeComponent();
        }

        private void LocationControl_Load(object sender, EventArgs e)
        {
            data = new Location();
        }

        private void UnitSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Temporary fix until I find out why javascript is giving errors
                webBrowser1.ScriptErrorsSuppressed = true;
                webBrowser1.Navigate(data.GetGoogleMapsSearchURL());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void RodoviaButton_CheckedChanged(object sender, EventArgs e)
        {
            data.prefix = LocationPrefix.Highway;
        }

        private void TravessaButton_CheckedChanged(object sender, EventArgs e)
        {
            data.prefix = LocationPrefix.Crossing;
        }

        private void AlamedaButton_CheckedChanged(object sender, EventArgs e)
        {
            data.prefix = LocationPrefix.Boulevard;
        }

        private void AvenidaButton_CheckedChanged(object sender, EventArgs e)
        {
            data.prefix = LocationPrefix.Avenue;
        }

        private void RuaButton_CheckedChanged(object sender, EventArgs e)
        {
            data.prefix = LocationPrefix.Road;
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            data.streetName = StreetTextBox.Text;
        }

        private void NeighborHoodTextBox_TextChanged(object sender, EventArgs e)
        {
            data.district = NeighborhoodTextBox.Text;
        }

        private void ZIPTextBox_TextChanged(object sender, EventArgs e)
        {
            data.ZIPCode = ZIPTextBox.Text;
        }

        private void ComplementTextBox_TextChanged(object sender, EventArgs e)
        {
            data.complement = ComplementTextBox.Text;
        }

        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            data.streetNumber = int.Parse(NumberTextBox.Text);
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
