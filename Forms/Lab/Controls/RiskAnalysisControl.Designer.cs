
namespace RyskTech.Forms.Lab.Controls
{
    partial class RiskAnalysisControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiskAnalysisControl));
            this.riskAnalysisGroupBox = new System.Windows.Forms.GroupBox();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.riskAnalysisInstructionLabel = new System.Windows.Forms.Label();
            this.riskDataGridView = new System.Windows.Forms.DataGridView();
            this.risk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.safetyNet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequency = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.severity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tableButtonsLayoutPannel = new System.Windows.Forms.TableLayoutPanel();
            this.severityClassesButton = new System.Windows.Forms.Button();
            this.frequencyClassesButton = new System.Windows.Forms.Button();
            this.riskAnalysisGroupBox.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riskDataGridView)).BeginInit();
            this.tableButtonsLayoutPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // riskAnalysisGroupBox
            // 
            this.riskAnalysisGroupBox.Controls.Add(this.mainTableLayoutPanel);
            this.riskAnalysisGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riskAnalysisGroupBox.Location = new System.Drawing.Point(5, 5);
            this.riskAnalysisGroupBox.Name = "riskAnalysisGroupBox";
            this.riskAnalysisGroupBox.Size = new System.Drawing.Size(682, 452);
            this.riskAnalysisGroupBox.TabIndex = 0;
            this.riskAnalysisGroupBox.TabStop = false;
            this.riskAnalysisGroupBox.Text = "Análise de Riscos";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.35503F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.64497F));
            this.mainTableLayoutPanel.Controls.Add(this.riskAnalysisInstructionLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.riskDataGridView, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.tableButtonsLayoutPannel, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.47575F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.52425F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(676, 433);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // riskAnalysisInstructionLabel
            // 
            this.riskAnalysisInstructionLabel.AutoSize = true;
            this.riskAnalysisInstructionLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.riskAnalysisInstructionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainTableLayoutPanel.SetColumnSpan(this.riskAnalysisInstructionLabel, 2);
            this.riskAnalysisInstructionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riskAnalysisInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riskAnalysisInstructionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.riskAnalysisInstructionLabel.Location = new System.Drawing.Point(3, 0);
            this.riskAnalysisInstructionLabel.Name = "riskAnalysisInstructionLabel";
            this.riskAnalysisInstructionLabel.Size = new System.Drawing.Size(670, 72);
            this.riskAnalysisInstructionLabel.TabIndex = 0;
            this.riskAnalysisInstructionLabel.Text = resources.GetString("riskAnalysisInstructionLabel.Text");
            this.riskAnalysisInstructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.riskDataGridView.Location = new System.Drawing.Point(3, 75);
            this.riskDataGridView.Name = "riskDataGridView";
            this.riskDataGridView.Size = new System.Drawing.Size(670, 312);
            this.riskDataGridView.TabIndex = 1;
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
            // tableButtonsLayoutPannel
            // 
            this.tableButtonsLayoutPannel.ColumnCount = 2;
            this.tableButtonsLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButtonsLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButtonsLayoutPannel.Controls.Add(this.severityClassesButton, 0, 0);
            this.tableButtonsLayoutPannel.Controls.Add(this.frequencyClassesButton, 1, 0);
            this.tableButtonsLayoutPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableButtonsLayoutPannel.Location = new System.Drawing.Point(3, 393);
            this.tableButtonsLayoutPannel.Name = "tableButtonsLayoutPannel";
            this.tableButtonsLayoutPannel.Padding = new System.Windows.Forms.Padding(2);
            this.tableButtonsLayoutPannel.RowCount = 1;
            this.tableButtonsLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButtonsLayoutPannel.Size = new System.Drawing.Size(233, 37);
            this.tableButtonsLayoutPannel.TabIndex = 2;
            // 
            // severityClassesButton
            // 
            this.severityClassesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.severityClassesButton.Location = new System.Drawing.Point(5, 5);
            this.severityClassesButton.Name = "severityClassesButton";
            this.severityClassesButton.Size = new System.Drawing.Size(108, 27);
            this.severityClassesButton.TabIndex = 0;
            this.severityClassesButton.Text = "Severidade";
            this.severityClassesButton.UseVisualStyleBackColor = true;
            this.severityClassesButton.Click += new System.EventHandler(this.severityClassesButton_Click);
            // 
            // frequencyClassesButton
            // 
            this.frequencyClassesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequencyClassesButton.Location = new System.Drawing.Point(119, 5);
            this.frequencyClassesButton.Name = "frequencyClassesButton";
            this.frequencyClassesButton.Size = new System.Drawing.Size(109, 27);
            this.frequencyClassesButton.TabIndex = 1;
            this.frequencyClassesButton.Text = "Frequência";
            this.frequencyClassesButton.UseVisualStyleBackColor = true;
            this.frequencyClassesButton.Click += new System.EventHandler(this.frequencyClassesButton_Click);
            // 
            // RiskAnalysisControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.riskAnalysisGroupBox);
            this.Name = "RiskAnalysisControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(692, 462);
            this.Load += new System.EventHandler(this.RiskAnalysisControl_Load);
            this.riskAnalysisGroupBox.ResumeLayout(false);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riskDataGridView)).EndInit();
            this.tableButtonsLayoutPannel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox riskAnalysisGroupBox;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label riskAnalysisInstructionLabel;
        private System.Windows.Forms.DataGridView riskDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableButtonsLayoutPannel;
        private System.Windows.Forms.Button severityClassesButton;
        private System.Windows.Forms.Button frequencyClassesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn risk;
        private System.Windows.Forms.DataGridViewTextBoxColumn danger;
        private System.Windows.Forms.DataGridViewTextBoxColumn safetyNet;
        private System.Windows.Forms.DataGridViewComboBoxColumn frequency;
        private System.Windows.Forms.DataGridViewComboBoxColumn severity;
    }
}
