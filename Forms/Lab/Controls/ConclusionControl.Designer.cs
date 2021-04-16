
namespace RyskTech.Forms.Lab.Controls
{
    partial class ConclusionControl
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
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.conclusionLabel = new System.Windows.Forms.Label();
            this.recomentaionsLabel = new System.Windows.Forms.Label();
            this.recomendationTextBox = new System.Windows.Forms.TextBox();
            this.conclusionTextBox = new System.Windows.Forms.TextBox();
            this.mainGroupBox.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.mainTableLayoutPanel);
            this.mainGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGroupBox.Location = new System.Drawing.Point(0, 0);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(726, 448);
            this.mainGroupBox.TabIndex = 0;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "Considerações Finais";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.conclusionLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.recomentaionsLabel, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.recomendationTextBox, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.conclusionTextBox, 0, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(720, 429);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // conclusionLabel
            // 
            this.conclusionLabel.AutoSize = true;
            this.conclusionLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.conclusionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainTableLayoutPanel.SetColumnSpan(this.conclusionLabel, 2);
            this.conclusionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conclusionLabel.Location = new System.Drawing.Point(3, 0);
            this.conclusionLabel.Name = "conclusionLabel";
            this.conclusionLabel.Size = new System.Drawing.Size(714, 42);
            this.conclusionLabel.TabIndex = 0;
            this.conclusionLabel.Text = "Comente de maneira geral sobre as classificações de risco encontradas, além de co" +
    "mentar sobre terinamento, capacitação, supervisão, etc. quanto à segurança no am" +
    "biente de trabalho";
            this.conclusionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recomentaionsLabel
            // 
            this.recomentaionsLabel.AutoSize = true;
            this.recomentaionsLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.recomentaionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainTableLayoutPanel.SetColumnSpan(this.recomentaionsLabel, 2);
            this.recomentaionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recomentaionsLabel.Location = new System.Drawing.Point(3, 213);
            this.recomentaionsLabel.Name = "recomentaionsLabel";
            this.recomentaionsLabel.Size = new System.Drawing.Size(714, 42);
            this.recomentaionsLabel.TabIndex = 1;
            this.recomentaionsLabel.Text = "Apresente algumas recomendações gerais para melhorar a segurança no seu ambiente " +
    "de trabalho";
            this.recomentaionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recomendationTextBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.recomendationTextBox, 2);
            this.recomendationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recomendationTextBox.Enabled = false;
            this.recomendationTextBox.Location = new System.Drawing.Point(3, 258);
            this.recomendationTextBox.Multiline = true;
            this.recomendationTextBox.Name = "recomendationTextBox";
            this.recomendationTextBox.Size = new System.Drawing.Size(714, 168);
            this.recomendationTextBox.TabIndex = 2;
            this.recomendationTextBox.TextChanged += new System.EventHandler(this.recomendationTextBox_TextChanged);
            // 
            // conclusionTextBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.conclusionTextBox, 2);
            this.conclusionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conclusionTextBox.Location = new System.Drawing.Point(3, 45);
            this.conclusionTextBox.Multiline = true;
            this.conclusionTextBox.Name = "conclusionTextBox";
            this.conclusionTextBox.Size = new System.Drawing.Size(714, 165);
            this.conclusionTextBox.TabIndex = 3;
            this.conclusionTextBox.TextChanged += new System.EventHandler(this.conclusionTextBox_TextChanged);
            // 
            // ConclusionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainGroupBox);
            this.Name = "ConclusionControl";
            this.Size = new System.Drawing.Size(726, 448);
            this.mainGroupBox.ResumeLayout(false);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label conclusionLabel;
        private System.Windows.Forms.Label recomentaionsLabel;
        private System.Windows.Forms.TextBox conclusionTextBox;
        private System.Windows.Forms.TextBox recomendationTextBox;
    }
}
