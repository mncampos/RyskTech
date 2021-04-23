
namespace RyskTech.Forms.Lab.Controls
{
    partial class BiologicalAgentsInformation
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
            this.bioTabControl = new System.Windows.Forms.TabControl();
            this.agentInfoTabPage = new System.Windows.Forms.TabPage();
            this.biologicalResidues1 = new RyskTech.Forms.Lab.Controls.BiologicalResidues();
            this.storageDestinationTabPage = new System.Windows.Forms.TabPage();
            this.bioStorage1 = new RyskTech.Forms.Lab.Controls.BioStorage();
            this.bioTabControl.SuspendLayout();
            this.agentInfoTabPage.SuspendLayout();
            this.storageDestinationTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // bioTabControl
            // 
            this.bioTabControl.Controls.Add(this.agentInfoTabPage);
            this.bioTabControl.Controls.Add(this.storageDestinationTabPage);
            this.bioTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bioTabControl.Location = new System.Drawing.Point(0, 0);
            this.bioTabControl.Name = "bioTabControl";
            this.bioTabControl.SelectedIndex = 0;
            this.bioTabControl.Size = new System.Drawing.Size(820, 429);
            this.bioTabControl.TabIndex = 0;
            // 
            // agentInfoTabPage
            // 
            this.agentInfoTabPage.Controls.Add(this.biologicalResidues1);
            this.agentInfoTabPage.Location = new System.Drawing.Point(4, 22);
            this.agentInfoTabPage.Name = "agentInfoTabPage";
            this.agentInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.agentInfoTabPage.Size = new System.Drawing.Size(812, 403);
            this.agentInfoTabPage.TabIndex = 0;
            this.agentInfoTabPage.Text = "Agentes e resíduos";
            this.agentInfoTabPage.UseVisualStyleBackColor = true;
            // 
            // biologicalResidues1
            // 
            this.biologicalResidues1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.biologicalResidues1.Location = new System.Drawing.Point(3, 3);
            this.biologicalResidues1.Name = "biologicalResidues1";
            this.biologicalResidues1.Size = new System.Drawing.Size(806, 397);
            this.biologicalResidues1.TabIndex = 0;
            // 
            // storageDestinationTabPage
            // 
            this.storageDestinationTabPage.Controls.Add(this.bioStorage1);
            this.storageDestinationTabPage.Location = new System.Drawing.Point(4, 22);
            this.storageDestinationTabPage.Name = "storageDestinationTabPage";
            this.storageDestinationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.storageDestinationTabPage.Size = new System.Drawing.Size(812, 403);
            this.storageDestinationTabPage.TabIndex = 1;
            this.storageDestinationTabPage.Text = "Armazenamento e Destino";
            this.storageDestinationTabPage.UseVisualStyleBackColor = true;
            // 
            // bioStorage1
            // 
            this.bioStorage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bioStorage1.Location = new System.Drawing.Point(3, 3);
            this.bioStorage1.Name = "bioStorage1";
            this.bioStorage1.Size = new System.Drawing.Size(806, 397);
            this.bioStorage1.TabIndex = 0;
            // 
            // BiologicalAgentsInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bioTabControl);
            this.Name = "BiologicalAgentsInformation";
            this.Size = new System.Drawing.Size(820, 429);
            this.Load += new System.EventHandler(this.BiologicalAgentsInformation_Load);
            this.bioTabControl.ResumeLayout(false);
            this.agentInfoTabPage.ResumeLayout(false);
            this.storageDestinationTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl bioTabControl;
        private System.Windows.Forms.TabPage agentInfoTabPage;
        private System.Windows.Forms.TabPage storageDestinationTabPage;
        private BiologicalResidues biologicalResidues1;
        private BioStorage bioStorage1;
    }
}
