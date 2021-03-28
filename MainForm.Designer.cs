
namespace RyskTech
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.objective_tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.agents_groupbox = new System.Windows.Forms.GroupBox();
            this.mech_checkbox = new System.Windows.Forms.CheckBox();
            this.bio_checkbox = new System.Windows.Forms.CheckBox();
            this.phys_checkbox = new System.Windows.Forms.CheckBox();
            this.chem_checkbox = new System.Windows.Forms.CheckBox();
            this.introdution_groupbox = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.IntroductionLabelEnd = new System.Windows.Forms.Label();
            this.UnitNameTextBox = new System.Windows.Forms.TextBox();
            this.IntroductionLabelStart = new System.Windows.Forms.Label();
            this.unit_tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.UnitTopLeftLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.location_info = new System.Windows.Forms.TabPage();
            this.unitLocationControl1 = new RyskTech.UnitLocationControl();
            this.team_info = new System.Windows.Forms.TabPage();
            this.unitTeamControl1 = new RyskTech.UnitTeamControl();
            this.structure_info = new System.Windows.Forms.TabPage();
            this.unitStructureControl1 = new RyskTech.UnitStructureControl();
            this.history_info = new System.Windows.Forms.TabPage();
            this.unitHistoryControl1 = new RyskTech.UnitHistoryControl();
            this.methodology_info = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.unitMethodologyControl1 = new RyskTech.UnitMethodologyControl();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.showTable1Button = new System.Windows.Forms.Button();
            this.showTable2Button = new System.Windows.Forms.Button();
            this.showTable3Button = new System.Windows.Forms.Button();
            this.showTable4Button = new System.Windows.Forms.Button();
            this.chemical_comp_tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.concludeButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.objective_tab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.agents_groupbox.SuspendLayout();
            this.introdution_groupbox.SuspendLayout();
            this.unit_tab.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.UnitTopLeftLayoutTable.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.location_info.SuspendLayout();
            this.team_info.SuspendLayout();
            this.structure_info.SuspendLayout();
            this.history_info.SuspendLayout();
            this.methodology_info.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 442);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.tabControl1.Size = new System.Drawing.Size(716, 395);
            this.tabControl1.TabIndex = 0;
            // 
            // objective_tab
            // 
            this.objective_tab.Controls.Add(this.tableLayoutPanel3);
            this.objective_tab.Location = new System.Drawing.Point(4, 22);
            this.objective_tab.Name = "objective_tab";
            this.objective_tab.Padding = new System.Windows.Forms.Padding(3);
            this.objective_tab.Size = new System.Drawing.Size(708, 369);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(702, 363);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // agents_groupbox
            // 
            this.agents_groupbox.Controls.Add(this.mech_checkbox);
            this.agents_groupbox.Controls.Add(this.bio_checkbox);
            this.agents_groupbox.Controls.Add(this.phys_checkbox);
            this.agents_groupbox.Controls.Add(this.chem_checkbox);
            this.agents_groupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agents_groupbox.Location = new System.Drawing.Point(3, 165);
            this.agents_groupbox.Name = "agents_groupbox";
            this.agents_groupbox.Size = new System.Drawing.Size(192, 195);
            this.agents_groupbox.TabIndex = 0;
            this.agents_groupbox.TabStop = false;
            this.agents_groupbox.Text = "Agentes";
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
            // introdution_groupbox
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.introdution_groupbox, 2);
            this.introdution_groupbox.Controls.Add(this.radioButton4);
            this.introdution_groupbox.Controls.Add(this.radioButton3);
            this.introdution_groupbox.Controls.Add(this.radioButton2);
            this.introdution_groupbox.Controls.Add(this.radioButton1);
            this.introdution_groupbox.Controls.Add(this.IntroductionLabelEnd);
            this.introdution_groupbox.Controls.Add(this.UnitNameTextBox);
            this.introdution_groupbox.Controls.Add(this.IntroductionLabelStart);
            this.introdution_groupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.introdution_groupbox.Location = new System.Drawing.Point(3, 3);
            this.introdution_groupbox.Name = "introdution_groupbox";
            this.introdution_groupbox.Size = new System.Drawing.Size(696, 156);
            this.introdution_groupbox.TabIndex = 1;
            this.introdution_groupbox.TabStop = false;
            this.introdution_groupbox.Text = "Introdução";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(472, 47);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(60, 21);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Setor";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(300, 47);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 21);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Espaço";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(139, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 21);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Laboratório";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(17, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Unidade";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // IntroductionLabelEnd
            // 
            this.IntroductionLabelEnd.AutoSize = true;
            this.IntroductionLabelEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroductionLabelEnd.Location = new System.Drawing.Point(14, 119);
            this.IntroductionLabelEnd.Name = "IntroductionLabelEnd";
            this.IntroductionLabelEnd.Size = new System.Drawing.Size(151, 34);
            this.IntroductionLabelEnd.TabIndex = 2;
            this.IntroductionLabelEnd.Text = "com foco nos agentes:\r\n\r\n";
            // 
            // UnitNameTextBox
            // 
            this.UnitNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitNameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UnitNameTextBox.Location = new System.Drawing.Point(17, 74);
            this.UnitNameTextBox.Name = "UnitNameTextBox";
            this.UnitNameTextBox.Size = new System.Drawing.Size(644, 23);
            this.UnitNameTextBox.TabIndex = 1;
            this.UnitNameTextBox.Text = "Nome da sua unidade/Laboratório/Espaço/Setor";
            this.UnitNameTextBox.TextChanged += new System.EventHandler(this.UnitNameTextBox_TextChanged);
            this.UnitNameTextBox.Enter += new System.EventHandler(this.UnitNameTextBox_Enter);
            this.UnitNameTextBox.Leave += new System.EventHandler(this.UnitNameTextBox_Leave);
            // 
            // IntroductionLabelStart
            // 
            this.IntroductionLabelStart.AutoSize = true;
            this.IntroductionLabelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroductionLabelStart.Location = new System.Drawing.Point(14, 27);
            this.IntroductionLabelStart.Name = "IntroductionLabelStart";
            this.IntroductionLabelStart.Size = new System.Drawing.Size(490, 17);
            this.IntroductionLabelStart.TabIndex = 0;
            this.IntroductionLabelStart.Text = "Visamos, por meio deste, apresentar a Análise Preliminar de Risco (APR) da";
            // 
            // unit_tab
            // 
            this.unit_tab.Controls.Add(this.tableLayoutPanel4);
            this.unit_tab.Location = new System.Drawing.Point(4, 22);
            this.unit_tab.Name = "unit_tab";
            this.unit_tab.Padding = new System.Windows.Forms.Padding(3);
            this.unit_tab.Size = new System.Drawing.Size(708, 369);
            this.unit_tab.TabIndex = 1;
            this.unit_tab.Text = "Unidade";
            this.unit_tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.72649F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.273504F));
            this.tableLayoutPanel4.Controls.Add(this.UnitTopLeftLayoutTable, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tabControl2, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.29477F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.70523F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(702, 363);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // UnitTopLeftLayoutTable
            // 
            this.UnitTopLeftLayoutTable.ColumnCount = 2;
            this.UnitTopLeftLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.68013F));
            this.UnitTopLeftLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.31986F));
            this.UnitTopLeftLayoutTable.Controls.Add(this.label1, 0, 1);
            this.UnitTopLeftLayoutTable.Controls.Add(this.textBox1, 1, 1);
            this.UnitTopLeftLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitTopLeftLayoutTable.Location = new System.Drawing.Point(3, 3);
            this.UnitTopLeftLayoutTable.Name = "UnitTopLeftLayoutTable";
            this.UnitTopLeftLayoutTable.RowCount = 3;
            this.UnitTopLeftLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.UnitTopLeftLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.UnitTopLeftLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.UnitTopLeftLayoutTable.Size = new System.Drawing.Size(665, 35);
            this.UnitTopLeftLayoutTable.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 11);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da Unidade";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(233, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.UnitNameTextBox_TextChanged);
            // 
            // tabControl2
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.tabControl2, 2);
            this.tabControl2.Controls.Add(this.location_info);
            this.tabControl2.Controls.Add(this.team_info);
            this.tabControl2.Controls.Add(this.structure_info);
            this.tabControl2.Controls.Add(this.history_info);
            this.tabControl2.Controls.Add(this.methodology_info);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 44);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(696, 316);
            this.tabControl2.TabIndex = 5;
            // 
            // location_info
            // 
            this.location_info.Controls.Add(this.unitLocationControl1);
            this.location_info.Location = new System.Drawing.Point(4, 22);
            this.location_info.Name = "location_info";
            this.location_info.Padding = new System.Windows.Forms.Padding(3);
            this.location_info.Size = new System.Drawing.Size(688, 290);
            this.location_info.TabIndex = 0;
            this.location_info.Text = "Localização";
            this.location_info.UseVisualStyleBackColor = true;
            // 
            // unitLocationControl1
            // 
            this.unitLocationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitLocationControl1.Location = new System.Drawing.Point(3, 3);
            this.unitLocationControl1.Name = "unitLocationControl1";
            this.unitLocationControl1.Size = new System.Drawing.Size(682, 284);
            this.unitLocationControl1.TabIndex = 0;
            // 
            // team_info
            // 
            this.team_info.Controls.Add(this.unitTeamControl1);
            this.team_info.Location = new System.Drawing.Point(4, 22);
            this.team_info.Name = "team_info";
            this.team_info.Padding = new System.Windows.Forms.Padding(3);
            this.team_info.Size = new System.Drawing.Size(688, 290);
            this.team_info.TabIndex = 1;
            this.team_info.Text = "Equipe";
            this.team_info.UseVisualStyleBackColor = true;
            // 
            // unitTeamControl1
            // 
            this.unitTeamControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitTeamControl1.Location = new System.Drawing.Point(3, 3);
            this.unitTeamControl1.Name = "unitTeamControl1";
            this.unitTeamControl1.Size = new System.Drawing.Size(682, 284);
            this.unitTeamControl1.TabIndex = 0;
            // 
            // structure_info
            // 
            this.structure_info.Controls.Add(this.unitStructureControl1);
            this.structure_info.Location = new System.Drawing.Point(4, 22);
            this.structure_info.Name = "structure_info";
            this.structure_info.Size = new System.Drawing.Size(688, 290);
            this.structure_info.TabIndex = 2;
            this.structure_info.Text = "Estrutura";
            this.structure_info.UseVisualStyleBackColor = true;
            // 
            // unitStructureControl1
            // 
            this.unitStructureControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitStructureControl1.Location = new System.Drawing.Point(0, 0);
            this.unitStructureControl1.Name = "unitStructureControl1";
            this.unitStructureControl1.Size = new System.Drawing.Size(688, 290);
            this.unitStructureControl1.TabIndex = 0;
            // 
            // history_info
            // 
            this.history_info.Controls.Add(this.unitHistoryControl1);
            this.history_info.Location = new System.Drawing.Point(4, 22);
            this.history_info.Name = "history_info";
            this.history_info.Size = new System.Drawing.Size(688, 290);
            this.history_info.TabIndex = 3;
            this.history_info.Text = "Histórico";
            this.history_info.UseVisualStyleBackColor = true;
            // 
            // unitHistoryControl1
            // 
            this.unitHistoryControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitHistoryControl1.Location = new System.Drawing.Point(0, 0);
            this.unitHistoryControl1.Name = "unitHistoryControl1";
            this.unitHistoryControl1.Size = new System.Drawing.Size(688, 290);
            this.unitHistoryControl1.TabIndex = 0;
            // 
            // methodology_info
            // 
            this.methodology_info.Controls.Add(this.tableLayoutPanel5);
            this.methodology_info.Location = new System.Drawing.Point(4, 22);
            this.methodology_info.Name = "methodology_info";
            this.methodology_info.Size = new System.Drawing.Size(688, 290);
            this.methodology_info.TabIndex = 4;
            this.methodology_info.Text = "Metodologia";
            this.methodology_info.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.88372F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.11628F));
            this.tableLayoutPanel5.Controls.Add(this.unitMethodologyControl1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.2069F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(688, 290);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // unitMethodologyControl1
            // 
            this.unitMethodologyControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitMethodologyControl1.Location = new System.Drawing.Point(3, 3);
            this.unitMethodologyControl1.Name = "unitMethodologyControl1";
            this.unitMethodologyControl1.Size = new System.Drawing.Size(577, 284);
            this.unitMethodologyControl1.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.showTable1Button, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.showTable2Button, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.showTable3Button, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.showTable4Button, 0, 3);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(586, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(99, 284);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // showTable1Button
            // 
            this.showTable1Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showTable1Button.Location = new System.Drawing.Point(20, 20);
            this.showTable1Button.Margin = new System.Windows.Forms.Padding(20);
            this.showTable1Button.Name = "showTable1Button";
            this.showTable1Button.Size = new System.Drawing.Size(59, 31);
            this.showTable1Button.TabIndex = 0;
            this.showTable1Button.Text = "Quadro 1";
            this.showTable1Button.UseVisualStyleBackColor = true;
            this.showTable1Button.Click += new System.EventHandler(this.showTable1Button_Click);
            // 
            // showTable2Button
            // 
            this.showTable2Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showTable2Button.Location = new System.Drawing.Point(20, 91);
            this.showTable2Button.Margin = new System.Windows.Forms.Padding(20);
            this.showTable2Button.Name = "showTable2Button";
            this.showTable2Button.Size = new System.Drawing.Size(59, 31);
            this.showTable2Button.TabIndex = 1;
            this.showTable2Button.Text = "Quadro 2";
            this.showTable2Button.UseVisualStyleBackColor = true;
            this.showTable2Button.Click += new System.EventHandler(this.showTable2Button_Click);
            // 
            // showTable3Button
            // 
            this.showTable3Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showTable3Button.Location = new System.Drawing.Point(20, 162);
            this.showTable3Button.Margin = new System.Windows.Forms.Padding(20);
            this.showTable3Button.Name = "showTable3Button";
            this.showTable3Button.Size = new System.Drawing.Size(59, 31);
            this.showTable3Button.TabIndex = 2;
            this.showTable3Button.Text = "Quadro 3";
            this.showTable3Button.UseVisualStyleBackColor = true;
            this.showTable3Button.Click += new System.EventHandler(this.showTable3Button_Click);
            // 
            // showTable4Button
            // 
            this.showTable4Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showTable4Button.Location = new System.Drawing.Point(20, 233);
            this.showTable4Button.Margin = new System.Windows.Forms.Padding(20);
            this.showTable4Button.Name = "showTable4Button";
            this.showTable4Button.Size = new System.Drawing.Size(59, 31);
            this.showTable4Button.TabIndex = 3;
            this.showTable4Button.Text = "Quadro 4";
            this.showTable4Button.UseVisualStyleBackColor = true;
            this.showTable4Button.Click += new System.EventHandler(this.showTable4Button_Click);
            // 
            // chemical_comp_tab
            // 
            this.chemical_comp_tab.Location = new System.Drawing.Point(4, 22);
            this.chemical_comp_tab.Name = "chemical_comp_tab";
            this.chemical_comp_tab.Size = new System.Drawing.Size(708, 369);
            this.chemical_comp_tab.TabIndex = 2;
            this.chemical_comp_tab.Text = "Agentes Químicos";
            this.chemical_comp_tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.concludeButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(364, 404);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(355, 35);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // concludeButton
            // 
            this.concludeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.concludeButton.Location = new System.Drawing.Point(239, 3);
            this.concludeButton.Name = "concludeButton";
            this.concludeButton.Size = new System.Drawing.Size(113, 29);
            this.concludeButton.TabIndex = 0;
            this.concludeButton.Text = "Conluir e enviar";
            this.concludeButton.UseVisualStyleBackColor = true;
            this.concludeButton.Click += new System.EventHandler(this.concludeButton_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(121, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Concluir depois";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 442);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "MainForm";
            this.Text = "RyskTech";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.objective_tab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.agents_groupbox.ResumeLayout(false);
            this.agents_groupbox.PerformLayout();
            this.introdution_groupbox.ResumeLayout(false);
            this.introdution_groupbox.PerformLayout();
            this.unit_tab.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.UnitTopLeftLayoutTable.ResumeLayout(false);
            this.UnitTopLeftLayoutTable.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.location_info.ResumeLayout(false);
            this.team_info.ResumeLayout(false);
            this.structure_info.ResumeLayout(false);
            this.history_info.ResumeLayout(false);
            this.methodology_info.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button concludeButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel UnitTopLeftLayoutTable;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage location_info;
        private System.Windows.Forms.TabPage team_info;
        private System.Windows.Forms.TabPage structure_info;
        private System.Windows.Forms.TabPage history_info;
        private System.Windows.Forms.TabPage methodology_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private UnitLocationControl unitLocationControl1;
        private UnitTeamControl unitTeamControl1;
        private UnitHistoryControl unitHistoryControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private UnitMethodologyControl unitMethodologyControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button showTable1Button;
        private System.Windows.Forms.Button showTable2Button;
        private System.Windows.Forms.Button showTable3Button;
        private System.Windows.Forms.Button showTable4Button;
        private UnitStructureControl unitStructureControl1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}