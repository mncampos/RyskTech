
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
            this.residueStorageTab = new System.Windows.Forms.TabPage();
            this.residueListGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addResidueButton = new System.Windows.Forms.Button();
            this.editResidueButton = new System.Windows.Forms.Button();
            this.removeResidueButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.residueListTab.SuspendLayout();
            this.residueListGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // residueStorageTab
            // 
            this.residueStorageTab.Location = new System.Drawing.Point(4, 22);
            this.residueStorageTab.Name = "residueStorageTab";
            this.residueStorageTab.Padding = new System.Windows.Forms.Padding(3);
            this.residueStorageTab.Size = new System.Drawing.Size(517, 354);
            this.residueStorageTab.TabIndex = 1;
            this.residueStorageTab.Text = "Aramzenamento";
            this.residueStorageTab.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 4);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(499, 284);
            this.dataGridView1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage residueListTab;
        private System.Windows.Forms.GroupBox residueListGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addResidueButton;
        private System.Windows.Forms.Button editResidueButton;
        private System.Windows.Forms.Button removeResidueButton;
        private System.Windows.Forms.TabPage residueStorageTab;
    }
}
