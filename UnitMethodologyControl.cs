using System;
using System.IO;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class UnitMethodologyControl : UserControl
    {
        public UnitMethodologyControl()
        {
            InitializeComponent();

            // Load default text to textbox
            try
            {
                StreamReader re = File.OpenText("../../Resources/default_method.txt");
                string default_method_text = re.ReadToEnd();
                MethodologyTextBox.Text = default_method_text;
                re.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.Message);
            }
        }

        private void MethodologyTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.unit_info.methodology = MethodologyTextBox.Text;
        }
    }
}
