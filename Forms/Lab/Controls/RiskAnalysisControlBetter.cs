using RyskTech.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class RiskAnalysisControlBetter : UserControl
    {
        public List<Risk> data;

        public RiskAnalysisControlBetter()
        {
            InitializeComponent();
        }

        private void RiskAnalysisControlBetter_Load(object sender, EventArgs e)
        {
            data = new List<Risk>();
        }

        private void severityClassesButton_Click(object sender, EventArgs e)
        {
            ShowTableForm table = new ShowTableForm(Properties.Resources.Quadro1, "Classificação quanto à severidade");
            table.ShowDialog();
        }

        private void frequencyClassesButton_Click(object sender, EventArgs e)
        {
            ShowTableForm table = new ShowTableForm(Properties.Resources.Quadro3, "Classificação quanto à frequência");
            table.ShowDialog();
        }

        private void CreateRiskList()
        {
            data = new List<Risk>();
            foreach (DataGridViewRow row in riskDataGridView.Rows)
            {
                if (row.Cells[0] != null && row.Cells[0].Value != null)
                {
                    Risk risk = new Risk(
                        row.Cells[0].Value.ToString(),
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString(),
                        row.Cells[3].Value == null ? "" : row.Cells[3].Value.ToString(),
                        row.Cells[4].Value == null ? "" : row.Cells[4].Value.ToString());

                    risk.CheckValidity();
                    data.Add(risk);
                }
            }
        }

        public void ValidateData()
        {
            if (data != null)
                CreateRiskList();
        }
    }
}
