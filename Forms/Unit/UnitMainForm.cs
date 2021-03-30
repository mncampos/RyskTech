using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Unit
{
    public partial class UnitMainForm : Form
    {
        Data.Unit data;

        public UnitMainForm()
        {
            InitializeComponent();
        }

        private void UnitMainForm_Load(object sender, EventArgs e)
        {
            data = new Data.Unit();
        }

        private bool IsReadyForGeneration()
        {
            try
            {
                welcomeControl1.ValidateData();
                locationControl1.ValidateData();
                teamControl1.ValidateData();
                structureControl1.ValidateData();
                historyControl1.ValidateData();
                methodologyControl1.ValidateData();                

                return true;
            
            } catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return false;
            }
        }

        public void Complete()
        {
            if (!IsReadyForGeneration())
            {
                MessageBox.Show("Form incomplete"); // TODO
                Close();
            }

            APR compilation = new APR(data);
            DocumentBuilder docBuilder = new DocumentBuilder(compilation, "APR_Unidade.docx");

            int statusCode = docBuilder.CreateUnitDocumentFromAPR();

            if (statusCode == 0)
                MessageBox.Show("APR Gerada com sucesso!", "Obrigado por usar RyskTech! :)");
            else
                MessageBox.Show("Foram encontrados alguns erros na geração da APR", ":(");

            Close();
        }
    }
}
