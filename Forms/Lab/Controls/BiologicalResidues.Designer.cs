
namespace RyskTech.Forms.Lab.Controls
{
    partial class BiologicalResidues
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
            this.biologicalAgentsGroupBox = new System.Windows.Forms.GroupBox();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bioAgentData = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riskClass = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generalInfoLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.processedBiologicalSamples = new System.Windows.Forms.GroupBox();
            this.processedSamplesLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.processedSamplesLabel = new System.Windows.Forms.Label();
            this.newProcessedSampleTextBox = new System.Windows.Forms.TextBox();
            this.addSampleButton = new System.Windows.Forms.Button();
            this.processedSamplesListBox = new System.Windows.Forms.ListBox();
            this.registryAndCertificationGroupBox = new System.Windows.Forms.GroupBox();
            this.registryAndCertificationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ogmYesNoPanel = new System.Windows.Forms.Panel();
            this.ogmNoRadioButton = new System.Windows.Forms.RadioButton();
            this.ogmYesRadioButton = new System.Windows.Forms.RadioButton();
            this.sisgenRegistryNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.certificateYesNoPanel = new System.Windows.Forms.Panel();
            this.certificateNoRadioButton = new System.Windows.Forms.RadioButton();
            this.certificateYesRadioButton = new System.Windows.Forms.RadioButton();
            this.addRemoveButtonsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.removeBioResidueButton = new System.Windows.Forms.Button();
            this.addBiologicalResidueButton = new System.Windows.Forms.Button();
            this.biologicalAgentsGroupBox.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bioAgentData)).BeginInit();
            this.generalInfoLayoutPanel.SuspendLayout();
            this.processedBiologicalSamples.SuspendLayout();
            this.processedSamplesLayoutPanel.SuspendLayout();
            this.registryAndCertificationGroupBox.SuspendLayout();
            this.registryAndCertificationTableLayoutPanel.SuspendLayout();
            this.ogmYesNoPanel.SuspendLayout();
            this.certificateYesNoPanel.SuspendLayout();
            this.addRemoveButtonsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // biologicalAgentsGroupBox
            // 
            this.biologicalAgentsGroupBox.Controls.Add(this.mainTableLayoutPanel);
            this.biologicalAgentsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.biologicalAgentsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.biologicalAgentsGroupBox.Name = "biologicalAgentsGroupBox";
            this.biologicalAgentsGroupBox.Size = new System.Drawing.Size(820, 429);
            this.biologicalAgentsGroupBox.TabIndex = 0;
            this.biologicalAgentsGroupBox.TabStop = false;
            this.biologicalAgentsGroupBox.Text = "Agentes Biológicos";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.99754F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.00246F));
            this.mainTableLayoutPanel.Controls.Add(this.bioAgentData, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.generalInfoLayoutPanel, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.addRemoveButtonsLayoutPanel, 0, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.04878F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.95122F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(814, 410);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // bioAgentData
            // 
            this.bioAgentData.AllowUserToAddRows = false;
            this.bioAgentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bioAgentData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.riskClass,
            this.usage});
            this.bioAgentData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bioAgentData.Location = new System.Drawing.Point(3, 3);
            this.bioAgentData.Name = "bioAgentData";
            this.bioAgentData.Size = new System.Drawing.Size(343, 355);
            this.bioAgentData.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Nomenclatura Binomial";
            this.name.Name = "name";
            // 
            // riskClass
            // 
            this.riskClass.HeaderText = "Classe de Risco";
            this.riskClass.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.riskClass.Name = "riskClass";
            // 
            // usage
            // 
            this.usage.HeaderText = "Uso do Material";
            this.usage.Name = "usage";
            this.usage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.usage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // generalInfoLayoutPanel
            // 
            this.generalInfoLayoutPanel.ColumnCount = 2;
            this.generalInfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalInfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalInfoLayoutPanel.Controls.Add(this.processedBiologicalSamples, 0, 0);
            this.generalInfoLayoutPanel.Controls.Add(this.registryAndCertificationGroupBox, 0, 1);
            this.generalInfoLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalInfoLayoutPanel.Location = new System.Drawing.Point(352, 3);
            this.generalInfoLayoutPanel.Name = "generalInfoLayoutPanel";
            this.generalInfoLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.SetRowSpan(this.generalInfoLayoutPanel, 2);
            this.generalInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.41584F));
            this.generalInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.58416F));
            this.generalInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.generalInfoLayoutPanel.Size = new System.Drawing.Size(459, 404);
            this.generalInfoLayoutPanel.TabIndex = 1;
            // 
            // processedBiologicalSamples
            // 
            this.generalInfoLayoutPanel.SetColumnSpan(this.processedBiologicalSamples, 2);
            this.processedBiologicalSamples.Controls.Add(this.processedSamplesLayoutPanel);
            this.processedBiologicalSamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processedBiologicalSamples.Location = new System.Drawing.Point(3, 3);
            this.processedBiologicalSamples.Name = "processedBiologicalSamples";
            this.processedBiologicalSamples.Padding = new System.Windows.Forms.Padding(5);
            this.processedBiologicalSamples.Size = new System.Drawing.Size(453, 229);
            this.processedBiologicalSamples.TabIndex = 0;
            this.processedBiologicalSamples.TabStop = false;
            this.processedBiologicalSamples.Text = "Amostras processadas";
            // 
            // processedSamplesLayoutPanel
            // 
            this.processedSamplesLayoutPanel.ColumnCount = 3;
            this.processedSamplesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.31818F));
            this.processedSamplesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.68182F));
            this.processedSamplesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.processedSamplesLayoutPanel.Controls.Add(this.processedSamplesLabel, 0, 0);
            this.processedSamplesLayoutPanel.Controls.Add(this.newProcessedSampleTextBox, 2, 2);
            this.processedSamplesLayoutPanel.Controls.Add(this.addSampleButton, 1, 2);
            this.processedSamplesLayoutPanel.Controls.Add(this.processedSamplesListBox, 0, 1);
            this.processedSamplesLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processedSamplesLayoutPanel.Location = new System.Drawing.Point(5, 18);
            this.processedSamplesLayoutPanel.Name = "processedSamplesLayoutPanel";
            this.processedSamplesLayoutPanel.RowCount = 3;
            this.processedSamplesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.26374F));
            this.processedSamplesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.73626F));
            this.processedSamplesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.processedSamplesLayoutPanel.Size = new System.Drawing.Size(443, 206);
            this.processedSamplesLayoutPanel.TabIndex = 0;
            // 
            // processedSamplesLabel
            // 
            this.processedSamplesLabel.AutoSize = true;
            this.processedSamplesLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.processedSamplesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processedSamplesLayoutPanel.SetColumnSpan(this.processedSamplesLabel, 3);
            this.processedSamplesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processedSamplesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processedSamplesLabel.Location = new System.Drawing.Point(3, 0);
            this.processedSamplesLabel.Name = "processedSamplesLabel";
            this.processedSamplesLabel.Size = new System.Drawing.Size(437, 60);
            this.processedSamplesLabel.TabIndex = 0;
            this.processedSamplesLabel.Text = "Que tipos de amostra biológica são processados pelo seu laboratório?\r\n(Sangue, ur" +
    "ina, tecidos, fezes, soro, etc.)";
            this.processedSamplesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newProcessedSampleTextBox
            // 
            this.newProcessedSampleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newProcessedSampleTextBox.Location = new System.Drawing.Point(253, 175);
            this.newProcessedSampleTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.newProcessedSampleTextBox.Name = "newProcessedSampleTextBox";
            this.newProcessedSampleTextBox.Size = new System.Drawing.Size(187, 20);
            this.newProcessedSampleTextBox.TabIndex = 2;
            // 
            // addSampleButton
            // 
            this.addSampleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSampleButton.Location = new System.Drawing.Point(181, 175);
            this.addSampleButton.Margin = new System.Windows.Forms.Padding(8);
            this.addSampleButton.Name = "addSampleButton";
            this.addSampleButton.Size = new System.Drawing.Size(61, 23);
            this.addSampleButton.TabIndex = 3;
            this.addSampleButton.Text = "Adicionar";
            this.addSampleButton.UseVisualStyleBackColor = true;
            this.addSampleButton.Click += new System.EventHandler(this.addSampleButton_Click);
            // 
            // processedSamplesListBox
            // 
            this.processedSamplesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processedSamplesListBox.FormattingEnabled = true;
            this.processedSamplesListBox.Location = new System.Drawing.Point(3, 63);
            this.processedSamplesListBox.Name = "processedSamplesListBox";
            this.processedSamplesLayoutPanel.SetRowSpan(this.processedSamplesListBox, 2);
            this.processedSamplesListBox.Size = new System.Drawing.Size(167, 140);
            this.processedSamplesListBox.TabIndex = 4;
            // 
            // registryAndCertificationGroupBox
            // 
            this.generalInfoLayoutPanel.SetColumnSpan(this.registryAndCertificationGroupBox, 2);
            this.registryAndCertificationGroupBox.Controls.Add(this.registryAndCertificationTableLayoutPanel);
            this.registryAndCertificationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registryAndCertificationGroupBox.Location = new System.Drawing.Point(3, 238);
            this.registryAndCertificationGroupBox.Name = "registryAndCertificationGroupBox";
            this.registryAndCertificationGroupBox.Size = new System.Drawing.Size(453, 163);
            this.registryAndCertificationGroupBox.TabIndex = 1;
            this.registryAndCertificationGroupBox.TabStop = false;
            this.registryAndCertificationGroupBox.Text = "Cadastro e Certificação";
            // 
            // registryAndCertificationTableLayoutPanel
            // 
            this.registryAndCertificationTableLayoutPanel.ColumnCount = 3;
            this.registryAndCertificationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.53468F));
            this.registryAndCertificationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.07623F));
            this.registryAndCertificationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.47085F));
            this.registryAndCertificationTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.registryAndCertificationTableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.registryAndCertificationTableLayoutPanel.Controls.Add(this.ogmYesNoPanel, 2, 0);
            this.registryAndCertificationTableLayoutPanel.Controls.Add(this.sisgenRegistryNumberTextBox, 1, 1);
            this.registryAndCertificationTableLayoutPanel.Controls.Add(this.label3, 0, 2);
            this.registryAndCertificationTableLayoutPanel.Controls.Add(this.certificateYesNoPanel, 2, 2);
            this.registryAndCertificationTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registryAndCertificationTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.registryAndCertificationTableLayoutPanel.Name = "registryAndCertificationTableLayoutPanel";
            this.registryAndCertificationTableLayoutPanel.RowCount = 3;
            this.registryAndCertificationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.80556F));
            this.registryAndCertificationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.38889F));
            this.registryAndCertificationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.80556F));
            this.registryAndCertificationTableLayoutPanel.Size = new System.Drawing.Size(447, 144);
            this.registryAndCertificationTableLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registryAndCertificationTableLayoutPanel.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seu laboratório conta com organismos genéticamente modificados (OGMs)?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(5, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Qual o seu número de cadastro SISGEN?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ogmYesNoPanel
            // 
            this.ogmYesNoPanel.Controls.Add(this.ogmNoRadioButton);
            this.ogmYesNoPanel.Controls.Add(this.ogmYesRadioButton);
            this.ogmYesNoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ogmYesNoPanel.Location = new System.Drawing.Point(380, 3);
            this.ogmYesNoPanel.Name = "ogmYesNoPanel";
            this.ogmYesNoPanel.Size = new System.Drawing.Size(64, 46);
            this.ogmYesNoPanel.TabIndex = 1;
            // 
            // ogmNoRadioButton
            // 
            this.ogmNoRadioButton.AutoSize = true;
            this.ogmNoRadioButton.Location = new System.Drawing.Point(12, 26);
            this.ogmNoRadioButton.Name = "ogmNoRadioButton";
            this.ogmNoRadioButton.Size = new System.Drawing.Size(45, 17);
            this.ogmNoRadioButton.TabIndex = 1;
            this.ogmNoRadioButton.TabStop = true;
            this.ogmNoRadioButton.Text = "Não";
            this.ogmNoRadioButton.UseVisualStyleBackColor = true;
            this.ogmNoRadioButton.CheckedChanged += new System.EventHandler(this.ogmNoRadioButton_CheckedChanged);
            // 
            // ogmYesRadioButton
            // 
            this.ogmYesRadioButton.AutoSize = true;
            this.ogmYesRadioButton.Location = new System.Drawing.Point(12, 5);
            this.ogmYesRadioButton.Name = "ogmYesRadioButton";
            this.ogmYesRadioButton.Size = new System.Drawing.Size(42, 17);
            this.ogmYesRadioButton.TabIndex = 0;
            this.ogmYesRadioButton.TabStop = true;
            this.ogmYesRadioButton.Text = "Sim";
            this.ogmYesRadioButton.UseVisualStyleBackColor = true;
            this.ogmYesRadioButton.CheckedChanged += new System.EventHandler(this.ogmYesRadioButton_CheckedChanged);
            // 
            // sisgenRegistryNumberTextBox
            // 
            this.registryAndCertificationTableLayoutPanel.SetColumnSpan(this.sisgenRegistryNumberTextBox, 2);
            this.sisgenRegistryNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sisgenRegistryNumberTextBox.Location = new System.Drawing.Point(286, 62);
            this.sisgenRegistryNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.sisgenRegistryNumberTextBox.Name = "sisgenRegistryNumberTextBox";
            this.sisgenRegistryNumberTextBox.Size = new System.Drawing.Size(158, 20);
            this.sisgenRegistryNumberTextBox.TabIndex = 3;
            this.sisgenRegistryNumberTextBox.TextChanged += new System.EventHandler(this.sisgenRegistryNumberTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registryAndCertificationTableLayoutPanel.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "O laboratório apresenta certificado de qualidade em biosegurança?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // certificateYesNoPanel
            // 
            this.certificateYesNoPanel.Controls.Add(this.certificateNoRadioButton);
            this.certificateYesNoPanel.Controls.Add(this.certificateYesRadioButton);
            this.certificateYesNoPanel.Location = new System.Drawing.Point(380, 92);
            this.certificateYesNoPanel.Name = "certificateYesNoPanel";
            this.certificateYesNoPanel.Size = new System.Drawing.Size(64, 47);
            this.certificateYesNoPanel.TabIndex = 5;
            // 
            // certificateNoRadioButton
            // 
            this.certificateNoRadioButton.AutoSize = true;
            this.certificateNoRadioButton.Location = new System.Drawing.Point(12, 24);
            this.certificateNoRadioButton.Name = "certificateNoRadioButton";
            this.certificateNoRadioButton.Size = new System.Drawing.Size(45, 17);
            this.certificateNoRadioButton.TabIndex = 1;
            this.certificateNoRadioButton.TabStop = true;
            this.certificateNoRadioButton.Text = "Não";
            this.certificateNoRadioButton.UseVisualStyleBackColor = true;
            this.certificateNoRadioButton.CheckedChanged += new System.EventHandler(this.certificateNoRadioButton_CheckedChanged);
            // 
            // certificateYesRadioButton
            // 
            this.certificateYesRadioButton.AutoSize = true;
            this.certificateYesRadioButton.Location = new System.Drawing.Point(12, 3);
            this.certificateYesRadioButton.Name = "certificateYesRadioButton";
            this.certificateYesRadioButton.Size = new System.Drawing.Size(42, 17);
            this.certificateYesRadioButton.TabIndex = 0;
            this.certificateYesRadioButton.TabStop = true;
            this.certificateYesRadioButton.Text = "Sim";
            this.certificateYesRadioButton.UseVisualStyleBackColor = true;
            this.certificateYesRadioButton.CheckedChanged += new System.EventHandler(this.certificateYesRadioButton_CheckedChanged);
            // 
            // addRemoveButtonsLayoutPanel
            // 
            this.addRemoveButtonsLayoutPanel.ColumnCount = 3;
            this.addRemoveButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.addRemoveButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.addRemoveButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.addRemoveButtonsLayoutPanel.Controls.Add(this.removeBioResidueButton, 0, 0);
            this.addRemoveButtonsLayoutPanel.Controls.Add(this.addBiologicalResidueButton, 0, 0);
            this.addRemoveButtonsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addRemoveButtonsLayoutPanel.Location = new System.Drawing.Point(3, 364);
            this.addRemoveButtonsLayoutPanel.Name = "addRemoveButtonsLayoutPanel";
            this.addRemoveButtonsLayoutPanel.RowCount = 1;
            this.addRemoveButtonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addRemoveButtonsLayoutPanel.Size = new System.Drawing.Size(343, 43);
            this.addRemoveButtonsLayoutPanel.TabIndex = 2;
            // 
            // removeBioResidueButton
            // 
            this.removeBioResidueButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeBioResidueButton.Location = new System.Drawing.Point(123, 9);
            this.removeBioResidueButton.Margin = new System.Windows.Forms.Padding(9);
            this.removeBioResidueButton.Name = "removeBioResidueButton";
            this.removeBioResidueButton.Size = new System.Drawing.Size(96, 25);
            this.removeBioResidueButton.TabIndex = 1;
            this.removeBioResidueButton.Text = "Remover";
            this.removeBioResidueButton.UseVisualStyleBackColor = true;
            this.removeBioResidueButton.Click += new System.EventHandler(this.removeBioResidueButton_Click);
            // 
            // addBiologicalResidueButton
            // 
            this.addBiologicalResidueButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBiologicalResidueButton.Location = new System.Drawing.Point(9, 9);
            this.addBiologicalResidueButton.Margin = new System.Windows.Forms.Padding(9);
            this.addBiologicalResidueButton.Name = "addBiologicalResidueButton";
            this.addBiologicalResidueButton.Size = new System.Drawing.Size(96, 25);
            this.addBiologicalResidueButton.TabIndex = 0;
            this.addBiologicalResidueButton.Text = "Adicionar";
            this.addBiologicalResidueButton.UseVisualStyleBackColor = true;
            this.addBiologicalResidueButton.Click += new System.EventHandler(this.addBiologicalResidueButton_Click);
            // 
            // BiologicalResidues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.biologicalAgentsGroupBox);
            this.Name = "BiologicalResidues";
            this.Size = new System.Drawing.Size(820, 429);
            this.Load += new System.EventHandler(this.BiologicalResidues_Load);
            this.biologicalAgentsGroupBox.ResumeLayout(false);
            this.mainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bioAgentData)).EndInit();
            this.generalInfoLayoutPanel.ResumeLayout(false);
            this.processedBiologicalSamples.ResumeLayout(false);
            this.processedSamplesLayoutPanel.ResumeLayout(false);
            this.processedSamplesLayoutPanel.PerformLayout();
            this.registryAndCertificationGroupBox.ResumeLayout(false);
            this.registryAndCertificationTableLayoutPanel.ResumeLayout(false);
            this.registryAndCertificationTableLayoutPanel.PerformLayout();
            this.ogmYesNoPanel.ResumeLayout(false);
            this.ogmYesNoPanel.PerformLayout();
            this.certificateYesNoPanel.ResumeLayout(false);
            this.certificateYesNoPanel.PerformLayout();
            this.addRemoveButtonsLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox biologicalAgentsGroupBox;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.DataGridView bioAgentData;
        private System.Windows.Forms.TableLayoutPanel generalInfoLayoutPanel;
        private System.Windows.Forms.GroupBox processedBiologicalSamples;
        private System.Windows.Forms.TableLayoutPanel processedSamplesLayoutPanel;
        private System.Windows.Forms.Label processedSamplesLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewComboBoxColumn riskClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn usage;
        private System.Windows.Forms.TableLayoutPanel addRemoveButtonsLayoutPanel;
        private System.Windows.Forms.Button addBiologicalResidueButton;
        private System.Windows.Forms.Button removeBiologicalResidueButton;
        private System.Windows.Forms.Button removeBioResidueButton;
        private System.Windows.Forms.TextBox newProcessedSampleTextBox;
        private System.Windows.Forms.Button addSampleButton;
        private System.Windows.Forms.ListBox processedSamplesListBox;
        private System.Windows.Forms.GroupBox registryAndCertificationGroupBox;
        private System.Windows.Forms.TableLayoutPanel registryAndCertificationTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ogmYesNoPanel;
        private System.Windows.Forms.RadioButton ogmNoRadioButton;
        private System.Windows.Forms.RadioButton ogmYesRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sisgenRegistryNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel certificateYesNoPanel;
        private System.Windows.Forms.RadioButton certificateNoRadioButton;
        private System.Windows.Forms.RadioButton certificateYesRadioButton;
    }
}
