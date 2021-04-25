
namespace RyskTech.Forms.Unit.Controls
{
    partial class TestWelcomeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestWelcomeControl));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.generalInfotableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.unitNameLabel = new System.Windows.Forms.Label();
            this.unitNameTextBox = new System.Windows.Forms.TextBox();
            this.manipulatedAgentsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mechanicalAgentsUsedCheckBox = new System.Windows.Forms.CheckBox();
            this.physicalAgentsUsedCheckBox = new System.Windows.Forms.CheckBox();
            this.biologicalAgentsUsedCheckBox = new System.Windows.Forms.CheckBox();
            this.chemicalAgentsUsedCheckBox = new System.Windows.Forms.CheckBox();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.generalInfotableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 3;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.mainTableLayoutPanel.Controls.Add(this.logoPictureBox, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.label1, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.groupBox1, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.77478F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.91892F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.05405F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.07207F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(578, 555);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::RyskTech.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(195, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(186, 187);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.mainTableLayoutPanel.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 216);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.generalInfotableLayoutPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 412);
            this.groupBox1.Name = "groupBox1";
            this.mainTableLayoutPanel.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(572, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Gerais";
            // 
            // generalInfotableLayoutPanel
            // 
            this.generalInfotableLayoutPanel.ColumnCount = 3;
            this.generalInfotableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.91519F));
            this.generalInfotableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.5159F));
            this.generalInfotableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.generalInfotableLayoutPanel.Controls.Add(this.unitNameLabel, 0, 0);
            this.generalInfotableLayoutPanel.Controls.Add(this.unitNameTextBox, 1, 0);
            this.generalInfotableLayoutPanel.Controls.Add(this.manipulatedAgentsLabel, 0, 1);
            this.generalInfotableLayoutPanel.Controls.Add(this.panel1, 1, 1);
            this.generalInfotableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalInfotableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.generalInfotableLayoutPanel.Name = "generalInfotableLayoutPanel";
            this.generalInfotableLayoutPanel.RowCount = 2;
            this.generalInfotableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalInfotableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalInfotableLayoutPanel.Size = new System.Drawing.Size(566, 121);
            this.generalInfotableLayoutPanel.TabIndex = 0;
            // 
            // unitNameLabel
            // 
            this.unitNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.unitNameLabel.AutoSize = true;
            this.unitNameLabel.Location = new System.Drawing.Point(3, 23);
            this.unitNameLabel.Name = "unitNameLabel";
            this.unitNameLabel.Size = new System.Drawing.Size(149, 13);
            this.unitNameLabel.TabIndex = 0;
            this.unitNameLabel.Text = "Qual o nome da sua unidade?";
            this.unitNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unitNameTextBox
            // 
            this.unitNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.generalInfotableLayoutPanel.SetColumnSpan(this.unitNameTextBox, 2);
            this.unitNameTextBox.Location = new System.Drawing.Point(161, 20);
            this.unitNameTextBox.Name = "unitNameTextBox";
            this.unitNameTextBox.Size = new System.Drawing.Size(402, 20);
            this.unitNameTextBox.TabIndex = 1;
            this.unitNameTextBox.TextChanged += new System.EventHandler(this.unitNameTextBox_TextChanged);
            // 
            // manipulatedAgentsLabel
            // 
            this.manipulatedAgentsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manipulatedAgentsLabel.AutoSize = true;
            this.manipulatedAgentsLabel.Location = new System.Drawing.Point(63, 60);
            this.manipulatedAgentsLabel.Name = "manipulatedAgentsLabel";
            this.manipulatedAgentsLabel.Size = new System.Drawing.Size(92, 13);
            this.manipulatedAgentsLabel.TabIndex = 2;
            this.manipulatedAgentsLabel.Text = "Agentes utilizados";
            this.manipulatedAgentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mechanicalAgentsUsedCheckBox);
            this.panel1.Controls.Add(this.physicalAgentsUsedCheckBox);
            this.panel1.Controls.Add(this.biologicalAgentsUsedCheckBox);
            this.panel1.Controls.Add(this.chemicalAgentsUsedCheckBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(161, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 55);
            this.panel1.TabIndex = 4;
            // 
            // mechanicalAgentsUsedCheckBox
            // 
            this.mechanicalAgentsUsedCheckBox.AutoSize = true;
            this.mechanicalAgentsUsedCheckBox.Location = new System.Drawing.Point(107, 27);
            this.mechanicalAgentsUsedCheckBox.Name = "mechanicalAgentsUsedCheckBox";
            this.mechanicalAgentsUsedCheckBox.Size = new System.Drawing.Size(78, 17);
            this.mechanicalAgentsUsedCheckBox.TabIndex = 3;
            this.mechanicalAgentsUsedCheckBox.Text = "Mecânicos";
            this.mechanicalAgentsUsedCheckBox.UseVisualStyleBackColor = true;
            this.mechanicalAgentsUsedCheckBox.CheckedChanged += new System.EventHandler(this.mechanicalAgentsUsedCheckBox_CheckedChanged);
            // 
            // physicalAgentsUsedCheckBox
            // 
            this.physicalAgentsUsedCheckBox.AutoSize = true;
            this.physicalAgentsUsedCheckBox.Location = new System.Drawing.Point(107, 4);
            this.physicalAgentsUsedCheckBox.Name = "physicalAgentsUsedCheckBox";
            this.physicalAgentsUsedCheckBox.Size = new System.Drawing.Size(60, 17);
            this.physicalAgentsUsedCheckBox.TabIndex = 2;
            this.physicalAgentsUsedCheckBox.Text = "Físicos";
            this.physicalAgentsUsedCheckBox.UseVisualStyleBackColor = true;
            this.physicalAgentsUsedCheckBox.CheckedChanged += new System.EventHandler(this.physicalAgentsUsedCheckBox_CheckedChanged);
            // 
            // biologicalAgentsUsedCheckBox
            // 
            this.biologicalAgentsUsedCheckBox.AutoSize = true;
            this.biologicalAgentsUsedCheckBox.Location = new System.Drawing.Point(4, 27);
            this.biologicalAgentsUsedCheckBox.Name = "biologicalAgentsUsedCheckBox";
            this.biologicalAgentsUsedCheckBox.Size = new System.Drawing.Size(74, 17);
            this.biologicalAgentsUsedCheckBox.TabIndex = 1;
            this.biologicalAgentsUsedCheckBox.Text = "Biológicos";
            this.biologicalAgentsUsedCheckBox.UseVisualStyleBackColor = true;
            this.biologicalAgentsUsedCheckBox.CheckedChanged += new System.EventHandler(this.biologicalAgentsUsedCheckBox_CheckedChanged);
            // 
            // chemicalAgentsUsedCheckBox
            // 
            this.chemicalAgentsUsedCheckBox.AutoSize = true;
            this.chemicalAgentsUsedCheckBox.Location = new System.Drawing.Point(4, 4);
            this.chemicalAgentsUsedCheckBox.Name = "chemicalAgentsUsedCheckBox";
            this.chemicalAgentsUsedCheckBox.Size = new System.Drawing.Size(71, 17);
            this.chemicalAgentsUsedCheckBox.TabIndex = 0;
            this.chemicalAgentsUsedCheckBox.Text = "Químicos";
            this.chemicalAgentsUsedCheckBox.UseVisualStyleBackColor = true;
            this.chemicalAgentsUsedCheckBox.CheckedChanged += new System.EventHandler(this.chemicalAgentsUsedCheckBox_CheckedChanged);
            // 
            // TestWelcomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "TestWelcomeControl";
            this.Size = new System.Drawing.Size(578, 555);
            this.Load += new System.EventHandler(this.TestWelcomeControl_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.generalInfotableLayoutPanel.ResumeLayout(false);
            this.generalInfotableLayoutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel generalInfotableLayoutPanel;
        private System.Windows.Forms.Label unitNameLabel;
        private System.Windows.Forms.TextBox unitNameTextBox;
        private System.Windows.Forms.Label manipulatedAgentsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox mechanicalAgentsUsedCheckBox;
        private System.Windows.Forms.CheckBox physicalAgentsUsedCheckBox;
        private System.Windows.Forms.CheckBox biologicalAgentsUsedCheckBox;
        private System.Windows.Forms.CheckBox chemicalAgentsUsedCheckBox;
    }
}
