using RyskTech.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RyskTech.Forms.Unit.Controls
{
    public partial class TestStructureControl : UserControl
    {
        public Structure data;

        public TestStructureControl()
        {
            InitializeComponent();
        }

        private void TestStructureControl_Load(object sender, EventArgs e)
        {
            data = new Structure();
        }

        private void SurroundingInfoTextBox_TextChanged(object sender, System.EventArgs e)
        {
            data.surroundingsDetails = SurroundingInfoTextBox.Text;
        }

        private List<Space> GetStructureData()
        {
            List<Space> result = new List<Space>();

            foreach (DataGridViewRow row in InternalStructureDataGridView.Rows)
            {
                Space entry = new Space();

                if (row.Cells[0].Value != null)
                {
                    entry.buildingIdentifier = row.Cells[0].Value.ToString();
                    if (row.Cells[1].Value != null)
                        entry.roomIdentifier = row.Cells[1].Value.ToString();
                    if (row.Cells[2].Value != null)
                        entry.floorIdentifier = row.Cells[2].Value.ToString();
                    if (row.Cells[3].Value != null)
                        entry.turnStart = System.TimeSpan.Parse(row.Cells[3].Value.ToString());
                    if (row.Cells[4].Value != null)
                        entry.turnEnd = System.TimeSpan.Parse(row.Cells[4].Value.ToString());

                    result.Add(entry);
                }
            }

            return result;
        }

        public void ValidateData()
        {
            data.spaces = GetStructureData();
            data.CheckValidity();
        }
    }
}
