using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UnitNameTextBox_Enter(object sender, EventArgs e)
        {
            if (UnitNameTextBox.Text == "Nome da sua unidade/Laboratório/Espaço/Setor")
            {
                UnitNameTextBox.Text = "";

                UnitNameTextBox.ForeColor = Color.Black;
            }
        }

        private void UnitNameTextBox_Leave(object sender, EventArgs e)
        {
            if (UnitNameTextBox.Text == "")
            {
                UnitNameTextBox.Text = "Nome da sua unidade/Laboratório/Espaço/Setor";

                UnitNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Try to load last version of the document
            if (APR.LoadPrevious())
            {
                // TODO If possible, fill the form fields with the information in that version
            }

        }

        private void concludeButton_Click(object sender, EventArgs e)
        {
            // Generate document
            //APR.generateDocument();

            DocumentBuilder builder = new DocumentBuilder("APR.docx");
            builder.CreateDocumentFromAPR();

            // Show success message
            MessageBox.Show("APR Gerada com sucesso!");
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

        private void UnitNameTextBox_TextChanged(object sender, EventArgs e)
        {
            APR.unit_info.unit_name = UnitNameTextBox.Text;
        }

        public List<UnitInformation.StructureInformation> getStructureData()
        {
            return this.unitStructureControl1.getStructureData();
        }

        public void addChemicalResidue(ChemicalAgent agent)
        {
            //
        }
    }
}
