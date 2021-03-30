﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace RyskTech
{
    public partial class StructureControl : UserControl
    {
        public StructureControl()
        {
            InitializeComponent();
        }

        private void SurroundingInfoTextBox_TextChanged(object sender, System.EventArgs e)
        {
            APR.unit.surroundingsDetails = SurroundingInfoTextBox.Text;
        }

        public List<Unit.StructureInformation> getStructureData()
        {
            List<Unit.StructureInformation> result = new List<Unit.StructureInformation>();

            foreach (DataGridViewRow row in InternalStructureDataGridView.Rows)
            {
                Unit.StructureInformation entry = new Unit.StructureInformation();
                if (row.Cells[0].Value != null)
                    entry.building = row.Cells[0].Value.ToString();
                if (row.Cells[1].Value != null)
                    entry.room = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value != null)
                    entry.floor = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value != null)
                    entry.turn_start = System.TimeSpan.Parse(row.Cells[3].Value.ToString());
                if (row.Cells[4].Value != null)
                    entry.turn_end = System.TimeSpan.Parse(row.Cells[4].Value.ToString());

                result.Add(entry);
            }

            return result;
        }
    }
}
