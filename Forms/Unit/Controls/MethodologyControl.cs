using System;
using System.IO;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class MethodologyControl : UserControl
    {
        public MethodologyControl()
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
                MessageBox.Show(ex.StackTrace + ex.Message, "WHAT THE FUCK WHY DOES THIS KEEP SHOWING UP");
            }
        }

        private void MethodologyTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.unit.methodologyDescription = MethodologyTextBox.Text;
        }

        private void showTable1Button_Click(object sender, EventArgs e)
        {
            ShowTableForm table1 = new ShowTableForm("../../Resources/Etapa1_Classificacao_de_risco_ANVISA.jpg", "Quadro 1");
            table1.ShowDialog();
        }

        private void showTable2Button_Click(object sender, EventArgs e)
        {
            ShowTableForm table1 = new ShowTableForm("../../Resources/Quadro2.png", "Quadro 2");
            table1.ShowDialog();
        }

        private void showTable3Button_Click(object sender, EventArgs e)
        {
            ShowTableForm table1 = new ShowTableForm("../../Resources/Quadro3.png", "Quadro 3");
            table1.ShowDialog();
        }

        private void showTable4Button_Click(object sender, EventArgs e)
        {
            ShowTableForm table1 = new ShowTableForm("../../Resources/Quadro4.png", "Quadro 4");
            table1.ShowDialog();
        }
    }
}
