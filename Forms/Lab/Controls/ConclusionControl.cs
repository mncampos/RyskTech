using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class ConclusionControl : UserControl
    {
        public string conclusion;
        public string recomendation;
        public string accidentHistory;

        public ConclusionControl()
        {
            InitializeComponent();
        }

        private void ConclusionControlBetter_Load(object sender, EventArgs e)
        {
            conclusion = "";
            recomendation = "";
            accidentHistory = "";
        }

        private void accidentHistoryTextBox_TextChanged(object sender, System.EventArgs e)
        {
            accidentHistory = accidentHistoryTextBox.Text;
        }

        private void conclusionTextBox_TextChanged(object sender, System.EventArgs e)
        {
            conclusion = conclusionTextBox.Text;
        }

        private void recomendationTextBox_TextChanged(object sender, System.EventArgs e)
        {
            recomendation = recomendationTextBox.Text;
        }

        public void ValidateData()
        {
            if (conclusion == null || conclusion.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoConclusion);

            if (recomendation == null || recomendation.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoSugestions);
        }
    }
}
