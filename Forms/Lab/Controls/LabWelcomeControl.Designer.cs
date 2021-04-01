
namespace RyskTech.Forms.Lab.Controls
{
    partial class LabWelcomeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabWelcomeControl));
            this.introductionTextLabel = new System.Windows.Forms.Label();
            this.welcomeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.firstStepsGroupBox = new System.Windows.Forms.GroupBox();
            this.firstStepsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.unitNameTextLabel = new System.Windows.Forms.Label();
            this.unitNameTextBox = new System.Windows.Forms.TextBox();
            this.concludeButton = new System.Windows.Forms.Button();
            this.unitMaterialsHandledLabel = new System.Windows.Forms.Label();
            this.chemicalAgentsUsedCheckBox = new System.Windows.Forms.CheckBox();
            this.biologicalAgentsUsedCheckBox = new System.Windows.Forms.CheckBox();
            this.physicalAgentsUsedCheckBox = new System.Windows.Forms.CheckBox();
            this.mechanicalAgentsUsedCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labNameTextBox = new System.Windows.Forms.TextBox();
            this.welcomeTableLayoutPanel.SuspendLayout();
            this.firstStepsGroupBox.SuspendLayout();
            this.firstStepsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // introductionTextLabel
            // 
            this.introductionTextLabel.AutoSize = true;
            this.introductionTextLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.introductionTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcomeTableLayoutPanel.SetColumnSpan(this.introductionTextLabel, 2);
            this.introductionTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.introductionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introductionTextLabel.Location = new System.Drawing.Point(3, 0);
            this.introductionTextLabel.Name = "introductionTextLabel";
            this.introductionTextLabel.Size = new System.Drawing.Size(844, 235);
            this.introductionTextLabel.TabIndex = 0;
            this.introductionTextLabel.Text = resources.GetString("introductionTextLabel.Text");
            this.introductionTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeTableLayoutPanel
            // 
            this.welcomeTableLayoutPanel.ColumnCount = 2;
            this.welcomeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.welcomeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.welcomeTableLayoutPanel.Controls.Add(this.introductionTextLabel, 0, 0);
            this.welcomeTableLayoutPanel.Controls.Add(this.firstStepsGroupBox, 0, 1);
            this.welcomeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.welcomeTableLayoutPanel.MaximumSize = new System.Drawing.Size(850, 430);
            this.welcomeTableLayoutPanel.Name = "welcomeTableLayoutPanel";
            this.welcomeTableLayoutPanel.RowCount = 2;
            this.welcomeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.88372F));
            this.welcomeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.11628F));
            this.welcomeTableLayoutPanel.Size = new System.Drawing.Size(850, 430);
            this.welcomeTableLayoutPanel.TabIndex = 2;
            // 
            // firstStepsGroupBox
            // 
            this.welcomeTableLayoutPanel.SetColumnSpan(this.firstStepsGroupBox, 2);
            this.firstStepsGroupBox.Controls.Add(this.firstStepsTableLayoutPanel);
            this.firstStepsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstStepsGroupBox.Location = new System.Drawing.Point(3, 238);
            this.firstStepsGroupBox.Name = "firstStepsGroupBox";
            this.firstStepsGroupBox.Size = new System.Drawing.Size(844, 189);
            this.firstStepsGroupBox.TabIndex = 1;
            this.firstStepsGroupBox.TabStop = false;
            this.firstStepsGroupBox.Text = "Primeiros passos";
            // 
            // firstStepsTableLayoutPanel
            // 
            this.firstStepsTableLayoutPanel.ColumnCount = 5;
            this.firstStepsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.firstStepsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.firstStepsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.firstStepsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.firstStepsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.firstStepsTableLayoutPanel.Controls.Add(this.unitNameTextLabel, 0, 0);
            this.firstStepsTableLayoutPanel.Controls.Add(this.unitNameTextBox, 1, 0);
            this.firstStepsTableLayoutPanel.Controls.Add(this.concludeButton, 4, 3);
            this.firstStepsTableLayoutPanel.Controls.Add(this.unitMaterialsHandledLabel, 0, 2);
            this.firstStepsTableLayoutPanel.Controls.Add(this.chemicalAgentsUsedCheckBox, 1, 2);
            this.firstStepsTableLayoutPanel.Controls.Add(this.biologicalAgentsUsedCheckBox, 2, 2);
            this.firstStepsTableLayoutPanel.Controls.Add(this.physicalAgentsUsedCheckBox, 3, 2);
            this.firstStepsTableLayoutPanel.Controls.Add(this.mechanicalAgentsUsedCheckBox, 4, 2);
            this.firstStepsTableLayoutPanel.Controls.Add(this.label1, 0, 1);
            this.firstStepsTableLayoutPanel.Controls.Add(this.labNameTextBox, 1, 1);
            this.firstStepsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstStepsTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.firstStepsTableLayoutPanel.Name = "firstStepsTableLayoutPanel";
            this.firstStepsTableLayoutPanel.RowCount = 4;
            this.firstStepsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.firstStepsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.firstStepsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.firstStepsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.firstStepsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.firstStepsTableLayoutPanel.Size = new System.Drawing.Size(838, 170);
            this.firstStepsTableLayoutPanel.TabIndex = 0;
            // 
            // unitNameTextLabel
            // 
            this.unitNameTextLabel.AutoSize = true;
            this.unitNameTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitNameTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitNameTextLabel.Location = new System.Drawing.Point(5, 5);
            this.unitNameTextLabel.Margin = new System.Windows.Forms.Padding(5);
            this.unitNameTextLabel.Name = "unitNameTextLabel";
            this.unitNameTextLabel.Size = new System.Drawing.Size(199, 32);
            this.unitNameTextLabel.TabIndex = 0;
            this.unitNameTextLabel.Text = "Qual é o nome da sua unidade da qual seu espaço faz parte?";
            this.unitNameTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unitNameTextBox
            // 
            this.firstStepsTableLayoutPanel.SetColumnSpan(this.unitNameTextBox, 4);
            this.unitNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitNameTextBox.Location = new System.Drawing.Point(221, 12);
            this.unitNameTextBox.Margin = new System.Windows.Forms.Padding(12);
            this.unitNameTextBox.Name = "unitNameTextBox";
            this.unitNameTextBox.Size = new System.Drawing.Size(605, 20);
            this.unitNameTextBox.TabIndex = 1;
            this.unitNameTextBox.TextChanged += new System.EventHandler(this.unitNameTextBox_TextChanged);
            // 
            // concludeButton
            // 
            this.concludeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.concludeButton.Location = new System.Drawing.Point(690, 136);
            this.concludeButton.Margin = new System.Windows.Forms.Padding(10);
            this.concludeButton.Name = "concludeButton";
            this.concludeButton.Size = new System.Drawing.Size(138, 24);
            this.concludeButton.TabIndex = 7;
            this.concludeButton.Text = "Concluir e gerar APR";
            this.concludeButton.UseVisualStyleBackColor = true;
            this.concludeButton.Click += new System.EventHandler(this.concludeButton_Click);
            // 
            // unitMaterialsHandledLabel
            // 
            this.unitMaterialsHandledLabel.AutoSize = true;
            this.unitMaterialsHandledLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitMaterialsHandledLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitMaterialsHandledLabel.Location = new System.Drawing.Point(5, 89);
            this.unitMaterialsHandledLabel.Margin = new System.Windows.Forms.Padding(5);
            this.unitMaterialsHandledLabel.Name = "unitMaterialsHandledLabel";
            this.unitMaterialsHandledLabel.Size = new System.Drawing.Size(199, 32);
            this.unitMaterialsHandledLabel.TabIndex = 2;
            this.unitMaterialsHandledLabel.Text = "No seu espaço, quais dos tipos de agentes a seguir são manipulados?";
            this.unitMaterialsHandledLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chemicalAgentsUsedCheckBox
            // 
            this.chemicalAgentsUsedCheckBox.AutoSize = true;
            this.chemicalAgentsUsedCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chemicalAgentsUsedCheckBox.Location = new System.Drawing.Point(212, 87);
            this.chemicalAgentsUsedCheckBox.Name = "chemicalAgentsUsedCheckBox";
            this.chemicalAgentsUsedCheckBox.Size = new System.Drawing.Size(151, 36);
            this.chemicalAgentsUsedCheckBox.TabIndex = 3;
            this.chemicalAgentsUsedCheckBox.Text = "Agentes Químicos";
            this.chemicalAgentsUsedCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chemicalAgentsUsedCheckBox.UseVisualStyleBackColor = true;
            this.chemicalAgentsUsedCheckBox.CheckedChanged += new System.EventHandler(this.chemicalAgentsUsedCheckBox_CheckedChanged);
            // 
            // biologicalAgentsUsedCheckBox
            // 
            this.biologicalAgentsUsedCheckBox.AutoSize = true;
            this.biologicalAgentsUsedCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.biologicalAgentsUsedCheckBox.Location = new System.Drawing.Point(369, 87);
            this.biologicalAgentsUsedCheckBox.Name = "biologicalAgentsUsedCheckBox";
            this.biologicalAgentsUsedCheckBox.Size = new System.Drawing.Size(151, 36);
            this.biologicalAgentsUsedCheckBox.TabIndex = 4;
            this.biologicalAgentsUsedCheckBox.Text = "Agentes Biológicos";
            this.biologicalAgentsUsedCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.biologicalAgentsUsedCheckBox.UseVisualStyleBackColor = true;
            this.biologicalAgentsUsedCheckBox.CheckedChanged += new System.EventHandler(this.biologicalAgentsUsedCheckBox_CheckedChanged);
            // 
            // physicalAgentsUsedCheckBox
            // 
            this.physicalAgentsUsedCheckBox.AutoSize = true;
            this.physicalAgentsUsedCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.physicalAgentsUsedCheckBox.Location = new System.Drawing.Point(526, 87);
            this.physicalAgentsUsedCheckBox.Name = "physicalAgentsUsedCheckBox";
            this.physicalAgentsUsedCheckBox.Size = new System.Drawing.Size(151, 36);
            this.physicalAgentsUsedCheckBox.TabIndex = 5;
            this.physicalAgentsUsedCheckBox.Text = "Agentes Físicos";
            this.physicalAgentsUsedCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.physicalAgentsUsedCheckBox.UseVisualStyleBackColor = true;
            this.physicalAgentsUsedCheckBox.CheckedChanged += new System.EventHandler(this.physicalAgentsUsedCheckBox_CheckedChanged);
            // 
            // mechanicalAgentsUsedCheckBox
            // 
            this.mechanicalAgentsUsedCheckBox.AutoSize = true;
            this.mechanicalAgentsUsedCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mechanicalAgentsUsedCheckBox.Location = new System.Drawing.Point(683, 87);
            this.mechanicalAgentsUsedCheckBox.Name = "mechanicalAgentsUsedCheckBox";
            this.mechanicalAgentsUsedCheckBox.Size = new System.Drawing.Size(152, 36);
            this.mechanicalAgentsUsedCheckBox.TabIndex = 6;
            this.mechanicalAgentsUsedCheckBox.Text = "Agentes Mecânicos";
            this.mechanicalAgentsUsedCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mechanicalAgentsUsedCheckBox.UseVisualStyleBackColor = true;
            this.mechanicalAgentsUsedCheckBox.CheckedChanged += new System.EventHandler(this.mechanicalAgentsUsedCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Qual é o nome e/ou descritor do seu espaço?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labNameTextBox
            // 
            this.firstStepsTableLayoutPanel.SetColumnSpan(this.labNameTextBox, 4);
            this.labNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labNameTextBox.Location = new System.Drawing.Point(221, 54);
            this.labNameTextBox.Margin = new System.Windows.Forms.Padding(12);
            this.labNameTextBox.Name = "labNameTextBox";
            this.labNameTextBox.Size = new System.Drawing.Size(605, 20);
            this.labNameTextBox.TabIndex = 9;
            this.labNameTextBox.TextChanged += new System.EventHandler(this.labNameTextBox_TextChanged);
            // 
            // LabWelcomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.welcomeTableLayoutPanel);
            this.Name = "LabWelcomeControl";
            this.Size = new System.Drawing.Size(850, 430);
            this.Load += new System.EventHandler(this.LabWelcomeControl_Load);
            this.welcomeTableLayoutPanel.ResumeLayout(false);
            this.welcomeTableLayoutPanel.PerformLayout();
            this.firstStepsGroupBox.ResumeLayout(false);
            this.firstStepsTableLayoutPanel.ResumeLayout(false);
            this.firstStepsTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label introductionTextLabel;
        private System.Windows.Forms.TableLayoutPanel welcomeTableLayoutPanel;
        private System.Windows.Forms.GroupBox firstStepsGroupBox;
        private System.Windows.Forms.TableLayoutPanel firstStepsTableLayoutPanel;
        private System.Windows.Forms.Label unitNameTextLabel;
        private System.Windows.Forms.TextBox unitNameTextBox;
        private System.Windows.Forms.Label unitMaterialsHandledLabel;
        private System.Windows.Forms.CheckBox chemicalAgentsUsedCheckBox;
        private System.Windows.Forms.CheckBox biologicalAgentsUsedCheckBox;
        private System.Windows.Forms.CheckBox physicalAgentsUsedCheckBox;
        private System.Windows.Forms.CheckBox mechanicalAgentsUsedCheckBox;
        private System.Windows.Forms.Button concludeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox labNameTextBox;
    }
}
