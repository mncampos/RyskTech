
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.recomendationTextBox = new System.Windows.Forms.TextBox();
            this.accidentHistoryTextBox = new System.Windows.Forms.TextBox();
            this.conclusionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.mainTableLayoutPanel.Controls.Add(this.panel1, 0, 4);
            this.mainTableLayoutPanel.Controls.Add(this.panel2, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 6;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.922912F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.05353F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.351178F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.05353F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.922912F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.55246F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(596, 467);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // recomendationTextBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.recomendationTextBox, 2);
            this.recomendationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recomendationTextBox.Location = new System.Drawing.Point(3, 345);
            this.recomendationTextBox.Multiline = true;
            this.recomendationTextBox.Name = "recomendationTextBox";
            this.recomendationTextBox.Size = new System.Drawing.Size(590, 119);
            this.recomendationTextBox.TabIndex = 5;
            this.recomendationTextBox.TextChanged += new System.EventHandler(this.recomendationTextBox_TextChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Por favor descreva abaixo um breve histórico dos acidentes que ocorreram no seu a" +
    "mbiente de trabalho. Caso não haja nenhum, poderá pular este passo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 30);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Recomendações:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "apresente, na forma de itens, mudanças de procedimentos, treinamentos, equipament" +
    "os de \r\nsegurança, adequações de infraestrutura, entre outros.";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 32);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "apresente comentários gerais referentes à análise de riscos ambientais realizada," +
    " lembrando de \r\ndestacar os principais riscos encontrados e níveis de classifica" +
    "ção.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Conclusões:";
            // 
            // ConclusionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "ConclusionControl";
            this.Size = new System.Drawing.Size(596, 467);
            this.Load += new System.EventHandler(this.ConclusionControlBetter_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TextBox accidentHistoryTextBox;
        private System.Windows.Forms.TextBox conclusionTextBox;
        private System.Windows.Forms.TextBox recomendationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}
