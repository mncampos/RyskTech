
namespace RyskTech.Forms.Lab.Controls
{
    partial class ConclusionControlBetter
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.accidentHistoryTextBox = new System.Windows.Forms.TextBox();
            this.conclusionTextBox = new System.Windows.Forms.TextBox();
            this.recomendationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.recomendationTextBox, 0, 5);
            this.mainTableLayoutPanel.Controls.Add(this.accidentHistoryTextBox, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.conclusionTextBox, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.label2, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.label3, 0, 4);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 6;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.922912F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.05353F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.351178F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.05353F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.781585F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.69379F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(596, 467);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // accidentHistoryTextBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.accidentHistoryTextBox, 2);
            this.accidentHistoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accidentHistoryTextBox.Location = new System.Drawing.Point(3, 39);
            this.accidentHistoryTextBox.Multiline = true;
            this.accidentHistoryTextBox.Name = "accidentHistoryTextBox";
            this.accidentHistoryTextBox.Size = new System.Drawing.Size(590, 110);
            this.accidentHistoryTextBox.TabIndex = 2;
            this.accidentHistoryTextBox.TextChanged += new System.EventHandler(this.accidentHistoryTextBox_TextChanged);
            // 
            // conclusionTextBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.conclusionTextBox, 2);
            this.conclusionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conclusionTextBox.Location = new System.Drawing.Point(3, 193);
            this.conclusionTextBox.Multiline = true;
            this.conclusionTextBox.Name = "conclusionTextBox";
            this.conclusionTextBox.Size = new System.Drawing.Size(590, 110);
            this.conclusionTextBox.TabIndex = 4;
            this.conclusionTextBox.TextChanged += new System.EventHandler(this.conclusionTextBox_TextChanged);
            // 
            // recomendationTextBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.recomendationTextBox, 2);
            this.recomendationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recomendationTextBox.Location = new System.Drawing.Point(3, 335);
            this.recomendationTextBox.Multiline = true;
            this.recomendationTextBox.Name = "recomendationTextBox";
            this.recomendationTextBox.Size = new System.Drawing.Size(590, 129);
            this.recomendationTextBox.TabIndex = 5;
            this.recomendationTextBox.TextChanged += new System.EventHandler(this.recomendationTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Por favor descreva abaixo um breve histórico dos acidentes notáveis que ocorreram" +
    " no seu ambiente de trabalho. Caso não haja nenhum, poderá pular este passo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(590, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Comente de maneira geral sobre as classificações de risco encontradas, além de co" +
    "mentar sobre terinamento, capacitação, supervisão, etc. quanto à segurança no am" +
    "biente de trabalho";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(590, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apresente algumas recomendações gerais para melhorar a segurança no seu ambiente " +
    "de trabalho";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConclusionControlBetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "ConclusionControlBetter";
            this.Size = new System.Drawing.Size(596, 467);
            this.Load += new System.EventHandler(this.ConclusionControlBetter_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TextBox accidentHistoryTextBox;
        private System.Windows.Forms.TextBox conclusionTextBox;
        private System.Windows.Forms.TextBox recomendationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
