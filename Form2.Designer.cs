
namespace RyskTech
{
    partial class Form2
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
            this.microorganismos = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Microorganismo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classificacao_de_Risco = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.microorganismos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.microorganismos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.82645F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.17355F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 605);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // microorganismos
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.microorganismos, 2);
            this.microorganismos.Controls.Add(this.splitContainer1);
            this.microorganismos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.microorganismos.Location = new System.Drawing.Point(3, 3);
            this.microorganismos.Name = "microorganismos";
            this.microorganismos.Size = new System.Drawing.Size(768, 362);
            this.microorganismos.TabIndex = 0;
            this.microorganismos.TabStop = false;
            this.microorganismos.Text = "Microorganismos";
            this.microorganismos.Enter += new System.EventHandler(this.microorganismos_Enter);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(762, 343);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Microorganismo,
            this.Classificacao_de_Risco});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(280, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // Microorganismo
            // 
            this.Microorganismo.HeaderText = "Microorganismo";
            this.Microorganismo.MinimumWidth = 100;
            this.Microorganismo.Name = "Microorganismo";
            this.Microorganismo.Width = 120;
            // 
            // Classificacao_de_Risco
            // 
            this.Classificacao_de_Risco.HeaderText = "Classificação de Risco";
            this.Classificacao_de_Risco.Items.AddRange(new object[] {
            "Classe de Risco 1",
            "Classe de Risco 2",
            "Classe de Risco 3",
            "Classe de Risco 4"});
            this.Classificacao_de_Risco.MinimumWidth = 120;
            this.Classificacao_de_Risco.Name = "Classificacao_de_Risco";
            this.Classificacao_de_Risco.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Classificacao_de_Risco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Classificacao_de_Risco.Width = 120;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::RyskTech.Properties.Resources.Etapa1_Classificacao_de_risco_ANVISA;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "u";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 605);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Agentes Biológicos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.microorganismos.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox microorganismos;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Microorganismo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Classificacao_de_Risco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}