﻿
namespace RyskTech.Forms.Lab.Controls
{
    partial class PhysicalAgentsControlBetter
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
            this.phyisicalAgentsDataGridView = new System.Windows.Forms.DataGridView();
            this.equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.risks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removePhyisicalAgentButton = new System.Windows.Forms.Button();
            this.addPhyisicalAgentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phyisicalAgentsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.phyisicalAgentsDataGridView, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.panel1, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.635974F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.65739F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.92077F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(596, 467);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // phyisicalAgentsDataGridView
            // 
            this.phyisicalAgentsDataGridView.AllowUserToAddRows = false;
            this.phyisicalAgentsDataGridView.AllowUserToDeleteRows = false;
            this.phyisicalAgentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phyisicalAgentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipment,
            this.usage,
            this.risks});
            this.phyisicalAgentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phyisicalAgentsDataGridView.Location = new System.Drawing.Point(3, 47);
            this.phyisicalAgentsDataGridView.Name = "phyisicalAgentsDataGridView";
            this.phyisicalAgentsDataGridView.ReadOnly = true;
            this.phyisicalAgentsDataGridView.Size = new System.Drawing.Size(590, 365);
            this.phyisicalAgentsDataGridView.TabIndex = 2;
            // 
            // equipment
            // 
            this.equipment.HeaderText = "Equipamento";
            this.equipment.Name = "equipment";
            this.equipment.ReadOnly = true;
            // 
            // usage
            // 
            this.usage.HeaderText = "Usos";
            this.usage.Name = "usage";
            this.usage.ReadOnly = true;
            // 
            // risks
            // 
            this.risks.HeaderText = "Riscos Gerados";
            this.risks.Name = "risks";
            this.risks.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.removePhyisicalAgentButton);
            this.panel1.Controls.Add(this.addPhyisicalAgentButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 46);
            this.panel1.TabIndex = 3;
            // 
            // removePhyisicalAgentButton
            // 
            this.removePhyisicalAgentButton.Location = new System.Drawing.Point(93, 12);
            this.removePhyisicalAgentButton.Name = "removePhyisicalAgentButton";
            this.removePhyisicalAgentButton.Size = new System.Drawing.Size(75, 23);
            this.removePhyisicalAgentButton.TabIndex = 1;
            this.removePhyisicalAgentButton.Text = "Remover";
            this.removePhyisicalAgentButton.UseVisualStyleBackColor = true;
            this.removePhyisicalAgentButton.Click += new System.EventHandler(this.removePhyisicalAgentButton_Click);
            // 
            // addPhyisicalAgentButton
            // 
            this.addPhyisicalAgentButton.Location = new System.Drawing.Point(12, 12);
            this.addPhyisicalAgentButton.Name = "addPhyisicalAgentButton";
            this.addPhyisicalAgentButton.Size = new System.Drawing.Size(75, 23);
            this.addPhyisicalAgentButton.TabIndex = 0;
            this.addPhyisicalAgentButton.Text = "Adicionar";
            this.addPhyisicalAgentButton.UseVisualStyleBackColor = true;
            this.addPhyisicalAgentButton.Click += new System.EventHandler(this.addPhyisicalAgentButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Preencha a tabela abaixo com os agentes e riscos físicos presentes em seu espaço";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhysicalAgentsControlBetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "PhysicalAgentsControlBetter";
            this.Size = new System.Drawing.Size(596, 467);
            this.Load += new System.EventHandler(this.PhysicalAgentsControlBetter_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phyisicalAgentsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.DataGridView phyisicalAgentsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removePhyisicalAgentButton;
        private System.Windows.Forms.Button addPhyisicalAgentButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn usage;
        private System.Windows.Forms.DataGridViewTextBoxColumn risks;
        private System.Windows.Forms.Label label1;
    }
}