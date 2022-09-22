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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.activeControlPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.mainTableLayoutPanel.Controls.Add(this.label1, 1, 0);
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
            this.navigationLayoutPanel.Controls.Add(this.button4, 0, 3);
            this.navigationLayoutPanel.Controls.Add(this.button3, 0, 2);
            this.navigationLayoutPanel.Controls.Add(this.button2, 0, 1);
            this.navigationLayoutPanel.Controls.Add(this.button1, 0, 0);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.BackgroundImage = global::RyskTech.Properties.Resources.home;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(11, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 162);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(111, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bem Vindo!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.BackgroundImage = global::RyskTech.Properties.Resources.chemical;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(11, 176);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 162);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.BackgroundImage = global::RyskTech.Properties.Resources.methodolody;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(11, 343);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 162);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.BackgroundImage = global::RyskTech.Properties.Resources.information;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(11, 510);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 163);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel activeControlPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button nextConcludeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}