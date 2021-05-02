using RyskTech.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RyskTech.Forms.Unit.Controls
{
    public partial class StructureControl : UserControl
    {
        public Structure data;

        public StructureControl()
        {
            InitializeComponent();
        }

        private void TestStructureControl_Load(object sender, EventArgs e)
        {
            data = new Structure();
        }

        private void addSpaceButton_Click(object sender, EventArgs e)
        {
            EditSpaceForm form = new EditSpaceForm();
            form.ShowDialog();

            if (form.data != null)
                addDataToTable(form.data);
        }

        private void removeSpaceButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in InternalStructureDataGridView.SelectedRows)
                InternalStructureDataGridView.Rows.RemoveAt(row.Index);
        }

        private void addDataToTable(Space createdSpace)
        {
            if (createdSpace != null)
            {
                InternalStructureDataGridView.Rows.Add(
                    createdSpace.buildingIdentifier,
                    createdSpace.roomIdentifier,
                    createdSpace.floorIdentifier,
                    createdSpace.turnStart.ToString(),
                    createdSpace.turnEnd.ToString(),
                    createdSpace.surroundingsComments);
            }
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
                    if (row.Cells[5].Value != null)
                        entry.surroundingsComments = row.Cells[5].Value.ToString();

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
