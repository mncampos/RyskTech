
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditChemicalReactorForm));
            this.residueNameTextBox = new System.Windows.Forms.ComboBox();
            this.residueInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.physicalStateComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.originCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dangerCharacteristicsListBox = new System.Windows.Forms.CheckedListBox();
            this.storageLocationTextBox = new System.Windows.Forms.TextBox();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.activeRadioButton = new System.Windows.Forms.RadioButton();
            this.inertRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.transparentGlassRadioButton = new System.Windows.Forms.CheckBox();
            this.amberGlassRadioButton = new System.Windows.Forms.CheckBox();
            this.plasticRadioButton = new System.Windows.Forms.CheckBox();
            this.otherRadioButton = new System.Windows.Forms.CheckBox();
            this.refMassKgLabel = new System.Windows.Forms.Label();
            this.refMassLabel = new System.Windows.Forms.Label();
            this.refMassUpdown = new System.Windows.Forms.NumericUpDown();
            this.residueNameLabel = new System.Windows.Forms.Label();
            this.concludeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.residueInfoGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refMassUpdown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // residueNameTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.residueNameTextBox, 2);
            this.residueNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.residueNameTextBox.FormattingEnabled = true;
            this.residueNameTextBox.Location = new System.Drawing.Point(145, 15);
            this.residueNameTextBox.Margin = new System.Windows.Forms.Padding(4, 15, 4, 4);
            this.residueNameTextBox.Name = "residueNameTextBox";
            this.residueNameTextBox.Size = new System.Drawing.Size(417, 24);
            this.residueNameTextBox.TabIndex = 5;
            this.residueNameTextBox.SelectedIndexChanged += new System.EventHandler(this.residueNameTextBox_SelectedIndexChanged_1);
            this.residueNameTextBox.TextChanged += new System.EventHandler(this.residueNameTextBox_TextChanged);
            // 
            // residueInfoGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.residueInfoGroupBox, 4);
            this.residueInfoGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.residueInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.residueInfoGroupBox.Location = new System.Drawing.Point(4, 56);
            this.residueInfoGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.residueInfoGroupBox.Name = "residueInfoGroupBox";
            this.residueInfoGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.residueInfoGroupBox.Size = new System.Drawing.Size(768, 494);
            this.residueInfoGroupBox.TabIndex = 4;
            this.residueInfoGroupBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.14286F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.42857F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.2485F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07989F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.physicalStateComboBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.originCheckedListBox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.dangerCharacteristicsListBox, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.storageLocationTextBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.isDangerousCheckBox, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.quantityUpDown, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.measurementUnitComboBox, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.casNumberTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.transparentGlassRadioButton, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.amberGlassRadioButton, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.plasticRadioButton, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.otherRadioButton, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.refMassKgLabel, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.refMassLabel, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.refMassUpdown, 1, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(760, 471);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
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
            this.physicalStateComboBox.Location = new System.Drawing.Point(132, 9);
            this.physicalStateComboBox.Margin = new System.Windows.Forms.Padding(4, 9, 4, 4);
            this.physicalStateComboBox.Name = "physicalStateComboBox";
            this.physicalStateComboBox.Size = new System.Drawing.Size(226, 24);
            this.physicalStateComboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uso";
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
            this.originCheckedListBox.Location = new System.Drawing.Point(4, 118);
            this.originCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.originCheckedListBox.Name = "originCheckedListBox";
            this.originCheckedListBox.Size = new System.Drawing.Size(240, 98);
            this.originCheckedListBox.TabIndex = 6;
            this.originCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.originCheckedListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(366, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 32);
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
            this.dangerCharacteristicsListBox.Location = new System.Drawing.Point(366, 118);
            this.dangerCharacteristicsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dangerCharacteristicsListBox.Name = "dangerCharacteristicsListBox";
            this.dangerCharacteristicsListBox.Size = new System.Drawing.Size(390, 98);
            this.dangerCharacteristicsListBox.TabIndex = 9;
            // 
            // storageLocationTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.storageLocationTextBox, 5);
            this.storageLocationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storageLocationTextBox.Location = new System.Drawing.Point(132, 272);
            this.storageLocationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.storageLocationTextBox.Multiline = true;
            this.storageLocationTextBox.Name = "storageLocationTextBox";
            this.storageLocationTextBox.Size = new System.Drawing.Size(624, 52);
            this.storageLocationTextBox.TabIndex = 11;
            // 
            // isDangerousCheckBox
            // 
            this.isDangerousCheckBox.AutoSize = true;
            this.isDangerousCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isDangerousCheckBox.Location = new System.Drawing.Point(252, 118);
            this.isDangerousCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isDangerousCheckBox.Name = "isDangerousCheckBox";
            this.isDangerousCheckBox.Size = new System.Drawing.Size(106, 98);
            this.isDangerousCheckBox.TabIndex = 16;
            this.isDangerousCheckBox.Text = "Perigoso?";
            this.isDangerousCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isDangerousCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(369, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.DecimalPlaces = 2;
            this.quantityUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityUpDown.Location = new System.Drawing.Point(478, 10);
            this.quantityUpDown.Margin = new System.Windows.Forms.Padding(7, 10, 7, 6);
            this.quantityUpDown.Maximum = new decimal(new int[] {
            32500,
            0,
            0,
            0});
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(58, 22);
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
            this.measurementUnitComboBox.Location = new System.Drawing.Point(550, 10);
            this.measurementUnitComboBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 6);
            this.measurementUnitComboBox.Name = "measurementUnitComboBox";
            this.measurementUnitComboBox.Size = new System.Drawing.Size(203, 24);
            this.measurementUnitComboBox.TabIndex = 4;
            this.measurementUnitComboBox.SelectedIndexChanged += new System.EventHandler(this.measurementUnitComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(4, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 42);
            this.label6.TabIndex = 17;
            this.label6.Text = "Número CAS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // casNumberTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.casNumberTextBox, 2);
            this.casNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.casNumberTextBox.Location = new System.Drawing.Point(136, 47);
            this.casNumberTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.casNumberTextBox.Name = "casNumberTextBox";
            this.casNumberTextBox.Size = new System.Drawing.Size(218, 22);
            this.casNumberTextBox.TabIndex = 18;
            // 
            // panel1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 6);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 332);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 57);
            this.panel1.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.37563F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.62437F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 424F));
            this.tableLayoutPanel3.Controls.Add(this.pureRadioButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.mixedRadioButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.mixedSubstanceTextBox, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(752, 57);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // pureRadioButton
            // 
            this.pureRadioButton.AutoSize = true;
            this.pureRadioButton.Checked = true;
            this.pureRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pureRadioButton.Location = new System.Drawing.Point(4, 4);
            this.pureRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pureRadioButton.Name = "pureRadioButton";
            this.pureRadioButton.Size = new System.Drawing.Size(183, 49);
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
            this.mixedRadioButton.Location = new System.Drawing.Point(195, 4);
            this.mixedRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mixedRadioButton.Name = "mixedRadioButton";
            this.mixedRadioButton.Size = new System.Drawing.Size(128, 49);
            this.mixedRadioButton.TabIndex = 1;
            this.mixedRadioButton.Text = "Mistura";
            this.mixedRadioButton.UseVisualStyleBackColor = true;
            this.mixedRadioButton.CheckedChanged += new System.EventHandler(this.mixedRadioButton_CheckedChanged);
            // 
            // mixedSubstanceTextBox
            // 
            this.mixedSubstanceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mixedSubstanceTextBox.Enabled = false;
            this.mixedSubstanceTextBox.Location = new System.Drawing.Point(331, 4);
            this.mixedSubstanceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mixedSubstanceTextBox.Multiline = true;
            this.mixedSubstanceTextBox.Name = "mixedSubstanceTextBox";
            this.mixedSubstanceTextBox.Size = new System.Drawing.Size(417, 49);
            this.mixedSubstanceTextBox.TabIndex = 2;
            // 
            // panel2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.activeRadioButton);
            this.panel2.Controls.Add(this.inertRadioButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(475, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 34);
            this.panel2.TabIndex = 20;
            // 
            // activeRadioButton
            // 
            this.activeRadioButton.AutoSize = true;
            this.activeRadioButton.Location = new System.Drawing.Point(139, 6);
            this.activeRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activeRadioButton.Name = "activeRadioButton";
            this.activeRadioButton.Size = new System.Drawing.Size(90, 20);
            this.activeRadioButton.TabIndex = 1;
            this.activeRadioButton.TabStop = true;
            this.activeRadioButton.Text = "Não Inerte";
            this.activeRadioButton.UseVisualStyleBackColor = true;
            this.activeRadioButton.CheckedChanged += new System.EventHandler(this.activeRadioButton_CheckedChanged);
            // 
            // inertRadioButton
            // 
            this.inertRadioButton.AutoSize = true;
            this.inertRadioButton.Checked = true;
            this.inertRadioButton.Location = new System.Drawing.Point(56, 6);
            this.inertRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inertRadioButton.Name = "inertRadioButton";
            this.inertRadioButton.Size = new System.Drawing.Size(61, 20);
            this.inertRadioButton.TabIndex = 0;
            this.inertRadioButton.TabStop = true;
            this.inertRadioButton.Text = "Inerte";
            this.inertRadioButton.UseVisualStyleBackColor = true;
            this.inertRadioButton.CheckedChanged += new System.EventHandler(this.inertRadioButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 60);
            this.label5.TabIndex = 10;
            this.label5.Text = "Local em que o recipiente é armazenado";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(4, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 48);
            this.label7.TabIndex = 21;
            this.label7.Text = "Qual o recipiente no qual o reagente está armazenado?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transparentGlassRadioButton
            // 
            this.transparentGlassRadioButton.AutoSize = true;
            this.transparentGlassRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transparentGlassRadioButton.Location = new System.Drawing.Point(132, 224);
            this.transparentGlassRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transparentGlassRadioButton.Name = "transparentGlassRadioButton";
            this.transparentGlassRadioButton.Size = new System.Drawing.Size(112, 40);
            this.transparentGlassRadioButton.TabIndex = 22;
            this.transparentGlassRadioButton.Text = "Vidro Temperado Transparente";
            this.transparentGlassRadioButton.UseVisualStyleBackColor = true;
            this.transparentGlassRadioButton.CheckedChanged += new System.EventHandler(this.transparentGlassRadioButton_CheckedChanged);
            // 
            // amberGlassRadioButton
            // 
            this.amberGlassRadioButton.AutoSize = true;
            this.amberGlassRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amberGlassRadioButton.Location = new System.Drawing.Point(252, 224);
            this.amberGlassRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amberGlassRadioButton.Name = "amberGlassRadioButton";
            this.amberGlassRadioButton.Size = new System.Drawing.Size(106, 40);
            this.amberGlassRadioButton.TabIndex = 23;
            this.amberGlassRadioButton.Text = "Vidro Temperado  Âmbar";
            this.amberGlassRadioButton.UseVisualStyleBackColor = true;
            this.amberGlassRadioButton.CheckedChanged += new System.EventHandler(this.amberGlassRadioButton_CheckedChanged);
            // 
            // plasticRadioButton
            // 
            this.plasticRadioButton.AutoSize = true;
            this.plasticRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plasticRadioButton.Location = new System.Drawing.Point(366, 224);
            this.plasticRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plasticRadioButton.Name = "plasticRadioButton";
            this.plasticRadioButton.Size = new System.Drawing.Size(101, 40);
            this.plasticRadioButton.TabIndex = 24;
            this.plasticRadioButton.Text = "Bombona plástica";
            this.plasticRadioButton.UseVisualStyleBackColor = true;
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.otherRadioButton, 2);
            this.otherRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otherRadioButton.Location = new System.Drawing.Point(475, 224);
            this.otherRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(281, 40);
            this.otherRadioButton.TabIndex = 25;
            this.otherRadioButton.Text = "Outro";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            this.otherRadioButton.CheckedChanged += new System.EventHandler(this.otherRadioButton_CheckedChanged);
            // 
            // refMassKgLabel
            // 
            this.refMassKgLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.refMassKgLabel.AutoSize = true;
            this.refMassKgLabel.Location = new System.Drawing.Point(252, 424);
            this.refMassKgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.refMassKgLabel.Name = "refMassKgLabel";
            this.refMassKgLabel.Size = new System.Drawing.Size(23, 16);
            this.refMassKgLabel.TabIndex = 28;
            this.refMassKgLabel.Text = "Kg";
            // 
            // refMassLabel
            // 
            this.refMassLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refMassLabel.AutoSize = true;
            this.refMassLabel.Location = new System.Drawing.Point(27, 416);
            this.refMassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.refMassLabel.Name = "refMassLabel";
            this.refMassLabel.Size = new System.Drawing.Size(73, 32);
            this.refMassLabel.TabIndex = 26;
            this.refMassLabel.Text = "Massa de Referência";
            // 
            // refMassUpdown
            // 
            this.refMassUpdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refMassUpdown.Location = new System.Drawing.Point(132, 421);
            this.refMassUpdown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refMassUpdown.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.refMassUpdown.Name = "refMassUpdown";
            this.refMassUpdown.Size = new System.Drawing.Size(111, 22);
            this.refMassUpdown.TabIndex = 29;
            // 
            // residueNameLabel
            // 
            this.residueNameLabel.AutoSize = true;
            this.residueNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.residueNameLabel.Location = new System.Drawing.Point(4, 0);
            this.residueNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.residueNameLabel.Name = "residueNameLabel";
            this.residueNameLabel.Size = new System.Drawing.Size(133, 52);
            this.residueNameLabel.TabIndex = 2;
            this.residueNameLabel.Text = "Nome (se for o caso, especifique a concentração)";
            this.residueNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // concludeButton
            // 
            this.concludeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.concludeButton.Location = new System.Drawing.Point(570, 558);
            this.concludeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.concludeButton.Name = "concludeButton";
            this.concludeButton.Size = new System.Drawing.Size(202, 47);
            this.concludeButton.TabIndex = 1;
            this.concludeButton.Text = "Concluir";
            this.concludeButton.UseVisualStyleBackColor = true;
            this.concludeButton.Click += new System.EventHandler(this.concludeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(398, 558);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(164, 47);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.44701F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.55299F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.concludeButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.residueNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.residueInfoGroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.residueNameTextBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.22801F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.771987F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 609);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // EditChemicalReactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 609);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditChemicalReactorForm";
            this.Text = "Editar reagente";
            this.residueInfoGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refMassUpdown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox residueNameTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button concludeButton;
        private System.Windows.Forms.Label residueNameLabel;
        private System.Windows.Forms.GroupBox residueInfoGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox physicalStateComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox originCheckedListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox dangerCharacteristicsListBox;
        private System.Windows.Forms.TextBox storageLocationTextBox;
        private System.Windows.Forms.CheckBox isDangerousCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
        private System.Windows.Forms.ComboBox measurementUnitComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox casNumberTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton activeRadioButton;
        private System.Windows.Forms.RadioButton inertRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox transparentGlassRadioButton;
        private System.Windows.Forms.CheckBox amberGlassRadioButton;
        private System.Windows.Forms.CheckBox plasticRadioButton;
        private System.Windows.Forms.CheckBox otherRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton pureRadioButton;
        private System.Windows.Forms.RadioButton mixedRadioButton;
        private System.Windows.Forms.TextBox mixedSubstanceTextBox;
        private System.Windows.Forms.Label refMassKgLabel;
        private System.Windows.Forms.Label refMassLabel;
        private System.Windows.Forms.NumericUpDown refMassUpdown;
    }
}