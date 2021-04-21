﻿using RyskTech.Data;
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

        private void RiskAnalysisControl_Load(object sender, EventArgs e)
        {
            data = new List<Risk>();
        }

        private void severityClassesButton_Click(object sender, EventArgs e)
        {
            ShowTableForm table = new ShowTableForm("../../Resources/Etapa1_Classificacao_de_risco_ANVISA.jpg", "Classificação quanto à severidade");
            table.ShowDialog();
        }

        private void frequencyClassesButton_Click(object sender, EventArgs e)
        {
            ShowTableForm table = new ShowTableForm("../../Resources/Quadro3.png", "Classificação quanto à frequência");
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
                        row.Cells[3].Value.ToString(),
                        row.Cells[4].Value.ToString());

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
