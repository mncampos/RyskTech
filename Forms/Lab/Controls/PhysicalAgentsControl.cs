using RyskTech.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RyskTech.Forms.Lab.Controls
{
    public partial class PhysicalAgentsControl : UserControl
    {
        public List<PhysicalAgent> physicalAgentList;

        public PhysicalAgentsControl()
        {
            InitializeComponent();
        }

        private void PhysicalAgentsControl_Load(object sender, EventArgs e)
        {
            physicalAgentList = new List<PhysicalAgent>();
        }

        private void addPhyisicalAgentButton_Click(object sender, EventArgs e)
        {
            EditPhysicalAgentForm newAgentForm = new EditPhysicalAgentForm();
            newAgentForm.ShowDialog();

            AddAgentDataToTable(newAgentForm.createdAgent);
        }

        private void AddAgentDataToTable(PhysicalAgent createdAgent)
        {
            if (createdAgent != null)
            {
                phyisicalAgentsDataGridView.Rows.Add(
                    createdAgent.equipment,
                    createdAgent.usage,
                    createdAgent.generatedRisks);
            }
        }
        
        private void CreatePhyisicalAgentList()
        {
            physicalAgentList = new List<PhysicalAgent>();
            foreach (DataGridViewRow row in phyisicalAgentsDataGridView.Rows)
            {
                if (row.Cells[0] != null)
                {
                    PhysicalAgent agent = new PhysicalAgent(
                        row.Cells[0].Value.ToString(),
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString()
                    );

                    physicalAgentList.Add(agent);
                }
            }
        }

        private void removePhyisicalAgentButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in phyisicalAgentsDataGridView.SelectedRows)
                phyisicalAgentsDataGridView.Rows.RemoveAt(row.Index);
        }

        public void ValidateData()
        {
            if (this.physicalAgentList == null)
                throw new ApplicationException(Resources.Language.pt_local.NotAllTabsVisited);

            CreatePhyisicalAgentList();

            if (physicalAgentList.Count <= 0)
                throw new ApplicationException(Resources.Language.pt_local.ErrorNoPhyisicalAgents);
        }
    }
}
