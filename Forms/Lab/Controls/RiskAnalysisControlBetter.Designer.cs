
namespace RyskTech.Forms.Lab.Controls
{
    partial class RiskAnalysisControlBetter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiskAnalysisControlBetter));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.riskDataGridView = new System.Windows.Forms.DataGridView();
            this.risk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.safetyNet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequency = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.severity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.severityClassesButton = new System.Windows.Forms.Button();
            this.frequencyClassesButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riskDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.riskDataGridView, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.panel1, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.99144F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.58672F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.421842F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(596, 467);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // riskDataGridView
            // 
            this.riskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.riskDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.risk,
            this.danger,
            this.safetyNet,
            this.frequency,
            this.severity});
            this.mainTableLayoutPanel.SetColumnSpan(this.riskDataGridView, 2);
            this.riskDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riskDataGridView.Location = new System.Drawing.Point(3, 59);
            this.riskDataGridView.Name = "riskDataGridView";
            this.riskDataGridView.Size = new System.Drawing.Size(590, 360);
            this.riskDataGridView.TabIndex = 2;
            // 
            // risk
            // 
            this.risk.HeaderText = "Risco";
            this.risk.Name = "risk";
            // 
            // danger
            // 
            this.danger.HeaderText = "Perigo";
            this.danger.Name = "danger";
            // 
            // safetyNet
            // 
            this.safetyNet.HeaderText = "Salvaguarda";
            this.safetyNet.Name = "safetyNet";
            // 
            // frequency
            // 
            this.frequency.HeaderText = "Frequência";
            this.frequency.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.frequency.Name = "frequency";
            this.frequency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.frequency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // severity
            // 
            this.severity.HeaderText = "Severidade";
            this.severity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.severity.Name = "severity";
            this.severity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.severity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.frequencyClassesButton);
            this.panel1.Controls.Add(this.severityClassesButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 39);
            this.panel1.TabIndex = 4;
            // 
            // severityClassesButton
            // 
            this.severityClassesButton.Location = new System.Drawing.Point(8, 8);
            this.severityClassesButton.Name = "severityClassesButton";
            this.severityClassesButton.Size = new System.Drawing.Size(75, 23);
            this.severityClassesButton.TabIndex = 0;
            this.severityClassesButton.Text = "Severidade";
            this.severityClassesButton.UseVisualStyleBackColor = true;
            this.severityClassesButton.Click += new System.EventHandler(this.severityClassesButton_Click);
            // 
            // frequencyClassesButton
            // 
            this.frequencyClassesButton.Location = new System.Drawing.Point(90, 8);
            this.frequencyClassesButton.Name = "frequencyClassesButton";
            this.frequencyClassesButton.Size = new System.Drawing.Size(75, 23);
            this.frequencyClassesButton.TabIndex = 1;
            this.frequencyClassesButton.Text = "Frequência";
            this.frequencyClassesButton.UseVisualStyleBackColor = true;
            this.frequencyClassesButton.Click += new System.EventHandler(this.frequencyClassesButton_Click);
            // 
            // RiskAnalysisControlBetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "RiskAnalysisControlBetter";
            this.Size = new System.Drawing.Size(596, 467);
            this.Load += new System.EventHandler(this.RiskAnalysisControlBetter_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riskDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.DataGridView riskDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn risk;
        private System.Windows.Forms.DataGridViewTextBoxColumn danger;
        private System.Windows.Forms.DataGridViewTextBoxColumn safetyNet;
        private System.Windows.Forms.DataGridViewComboBoxColumn frequency;
        private System.Windows.Forms.DataGridViewComboBoxColumn severity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button severityClassesButton;
        private System.Windows.Forms.Button frequencyClassesButton;
    }
}
