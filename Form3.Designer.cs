
namespace RyskTech
{
    partial class Form3
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chemical_comp_tab = new System.Windows.Forms.TabPage();
            this.objective_tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.introdution_groupbox = new System.Windows.Forms.GroupBox();
            this.IntroductionLabelStart = new System.Windows.Forms.Label();
            this.UnitNameTextBox = new System.Windows.Forms.TextBox();
            this.IntroductionLabelEnd = new System.Windows.Forms.Label();
            this.agents_groupbox = new System.Windows.Forms.GroupBox();
            this.chem_checkbox = new System.Windows.Forms.CheckBox();
            this.phys_checkbox = new System.Windows.Forms.CheckBox();
            this.bio_checkbox = new System.Windows.Forms.CheckBox();
            this.mech_checkbox = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.unit_tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.objective_tab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.introdution_groupbox.SuspendLayout();
            this.agents_groupbox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.unit_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.111111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 375);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(105, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Concluir depois";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(207, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Concluir e enviar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(316, 343);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(307, 29);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // chemical_comp_tab
            // 
            this.chemical_comp_tab.Location = new System.Drawing.Point(4, 22);
            this.chemical_comp_tab.Name = "chemical_comp_tab";
            this.chemical_comp_tab.Size = new System.Drawing.Size(612, 308);
            this.chemical_comp_tab.TabIndex = 2;
            this.chemical_comp_tab.Text = "Agentes Químicos";
            this.chemical_comp_tab.UseVisualStyleBackColor = true;
            // 
            // objective_tab
            // 
            this.objective_tab.Controls.Add(this.tableLayoutPanel3);
            this.objective_tab.Location = new System.Drawing.Point(4, 22);
            this.objective_tab.Name = "objective_tab";
            this.objective_tab.Padding = new System.Windows.Forms.Padding(3);
            this.objective_tab.Size = new System.Drawing.Size(612, 308);
            this.objective_tab.TabIndex = 0;
            this.objective_tab.Text = "Objetivo";
            this.objective_tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.21782F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.78218F));
            this.tableLayoutPanel3.Controls.Add(this.agents_groupbox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.introdution_groupbox, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.64286F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.35714F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(606, 302);
            this.tableLayoutPanel3.TabIndex = 0;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // introdution_groupbox
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.introdution_groupbox, 2);
            this.introdution_groupbox.Controls.Add(this.IntroductionLabelEnd);
            this.introdution_groupbox.Controls.Add(this.UnitNameTextBox);
            this.introdution_groupbox.Controls.Add(this.IntroductionLabelStart);
            this.introdution_groupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.introdution_groupbox.Location = new System.Drawing.Point(3, 3);
            this.introdution_groupbox.Name = "introdution_groupbox";
            this.introdution_groupbox.Size = new System.Drawing.Size(600, 128);
            this.introdution_groupbox.TabIndex = 1;
            this.introdution_groupbox.TabStop = false;
            this.introdution_groupbox.Text = "Introdução";
            // 
            // IntroductionLabelStart
            // 
            this.IntroductionLabelStart.AutoSize = true;
            this.IntroductionLabelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroductionLabelStart.Location = new System.Drawing.Point(14, 27);
            this.IntroductionLabelStart.Name = "IntroductionLabelStart";
            this.IntroductionLabelStart.Size = new System.Drawing.Size(545, 34);
            this.IntroductionLabelStart.TabIndex = 0;
            this.IntroductionLabelStart.Text = "Visamos, por meio deste, apresentar a Análise Preliminar de Risco (APR) da unidad" +
    "e\r\n\r\n";
            // 
            // UnitNameTextBox
            // 
            this.UnitNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitNameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UnitNameTextBox.Location = new System.Drawing.Point(17, 53);
            this.UnitNameTextBox.Name = "UnitNameTextBox";
            this.UnitNameTextBox.Size = new System.Drawing.Size(473, 23);
            this.UnitNameTextBox.TabIndex = 1;
            this.UnitNameTextBox.Text = "Nome da sua unidade";
            this.UnitNameTextBox.Enter += new System.EventHandler(this.UnitNameTextBox_Enter);
            this.UnitNameTextBox.Leave += new System.EventHandler(this.UnitNameTextBox_Leave);
            // 
            // IntroductionLabelEnd
            // 
            this.IntroductionLabelEnd.AutoSize = true;
            this.IntroductionLabelEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroductionLabelEnd.Location = new System.Drawing.Point(14, 79);
            this.IntroductionLabelEnd.Name = "IntroductionLabelEnd";
            this.IntroductionLabelEnd.Size = new System.Drawing.Size(151, 34);
            this.IntroductionLabelEnd.TabIndex = 2;
            this.IntroductionLabelEnd.Text = "com foco nos agentes:\r\n\r\n";
            // 
            // agents_groupbox
            // 
            this.agents_groupbox.Controls.Add(this.mech_checkbox);
            this.agents_groupbox.Controls.Add(this.bio_checkbox);
            this.agents_groupbox.Controls.Add(this.phys_checkbox);
            this.agents_groupbox.Controls.Add(this.chem_checkbox);
            this.agents_groupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agents_groupbox.Location = new System.Drawing.Point(3, 137);
            this.agents_groupbox.Name = "agents_groupbox";
            this.agents_groupbox.Size = new System.Drawing.Size(164, 162);
            this.agents_groupbox.TabIndex = 0;
            this.agents_groupbox.TabStop = false;
            this.agents_groupbox.Text = "Agentes";
            // 
            // chem_checkbox
            // 
            this.chem_checkbox.AutoSize = true;
            this.chem_checkbox.Location = new System.Drawing.Point(17, 32);
            this.chem_checkbox.Name = "chem_checkbox";
            this.chem_checkbox.Size = new System.Drawing.Size(113, 17);
            this.chem_checkbox.TabIndex = 0;
            this.chem_checkbox.Text = "Agentes Químicos";
            this.chem_checkbox.UseVisualStyleBackColor = true;
            // 
            // phys_checkbox
            // 
            this.phys_checkbox.AutoSize = true;
            this.phys_checkbox.Location = new System.Drawing.Point(17, 56);
            this.phys_checkbox.Name = "phys_checkbox";
            this.phys_checkbox.Size = new System.Drawing.Size(102, 17);
            this.phys_checkbox.TabIndex = 1;
            this.phys_checkbox.Text = "Agentes Físicos";
            this.phys_checkbox.UseVisualStyleBackColor = true;
            // 
            // bio_checkbox
            // 
            this.bio_checkbox.AutoSize = true;
            this.bio_checkbox.Location = new System.Drawing.Point(17, 80);
            this.bio_checkbox.Name = "bio_checkbox";
            this.bio_checkbox.Size = new System.Drawing.Size(116, 17);
            this.bio_checkbox.TabIndex = 2;
            this.bio_checkbox.Text = "Agentes Biológicos";
            this.bio_checkbox.UseVisualStyleBackColor = true;
            // 
            // mech_checkbox
            // 
            this.mech_checkbox.AutoSize = true;
            this.mech_checkbox.Location = new System.Drawing.Point(17, 104);
            this.mech_checkbox.Name = "mech_checkbox";
            this.mech_checkbox.Size = new System.Drawing.Size(120, 17);
            this.mech_checkbox.TabIndex = 3;
            this.mech_checkbox.Text = "Agentes Mecânicos";
            this.mech_checkbox.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 2);
            this.tabControl1.Controls.Add(this.objective_tab);
            this.tabControl1.Controls.Add(this.unit_tab);
            this.tabControl1.Controls.Add(this.chemical_comp_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 334);
            this.tabControl1.TabIndex = 0;
            // 
            // unit_tab
            // 
            this.unit_tab.Controls.Add(this.tableLayoutPanel4);
            this.unit_tab.Location = new System.Drawing.Point(4, 22);
            this.unit_tab.Name = "unit_tab";
            this.unit_tab.Padding = new System.Windows.Forms.Padding(3);
            this.unit_tab.Size = new System.Drawing.Size(612, 308);
            this.unit_tab.TabIndex = 1;
            this.unit_tab.Text = "Unidade";
            this.unit_tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(606, 302);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 375);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "Form3";
            this.Text = "RyskTech";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.objective_tab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.introdution_groupbox.ResumeLayout(false);
            this.introdution_groupbox.PerformLayout();
            this.agents_groupbox.ResumeLayout(false);
            this.agents_groupbox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.unit_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage objective_tab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox agents_groupbox;
        private System.Windows.Forms.CheckBox mech_checkbox;
        private System.Windows.Forms.CheckBox bio_checkbox;
        private System.Windows.Forms.CheckBox phys_checkbox;
        private System.Windows.Forms.CheckBox chem_checkbox;
        private System.Windows.Forms.GroupBox introdution_groupbox;
        private System.Windows.Forms.Label IntroductionLabelEnd;
        private System.Windows.Forms.TextBox UnitNameTextBox;
        private System.Windows.Forms.Label IntroductionLabelStart;
        private System.Windows.Forms.TabPage unit_tab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TabPage chemical_comp_tab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}