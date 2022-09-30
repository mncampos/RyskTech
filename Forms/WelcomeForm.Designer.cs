
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.manualButton = new System.Windows.Forms.Button();
            this.administrativeUnitButton = new System.Windows.Forms.Button();
            this.laboratoryButton = new System.Windows.Forms.Button();
            this.welcomeTextLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.calculateRiskIndicebutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.manualButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.administrativeUnitButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.laboratoryButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 488);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(841, 84);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // manualButton
            // 
            this.manualButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manualButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.manualButton.Location = new System.Drawing.Point(570, 10);
            this.manualButton.Margin = new System.Windows.Forms.Padding(10);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(261, 64);
            this.manualButton.TabIndex = 2;
            this.manualButton.Text = "Conferir Manual";
            this.manualButton.UseVisualStyleBackColor = true;
            this.manualButton.Click += new System.EventHandler(this.manualButton_Click);
            // 
            // administrativeUnitButton
            // 
            this.administrativeUnitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.administrativeUnitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.administrativeUnitButton.Location = new System.Drawing.Point(290, 10);
            this.administrativeUnitButton.Margin = new System.Windows.Forms.Padding(10);
            this.administrativeUnitButton.Name = "administrativeUnitButton";
            this.administrativeUnitButton.Size = new System.Drawing.Size(260, 64);
            this.administrativeUnitButton.TabIndex = 1;
            this.administrativeUnitButton.Text = "Somos Uma Unidade Administrativa";
            this.administrativeUnitButton.UseVisualStyleBackColor = true;
            this.administrativeUnitButton.Click += new System.EventHandler(this.administrativeUnitButton_Click);
            // 
            // laboratoryButton
            // 
            this.laboratoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laboratoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.laboratoryButton.Location = new System.Drawing.Point(10, 10);
            this.laboratoryButton.Margin = new System.Windows.Forms.Padding(10);
            this.laboratoryButton.Name = "laboratoryButton";
            this.laboratoryButton.Size = new System.Drawing.Size(260, 64);
            this.laboratoryButton.TabIndex = 0;
            this.laboratoryButton.Text = "Somos Um Laboratório";
            this.laboratoryButton.UseVisualStyleBackColor = true;
            this.laboratoryButton.Click += new System.EventHandler(this.laboratoryButton_Click_1);
            // 
            // welcomeTextLabel
            // 
            this.welcomeTextLabel.AutoSize = true;
            this.welcomeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.welcomeTextLabel.Location = new System.Drawing.Point(98, 9);
            this.welcomeTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeTextLabel.Name = "welcomeTextLabel";
            this.welcomeTextLabel.Size = new System.Drawing.Size(621, 36);
            this.welcomeTextLabel.TabIndex = 2;
            this.welcomeTextLabel.Text = "Bem-vindo a versão de teste do RyskTech!";
            this.welcomeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RyskTech.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(230, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // calculateRiskIndicebutton
            // 
            this.calculateRiskIndicebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calculateRiskIndicebutton.Location = new System.Drawing.Point(290, 397);
            this.calculateRiskIndicebutton.Name = "calculateRiskIndicebutton";
            this.calculateRiskIndicebutton.Size = new System.Drawing.Size(260, 64);
            this.calculateRiskIndicebutton.TabIndex = 4;
            this.calculateRiskIndicebutton.Text = "Calcular IR";
            this.calculateRiskIndicebutton.UseVisualStyleBackColor = true;
            this.calculateRiskIndicebutton.Click += new System.EventHandler(this.calculateRiskIndicebutton_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 572);
            this.Controls.Add(this.calculateRiskIndicebutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.welcomeTextLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome!";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label welcomeTextLabel;
        private System.Windows.Forms.Button manualButton;
        private System.Windows.Forms.Button administrativeUnitButton;
        private System.Windows.Forms.Button laboratoryButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button calculateRiskIndicebutton;
    }
}