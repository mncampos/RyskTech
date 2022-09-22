
namespace RyskTech.Forms.Lab.Controls
{
    partial class ChemicalAgentControl
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.hasFISPQRadioButton = new System.Windows.Forms.RadioButton();
            this.noFISPQRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.nbrLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.residuosCheckbox = new System.Windows.Forms.CheckBox();
            this.editResidueButton = new System.Windows.Forms.Button();
            this.editReactorButton = new System.Windows.Forms.Button();
            this.removeReactorButton = new System.Windows.Forms.Button();
            this.addReactorButton = new System.Windows.Forms.Button();
            this.removeResidueButton = new System.Windows.Forms.Button();
            this.addResidueButton = new System.Windows.Forms.Button();
            this.chemicalReactorData = new System.Windows.Forms.DataGridView();
            this.chemicalResidueData = new System.Windows.Forms.DataGridView();
            this.chemicalResidueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResiduePhysicalState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResidueOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResidueQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResidueDangers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dangerCharacteristics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inertState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResidueStorageLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResidueContainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DangerFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casNumberTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalReactorData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalResidueData)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.textBox2);
            this.mainPanel.Controls.Add(this.tableLayoutPanel4);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.linkLabel1);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.nbrLinkLabel);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(795, 575);
            this.mainPanel.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 471);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(490, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Qual o destino dos resíduos químicos? (especificar internamente e externamente)";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(28, 491);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(724, 68);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.hasFISPQRadioButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.noFISPQRadioButton, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(24, 438);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(143, 27);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // hasFISPQRadioButton
            // 
            this.hasFISPQRadioButton.AutoSize = true;
            this.hasFISPQRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hasFISPQRadioButton.Location = new System.Drawing.Point(75, 4);
            this.hasFISPQRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hasFISPQRadioButton.Name = "hasFISPQRadioButton";
            this.hasFISPQRadioButton.Size = new System.Drawing.Size(64, 19);
            this.hasFISPQRadioButton.TabIndex = 1;
            this.hasFISPQRadioButton.Text = "Sim:";
            this.hasFISPQRadioButton.UseVisualStyleBackColor = true;
            this.hasFISPQRadioButton.CheckedChanged += new System.EventHandler(this.hasFISPQRadioButton_CheckedChanged);
            // 
            // noFISPQRadioButton
            // 
            this.noFISPQRadioButton.AutoSize = true;
            this.noFISPQRadioButton.Checked = true;
            this.noFISPQRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noFISPQRadioButton.Location = new System.Drawing.Point(4, 4);
            this.noFISPQRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noFISPQRadioButton.Name = "noFISPQRadioButton";
            this.noFISPQRadioButton.Size = new System.Drawing.Size(63, 19);
            this.noFISPQRadioButton.TabIndex = 0;
            this.noFISPQRadioButton.TabStop = true;
            this.noFISPQRadioButton.Text = "Não";
            this.noFISPQRadioButton.UseVisualStyleBackColor = true;
            this.noFISPQRadioButton.CheckedChanged += new System.EventHandler(this.noFISPQRadioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.yesRadioButton);
            this.panel1.Controls.Add(this.noRadioButton);
            this.panel1.Location = new System.Drawing.Point(28, 374);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 32);
            this.panel1.TabIndex = 11;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(69, 7);
            this.yesRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(51, 20);
            this.yesRadioButton.TabIndex = 3;
            this.yesRadioButton.Text = "Sim";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            this.yesRadioButton.CheckedChanged += new System.EventHandler(this.yesRadioButton_CheckedChanged);
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Checked = true;
            this.noRadioButton.Location = new System.Drawing.Point(1, 7);
            this.noRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(54, 20);
            this.noRadioButton.TabIndex = 2;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "Não";
            this.noRadioButton.UseVisualStyleBackColor = true;
            this.noRadioButton.CheckedChanged += new System.EventHandler(this.noRadioButton_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(499, 410);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(127, 16);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "NBR-14725-4:2014 ?";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 410);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(456, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Os reagentes possuem rótulo com base na FISPQ, em concordância com a";
            // 
            // nbrLinkLabel
            // 
            this.nbrLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nbrLinkLabel.AutoSize = true;
            this.nbrLinkLabel.Location = new System.Drawing.Point(419, 354);
            this.nbrLinkLabel.Margin = new System.Windows.Forms.Padding(1);
            this.nbrLinkLabel.Name = "nbrLinkLabel";
            this.nbrLinkLabel.Size = new System.Drawing.Size(127, 16);
            this.nbrLinkLabel.TabIndex = 4;
            this.nbrLinkLabel.TabStop = true;
            this.nbrLinkLabel.Text = "NBR-14725-3:2017 ?";
            this.nbrLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbrLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nbrLinkLabel_LinkClicked);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 354);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Os recipientes de reagentes químicos estão de acordo com a ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.residuosCheckbox);
            this.groupBox1.Controls.Add(this.editResidueButton);
            this.groupBox1.Controls.Add(this.editReactorButton);
            this.groupBox1.Controls.Add(this.removeReactorButton);
            this.groupBox1.Controls.Add(this.addReactorButton);
            this.groupBox1.Controls.Add(this.removeResidueButton);
            this.groupBox1.Controls.Add(this.addResidueButton);
            this.groupBox1.Controls.Add(this.chemicalReactorData);
            this.groupBox1.Controls.Add(this.chemicalResidueData);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(763, 342);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agentes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            this.groupBox1.Resize += new System.EventHandler(this.resized);
            // 
            // residuosCheckbox
            // 
            this.residuosCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.residuosCheckbox.AutoSize = true;
            this.residuosCheckbox.Location = new System.Drawing.Point(356, 313);
            this.residuosCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.residuosCheckbox.Name = "residuosCheckbox";
            this.residuosCheckbox.Size = new System.Drawing.Size(94, 20);
            this.residuosCheckbox.TabIndex = 9;
            this.residuosCheckbox.Text = "Resíduos?";
            this.residuosCheckbox.UseVisualStyleBackColor = true;
            this.residuosCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // editResidueButton
            // 
            this.editResidueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editResidueButton.Location = new System.Drawing.Point(573, 304);
            this.editResidueButton.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.editResidueButton.Name = "editResidueButton";
            this.editResidueButton.Size = new System.Drawing.Size(91, 33);
            this.editResidueButton.TabIndex = 8;
            this.editResidueButton.Text = "Editar";
            this.editResidueButton.UseVisualStyleBackColor = true;
            this.editResidueButton.Visible = false;
            this.editResidueButton.Click += new System.EventHandler(this.editResidueButton_Click);
            // 
            // editReactorButton
            // 
            this.editReactorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editReactorButton.Location = new System.Drawing.Point(124, 303);
            this.editReactorButton.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.editReactorButton.Name = "editReactorButton";
            this.editReactorButton.Size = new System.Drawing.Size(91, 33);
            this.editReactorButton.TabIndex = 7;
            this.editReactorButton.Text = "Editar";
            this.editReactorButton.UseVisualStyleBackColor = true;
            this.editReactorButton.Click += new System.EventHandler(this.editReactorButton_Click);
            // 
            // removeReactorButton
            // 
            this.removeReactorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeReactorButton.Location = new System.Drawing.Point(236, 303);
            this.removeReactorButton.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.removeReactorButton.Name = "removeReactorButton";
            this.removeReactorButton.Size = new System.Drawing.Size(91, 33);
            this.removeReactorButton.TabIndex = 4;
            this.removeReactorButton.Text = "Remover";
            this.removeReactorButton.UseVisualStyleBackColor = true;
            this.removeReactorButton.Click += new System.EventHandler(this.removeReactorButton_Click);
            // 
            // addReactorButton
            // 
            this.addReactorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addReactorButton.Location = new System.Drawing.Point(12, 303);
            this.addReactorButton.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.addReactorButton.Name = "addReactorButton";
            this.addReactorButton.Size = new System.Drawing.Size(91, 33);
            this.addReactorButton.TabIndex = 2;
            this.addReactorButton.Text = "Novo";
            this.addReactorButton.UseVisualStyleBackColor = true;
            this.addReactorButton.Click += new System.EventHandler(this.addReactorButton_Click);
            // 
            // removeResidueButton
            // 
            this.removeResidueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeResidueButton.Location = new System.Drawing.Point(664, 303);
            this.removeResidueButton.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.removeResidueButton.Name = "removeResidueButton";
            this.removeResidueButton.Size = new System.Drawing.Size(91, 33);
            this.removeResidueButton.TabIndex = 6;
            this.removeResidueButton.Text = "Remover";
            this.removeResidueButton.UseVisualStyleBackColor = true;
            this.removeResidueButton.Visible = false;
            this.removeResidueButton.Click += new System.EventHandler(this.removeResidueButton_Click);
            // 
            // addResidueButton
            // 
            this.addResidueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addResidueButton.Location = new System.Drawing.Point(475, 303);
            this.addResidueButton.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.addResidueButton.Name = "addResidueButton";
            this.addResidueButton.Size = new System.Drawing.Size(91, 33);
            this.addResidueButton.TabIndex = 5;
            this.addResidueButton.Text = "Novo";
            this.addResidueButton.UseVisualStyleBackColor = true;
            this.addResidueButton.Visible = false;
            this.addResidueButton.Click += new System.EventHandler(this.addResidueButton_Click);
            // 
            // chemicalReactorData
            // 
            this.chemicalReactorData.AllowUserToAddRows = false;
            this.chemicalReactorData.AllowUserToDeleteRows = false;
            this.chemicalReactorData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chemicalReactorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chemicalReactorData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.casNumberTab,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.DangerFactor});
            this.chemicalReactorData.Location = new System.Drawing.Point(12, 92);
            this.chemicalReactorData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chemicalReactorData.MinimumSize = new System.Drawing.Size(376, 0);
            this.chemicalReactorData.Name = "chemicalReactorData";
            this.chemicalReactorData.ReadOnly = true;
            this.chemicalReactorData.RowHeadersWidth = 51;
            this.chemicalReactorData.ShowCellToolTips = false;
            this.chemicalReactorData.Size = new System.Drawing.Size(743, 198);
            this.chemicalReactorData.TabIndex = 4;
            this.chemicalReactorData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chemicalReactorData_CellContentClick);
            // 
            // chemicalResidueData
            // 
            this.chemicalResidueData.AllowUserToAddRows = false;
            this.chemicalResidueData.AllowUserToDeleteRows = false;
            this.chemicalResidueData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chemicalResidueData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chemicalResidueData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chemicalResidueName,
            this.chemicalResiduePhysicalState,
            this.chemicalResidueOrigin,
            this.chemicalResidueQuantity,
            this.measurement,
            this.chemicalResidueDangers,
            this.dangerCharacteristics,
            this.inertState,
            this.chemicalResidueStorageLocation,
            this.chemicalResidueContainer});
            this.chemicalResidueData.Location = new System.Drawing.Point(396, 92);
            this.chemicalResidueData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chemicalResidueData.Name = "chemicalResidueData";
            this.chemicalResidueData.ReadOnly = true;
            this.chemicalResidueData.RowHeadersWidth = 51;
            this.chemicalResidueData.Size = new System.Drawing.Size(359, 198);
            this.chemicalResidueData.TabIndex = 3;
            this.chemicalResidueData.Visible = false;
            // 
            // chemicalResidueName
            // 
            this.chemicalResidueName.HeaderText = "Nome";
            this.chemicalResidueName.MinimumWidth = 6;
            this.chemicalResidueName.Name = "chemicalResidueName";
            this.chemicalResidueName.ReadOnly = true;
            this.chemicalResidueName.Width = 125;
            // 
            // chemicalResiduePhysicalState
            // 
            this.chemicalResiduePhysicalState.HeaderText = "Estado Físico";
            this.chemicalResiduePhysicalState.MinimumWidth = 6;
            this.chemicalResiduePhysicalState.Name = "chemicalResiduePhysicalState";
            this.chemicalResiduePhysicalState.ReadOnly = true;
            this.chemicalResiduePhysicalState.Width = 125;
            // 
            // chemicalResidueOrigin
            // 
            this.chemicalResidueOrigin.HeaderText = "Origem";
            this.chemicalResidueOrigin.MinimumWidth = 6;
            this.chemicalResidueOrigin.Name = "chemicalResidueOrigin";
            this.chemicalResidueOrigin.ReadOnly = true;
            this.chemicalResidueOrigin.Width = 125;
            // 
            // chemicalResidueQuantity
            // 
            this.chemicalResidueQuantity.HeaderText = "Quantidade";
            this.chemicalResidueQuantity.MinimumWidth = 6;
            this.chemicalResidueQuantity.Name = "chemicalResidueQuantity";
            this.chemicalResidueQuantity.ReadOnly = true;
            this.chemicalResidueQuantity.Width = 125;
            // 
            // measurement
            // 
            this.measurement.HeaderText = "Unidade de Medida";
            this.measurement.MinimumWidth = 6;
            this.measurement.Name = "measurement";
            this.measurement.ReadOnly = true;
            this.measurement.Width = 125;
            // 
            // chemicalResidueDangers
            // 
            this.chemicalResidueDangers.HeaderText = "Perigoso?";
            this.chemicalResidueDangers.MinimumWidth = 6;
            this.chemicalResidueDangers.Name = "chemicalResidueDangers";
            this.chemicalResidueDangers.ReadOnly = true;
            this.chemicalResidueDangers.Width = 125;
            // 
            // dangerCharacteristics
            // 
            this.dangerCharacteristics.HeaderText = "Características de periculosidade";
            this.dangerCharacteristics.MinimumWidth = 6;
            this.dangerCharacteristics.Name = "dangerCharacteristics";
            this.dangerCharacteristics.ReadOnly = true;
            this.dangerCharacteristics.Width = 125;
            // 
            // inertState
            // 
            this.inertState.HeaderText = "Inerte?";
            this.inertState.MinimumWidth = 6;
            this.inertState.Name = "inertState";
            this.inertState.ReadOnly = true;
            this.inertState.Width = 125;
            // 
            // chemicalResidueStorageLocation
            // 
            this.chemicalResidueStorageLocation.HeaderText = "Armazenamento";
            this.chemicalResidueStorageLocation.MinimumWidth = 6;
            this.chemicalResidueStorageLocation.Name = "chemicalResidueStorageLocation";
            this.chemicalResidueStorageLocation.ReadOnly = true;
            this.chemicalResidueStorageLocation.Width = 125;
            // 
            // chemicalResidueContainer
            // 
            this.chemicalResidueContainer.HeaderText = "Recipiente";
            this.chemicalResidueContainer.MinimumWidth = 6;
            this.chemicalResidueContainer.Name = "chemicalResidueContainer";
            this.chemicalResidueContainer.ReadOnly = true;
            this.chemicalResidueContainer.Width = 125;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resíduos";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reagentes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indique nas tabelas abaixo os reagentes e resíduos químicos que são manipulados e" +
    "/ou gerados no local.";
            // 
            // DangerFactor
            // 
            this.DangerFactor.HeaderText = "Fator de Perigo";
            this.DangerFactor.MinimumWidth = 6;
            this.DangerFactor.Name = "DangerFactor";
            this.DangerFactor.ReadOnly = true;
            this.DangerFactor.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Recipiente";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Armazenamento";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Inerte?";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Características de periculosidade";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // casNumberTab
            // 
            this.casNumberTab.HeaderText = "Número CAS";
            this.casNumberTab.MinimumWidth = 6;
            this.casNumberTab.Name = "casNumberTab";
            this.casNumberTab.ReadOnly = true;
            this.casNumberTab.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Mistura";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Unidade de Medida";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Origem";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Estado Físico";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // ChemicalAgentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChemicalAgentControl";
            this.Size = new System.Drawing.Size(795, 575);
            this.Load += new System.EventHandler(this.ChemicalAgentControlBetter_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalReactorData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalResidueData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView chemicalResidueData;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResidueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResiduePhysicalState;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResidueOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResidueQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResidueDangers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dangerCharacteristics;
        private System.Windows.Forms.DataGridViewTextBoxColumn inertState;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResidueStorageLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResidueContainer;
        private System.Windows.Forms.DataGridView chemicalReactorData;
        private System.Windows.Forms.Button addResidueButton;
        private System.Windows.Forms.Button removeResidueButton;
        private System.Windows.Forms.Button addReactorButton;
        private System.Windows.Forms.Button removeReactorButton;
        private System.Windows.Forms.LinkLabel nbrLinkLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton hasFISPQRadioButton;
        private System.Windows.Forms.RadioButton noFISPQRadioButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button editReactorButton;
        private System.Windows.Forms.Button editResidueButton;
        private System.Windows.Forms.CheckBox residuosCheckbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn casNumberTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn DangerFactor;
    }
}
