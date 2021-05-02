using RyskTech.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class RiskAnalysisControl : UserControl
    {
        public List<Risk> data;

        public RiskAnalysisControl()
        {
            InitializeComponent();
        }

        private void RiskAnalysisControlBetter_Load(object sender, EventArgs e)
        {
            data = new List<Risk>();
        }

        private void addRiskButton_Click(object sender, EventArgs e)
        {
            EditRiskForm newRisk = new EditRiskForm();
            newRisk.ShowDialog();

            AddAgentDataToTable(newRisk.createdRisk);
        }

        private void removeRiskButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in riskDataGridView.SelectedRows)
                riskDataGridView.Rows.RemoveAt(row.Index);
        }

        private void AddAgentDataToTable(Risk createdAgent)
        {
            if (createdAgent != null)
            {
                this.riskDataGridView.Rows.Add(
                    createdAgent.description,
                    createdAgent.associatedDanger,
                    createdAgent.safetyNet,
                    createdAgent.frequencyClassification,
                    createdAgent.severityClassification,
                    createdAgent.riskClassification
                    );
            }
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
