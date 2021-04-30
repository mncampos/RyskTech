
namespace RyskTech.Forms.Lab
{
    partial class EditChemicalReactorForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.originCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dangerCharacteristicsListBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.storageLocationTextBox = new System.Windows.Forms.TextBox();
            this.transparentGlassRadioButton = new System.Windows.Forms.RadioButton();
            this.amberGlassRadioButton = new System.Windows.Forms.RadioButton();
            this.plasticRadioButton = new System.Windows.Forms.RadioButton();
            this.otherRadioButton = new System.Windows.Forms.RadioButton();
            this.isDangerousCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.measurementUnitComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.casNumberTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pureRadioButton = new System.Windows.Forms.RadioButton();
            this.mixedRadioButton = new System.Windows.Forms.RadioButton();
            this.mixedSubstanceTextBox = new System.Windows.Forms.TextBox();
            this.inertCheckbox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.residueInfoGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.44701F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.55299F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(575, 489);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(314, 448);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(133, 38);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // concludeButton
            // 
            this.concludeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.concludeButton.Location = new System.Drawing.Point(453, 448);
            this.concludeButton.Name = "concludeButton";
            this.concludeButton.Size = new System.Drawing.Size(119, 38);
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
            this.residueNameTextBox.Size = new System.Drawing.Size(338, 20);
            this.residueNameTextBox.TabIndex = 3;
            // 
            // residueInfoGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.residueInfoGroupBox, 4);
            this.residueInfoGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.residueInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.residueInfoGroupBox.Location = new System.Drawing.Point(3, 45);
            this.residueInfoGroupBox.Name = "residueInfoGroupBox";
            this.residueInfoGroupBox.Size = new System.Drawing.Size(569, 397);
            this.residueInfoGroupBox.TabIndex = 4;
            this.residueInfoGroupBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.23077F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.48538F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.26901F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.09941F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.physicalStateComboBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.originCheckedListBox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.dangerCharacteristicsListBox, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.storageLocationTextBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.transparentGlassRadioButton, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.amberGlassRadioButton, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.plasticRadioButton, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.otherRadioButton, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.isDangerousCheckBox, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.quantityUpDown, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.measurementUnitComboBox, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.casNumberTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.inertCheckbox, 5, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.58537F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.94915F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.0226F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(563, 378);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado Físico";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // physicalStateComboBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.physicalStateComboBox, 2);
            this.physicalStateComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.physicalStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.physicalStateComboBox.FormattingEnabled = true;
            this.physicalStateComboBox.Items.AddRange(new object[] {
            "Sólido",
            "Líquido",
            "Gasoso",
            "Aquoso"});
            this.physicalStateComboBox.Location = new System.Drawing.Point(105, 7);
            this.physicalStateComboBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.physicalStateComboBox.Name = "physicalStateComboBox";
            this.physicalStateComboBox.Size = new System.Drawing.Size(203, 21);
            this.physicalStateComboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(5, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 13);
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
            this.originCheckedListBox.Location = new System.Drawing.Point(3, 106);
            this.originCheckedListBox.Name = "originCheckedListBox";
            this.originCheckedListBox.Size = new System.Drawing.Size(207, 90);
            this.originCheckedListBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(314, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Características de periculosidade";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dangerCharacteristicsListBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.dangerCharacteristicsListBox, 3);
            this.dangerCharacteristicsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dangerCharacteristicsListBox.FormattingEnabled = true;
            this.dangerCharacteristicsListBox.Items.AddRange(new object[] {
            "Inflamável",
            "Corrosivo",
            "Tóxico",
            "Reativo"});
            this.dangerCharacteristicsListBox.Location = new System.Drawing.Point(314, 106);
            this.dangerCharacteristicsListBox.Name = "dangerCharacteristicsListBox";
            this.dangerCharacteristicsListBox.Size = new System.Drawing.Size(246, 90);
            this.dangerCharacteristicsListBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 199);
            this.label5.Name = "label5";
            this.tableLayoutPanel2.SetRowSpan(this.label5, 2);
            this.label5.Size = new System.Drawing.Size(96, 125);
            this.label5.TabIndex = 10;
            this.label5.Text = "Onde o reagemte é armazenado?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // storageLocationTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.storageLocationTextBox, 5);
            this.storageLocationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storageLocationTextBox.Location = new System.Drawing.Point(105, 278);
            this.storageLocationTextBox.Multiline = true;
            this.storageLocationTextBox.Name = "storageLocationTextBox";
            this.storageLocationTextBox.Size = new System.Drawing.Size(455, 43);
            this.storageLocationTextBox.TabIndex = 11;
            // 
            // transparentGlassRadioButton
            // 
            this.transparentGlassRadioButton.AutoSize = true;
            this.transparentGlassRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transparentGlassRadioButton.Location = new System.Drawing.Point(105, 202);
            this.transparentGlassRadioButton.Name = "transparentGlassRadioButton";
            this.transparentGlassRadioButton.Size = new System.Drawing.Size(105, 70);
            this.transparentGlassRadioButton.TabIndex = 12;
            this.transparentGlassRadioButton.TabStop = true;
            this.transparentGlassRadioButton.Text = "Vidro temperado transparente";
            this.transparentGlassRadioButton.UseVisualStyleBackColor = true;
            // 
            // amberGlassRadioButton
            // 
            this.amberGlassRadioButton.AutoSize = true;
            this.amberGlassRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amberGlassRadioButton.Location = new System.Drawing.Point(216, 202);
            this.amberGlassRadioButton.Name = "amberGlassRadioButton";
            this.amberGlassRadioButton.Size = new System.Drawing.Size(92, 70);
            this.amberGlassRadioButton.TabIndex = 13;
            this.amberGlassRadioButton.TabStop = true;
            this.amberGlassRadioButton.Text = "Vidro temperado âmbar";
            this.amberGlassRadioButton.UseVisualStyleBackColor = true;
            // 
            // plasticRadioButton
            // 
            this.plasticRadioButton.AutoSize = true;
            this.plasticRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plasticRadioButton.Location = new System.Drawing.Point(314, 202);
            this.plasticRadioButton.Name = "plasticRadioButton";
            this.plasticRadioButton.Size = new System.Drawing.Size(87, 70);
            this.plasticRadioButton.TabIndex = 14;
            this.plasticRadioButton.TabStop = true;
            this.plasticRadioButton.Text = "Bombona plásitca";
            this.plasticRadioButton.UseVisualStyleBackColor = true;
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.otherRadioButton, 2);
            this.otherRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otherRadioButton.Location = new System.Drawing.Point(407, 202);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(153, 70);
            this.otherRadioButton.TabIndex = 15;
            this.otherRadioButton.TabStop = true;
            this.otherRadioButton.Text = "Outro (especificar no texto)";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            // 
            // isDangerousCheckBox
            // 
            this.isDangerousCheckBox.AutoSize = true;
            this.isDangerousCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isDangerousCheckBox.Location = new System.Drawing.Point(216, 106);
            this.isDangerousCheckBox.Name = "isDangerousCheckBox";
            this.isDangerousCheckBox.Size = new System.Drawing.Size(92, 90);
            this.isDangerousCheckBox.TabIndex = 16;
            this.isDangerousCheckBox.Text = "Perigoso?";
            this.isDangerousCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isDangerousCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(316, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.DecimalPlaces = 2;
            this.quantityUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityUpDown.Location = new System.Drawing.Point(409, 8);
            this.quantityUpDown.Margin = new System.Windows.Forms.Padding(5, 8, 5, 5);
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(44, 20);
            this.quantityUpDown.TabIndex = 3;
            // 
            // measurementUnitComboBox
            // 
            this.measurementUnitComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.measurementUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.measurementUnitComboBox.FormattingEnabled = true;
            this.measurementUnitComboBox.Items.AddRange(new object[] {
            "mL",
            "L",
            "g",
            "Kg",
            "m³"});
            this.measurementUnitComboBox.Location = new System.Drawing.Point(463, 8);
            this.measurementUnitComboBox.Margin = new System.Windows.Forms.Padding(5, 8, 5, 5);
            this.measurementUnitComboBox.Name = "measurementUnitComboBox";
            this.measurementUnitComboBox.Size = new System.Drawing.Size(95, 21);
            this.measurementUnitComboBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 33);
            this.label6.TabIndex = 17;
            this.label6.Text = "Número CAS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // casNumberTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.casNumberTextBox, 2);
            this.casNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.casNumberTextBox.Location = new System.Drawing.Point(108, 43);
            this.casNumberTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.casNumberTextBox.Name = "casNumberTextBox";
            this.casNumberTextBox.Size = new System.Drawing.Size(197, 20);
            this.casNumberTextBox.TabIndex = 18;
            // 
            // panel1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 6);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 48);
            this.panel1.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.37563F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.62437F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285F));
            this.tableLayoutPanel3.Controls.Add(this.pureRadioButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.mixedRadioButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.mixedSubstanceTextBox, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(557, 48);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // pureRadioButton
            // 
            this.pureRadioButton.AutoSize = true;
            this.pureRadioButton.Checked = true;
            this.pureRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pureRadioButton.Location = new System.Drawing.Point(3, 3);
            this.pureRadioButton.Name = "pureRadioButton";
            this.pureRadioButton.Size = new System.Drawing.Size(152, 42);
            this.pureRadioButton.TabIndex = 0;
            this.pureRadioButton.TabStop = true;
            this.pureRadioButton.Text = "Substância pura";
            this.pureRadioButton.UseVisualStyleBackColor = true;
            this.pureRadioButton.CheckedChanged += new System.EventHandler(this.pureRadioButton_CheckedChanged);
            // 
            // mixedRadioButton
            // 
            this.mixedRadioButton.AutoSize = true;
            this.mixedRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mixedRadioButton.Location = new System.Drawing.Point(161, 3);
            this.mixedRadioButton.Name = "mixedRadioButton";
            this.mixedRadioButton.Size = new System.Drawing.Size(107, 42);
            this.mixedRadioButton.TabIndex = 1;
            this.mixedRadioButton.Text = "Mistura";
            this.mixedRadioButton.UseVisualStyleBackColor = true;
            this.mixedRadioButton.CheckedChanged += new System.EventHandler(this.mixedRadioButton_CheckedChanged);
            // 
            // mixedSubstanceTextBox
            // 
            this.mixedSubstanceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mixedSubstanceTextBox.Enabled = false;
            this.mixedSubstanceTextBox.Location = new System.Drawing.Point(274, 3);
            this.mixedSubstanceTextBox.Multiline = true;
            this.mixedSubstanceTextBox.Name = "mixedSubstanceTextBox";
            this.mixedSubstanceTextBox.Size = new System.Drawing.Size(280, 42);
            this.mixedSubstanceTextBox.TabIndex = 2;
            // 
            // inertCheckbox
            // 
            this.inertCheckbox.AutoSize = true;
            this.inertCheckbox.Location = new System.Drawing.Point(461, 40);
            this.inertCheckbox.Name = "inertCheckbox";
            this.inertCheckbox.Size = new System.Drawing.Size(59, 17);
            this.inertCheckbox.TabIndex = 20;
            this.inertCheckbox.Text = "Inerte?";
            this.inertCheckbox.UseVisualStyleBackColor = true;
            // 
            // EditChemicalReactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditChemicalReactorForm";
            this.Text = "Editar reagente";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.residueInfoGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox dangerCharacteristicsListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox storageLocationTextBox;
        private System.Windows.Forms.RadioButton transparentGlassRadioButton;
        private System.Windows.Forms.RadioButton amberGlassRadioButton;
        private System.Windows.Forms.RadioButton plasticRadioButton;
        private System.Windows.Forms.RadioButton otherRadioButton;
        private System.Windows.Forms.CheckBox isDangerousCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox casNumberTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton pureRadioButton;
        private System.Windows.Forms.RadioButton mixedRadioButton;
        private System.Windows.Forms.TextBox mixedSubstanceTextBox;
        private System.Windows.Forms.CheckBox inertCheckbox;
    }
}