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
            EditSpaceForm form = new EditSpaceForm(null);
            form.ShowDialog();

            if (form.data != null)
                addDataToTable(form.data);
        }
        
        private void editSpaceButton_Click(object sender, EventArgs e)
        {
            if (InternalStructureDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = InternalStructureDataGridView.SelectedRows[0];

                Space entry = new Space();
                entry.buildingIdentifier = row.Cells[0].Value.ToString();
                entry.roomIdentifier = row.Cells[1].Value.ToString();
                entry.floorIdentifier = row.Cells[2].Value.ToString();
                entry.turnStart = System.TimeSpan.Parse(row.Cells[3].Value.ToString());
                entry.turnEnd = System.TimeSpan.Parse(row.Cells[4].Value.ToString());
                entry.surroundingsComments = row.Cells[5].Value.ToString();

                EditSpaceForm form = new EditSpaceForm(entry);
                form.ShowDialog();

                if (form.data != null)
                {
                    InternalStructureDataGridView.Rows[row.Index].Cells[0].Value = form.data.buildingIdentifier;
                    InternalStructureDataGridView.Rows[row.Index].Cells[1].Value = form.data.roomIdentifier;
                    InternalStructureDataGridView.Rows[row.Index].Cells[2].Value = form.data.floorIdentifier;
                    InternalStructureDataGridView.Rows[row.Index].Cells[3].Value = form.data.turnStart.ToString();
                    InternalStructureDataGridView.Rows[row.Index].Cells[4].Value = form.data.turnEnd.ToString();
                    InternalStructureDataGridView.Rows[row.Index].Cells[5].Value = form.data.surroundingsComments;
                }
            }
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
