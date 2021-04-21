
namespace RyskTech.Forms.Lab.Controls
{
    partial class AccidentHistoryControl
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
            this.accidentGroupBox = new System.Windows.Forms.GroupBox();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.accidentLabel = new System.Windows.Forms.Label();
            this.accidentHistoryTextBox = new System.Windows.Forms.TextBox();
            this.accidentGroupBox.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // accidentGroupBox
            // 
            this.accidentGroupBox.Controls.Add(this.mainTableLayoutPanel);
            this.accidentGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accidentGroupBox.Location = new System.Drawing.Point(0, 0);
            this.accidentGroupBox.Name = "accidentGroupBox";
            this.accidentGroupBox.Size = new System.Drawing.Size(731, 479);
            this.accidentGroupBox.TabIndex = 0;
            this.accidentGroupBox.TabStop = false;
            this.accidentGroupBox.Text = "Histórico de Acidentes";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.accidentLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.accidentHistoryTextBox, 0, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34783F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.65218F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(725, 460);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // accidentLabel
            // 
            this.accidentLabel.AutoSize = true;
            this.accidentLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.accidentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainTableLayoutPanel.SetColumnSpan(this.accidentLabel, 2);
            this.accidentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accidentLabel.Location = new System.Drawing.Point(3, 0);
            this.accidentLabel.Name = "accidentLabel";
            this.accidentLabel.Size = new System.Drawing.Size(719, 66);
            this.accidentLabel.TabIndex = 0;
            this.accidentLabel.Text = "Por favor descreva abaixo um breve histórico dos acidentes notáveis que ocorreram" +
    " no seu ambiente de trabalho. Caso não haja nenhum, poderá pular este passo";
            this.accidentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accidentHistoryTextBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.accidentHistoryTextBox, 2);
            this.accidentHistoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accidentHistoryTextBox.Location = new System.Drawing.Point(3, 69);
            this.accidentHistoryTextBox.Multiline = true;
            this.accidentHistoryTextBox.Name = "accidentHistoryTextBox";
            this.accidentHistoryTextBox.Size = new System.Drawing.Size(719, 388);
            this.accidentHistoryTextBox.TabIndex = 1;
            this.accidentHistoryTextBox.TextChanged += new System.EventHandler(this.accidentHistoryTextBox_TextChanged);
            // 
            // AccidentHistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accidentGroupBox);
            this.Name = "AccidentHistoryControl";
            this.Size = new System.Drawing.Size(731, 479);
            this.Load += new System.EventHandler(this.AccidentHistoryControl_Load);
            this.accidentGroupBox.ResumeLayout(false);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox accidentGroupBox;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label accidentLabel;
        private System.Windows.Forms.TextBox accidentHistoryTextBox;
    }
}
