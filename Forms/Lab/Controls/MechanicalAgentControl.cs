using RyskTech.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class MechanicalAgentControl : UserControl
    {
        public List<MechanicalAgent> mechanicalAgentList;

        public MechanicalAgentControl()
        {
            InitializeComponent();
        }

        private void MechanicalAgentControlBetter_Load(object sender, EventArgs e)
        {
            mechanicalAgentList = new List<MechanicalAgent>();
        }

        private void addAgentButton_Click(object sender, EventArgs e)
        {
            EditMechanicalAgentForm newAgent = new EditMechanicalAgentForm(null);
            newAgent.ShowDialog();

            AddAgentDataToTable(newAgent.createdAgent);
        }

        private void editMechanicalAgentButton_Click(object sender, EventArgs e)
        {
            if (mechanicalAgentsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = mechanicalAgentsDataGridView.SelectedRows[0];
                MechanicalAgent agent = new MechanicalAgent(
                    row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString()
                );

                EditMechanicalAgentForm newAgent = new EditMechanicalAgentForm(agent);
                newAgent.ShowDialog();

                if (newAgent.createdAgent != null)
                {
                    mechanicalAgentsDataGridView.Rows[row.Index].Cells[0].Value = newAgent.createdAgent.name;
                    mechanicalAgentsDataGridView.Rows[row.Index].Cells[1].Value = newAgent.createdAgent.associatedRisk;
                    mechanicalAgentsDataGridView.Rows[row.Index].Cells[2].Value = newAgent.createdAgent.additionalInfo;
                }
            }
        }

        private void AddAgentDataToTable(MechanicalAgent createdAgent)
        {
            if (createdAgent != null)
            {
                this.mechanicalAgentsDataGridView.Rows.Add(
                    createdAgent.name,
                    createdAgent.associatedRisk,
                    createdAgent.additionalInfo
                    );
            }
        }

        private void removeAgentButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in mechanicalAgentsDataGridView.SelectedRows)
                mechanicalAgentsDataGridView.Rows.RemoveAt(row.Index);
        }

        private void CreateMechanicalAgentList()
        {
            mechanicalAgentList = new List<MechanicalAgent>();
            foreach (DataGridViewRow row in mechanicalAgentsDataGridView.Rows)
            {
                if (row.Cells[0] != null)
                {
                    MechanicalAgent agent = new MechanicalAgent(
                        row.Cells[0].Value.ToString(),
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString()
                    );

                    agent.CheckValidity();
                    mechanicalAgentList.Add(agent);
                }
            }
        }

        public void ValidateData()
        {
            if (this.mechanicalAgentList == null)
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);

            CreateMechanicalAgentList();
        }
    }
}
