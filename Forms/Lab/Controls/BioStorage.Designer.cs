
namespace RyskTech.Forms.Lab.Controls
{
    partial class BioStorage
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
            this.storageAndDestionationGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.storageLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.bioStorageTextBox = new System.Windows.Forms.TextBox();
            this.bioResidueDestinationTextBox = new System.Windows.Forms.TextBox();
            this.storageAndDestionationGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // storageAndDestionationGroupBox
            // 
            this.storageAndDestionationGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.storageAndDestionationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storageAndDestionationGroupBox.Location = new System.Drawing.Point(0, 0);
            this.storageAndDestionationGroupBox.Name = "storageAndDestionationGroupBox";
            this.storageAndDestionationGroupBox.Size = new System.Drawing.Size(820, 429);
            this.storageAndDestionationGroupBox.TabIndex = 0;
            this.storageAndDestionationGroupBox.TabStop = false;
            this.storageAndDestionationGroupBox.Text = "Armazenamento e destino";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.storageLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.destinationLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bioStorageTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bioResidueDestinationTextBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.65854F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.34146F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 410);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // storageLabel
            // 
            this.storageLabel.AutoSize = true;
            this.storageLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.storageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.storageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storageLabel.Location = new System.Drawing.Point(3, 0);
            this.storageLabel.Name = "storageLabel";
            this.storageLabel.Size = new System.Drawing.Size(401, 56);
            this.storageLabel.TabIndex = 0;
            this.storageLabel.Text = "Como é feito o armazenamento de resíduos biológicos?";
            this.storageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.destinationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.destinationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationLabel.Location = new System.Drawing.Point(410, 0);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(401, 56);
            this.destinationLabel.TabIndex = 1;
            this.destinationLabel.Text = "Qual é o destino dos resíduos biológicos gerados?";
            this.destinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bioStorageTextBox
            // 
            this.bioStorageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bioStorageTextBox.Location = new System.Drawing.Point(10, 66);
            this.bioStorageTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.bioStorageTextBox.Multiline = true;
            this.bioStorageTextBox.Name = "bioStorageTextBox";
            this.bioStorageTextBox.Size = new System.Drawing.Size(387, 334);
            this.bioStorageTextBox.TabIndex = 2;
            this.bioStorageTextBox.TextChanged += new System.EventHandler(this.bioStorageTextBox_TextChanged);
            // 
            // bioResidueDestinationTextBox
            // 
            this.bioResidueDestinationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bioResidueDestinationTextBox.Location = new System.Drawing.Point(417, 66);
            this.bioResidueDestinationTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.bioResidueDestinationTextBox.Multiline = true;
            this.bioResidueDestinationTextBox.Name = "bioResidueDestinationTextBox";
            this.bioResidueDestinationTextBox.Size = new System.Drawing.Size(387, 334);
            this.bioResidueDestinationTextBox.TabIndex = 3;
            this.bioResidueDestinationTextBox.TextChanged += new System.EventHandler(this.bioResidueDestinationTextBox_TextChanged);
            // 
            // BioStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.storageAndDestionationGroupBox);
            this.Name = "BioStorage";
            this.Size = new System.Drawing.Size(820, 429);
            this.storageAndDestionationGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox storageAndDestionationGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label storageLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.TextBox bioStorageTextBox;
        private System.Windows.Forms.TextBox bioResidueDestinationTextBox;
    }
}
