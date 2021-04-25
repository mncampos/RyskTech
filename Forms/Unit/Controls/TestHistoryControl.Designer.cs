
namespace RyskTech.Forms.Unit.Controls
{
    partial class TestHistoryControl
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
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UnitHistoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayout.Controls.Add(this.UnitHistoryTextBox, 0, 1);
            this.mainTableLayout.Controls.Add(this.label1, 0, 0);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 2;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.84797F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.15203F));
            this.mainTableLayout.Size = new System.Drawing.Size(596, 467);
            this.mainTableLayout.TabIndex = 0;
            // 
            // UnitHistoryTextBox
            // 
            this.mainTableLayout.SetColumnSpan(this.UnitHistoryTextBox, 2);
            this.UnitHistoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitHistoryTextBox.Location = new System.Drawing.Point(5, 65);
            this.UnitHistoryTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.UnitHistoryTextBox.MaxLength = 30000;
            this.UnitHistoryTextBox.Multiline = true;
            this.UnitHistoryTextBox.Name = "UnitHistoryTextBox";
            this.UnitHistoryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UnitHistoryTextBox.Size = new System.Drawing.Size(586, 397);
            this.UnitHistoryTextBox.TabIndex = 0;
            this.UnitHistoryTextBox.TextChanged += new System.EventHandler(this.UnitHistoryTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.mainTableLayout.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descreva brevemente o histórico da sua unidade.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestHistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTableLayout);
            this.Name = "TestHistoryControl";
            this.Size = new System.Drawing.Size(596, 467);
            this.mainTableLayout.ResumeLayout(false);
            this.mainTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.TextBox UnitHistoryTextBox;
        private System.Windows.Forms.Label label1;
    }
}
