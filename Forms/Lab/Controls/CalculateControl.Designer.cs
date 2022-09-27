namespace RyskTech.Forms.Lab.Controls
{
    partial class CalculateControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.residuosCheckbox = new System.Windows.Forms.CheckBox();
            this.editResidueButton = new System.Windows.Forms.Button();
            this.editReactorButton = new System.Windows.Forms.Button();
            this.removeReactorButton = new System.Windows.Forms.Button();
            this.addReactorButton = new System.Windows.Forms.Button();
            this.removeResidueButton = new System.Windows.Forms.Button();
            this.addResidueButton = new System.Windows.Forms.Button();
            this.chemicalReactorData = new System.Windows.Forms.DataGridView();
            this.substance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CASNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalReactorData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalResidueData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 575);
            this.panel1.TabIndex = 0;
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
            this.groupBox1.Location = new System.Drawing.Point(16, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(763, 342);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agentes";
            // 
            // residuosCheckbox
            // 
            this.residuosCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.residuosCheckbox.AutoSize = true;
            this.residuosCheckbox.Location = new System.Drawing.Point(356, 313);
            this.residuosCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.residuosCheckbox.Name = "residuosCheckbox";
            this.residuosCheckbox.Size = new System.Drawing.Size(94, 20);
            this.residuosCheckbox.TabIndex = 9;
            this.residuosCheckbox.Text = "Resíduos?";
            this.residuosCheckbox.UseVisualStyleBackColor = true;
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
            this.substance,
            this.CASNumber,
            this.quantity,
            this.IDLH,
            this.PVAP,
            this.category,
            this.referenceMass});
            this.chemicalReactorData.Location = new System.Drawing.Point(12, 92);
            this.chemicalReactorData.Margin = new System.Windows.Forms.Padding(4);
            this.chemicalReactorData.MinimumSize = new System.Drawing.Size(376, 0);
            this.chemicalReactorData.Name = "chemicalReactorData";
            this.chemicalReactorData.ReadOnly = true;
            this.chemicalReactorData.RowHeadersWidth = 51;
            this.chemicalReactorData.ShowCellToolTips = false;
            this.chemicalReactorData.Size = new System.Drawing.Size(743, 198);
            this.chemicalReactorData.TabIndex = 4;
            // 
            // substance
            // 
            this.substance.HeaderText = "Substância";
            this.substance.MinimumWidth = 6;
            this.substance.Name = "substance";
            this.substance.ReadOnly = true;
            this.substance.Width = 125;
            // 
            // CASNumber
            // 
            this.CASNumber.HeaderText = "Nº CAS";
            this.CASNumber.MinimumWidth = 6;
            this.CASNumber.Name = "CASNumber";
            this.CASNumber.ReadOnly = true;
            this.CASNumber.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantidade";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 125;
            // 
            // IDLH
            // 
            this.IDLH.HeaderText = "IDLH";
            this.IDLH.MinimumWidth = 6;
            this.IDLH.Name = "IDLH";
            this.IDLH.ReadOnly = true;
            this.IDLH.Width = 125;
            // 
            // PVAP
            // 
            this.PVAP.HeaderText = "Pvap (mmHg)";
            this.PVAP.MinimumWidth = 6;
            this.PVAP.Name = "PVAP";
            this.PVAP.ReadOnly = true;
            this.PVAP.Width = 125;
            // 
            // category
            // 
            this.category.HeaderText = "Categoria";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 125;
            // 
            // referenceMass
            // 
            this.referenceMass.HeaderText = "MR (kg)";
            this.referenceMass.MinimumWidth = 6;
            this.referenceMass.Name = "referenceMass";
            this.referenceMass.ReadOnly = true;
            this.referenceMass.Width = 125;
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
            this.chemicalResidueData.Margin = new System.Windows.Forms.Padding(4);
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
            // CalculateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CalculateControl";
            this.Size = new System.Drawing.Size(795, 575);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalReactorData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalResidueData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox residuosCheckbox;
        private System.Windows.Forms.Button editResidueButton;
        private System.Windows.Forms.Button editReactorButton;
        private System.Windows.Forms.Button removeReactorButton;
        private System.Windows.Forms.Button addReactorButton;
        private System.Windows.Forms.Button removeResidueButton;
        private System.Windows.Forms.Button addResidueButton;
        private System.Windows.Forms.DataGridView chemicalReactorData;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn substance;
        private System.Windows.Forms.DataGridViewTextBoxColumn CASNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceMass;
    }
}
