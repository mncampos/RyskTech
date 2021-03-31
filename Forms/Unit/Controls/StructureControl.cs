using RyskTech.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class StructureControl : UserControl
    {
        public Structure data;

        public StructureControl()
        {
            InitializeComponent();
        }

        private void StructureControl_Load(object sender, System.EventArgs e)
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
