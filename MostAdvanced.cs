using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// From the nuget package
using Syncfusion.DocIO.DLS;

namespace RyskTech
{
    public partial class MostAdvanced : Form
    {
        public MostAdvanced()
        {
            InitializeComponent();
        }

        private void UnitNameTextBox_Enter(object sender, EventArgs e)
        {
            if (UnitNameTextBox.Text == "Nome da sua unidade")
            {
                UnitNameTextBox.Text = "";

                UnitNameTextBox.ForeColor = Color.Black;
            }
        }

        private void UnitNameTextBox_Leave(object sender, EventArgs e)
        {
            if (UnitNameTextBox.Text == "")
            {
                UnitNameTextBox.Text = "Nome da sua unidade";

                UnitNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void concludeButton_Click(object sender, EventArgs e)
        {
            // TODO Pegar todas as info de todas as abas, juntar e gerar o docx
           
            // Testing
            using (WordDocument document = new WordDocument())
            {
                // Add section and paragraph for testing
                document.EnsureMinimal();

                // Append some text to the document
                document.LastParagraph.AppendText("Testing");

                // Save
                document.Save("output.docx");
            }
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
