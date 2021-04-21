
namespace RyskTech
{
    partial class EditChemicalResidueForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.concludeButton = new System.Windows.Forms.Button();
            this.residueNameLabel = new System.Windows.Forms.Label();
            this.residueNameTextBox = new System.Windows.Forms.TextBox();
            this.residueInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.physicalStateComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.measurementUnitComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.originCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.isInertCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dangerCharacteristicsListBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.storageLocationTextBox = new System.Windows.Forms.TextBox();
            this.transparentGlassRadioButton = new System.Windows.Forms.RadioButton();
            this.amberGlassRadioButton = new System.Windows.Forms.RadioButton();
            this.plasticRadioButton = new System.Windows.Forms.RadioButton();
            this.otherRadioButton = new System.Windows.Forms.RadioButton();
            this.isDangerousCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.residueInfoGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.44701F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.55299F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.concludeButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.residueNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.residueNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.residueInfoGroupBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.22801F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.771987F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 398);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(249, 366);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 29);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // concludeButton
            // 
            this.concludeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.concludeButton.Location = new System.Drawing.Point(344, 366);
            this.concludeButton.Name = "concludeButton";
            this.concludeButton.Size = new System.Drawing.Size(112, 29);
            this.concludeButton.TabIndex = 1;
            this.concludeButton.Text = "Concluir";
            this.concludeButton.UseVisualStyleBackColor = true;
            this.concludeButton.Click += new System.EventHandler(this.concludeButton_Click);
            // 
            // residueNameLabel
            // 
            this.residueNameLabel.AutoSize = true;
            this.residueNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.residueNameLabel.Location = new System.Drawing.Point(3, 0);
            this.residueNameLabel.Name = "residueNameLabel";
            this.residueNameLabel.Size = new System.Drawing.Size(100, 42);
            this.residueNameLabel.TabIndex = 2;
            this.residueNameLabel.Text = "Nome";
            this.residueNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // residueNameTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.residueNameTextBox, 2);
            this.residueNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.residueNameTextBox.Location = new System.Drawing.Point(109, 12);
            this.residueNameTextBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.residueNameTextBox.Name = "residueNameTextBox";
            this.residueNameTextBox.Size = new System.Drawing.Size(229, 20);
            this.residueNameTextBox.TabIndex = 3;
            // 
            // residueInfoGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.residueInfoGroupBox, 4);
            this.residueInfoGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.residueInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.residueInfoGroupBox.Location = new System.Drawing.Point(3, 45);
            this.residueInfoGroupBox.Name = "residueInfoGroupBox";
            this.residueInfoGroupBox.Size = new System.Drawing.Size(453, 315);
            this.residueInfoGroupBox.TabIndex = 4;
            this.residueInfoGroupBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.33229F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.92308F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.61539F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.07932F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.physicalStateComboBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.quantityUpDown, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.measurementUnitComboBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.originCheckedListBox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.isInertCheckBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.dangerCharacteristicsListBox, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.storageLocationTextBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.transparentGlassRadioButton, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.amberGlassRadioButton, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.plasticRadioButton, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.otherRadioButton, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.isDangerousCheckBox, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.46988F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.18072F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(447, 296);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado Físico";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // physicalStateComboBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.physicalStateComboBox, 2);
            this.physicalStateComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.physicalStateComboBox.FormattingEnabled = true;
            this.physicalStateComboBox.Items.AddRange(new object[] {
            "Sólido",
            "Líquido",
            "Gasoso",
            "Aquoso"});
            this.physicalStateComboBox.Location = new System.Drawing.Point(81, 7);
            this.physicalStateComboBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.physicalStateComboBox.Name = "physicalStateComboBox";
            this.physicalStateComboBox.Size = new System.Drawing.Size(141, 21);
            this.physicalStateComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(5, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.DecimalPlaces = 2;
            this.quantityUpDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.quantityUpDown.Location = new System.Drawing.Point(81, 39);
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(68, 20);
            this.quantityUpDown.TabIndex = 3;
            // 
            // measurementUnitComboBox
            // 
            this.measurementUnitComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.measurementUnitComboBox.FormattingEnabled = true;
            this.measurementUnitComboBox.Items.AddRange(new object[] {
            "mL",
            "L",
            "g",
            "Kg",
            "m³"});
            this.measurementUnitComboBox.Location = new System.Drawing.Point(155, 38);
            this.measurementUnitComboBox.Name = "measurementUnitComboBox";
            this.measurementUnitComboBox.Size = new System.Drawing.Size(67, 21);
            this.measurementUnitComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(5, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Origem";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // originCheckedListBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.originCheckedListBox, 2);
            this.originCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originCheckedListBox.FormattingEnabled = true;
            this.originCheckedListBox.Items.AddRange(new object[] {
            "Ensino",
            "Pesquisa",
            "Extensão",
            "Processo Produtivo"});
            this.originCheckedListBox.Location = new System.Drawing.Point(3, 94);
            this.originCheckedListBox.Name = "originCheckedListBox";
            this.originCheckedListBox.Size = new System.Drawing.Size(146, 69);
            this.originCheckedListBox.TabIndex = 6;
            // 
            // isInertCheckBox
            // 
            this.isInertCheckBox.AutoSize = true;
            this.isInertCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isInertCheckBox.Location = new System.Drawing.Point(228, 3);
            this.isInertCheckBox.Name = "isInertCheckBox";
            this.isInertCheckBox.Size = new System.Drawing.Size(65, 25);
            this.isInertCheckBox.TabIndex = 7;
            this.isInertCheckBox.Text = "Inerte?";
            this.isInertCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(228, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Características de periculosidade";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dangerCharacteristicsListBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.dangerCharacteristicsListBox, 2);
            this.dangerCharacteristicsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dangerCharacteristicsListBox.FormattingEnabled = true;
            this.dangerCharacteristicsListBox.Items.AddRange(new object[] {
            "Inflamável",
            "Corrosivo",
            "Tóxico",
            "Reativo"});
            this.dangerCharacteristicsListBox.Location = new System.Drawing.Point(228, 94);
            this.dangerCharacteristicsListBox.Name = "dangerCharacteristicsListBox";
            this.dangerCharacteristicsListBox.Size = new System.Drawing.Size(216, 69);
            this.dangerCharacteristicsListBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 166);
            this.label5.Name = "label5";
            this.tableLayoutPanel2.SetRowSpan(this.label5, 2);
            this.label5.Size = new System.Drawing.Size(72, 130);
            this.label5.TabIndex = 10;
            this.label5.Text = "Onde o resíduo é armazenado?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // storageLocationTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.storageLocationTextBox, 4);
            this.storageLocationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storageLocationTextBox.Location = new System.Drawing.Point(81, 239);
            this.storageLocationTextBox.Multiline = true;
            this.storageLocationTextBox.Name = "storageLocationTextBox";
            this.storageLocationTextBox.Size = new System.Drawing.Size(363, 54);
            this.storageLocationTextBox.TabIndex = 11;
            // 
            // transparentGlassRadioButton
            // 
            this.transparentGlassRadioButton.AutoSize = true;
            this.transparentGlassRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transparentGlassRadioButton.Location = new System.Drawing.Point(81, 169);
            this.transparentGlassRadioButton.Name = "transparentGlassRadioButton";
            this.transparentGlassRadioButton.Size = new System.Drawing.Size(68, 64);
            this.transparentGlassRadioButton.TabIndex = 12;
            this.transparentGlassRadioButton.TabStop = true;
            this.transparentGlassRadioButton.Text = "Vidro temperado transparente";
            this.transparentGlassRadioButton.UseVisualStyleBackColor = true;
            // 
            // amberGlassRadioButton
            // 
            this.amberGlassRadioButton.AutoSize = true;
            this.amberGlassRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amberGlassRadioButton.Location = new System.Drawing.Point(155, 169);
            this.amberGlassRadioButton.Name = "amberGlassRadioButton";
            this.amberGlassRadioButton.Size = new System.Drawing.Size(67, 64);
            this.amberGlassRadioButton.TabIndex = 13;
            this.amberGlassRadioButton.TabStop = true;
            this.amberGlassRadioButton.Text = "Vidro temperado âmbar";
            this.amberGlassRadioButton.UseVisualStyleBackColor = true;
            // 
            // plasticRadioButton
            // 
            this.plasticRadioButton.AutoSize = true;
            this.plasticRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plasticRadioButton.Location = new System.Drawing.Point(228, 169);
            this.plasticRadioButton.Name = "plasticRadioButton";
            this.plasticRadioButton.Size = new System.Drawing.Size(65, 64);
            this.plasticRadioButton.TabIndex = 14;
            this.plasticRadioButton.TabStop = true;
            this.plasticRadioButton.Text = "Bombona plásitca";
            this.plasticRadioButton.UseVisualStyleBackColor = true;
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.otherRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otherRadioButton.Location = new System.Drawing.Point(299, 169);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(145, 64);
            this.otherRadioButton.TabIndex = 15;
            this.otherRadioButton.TabStop = true;
            this.otherRadioButton.Text = "Outro (especificar no texto)";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            // 
            // isDangerousCheckBox
            // 
            this.isDangerousCheckBox.AutoSize = true;
            this.isDangerousCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isDangerousCheckBox.Location = new System.Drawing.Point(155, 94);
            this.isDangerousCheckBox.Name = "isDangerousCheckBox";
            this.isDangerousCheckBox.Size = new System.Drawing.Size(67, 69);
            this.isDangerousCheckBox.TabIndex = 16;
            this.isDangerousCheckBox.Text = "Perigoso?";
            this.isDangerousCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isDangerousCheckBox.UseVisualStyleBackColor = true;
            // 
            // EditChemicalResidueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 398);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditChemicalResidueForm";
            this.Text = "Editar resíduo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.residueInfoGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button concludeButton;
        private System.Windows.Forms.Label residueNameLabel;
        private System.Windows.Forms.TextBox residueNameTextBox;
        private System.Windows.Forms.GroupBox residueInfoGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox physicalStateComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
        private System.Windows.Forms.ComboBox measurementUnitComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox originCheckedListBox;
        private System.Windows.Forms.CheckBox isInertCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox dangerCharacteristicsListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox storageLocationTextBox;
        private System.Windows.Forms.RadioButton transparentGlassRadioButton;
        private System.Windows.Forms.RadioButton amberGlassRadioButton;
        private System.Windows.Forms.RadioButton plasticRadioButton;
        private System.Windows.Forms.RadioButton otherRadioButton;
        private System.Windows.Forms.CheckBox isDangerousCheckBox;
    }
}