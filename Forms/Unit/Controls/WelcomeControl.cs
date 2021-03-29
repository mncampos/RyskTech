using System.Windows.Forms;

namespace RyskTech.Forms.Unit.Controls
{
    public partial class WelcomeControl : UserControl
    {
        public WelcomeControl()
        {
            InitializeComponent();
        }

        private void concludeButton_Click(object sender, System.EventArgs e)
        {
            // TODO Validate the entire form so we make sure every field has been filled

            DocumentBuilder docBuilder = new DocumentBuilder("APR.docx");
            int statusCode = 0;// docBuilder.CreateDocumentFromAPR();

            if (statusCode == 0)
                MessageBox.Show("APR Gerada com sucesso!", "Obrigado por usar RyskTech! :)");
            else
                MessageBox.Show("Foram encontrados alguns erros na geração da APR", ":(");

            ((Form)this.TopLevelControl).Close();
        }
    }
}
