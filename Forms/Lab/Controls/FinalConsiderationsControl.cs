using RyskTech.Data;
using System;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class FinalConsiderationsControl : UserControl
    {
        public RiskAnalysis data;

        public FinalConsiderationsControl()
        {
            InitializeComponent();
        }

        private void FinalConsiderationsControl_Load(object sender, System.EventArgs e)
        {
            this.data = new RiskAnalysis();
        }

        public void ValidateData()
        {
            if (this.data == null)
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);

            accidentHistoryControl1.ValidateData();
            data.accidents = accidentHistoryControl1.accidentHistory;

            riskAnalysisControl1.ValidateData();
            data.identifiedRisks = riskAnalysisControl1.data;

            conclusionControl1.ValidateData();
            data.conclusion = conclusionControl1.conclusion;
            data.recomendations = conclusionControl1.recomendation;

            data.CheckValidity();
        }
    }
}
