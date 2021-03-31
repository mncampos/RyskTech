using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Unit
{
    public partial class UnitMainForm : Form
    {
        private Data.Unit data;

        public UnitMainForm()
        {
            InitializeComponent();
        }

        private void UnitMainForm_Load(object sender, EventArgs e)
        {
            data = new Data.Unit();
        }

        private void PrepareForGeneration()
        {
            welcomeControl1.ValidateData();
            data.generalInformation = welcomeControl1.data;

            locationControl1.ValidateData();
            data.location = locationControl1.data;
            
            teamControl1.ValidateData();
            data.team = teamControl1.data;
            
            structureControl1.ValidateData();
            data.structure = structureControl1.data;
            
            historyControl1.ValidateData();
            data.history = historyControl1.history;
            
            methodologyControl1.ValidateData();
            data.methodologyDescription = methodologyControl1.methodology;
        }

        public void Complete()
        {
            try
            {
                PrepareForGeneration();

                APR compilation = new APR(data);
                DocumentBuilder docBuilder = new DocumentBuilder(compilation, "APR_Unidade.docx");

                int statusCode = docBuilder.CreateUnitDocumentFromAPR();

                if (statusCode == 0)
                    MessageBox.Show("APR Gerada com sucesso!", "Obrigado por usar RyskTech! :)");
                else
                    MessageBox.Show("Foram encontrados alguns erros na geração da APR", ":(");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
