
namespace RyskTech
{
    partial class ChemicalResidueControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.residueListTab = new System.Windows.Forms.TabPage();
            this.residueListGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chemicalResidueData = new System.Windows.Forms.DataGridView();
            this.addResidueButton = new System.Windows.Forms.Button();
            this.editResidueButton = new System.Windows.Forms.Button();
            this.removeResidueButton = new System.Windows.Forms.Button();
            this.residueStorageTab = new System.Windows.Forms.TabPage();
            this.chemicalResidueStorageGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nbrLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chemicalResidueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResiduePhysicalState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResidueOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResidueQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResidueDangers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inertState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResidueStorageLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemicalResidueContainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.residueListTab.SuspendLayout();
            this.residueListGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalResidueData)).BeginInit();
            this.residueStorageTab.SuspendLayout();
            this.chemicalResidueStorageGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.residueListTab);
            this.tabControl1.Controls.Add(this.residueStorageTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(525, 380);
            this.tabControl1.TabIndex = 0;
            // 
            // residueListTab
            // 
            this.residueListTab.Controls.Add(this.residueListGroupBox);
            this.residueListTab.Location = new System.Drawing.Point(4, 22);
            this.residueListTab.Name = "residueListTab";
            this.residueListTab.Padding = new System.Windows.Forms.Padding(3);
            this.residueListTab.Size = new System.Drawing.Size(517, 354);
            this.residueListTab.TabIndex = 0;
            this.residueListTab.Text = "Listagem de informações";
            this.residueListTab.UseVisualStyleBackColor = true;
            // 
            // residueListGroupBox
            // 
            this.residueListGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.residueListGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.residueListGroupBox.Location = new System.Drawing.Point(3, 3);
            this.residueListGroupBox.Name = "residueListGroupBox";
            this.residueListGroupBox.Size = new System.Drawing.Size(511, 348);
            this.residueListGroupBox.TabIndex = 0;
            this.residueListGroupBox.TabStop = false;
            this.residueListGroupBox.Text = "Resíduos";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.01001F));
            this.tableLayoutPanel1.Controls.Add(this.chemicalResidueData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addResidueButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.editResidueButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.removeResidueButton, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.1459F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8541F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 329);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chemicalResidueData
            // 
            this.chemicalResidueData.AllowUserToAddRows = false;
            this.chemicalResidueData.AllowUserToDeleteRows = false;
            this.chemicalResidueData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chemicalResidueData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chemicalResidueName,
            this.chemicalResiduePhysicalState,
            this.chemicalResidueOrigin,
            this.chemicalResidueQuantity,
            this.chemicalResidueDangers,
            this.inertState,
            this.chemicalResidueStorageLocation,
            this.chemicalResidueContainer});
            this.tableLayoutPanel1.SetColumnSpan(this.chemicalResidueData, 4);
            this.chemicalResidueData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chemicalResidueData.Location = new System.Drawing.Point(3, 3);
            this.chemicalResidueData.Name = "chemicalResidueData";
            this.chemicalResidueData.ReadOnly = true;
            this.chemicalResidueData.Size = new System.Drawing.Size(499, 284);
            this.chemicalResidueData.TabIndex = 0;
            // 
            // addResidueButton
            // 
            this.addResidueButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addResidueButton.Location = new System.Drawing.Point(8, 298);
            this.addResidueButton.Margin = new System.Windows.Forms.Padding(8);
            this.addResidueButton.Name = "addResidueButton";
            this.addResidueButton.Size = new System.Drawing.Size(68, 23);
            this.addResidueButton.TabIndex = 1;
            this.addResidueButton.Text = "Novo";
            this.addResidueButton.UseVisualStyleBackColor = true;
            this.addResidueButton.Click += new System.EventHandler(this.addResidueButton_Click);
            // 
            // editResidueButton
            // 
            this.editResidueButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editResidueButton.Location = new System.Drawing.Point(92, 298);
            this.editResidueButton.Margin = new System.Windows.Forms.Padding(8);
            this.editResidueButton.Name = "editResidueButton";
            this.editResidueButton.Size = new System.Drawing.Size(68, 23);
            this.editResidueButton.TabIndex = 2;
            this.editResidueButton.Text = "Editar";
            this.editResidueButton.UseVisualStyleBackColor = true;
            this.editResidueButton.Click += new System.EventHandler(this.editResidueButton_Click);
            // 
            // removeResidueButton
            // 
            this.removeResidueButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeResidueButton.Location = new System.Drawing.Point(176, 298);
            this.removeResidueButton.Margin = new System.Windows.Forms.Padding(8);
            this.removeResidueButton.Name = "removeResidueButton";
            this.removeResidueButton.Size = new System.Drawing.Size(68, 23);
            this.removeResidueButton.TabIndex = 3;
            this.removeResidueButton.Text = "Remover";
            this.removeResidueButton.UseVisualStyleBackColor = true;
            this.removeResidueButton.Click += new System.EventHandler(this.removeResidueButton_Click);
            // 
            // residueStorageTab
            // 
            this.residueStorageTab.Controls.Add(this.chemicalResidueStorageGroupBox);
            this.residueStorageTab.Location = new System.Drawing.Point(4, 22);
            this.residueStorageTab.Name = "residueStorageTab";
            this.residueStorageTab.Padding = new System.Windows.Forms.Padding(3);
            this.residueStorageTab.Size = new System.Drawing.Size(517, 354);
            this.residueStorageTab.TabIndex = 1;
            this.residueStorageTab.Text = "Armazenamento";
            this.residueStorageTab.UseVisualStyleBackColor = true;
            // 
            // chemicalResidueStorageGroupBox
            // 
            this.chemicalResidueStorageGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.chemicalResidueStorageGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chemicalResidueStorageGroupBox.Location = new System.Drawing.Point(3, 3);
            this.chemicalResidueStorageGroupBox.Name = "chemicalResidueStorageGroupBox";
            this.chemicalResidueStorageGroupBox.Size = new System.Drawing.Size(511, 348);
            this.chemicalResidueStorageGroupBox.TabIndex = 0;
            this.chemicalResidueStorageGroupBox.TabStop = false;
            this.chemicalResidueStorageGroupBox.Text = "Containers";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.54099F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.45901F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Controls.Add(this.yesRadioButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.noRadioButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nbrLinkLabel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.45763F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.54237F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(505, 329);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yesRadioButton.Location = new System.Drawing.Point(3, 29);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(44, 23);
            this.yesRadioButton.TabIndex = 0;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Sim";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noRadioButton.Location = new System.Drawing.Point(53, 29);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(50, 23);
            this.noRadioButton.TabIndex = 1;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "Não";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Os recipientes dos resíduos químicos estão rotulados de acordo com a ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nbrLinkLabel
            // 
            this.nbrLinkLabel.AutoSize = true;
            this.nbrLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nbrLinkLabel.Location = new System.Drawing.Point(348, 1);
            this.nbrLinkLabel.Margin = new System.Windows.Forms.Padding(1);
            this.nbrLinkLabel.Name = "nbrLinkLabel";
            this.nbrLinkLabel.Size = new System.Drawing.Size(120, 24);
            this.nbrLinkLabel.TabIndex = 3;
            this.nbrLinkLabel.TabStop = true;
            this.nbrLinkLabel.Text = "NBR-14725-3:2017 ?";
            this.nbrLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbrLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nbrLinkLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label2, 5);
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Como é feito o armazenamento dos resíduos químicos do laboratório/espaço?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox1, 5);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(499, 93);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label3, 5);
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(3, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Qual o destino dos resíduos químicos gerados pelo laboratório/espaço?";
            // 
            // textBox2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox2, 5);
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 212);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(499, 114);
            this.textBox2.TabIndex = 7;
            // 
            // chemicalResidueName
            // 
            this.chemicalResidueName.HeaderText = "Nome";
            this.chemicalResidueName.Name = "chemicalResidueName";
            this.chemicalResidueName.ReadOnly = true;
            // 
            // chemicalResiduePhysicalState
            // 
            this.chemicalResiduePhysicalState.HeaderText = "Estado Físico";
            this.chemicalResiduePhysicalState.Name = "chemicalResiduePhysicalState";
            this.chemicalResiduePhysicalState.ReadOnly = true;
            // 
            // chemicalResidueOrigin
            // 
            this.chemicalResidueOrigin.HeaderText = "Origem";
            this.chemicalResidueOrigin.Name = "chemicalResidueOrigin";
            this.chemicalResidueOrigin.ReadOnly = true;
            // 
            // chemicalResidueQuantity
            // 
            this.chemicalResidueQuantity.HeaderText = "Quantidade";
            this.chemicalResidueQuantity.Name = "chemicalResidueQuantity";
            this.chemicalResidueQuantity.ReadOnly = true;
            // 
            // chemicalResidueDangers
            // 
            this.chemicalResidueDangers.HeaderText = "Perigoso?";
            this.chemicalResidueDangers.Name = "chemicalResidueDangers";
            this.chemicalResidueDangers.ReadOnly = true;
            // 
            // inertState
            // 
            this.inertState.HeaderText = "Inerte?";
            this.inertState.Name = "inertState";
            this.inertState.ReadOnly = true;
            // 
            // chemicalResidueStorageLocation
            // 
            this.chemicalResidueStorageLocation.HeaderText = "Armazenamento";
            this.chemicalResidueStorageLocation.Name = "chemicalResidueStorageLocation";
            this.chemicalResidueStorageLocation.ReadOnly = true;
            // 
            // chemicalResidueContainer
            // 
            this.chemicalResidueContainer.HeaderText = "Recipiente";
            this.chemicalResidueContainer.Name = "chemicalResidueContainer";
            this.chemicalResidueContainer.ReadOnly = true;
            // 
            // ChemicalResidueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ChemicalResidueControl";
            this.Size = new System.Drawing.Size(525, 380);
            this.tabControl1.ResumeLayout(false);
            this.residueListTab.ResumeLayout(false);
            this.residueListGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chemicalResidueData)).EndInit();
            this.residueStorageTab.ResumeLayout(false);
            this.chemicalResidueStorageGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage residueListTab;
        private System.Windows.Forms.GroupBox residueListGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView chemicalResidueData;
        private System.Windows.Forms.Button addResidueButton;
        private System.Windows.Forms.Button editResidueButton;
        private System.Windows.Forms.Button removeResidueButton;
        private System.Windows.Forms.TabPage residueStorageTab;
        private System.Windows.Forms.GroupBox chemicalResidueStorageGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel nbrLinkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResidueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResiduePhysicalState;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResidueOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResidueQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResidueDangers;
        private System.Windows.Forms.DataGridViewTextBoxColumn inertState;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResidueStorageLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemicalResidueContainer;
    }
}
