
namespace RyskTech.Forms.Unit
{
    partial class UnitMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.unitMainTabControl = new System.Windows.Forms.TabControl();
            this.welcomeTabPage = new System.Windows.Forms.TabPage();
            this.welcomeControl1 = new RyskTech.Forms.Unit.Controls.WelcomeControl();
            this.locationTabPage = new System.Windows.Forms.TabPage();
            this.locationControl1 = new RyskTech.LocationControl();
            this.teamTabPage = new System.Windows.Forms.TabPage();
            this.structureTabPage = new System.Windows.Forms.TabPage();
            this.historyTabPage = new System.Windows.Forms.TabPage();
            this.methodologyTabPage = new System.Windows.Forms.TabPage();
            this.unitMainTabControl.SuspendLayout();
            this.welcomeTabPage.SuspendLayout();
            this.locationTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // unitMainTabControl
            // 
            this.unitMainTabControl.Controls.Add(this.welcomeTabPage);
            this.unitMainTabControl.Controls.Add(this.locationTabPage);
            this.unitMainTabControl.Controls.Add(this.teamTabPage);
            this.unitMainTabControl.Controls.Add(this.structureTabPage);
            this.unitMainTabControl.Controls.Add(this.historyTabPage);
            this.unitMainTabControl.Controls.Add(this.methodologyTabPage);
            this.unitMainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitMainTabControl.Location = new System.Drawing.Point(0, 0);
            this.unitMainTabControl.Name = "unitMainTabControl";
            this.unitMainTabControl.SelectedIndex = 0;
            this.unitMainTabControl.Size = new System.Drawing.Size(834, 461);
            this.unitMainTabControl.TabIndex = 0;
            // 
            // welcomeTabPage
            // 
            this.welcomeTabPage.Controls.Add(this.welcomeControl1);
            this.welcomeTabPage.Location = new System.Drawing.Point(4, 22);
            this.welcomeTabPage.Name = "welcomeTabPage";
            this.welcomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.welcomeTabPage.Size = new System.Drawing.Size(826, 435);
            this.welcomeTabPage.TabIndex = 0;
            this.welcomeTabPage.Text = "Bem vindo!";
            this.welcomeTabPage.UseVisualStyleBackColor = true;
            // 
            // welcomeControl1
            // 
            this.welcomeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeControl1.Location = new System.Drawing.Point(3, 3);
            this.welcomeControl1.Name = "welcomeControl1";
            this.welcomeControl1.Size = new System.Drawing.Size(820, 429);
            this.welcomeControl1.TabIndex = 0;
            // 
            // locationTabPage
            // 
            this.locationTabPage.Controls.Add(this.locationControl1);
            this.locationTabPage.Location = new System.Drawing.Point(4, 22);
            this.locationTabPage.Name = "locationTabPage";
            this.locationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.locationTabPage.Size = new System.Drawing.Size(826, 435);
            this.locationTabPage.TabIndex = 1;
            this.locationTabPage.Text = "Localização";
            this.locationTabPage.UseVisualStyleBackColor = true;
            // 
            // locationControl1
            // 
            this.locationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationControl1.Location = new System.Drawing.Point(3, 3);
            this.locationControl1.Name = "locationControl1";
            this.locationControl1.Size = new System.Drawing.Size(820, 429);
            this.locationControl1.TabIndex = 0;
            // 
            // teamTabPage
            // 
            this.teamTabPage.Location = new System.Drawing.Point(4, 22);
            this.teamTabPage.Name = "teamTabPage";
            this.teamTabPage.Size = new System.Drawing.Size(826, 435);
            this.teamTabPage.TabIndex = 2;
            this.teamTabPage.Text = "Equipe";
            this.teamTabPage.UseVisualStyleBackColor = true;
            // 
            // structureTabPage
            // 
            this.structureTabPage.Location = new System.Drawing.Point(4, 22);
            this.structureTabPage.Name = "structureTabPage";
            this.structureTabPage.Size = new System.Drawing.Size(826, 435);
            this.structureTabPage.TabIndex = 3;
            this.structureTabPage.Text = "Estrutura";
            this.structureTabPage.UseVisualStyleBackColor = true;
            // 
            // historyTabPage
            // 
            this.historyTabPage.Location = new System.Drawing.Point(4, 22);
            this.historyTabPage.Name = "historyTabPage";
            this.historyTabPage.Size = new System.Drawing.Size(826, 435);
            this.historyTabPage.TabIndex = 4;
            this.historyTabPage.Text = "Histórico";
            this.historyTabPage.UseVisualStyleBackColor = true;
            // 
            // methodologyTabPage
            // 
            this.methodologyTabPage.Location = new System.Drawing.Point(4, 22);
            this.methodologyTabPage.Name = "methodologyTabPage";
            this.methodologyTabPage.Size = new System.Drawing.Size(826, 435);
            this.methodologyTabPage.TabIndex = 5;
            this.methodologyTabPage.Text = "Metodologia";
            this.methodologyTabPage.UseVisualStyleBackColor = true;
            // 
            // UnitMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.unitMainTabControl);
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "UnitMainForm";
            this.Text = "Análise de Risco Ambiental - Unidades";
            this.unitMainTabControl.ResumeLayout(false);
            this.welcomeTabPage.ResumeLayout(false);
            this.locationTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl unitMainTabControl;
        private System.Windows.Forms.TabPage welcomeTabPage;
        private System.Windows.Forms.TabPage locationTabPage;
        private Controls.WelcomeControl welcomeControl1;
        private System.Windows.Forms.TabPage teamTabPage;
        private System.Windows.Forms.TabPage structureTabPage;
        private System.Windows.Forms.TabPage historyTabPage;
        private System.Windows.Forms.TabPage methodologyTabPage;
        private LocationControl locationControl1;
    }
}