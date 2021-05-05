
namespace RyskTech.Forms.Lab
{
    partial class EditMechanicalAgentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMechanicalAgentForm));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.concludeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.riskComboBox = new System.Windows.Forms.ComboBox();
            this.otherRiskTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.riskLabel = new System.Windows.Forms.Label();
            this.agentComboBox = new System.Windows.Forms.ComboBox();
            this.otherNameTextBox = new System.Windows.Forms.TextBox();
            this.additionalInfoLabel = new System.Windows.Forms.Label();
            this.additionalInfoTextBox = new System.Windows.Forms.TextBox();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 4;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.01501F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.83865F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.51032F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.4484F));
            this.mainTableLayoutPanel.Controls.Add(this.concludeButton, 3, 3);
            this.mainTableLayoutPanel.Controls.Add(this.cancelButton, 2, 3);
            this.mainTableLayoutPanel.Controls.Add(this.riskComboBox, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.otherRiskTextBox, 2, 1);
            this.mainTableLayoutPanel.Controls.Add(this.nameLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.riskLabel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.agentComboBox, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.otherNameTextBox, 2, 0);
            this.mainTableLayoutPanel.Controls.Add(this.additionalInfoLabel, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.additionalInfoTextBox, 1, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.05439F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.57322F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(533, 214);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // concludeButton
            // 
            this.concludeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.concludeButton.Location = new System.Drawing.Point(447, 184);
            this.concludeButton.Margin = new System.Windows.Forms.Padding(8);
            this.concludeButton.Name = "concludeButton";
            this.concludeButton.Size = new System.Drawing.Size(78, 22);
            this.concludeButton.TabIndex = 1;
            this.concludeButton.Text = "Concluir";
            this.concludeButton.UseVisualStyleBackColor = true;
            this.concludeButton.Click += new System.EventHandler(this.concludeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(359, 184);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(8);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(72, 22);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // riskComboBox
            // 
            this.riskComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Corte",
            "Queda",
            "Esmagamento",
            "Amputação",
            "Queimadura",
            "Explosão",
            "Incêndio",
            "Derramamento no meio ambiente",
            "Batidas",
            "Picada",
            "Intoxicação",
            "Choque eletrico",
            "Outros"});
            this.riskComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riskComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.riskComboBox.FormattingEnabled = true;
            this.riskComboBox.Items.AddRange(new object[] {
            "Corte",
            "Queda",
            "Esmagamento",
            "Amputação",
            "Queimadura",
            "Explosão",
            "Incêndio",
            "Derramamento no meio ambiente",
            "Batidas",
            "Picada",
            "Intoxicação",
            "Choque eletrico",
            "Outros"});
            this.riskComboBox.Location = new System.Drawing.Point(131, 71);
            this.riskComboBox.Margin = new System.Windows.Forms.Padding(3, 18, 3, 3);
            this.riskComboBox.Name = "riskComboBox";
            this.riskComboBox.Size = new System.Drawing.Size(217, 21);
            this.riskComboBox.TabIndex = 3;
            this.riskComboBox.SelectedIndexChanged += new System.EventHandler(this.riskComboBox_SelectedIndexChanged);
            // 
            // otherRiskTextBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.otherRiskTextBox, 2);
            this.otherRiskTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otherRiskTextBox.Enabled = false;
            this.otherRiskTextBox.Location = new System.Drawing.Point(354, 71);
            this.otherRiskTextBox.Margin = new System.Windows.Forms.Padding(3, 18, 3, 3);
            this.otherRiskTextBox.Name = "otherRiskTextBox";
            this.otherRiskTextBox.Size = new System.Drawing.Size(176, 20);
            this.otherRiskTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(122, 53);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Agente";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // riskLabel
            // 
            this.riskLabel.AutoSize = true;
            this.riskLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riskLabel.Location = new System.Drawing.Point(3, 53);
            this.riskLabel.Name = "riskLabel";
            this.riskLabel.Size = new System.Drawing.Size(122, 53);
            this.riskLabel.TabIndex = 5;
            this.riskLabel.Text = "Risco associado";
            this.riskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // agentComboBox
            // 
            this.agentComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agentComboBox.FormattingEnabled = true;
            this.agentComboBox.Items.AddRange(new object[] {
            "Arranjo físico inadequado",
            "Equipamentos sem proteção",
            "Matéria prima inadequada",
            "Animais peçonhentos ",
            "Ferramentas defeituosas ou inadequadas",
            "Falta de EPI ou EPI inadequado ao risco:",
            "Falta de EPC ou EPC inadequado ao risco:",
            "Deficiências de transporte",
            "Edificações com defeitos de construção",
            "Falta de sinalização",
            "Armazenamento inadequado",
            "Falta de treinamento para o manuseio de reagentes químicos",
            "Falta de treinamento  decolaboradores para a operação de máquinas e equipamentos",
            "Deficiência ou indispobilidade de sistemas e equipamentos de prevenção e proteção" +
                " de incêndio",
            "Problemas elétricos",
            "Equipamentos obsoletos",
            "Falta de sistema de exaustão",
            "Não há um agente específico",
            "Outros"});
            this.agentComboBox.Location = new System.Drawing.Point(131, 18);
            this.agentComboBox.Margin = new System.Windows.Forms.Padding(3, 18, 3, 3);
            this.agentComboBox.Name = "agentComboBox";
            this.agentComboBox.Size = new System.Drawing.Size(217, 21);
            this.agentComboBox.TabIndex = 6;
            this.agentComboBox.SelectedIndexChanged += new System.EventHandler(this.agentComboBox_SelectedIndexChanged);
            // 
            // otherNameTextBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.otherNameTextBox, 2);
            this.otherNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otherNameTextBox.Enabled = false;
            this.otherNameTextBox.Location = new System.Drawing.Point(354, 18);
            this.otherNameTextBox.Margin = new System.Windows.Forms.Padding(3, 18, 3, 3);
            this.otherNameTextBox.Name = "otherNameTextBox";
            this.otherNameTextBox.Size = new System.Drawing.Size(176, 20);
            this.otherNameTextBox.TabIndex = 7;
            // 
            // additionalInfoLabel
            // 
            this.additionalInfoLabel.AutoSize = true;
            this.additionalInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.additionalInfoLabel.Location = new System.Drawing.Point(3, 106);
            this.additionalInfoLabel.Name = "additionalInfoLabel";
            this.additionalInfoLabel.Size = new System.Drawing.Size(122, 70);
            this.additionalInfoLabel.TabIndex = 8;
            this.additionalInfoLabel.Text = "Informações adicionais";
            this.additionalInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // additionalInfoTextBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.additionalInfoTextBox, 3);
            this.additionalInfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.additionalInfoTextBox.Location = new System.Drawing.Point(131, 109);
            this.additionalInfoTextBox.Multiline = true;
            this.additionalInfoTextBox.Name = "additionalInfoTextBox";
            this.additionalInfoTextBox.Size = new System.Drawing.Size(399, 64);
            this.additionalInfoTextBox.TabIndex = 9;
            // 
            // EditMechanicalAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 214);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditMechanicalAgentForm";
            this.Text = "Agentes Mecânicos";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TextBox otherRiskTextBox;
        private System.Windows.Forms.Button concludeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox riskComboBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label riskLabel;
        private System.Windows.Forms.ComboBox agentComboBox;
        private System.Windows.Forms.TextBox otherNameTextBox;
        private System.Windows.Forms.Label additionalInfoLabel;
        private System.Windows.Forms.TextBox additionalInfoTextBox;
    }
}