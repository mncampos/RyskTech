
namespace RyskTech.Forms
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.welcomeTextLabel = new System.Windows.Forms.Label();
            this.iAmALaboratoryButton = new System.Windows.Forms.Button();
            this.iAmAUnitManagerButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.welcomeTextLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.iAmALaboratoryButton, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.iAmAUnitManagerButton, 1, 2);
            this.mainTableLayoutPanel.Controls.Add(this.pictureBox1, 0, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.28283F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.71717F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(379, 254);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // welcomeTextLabel
            // 
            this.welcomeTextLabel.AutoSize = true;
            this.mainTableLayoutPanel.SetColumnSpan(this.welcomeTextLabel, 2);
            this.welcomeTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTextLabel.Location = new System.Drawing.Point(3, 0);
            this.welcomeTextLabel.Name = "welcomeTextLabel";
            this.welcomeTextLabel.Size = new System.Drawing.Size(373, 56);
            this.welcomeTextLabel.TabIndex = 1;
            this.welcomeTextLabel.Text = "Bem vindo à versão de teste do RyskTech!";
            this.welcomeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iAmALaboratoryButton
            // 
            this.iAmALaboratoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iAmALaboratoryButton.Location = new System.Drawing.Point(10, 208);
            this.iAmALaboratoryButton.Margin = new System.Windows.Forms.Padding(10);
            this.iAmALaboratoryButton.Name = "iAmALaboratoryButton";
            this.iAmALaboratoryButton.Size = new System.Drawing.Size(169, 36);
            this.iAmALaboratoryButton.TabIndex = 2;
            this.iAmALaboratoryButton.Text = "Somos um laboratório";
            this.iAmALaboratoryButton.UseVisualStyleBackColor = true;
            this.iAmALaboratoryButton.Click += new System.EventHandler(this.iAmALaboratoryButton_Click);
            // 
            // iAmAUnitManagerButton
            // 
            this.iAmAUnitManagerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iAmAUnitManagerButton.Location = new System.Drawing.Point(199, 208);
            this.iAmAUnitManagerButton.Margin = new System.Windows.Forms.Padding(10);
            this.iAmAUnitManagerButton.Name = "iAmAUnitManagerButton";
            this.iAmAUnitManagerButton.Size = new System.Drawing.Size(170, 36);
            this.iAmAUnitManagerButton.TabIndex = 3;
            this.iAmAUnitManagerButton.Text = "Sou gerente de uma unidade";
            this.iAmAUnitManagerButton.UseVisualStyleBackColor = true;
            this.iAmAUnitManagerButton.Click += new System.EventHandler(this.iAmAUnitManagerButton_Click);
            // 
            // pictureBox1
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::RyskTech.Properties.Resources.logo;
            this.pictureBox1.InitialImage = global::RyskTech.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(100, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(100, 3, 100, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 254);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(395, 293);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(395, 293);
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome!";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label welcomeTextLabel;
        private System.Windows.Forms.Button iAmALaboratoryButton;
        private System.Windows.Forms.Button iAmAUnitManagerButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}