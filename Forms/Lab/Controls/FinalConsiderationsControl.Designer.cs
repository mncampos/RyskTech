
namespace RyskTech.Forms.Lab.Controls
{
    partial class FinalConsiderationsControl
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
            this.finalConsiderationsTabControl = new System.Windows.Forms.TabControl();
            this.risksTabPage = new System.Windows.Forms.TabPage();
            this.riskAnalysisControl1 = new RyskTech.Forms.Lab.Controls.RiskAnalysisControl();
            this.accidentsTabPage = new System.Windows.Forms.TabPage();
            this.accidentHistoryControl1 = new RyskTech.Forms.Lab.Controls.AccidentHistoryControl();
            this.conclusionTabPage = new System.Windows.Forms.TabPage();
            this.conclusionControl1 = new RyskTech.Forms.Lab.Controls.ConclusionControl();
            this.finalConsiderationsTabControl.SuspendLayout();
            this.risksTabPage.SuspendLayout();
            this.accidentsTabPage.SuspendLayout();
            this.conclusionTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // finalConsiderationsTabControl
            // 
            this.finalConsiderationsTabControl.Controls.Add(this.risksTabPage);
            this.finalConsiderationsTabControl.Controls.Add(this.accidentsTabPage);
            this.finalConsiderationsTabControl.Controls.Add(this.conclusionTabPage);
            this.finalConsiderationsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalConsiderationsTabControl.Location = new System.Drawing.Point(0, 0);
            this.finalConsiderationsTabControl.Name = "finalConsiderationsTabControl";
            this.finalConsiderationsTabControl.SelectedIndex = 0;
            this.finalConsiderationsTabControl.Size = new System.Drawing.Size(741, 493);
            this.finalConsiderationsTabControl.TabIndex = 0;
            // 
            // risksTabPage
            // 
            this.risksTabPage.Controls.Add(this.riskAnalysisControl1);
            this.risksTabPage.Location = new System.Drawing.Point(4, 22);
            this.risksTabPage.Name = "risksTabPage";
            this.risksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.risksTabPage.Size = new System.Drawing.Size(733, 467);
            this.risksTabPage.TabIndex = 0;
            this.risksTabPage.Text = "Riscos";
            this.risksTabPage.UseVisualStyleBackColor = true;
            // 
            // riskAnalysisControl1
            // 
            this.riskAnalysisControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riskAnalysisControl1.Location = new System.Drawing.Point(3, 3);
            this.riskAnalysisControl1.Name = "riskAnalysisControl1";
            this.riskAnalysisControl1.Padding = new System.Windows.Forms.Padding(5);
            this.riskAnalysisControl1.Size = new System.Drawing.Size(727, 461);
            this.riskAnalysisControl1.TabIndex = 0;
            // 
            // accidentsTabPage
            // 
            this.accidentsTabPage.Controls.Add(this.accidentHistoryControl1);
            this.accidentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.accidentsTabPage.Name = "accidentsTabPage";
            this.accidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.accidentsTabPage.Size = new System.Drawing.Size(733, 467);
            this.accidentsTabPage.TabIndex = 1;
            this.accidentsTabPage.Text = "Acidentes";
            this.accidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // accidentHistoryControl1
            // 
            this.accidentHistoryControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accidentHistoryControl1.Location = new System.Drawing.Point(3, 3);
            this.accidentHistoryControl1.Name = "accidentHistoryControl1";
            this.accidentHistoryControl1.Size = new System.Drawing.Size(727, 461);
            this.accidentHistoryControl1.TabIndex = 0;
            // 
            // conclusionTabPage
            // 
            this.conclusionTabPage.Controls.Add(this.conclusionControl1);
            this.conclusionTabPage.Location = new System.Drawing.Point(4, 22);
            this.conclusionTabPage.Name = "conclusionTabPage";
            this.conclusionTabPage.Size = new System.Drawing.Size(733, 467);
            this.conclusionTabPage.TabIndex = 2;
            this.conclusionTabPage.Text = "Conclusões";
            this.conclusionTabPage.UseVisualStyleBackColor = true;
            // 
            // conclusionControl1
            // 
            this.conclusionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conclusionControl1.Location = new System.Drawing.Point(0, 0);
            this.conclusionControl1.Name = "conclusionControl1";
            this.conclusionControl1.Size = new System.Drawing.Size(733, 467);
            this.conclusionControl1.TabIndex = 0;
            // 
            // FinalConsiderationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.finalConsiderationsTabControl);
            this.Name = "FinalConsiderationsControl";
            this.Size = new System.Drawing.Size(741, 493);
            this.Load += new System.EventHandler(this.FinalConsiderationsControl_Load);
            this.finalConsiderationsTabControl.ResumeLayout(false);
            this.risksTabPage.ResumeLayout(false);
            this.accidentsTabPage.ResumeLayout(false);
            this.conclusionTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl finalConsiderationsTabControl;
        private System.Windows.Forms.TabPage risksTabPage;
        private System.Windows.Forms.TabPage accidentsTabPage;
        private AccidentHistoryControl accidentHistoryControl1;
        private RiskAnalysisControl riskAnalysisControl1;
        private System.Windows.Forms.TabPage conclusionTabPage;
        private ConclusionControl conclusionControl1;
    }
}
