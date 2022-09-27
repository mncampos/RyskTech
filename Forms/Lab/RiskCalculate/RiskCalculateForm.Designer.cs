namespace RyskTech.Forms.Lab
{
    partial class RiskCalculateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiskCalculateForm));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bottomBarPanel = new System.Windows.Forms.Panel();
            this.nextConcludeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.navigationLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.generalInfoButton = new System.Windows.Forms.Button();
            this.calculatePageButton = new System.Windows.Forms.Button();
            this.chemicalAgentsButton = new System.Windows.Forms.Button();
            this.welcomeTabButton = new System.Windows.Forms.Button();
            this.activePanelLabel = new System.Windows.Forms.Label();
            this.activeControlPanel = new System.Windows.Forms.Panel();
            this.mainTableLayoutPanel.SuspendLayout();
            this.bottomBarPanel.SuspendLayout();
            this.navigationLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.bottomBarPanel, 1, 2);
            this.mainTableLayoutPanel.Controls.Add(this.navigationLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.activePanelLabel, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.activeControlPanel, 1, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(912, 690);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // bottomBarPanel
            // 
            this.bottomBarPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bottomBarPanel.Controls.Add(this.nextConcludeButton);
            this.bottomBarPanel.Controls.Add(this.saveButton);
            this.bottomBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomBarPanel.Location = new System.Drawing.Point(111, 650);
            this.bottomBarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bottomBarPanel.Name = "bottomBarPanel";
            this.bottomBarPanel.Size = new System.Drawing.Size(797, 36);
            this.bottomBarPanel.TabIndex = 0;
            // 
            // nextConcludeButton
            // 
            this.nextConcludeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextConcludeButton.Location = new System.Drawing.Point(674, 4);
            this.nextConcludeButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextConcludeButton.Name = "nextConcludeButton";
            this.nextConcludeButton.Size = new System.Drawing.Size(111, 28);
            this.nextConcludeButton.TabIndex = 7;
            this.nextConcludeButton.Text = "Próximo";
            this.nextConcludeButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(7, 5);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(151, 28);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Salvar Progresso";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // navigationLayoutPanel
            // 
            this.navigationLayoutPanel.BackColor = System.Drawing.Color.LightGray;
            this.navigationLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.navigationLayoutPanel.ColumnCount = 1;
            this.navigationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navigationLayoutPanel.Controls.Add(this.generalInfoButton, 0, 3);
            this.navigationLayoutPanel.Controls.Add(this.calculatePageButton, 0, 2);
            this.navigationLayoutPanel.Controls.Add(this.chemicalAgentsButton, 0, 1);
            this.navigationLayoutPanel.Controls.Add(this.welcomeTabButton, 0, 0);
            this.navigationLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.navigationLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.navigationLayoutPanel.Name = "navigationLayoutPanel";
            this.navigationLayoutPanel.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.navigationLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.SetRowSpan(this.navigationLayoutPanel, 3);
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.navigationLayoutPanel.Size = new System.Drawing.Size(99, 682);
            this.navigationLayoutPanel.TabIndex = 1;
            // 
            // generalInfoButton
            // 
            this.generalInfoButton.BackColor = System.Drawing.Color.LightGray;
            this.generalInfoButton.BackgroundImage = global::RyskTech.Properties.Resources.information;
            this.generalInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.generalInfoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalInfoButton.FlatAppearance.BorderSize = 0;
            this.generalInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generalInfoButton.Location = new System.Drawing.Point(11, 510);
            this.generalInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generalInfoButton.Name = "generalInfoButton";
            this.generalInfoButton.Size = new System.Drawing.Size(77, 163);
            this.generalInfoButton.TabIndex = 3;
            this.generalInfoButton.UseVisualStyleBackColor = false;
            // 
            // calculatePageButton
            // 
            this.calculatePageButton.BackColor = System.Drawing.Color.LightGray;
            this.calculatePageButton.BackgroundImage = global::RyskTech.Properties.Resources.methodolody;
            this.calculatePageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.calculatePageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculatePageButton.FlatAppearance.BorderSize = 0;
            this.calculatePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculatePageButton.Location = new System.Drawing.Point(11, 343);
            this.calculatePageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculatePageButton.Name = "calculatePageButton";
            this.calculatePageButton.Size = new System.Drawing.Size(77, 162);
            this.calculatePageButton.TabIndex = 2;
            this.calculatePageButton.UseVisualStyleBackColor = false;
            // 
            // chemicalAgentsButton
            // 
            this.chemicalAgentsButton.BackColor = System.Drawing.Color.LightGray;
            this.chemicalAgentsButton.BackgroundImage = global::RyskTech.Properties.Resources.chemical;
            this.chemicalAgentsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chemicalAgentsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chemicalAgentsButton.FlatAppearance.BorderSize = 0;
            this.chemicalAgentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chemicalAgentsButton.Location = new System.Drawing.Point(11, 176);
            this.chemicalAgentsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chemicalAgentsButton.Name = "chemicalAgentsButton";
            this.chemicalAgentsButton.Size = new System.Drawing.Size(77, 162);
            this.chemicalAgentsButton.TabIndex = 1;
            this.chemicalAgentsButton.UseVisualStyleBackColor = false;
            this.chemicalAgentsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // welcomeTabButton
            // 
            this.welcomeTabButton.BackColor = System.Drawing.Color.LightGray;
            this.welcomeTabButton.BackgroundImage = global::RyskTech.Properties.Resources.home;
            this.welcomeTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.welcomeTabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeTabButton.FlatAppearance.BorderSize = 0;
            this.welcomeTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcomeTabButton.Location = new System.Drawing.Point(11, 9);
            this.welcomeTabButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.welcomeTabButton.Name = "welcomeTabButton";
            this.welcomeTabButton.Size = new System.Drawing.Size(77, 162);
            this.welcomeTabButton.TabIndex = 0;
            this.welcomeTabButton.UseVisualStyleBackColor = false;
            this.welcomeTabButton.Click += new System.EventHandler(this.welcomeTabButton_Click);
            // 
            // activePanelLabel
            // 
            this.activePanelLabel.AutoSize = true;
            this.activePanelLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.activePanelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activePanelLabel.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.activePanelLabel.Location = new System.Drawing.Point(111, 0);
            this.activePanelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.activePanelLabel.Name = "activePanelLabel";
            this.activePanelLabel.Size = new System.Drawing.Size(797, 64);
            this.activePanelLabel.TabIndex = 2;
            this.activePanelLabel.Text = "Bem Vindo!";
            this.activePanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activeControlPanel
            // 
            this.activeControlPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.activeControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeControlPanel.Location = new System.Drawing.Point(110, 67);
            this.activeControlPanel.Name = "activeControlPanel";
            this.activeControlPanel.Size = new System.Drawing.Size(799, 576);
            this.activeControlPanel.TabIndex = 3;
            // 
            // RiskCalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 690);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RiskCalculateForm";
            this.Text = "RyskTech - Cálculo de Risco";
            this.Load += new System.EventHandler(this.RiskCalculateFormBetter_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.bottomBarPanel.ResumeLayout(false);
            this.navigationLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Panel bottomBarPanel;
        private System.Windows.Forms.TableLayoutPanel navigationLayoutPanel;
        private System.Windows.Forms.Label activePanelLabel;
        private System.Windows.Forms.Panel activeControlPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button nextConcludeButton;
        private System.Windows.Forms.Button welcomeTabButton;
        private System.Windows.Forms.Button generalInfoButton;
        private System.Windows.Forms.Button calculatePageButton;
        private System.Windows.Forms.Button chemicalAgentsButton;
    }
}