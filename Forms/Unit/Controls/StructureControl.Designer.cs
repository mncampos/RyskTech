
namespace RyskTech.Forms.Unit.Controls
{
    partial class StructureControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InternalStructureDataGridView = new System.Windows.Forms.DataGridView();
            this.building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usage_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usage_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SurroundingInfoTextBox = new System.Windows.Forms.TextBox();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InternalStructureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.InternalStructureDataGridView, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.label2, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.SurroundingInfoTextBox, 0, 3);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.mainTableLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(596, 467);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // InternalStructureDataGridView
            // 
            this.InternalStructureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InternalStructureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.building,
            this.room,
            this.level,
            this.usage_start,
            this.usage_end});
            this.mainTableLayoutPanel.SetColumnSpan(this.InternalStructureDataGridView, 2);
            this.InternalStructureDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InternalStructureDataGridView.Location = new System.Drawing.Point(8, 53);
            this.InternalStructureDataGridView.Name = "InternalStructureDataGridView";
            this.InternalStructureDataGridView.Size = new System.Drawing.Size(580, 176);
            this.InternalStructureDataGridView.TabIndex = 2;
            // 
            // building
            // 
            this.building.HeaderText = "Prédio";
            this.building.Name = "building";
            this.building.Width = 130;
            // 
            // room
            // 
            this.room.HeaderText = "Sala";
            this.room.Name = "room";
            // 
            // level
            // 
            this.level.HeaderText = "Andar";
            this.level.Name = "level";
            // 
            // usage_start
            // 
            this.usage_start.HeaderText = "Início do turno";
            this.usage_start.Name = "usage_start";
            // 
            // usage_end
            // 
            this.usage_end.HeaderText = "Fim do turno";
            this.usage_end.Name = "usage_end";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.mainTableLayoutPanel.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Preencha a tabela abaixo com as informações sobre prédios, salas e espaços utiliz" +
    "ados na unidade";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.mainTableLayoutPanel.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(580, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preencha a caixa de texto abaixo com informações relevantes sobre o entorno da su" +
    "a unidade";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SurroundingInfoTextBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.SurroundingInfoTextBox, 2);
            this.SurroundingInfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SurroundingInfoTextBox.Location = new System.Drawing.Point(8, 280);
            this.SurroundingInfoTextBox.Multiline = true;
            this.SurroundingInfoTextBox.Name = "SurroundingInfoTextBox";
            this.SurroundingInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SurroundingInfoTextBox.Size = new System.Drawing.Size(580, 179);
            this.SurroundingInfoTextBox.TabIndex = 5;
            this.SurroundingInfoTextBox.TextChanged += new System.EventHandler(this.SurroundingInfoTextBox_TextChanged);
            // 
            // TestStructureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "TestStructureControl";
            this.Size = new System.Drawing.Size(596, 467);
            this.Load += new System.EventHandler(this.TestStructureControl_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InternalStructureDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.DataGridView InternalStructureDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SurroundingInfoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn building;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn usage_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn usage_end;
    }
}
