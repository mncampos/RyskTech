
namespace RyskTech.Forms.Lab
{
    partial class EditBiologicalAgentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBiologicalAgentForm));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.concludeButton = new System.Windows.Forms.Button();
            this.agentNameLabel = new System.Windows.Forms.Label();
            this.agentNameTextBox = new System.Windows.Forms.TextBox();
            this.riskClassificationLabel = new System.Windows.Forms.Label();
            this.riskClassificationTextBox = new System.Windows.Forms.ComboBox();
            this.showRiskClassTableButton = new System.Windows.Forms.Button();
            this.useslabel = new System.Windows.Forms.Label();
            this.extensionCheckBox = new System.Windows.Forms.CheckBox();
            this.researchCheckBox = new System.Windows.Forms.CheckBox();
            this.productiveProcessCheckBox = new System.Windows.Forms.CheckBox();
            this.teachingCheckBox = new System.Windows.Forms.CheckBox();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 4;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.97561F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.43902F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.84466F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.51456F));
            this.mainTableLayoutPanel.Controls.Add(this.cancelButton, 2, 4);
            this.mainTableLayoutPanel.Controls.Add(this.concludeButton, 3, 4);
            this.mainTableLayoutPanel.Controls.Add(this.agentNameLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.agentNameTextBox, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.riskClassificationLabel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.riskClassificationTextBox, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.showRiskClassTableButton, 2, 1);
            this.mainTableLayoutPanel.Controls.Add(this.useslabel, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.extensionCheckBox, 1, 3);
            this.mainTableLayoutPanel.Controls.Add(this.researchCheckBox, 2, 3);
            this.mainTableLayoutPanel.Controls.Add(this.productiveProcessCheckBox, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.teachingCheckBox, 3, 3);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 5;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.3886F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.50777F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.17098F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(410, 193);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(227, 160);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(8);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(73, 25);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // concludeButton
            // 
            this.concludeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.concludeButton.Location = new System.Drawing.Point(316, 160);
            this.concludeButton.Margin = new System.Windows.Forms.Padding(8);
            this.concludeButton.Name = "concludeButton";
            this.concludeButton.Size = new System.Drawing.Size(86, 25);
            this.concludeButton.TabIndex = 0;
            this.concludeButton.Text = "Concluír";
            this.concludeButton.UseVisualStyleBackColor = true;
            this.concludeButton.Click += new System.EventHandler(this.concludeButton_Click);
            // 
            // agentNameLabel
            // 
            this.agentNameLabel.AutoSize = true;
            this.agentNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agentNameLabel.Location = new System.Drawing.Point(3, 0);
            this.agentNameLabel.Name = "agentNameLabel";
            this.agentNameLabel.Size = new System.Drawing.Size(121, 38);
            this.agentNameLabel.TabIndex = 2;
            this.agentNameLabel.Text = "Nome do Agente";
            this.agentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // agentNameTextBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.agentNameTextBox, 2);
            this.agentNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agentNameTextBox.Location = new System.Drawing.Point(130, 13);
            this.agentNameTextBox.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.agentNameTextBox.Name = "agentNameTextBox";
            this.agentNameTextBox.Size = new System.Drawing.Size(175, 20);
            this.agentNameTextBox.TabIndex = 3;
            // 
            // riskClassificationLabel
            // 
            this.riskClassificationLabel.AutoSize = true;
            this.riskClassificationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riskClassificationLabel.Location = new System.Drawing.Point(3, 38);
            this.riskClassificationLabel.Name = "riskClassificationLabel";
            this.riskClassificationLabel.Size = new System.Drawing.Size(121, 49);
            this.riskClassificationLabel.TabIndex = 4;
            this.riskClassificationLabel.Text = "Classificação de Risco";
            this.riskClassificationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // riskClassificationTextBox
            // 
            this.riskClassificationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riskClassificationTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.riskClassificationTextBox.FormattingEnabled = true;
            this.riskClassificationTextBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.riskClassificationTextBox.Location = new System.Drawing.Point(130, 48);
            this.riskClassificationTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.riskClassificationTextBox.Name = "riskClassificationTextBox";
            this.riskClassificationTextBox.Size = new System.Drawing.Size(86, 21);
            this.riskClassificationTextBox.TabIndex = 5;
            // 
            // showRiskClassTableButton
            // 
            this.showRiskClassTableButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showRiskClassTableButton.Location = new System.Drawing.Point(229, 48);
            this.showRiskClassTableButton.Margin = new System.Windows.Forms.Padding(10);
            this.showRiskClassTableButton.Name = "showRiskClassTableButton";
            this.showRiskClassTableButton.Size = new System.Drawing.Size(69, 29);
            this.showRiskClassTableButton.TabIndex = 6;
            this.showRiskClassTableButton.Text = "Tabela";
            this.showRiskClassTableButton.UseVisualStyleBackColor = true;
            this.showRiskClassTableButton.Click += new System.EventHandler(this.showRiskClassTableButton_Click);
            // 
            // useslabel
            // 
            this.useslabel.AutoSize = true;
            this.mainTableLayoutPanel.SetColumnSpan(this.useslabel, 4);
            this.useslabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.useslabel.Location = new System.Drawing.Point(3, 87);
            this.useslabel.Name = "useslabel";
            this.useslabel.Size = new System.Drawing.Size(404, 28);
            this.useslabel.TabIndex = 7;
            this.useslabel.Text = "Selecione todos os usos para este agente que se aplicam";
            this.useslabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // extensionCheckBox
            // 
            this.extensionCheckBox.AutoSize = true;
            this.extensionCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extensionCheckBox.Location = new System.Drawing.Point(130, 118);
            this.extensionCheckBox.Name = "extensionCheckBox";
            this.extensionCheckBox.Size = new System.Drawing.Size(86, 31);
            this.extensionCheckBox.TabIndex = 9;
            this.extensionCheckBox.Text = "Extensão";
            this.extensionCheckBox.UseVisualStyleBackColor = true;
            // 
            // researchCheckBox
            // 
            this.researchCheckBox.AutoSize = true;
            this.researchCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.researchCheckBox.Location = new System.Drawing.Point(222, 118);
            this.researchCheckBox.Name = "researchCheckBox";
            this.researchCheckBox.Size = new System.Drawing.Size(83, 31);
            this.researchCheckBox.TabIndex = 10;
            this.researchCheckBox.Text = "Pesquisa";
            this.researchCheckBox.UseVisualStyleBackColor = true;
            // 
            // productiveProcessCheckBox
            // 
            this.productiveProcessCheckBox.AutoSize = true;
            this.productiveProcessCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productiveProcessCheckBox.Location = new System.Drawing.Point(3, 118);
            this.productiveProcessCheckBox.Name = "productiveProcessCheckBox";
            this.productiveProcessCheckBox.Size = new System.Drawing.Size(121, 31);
            this.productiveProcessCheckBox.TabIndex = 11;
            this.productiveProcessCheckBox.Text = "Processo Produtivo";
            this.productiveProcessCheckBox.UseVisualStyleBackColor = true;
            // 
            // teachingCheckBox
            // 
            this.teachingCheckBox.AutoSize = true;
            this.teachingCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teachingCheckBox.Location = new System.Drawing.Point(311, 118);
            this.teachingCheckBox.Name = "teachingCheckBox";
            this.teachingCheckBox.Size = new System.Drawing.Size(96, 31);
            this.teachingCheckBox.TabIndex = 8;
            this.teachingCheckBox.Text = "Ensino";
            this.teachingCheckBox.UseVisualStyleBackColor = true;
            // 
            // EditBiologicalAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 193);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditBiologicalAgentForm";
            this.Text = "Editar agente biológico";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Button concludeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label agentNameLabel;
        private System.Windows.Forms.TextBox agentNameTextBox;
        private System.Windows.Forms.Label riskClassificationLabel;
        private System.Windows.Forms.ComboBox riskClassificationTextBox;
        private System.Windows.Forms.Button showRiskClassTableButton;
        private System.Windows.Forms.Label useslabel;
        private System.Windows.Forms.CheckBox teachingCheckBox;
        private System.Windows.Forms.CheckBox extensionCheckBox;
        private System.Windows.Forms.CheckBox researchCheckBox;
        private System.Windows.Forms.CheckBox productiveProcessCheckBox;
    }
}