using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab
{
    public partial class LabMainForm : Form
    {
        private Data.Lab data;

        public LabMainForm()
        {
            InitializeComponent();
        }

        private void LabMainForm_Load(object sender, EventArgs e)
        {
            data = new Data.Lab();
        }

        private void PrepareForGeneration()
        {
            // TODO Validate all subtabs
            throw new NotImplementedException();
        }

        public void Complete()
        {
            try
            {
                PrepareForGeneration();

                APR compilation = new APR(data);

                DocumentBuilder docBuilder = new DocumentBuilder(compilation, "APR_Unidade.docx");

                int statusCode = docBuilder.CreateLabDocumentFromAPR();

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
