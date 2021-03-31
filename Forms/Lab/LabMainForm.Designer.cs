
namespace RyskTech.Forms.Lab
{
    partial class LabMainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.welcomeTabPage = new System.Windows.Forms.TabPage();
            this.safetyEquipmentTab = new System.Windows.Forms.TabPage();
            this.safetyTrainingTab = new System.Windows.Forms.TabPage();
            this.chemicalResidueInformationTab = new System.Windows.Forms.TabPage();
            this.safetyEquipmentControl1 = new RyskTech.Forms.Lab.Controls.SafetyEquipmentControl();
            this.satefyTrainingControl1 = new RyskTech.Forms.Lab.Controls.SatefyTrainingControl();
            this.chemicalResidueControl1 = new RyskTech.ChemicalResidueControl();
            this.tabControl1.SuspendLayout();
            this.safetyEquipmentTab.SuspendLayout();
            this.safetyTrainingTab.SuspendLayout();
            this.chemicalResidueInformationTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.welcomeTabPage);
            this.tabControl1.Controls.Add(this.safetyEquipmentTab);
            this.tabControl1.Controls.Add(this.safetyTrainingTab);
            this.tabControl1.Controls.Add(this.chemicalResidueInformationTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // welcomeTabPage
            // 
            this.welcomeTabPage.Location = new System.Drawing.Point(4, 22);
            this.welcomeTabPage.Name = "welcomeTabPage";
            this.welcomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.welcomeTabPage.Size = new System.Drawing.Size(688, 352);
            this.welcomeTabPage.TabIndex = 0;
            this.welcomeTabPage.Text = "Bem Vindo!";
            this.welcomeTabPage.UseVisualStyleBackColor = true;
            // 
            // safetyEquipmentTab
            // 
            this.safetyEquipmentTab.Controls.Add(this.safetyEquipmentControl1);
            this.safetyEquipmentTab.Location = new System.Drawing.Point(4, 22);
            this.safetyEquipmentTab.Name = "safetyEquipmentTab";
            this.safetyEquipmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.safetyEquipmentTab.Size = new System.Drawing.Size(688, 352);
            this.safetyEquipmentTab.TabIndex = 1;
            this.safetyEquipmentTab.Text = "Equipamento de Segurança";
            this.safetyEquipmentTab.UseVisualStyleBackColor = true;
            // 
            // safetyTrainingTab
            // 
            this.safetyTrainingTab.Controls.Add(this.satefyTrainingControl1);
            this.safetyTrainingTab.Location = new System.Drawing.Point(4, 22);
            this.safetyTrainingTab.Name = "safetyTrainingTab";
            this.safetyTrainingTab.Size = new System.Drawing.Size(688, 352);
            this.safetyTrainingTab.TabIndex = 2;
            this.safetyTrainingTab.Text = "Treinamento de Segurança";
            this.safetyTrainingTab.UseVisualStyleBackColor = true;
            // 
            // chemicalResidueInformationTab
            // 
            this.chemicalResidueInformationTab.Controls.Add(this.chemicalResidueControl1);
            this.chemicalResidueInformationTab.Location = new System.Drawing.Point(4, 22);
            this.chemicalResidueInformationTab.Name = "chemicalResidueInformationTab";
            this.chemicalResidueInformationTab.Size = new System.Drawing.Size(688, 352);
            this.chemicalResidueInformationTab.TabIndex = 3;
            this.chemicalResidueInformationTab.Text = "Resíduos Químicos";
            this.chemicalResidueInformationTab.UseVisualStyleBackColor = true;
            // 
            // safetyEquipmentControl1
            // 
            this.safetyEquipmentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.safetyEquipmentControl1.Location = new System.Drawing.Point(3, 3);
            this.safetyEquipmentControl1.Name = "safetyEquipmentControl1";
            this.safetyEquipmentControl1.Size = new System.Drawing.Size(682, 346);
            this.safetyEquipmentControl1.TabIndex = 0;
            // 
            // satefyTrainingControl1
            // 
            this.satefyTrainingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.satefyTrainingControl1.Location = new System.Drawing.Point(0, 0);
            this.satefyTrainingControl1.Name = "satefyTrainingControl1";
            this.satefyTrainingControl1.Size = new System.Drawing.Size(688, 352);
            this.satefyTrainingControl1.TabIndex = 0;
            // 
            // chemicalResidueControl1
            // 
            this.chemicalResidueControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chemicalResidueControl1.Location = new System.Drawing.Point(0, 0);
            this.chemicalResidueControl1.Name = "chemicalResidueControl1";
            this.chemicalResidueControl1.Size = new System.Drawing.Size(688, 352);
            this.chemicalResidueControl1.TabIndex = 0;
            // 
            // LabMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 378);
            this.Controls.Add(this.tabControl1);
            this.Name = "LabMainForm";
            this.Text = "LabMainForm";
            this.Load += new System.EventHandler(this.LabMainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.safetyEquipmentTab.ResumeLayout(false);
            this.safetyTrainingTab.ResumeLayout(false);
            this.chemicalResidueInformationTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage welcomeTabPage;
        private System.Windows.Forms.TabPage safetyEquipmentTab;
        private System.Windows.Forms.TabPage safetyTrainingTab;
        private System.Windows.Forms.TabPage chemicalResidueInformationTab;
        private Controls.SafetyEquipmentControl safetyEquipmentControl1;
        private Controls.SatefyTrainingControl satefyTrainingControl1;
        private ChemicalResidueControl chemicalResidueControl1;
    }
}