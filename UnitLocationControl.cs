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
    public partial class UnitLocationControl : UserControl
    {
        public UnitLocationControl()
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

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void RodoviaButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TravessaButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AlamedaButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AvenidaButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UnitLocationGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void RuaButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
