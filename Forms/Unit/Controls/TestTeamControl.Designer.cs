﻿
namespace RyskTech.Forms.Unit.Controls
{
    partial class TestTeamControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.UnitContactTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.compositionGroupBox = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OtherTextBox = new System.Windows.Forms.TextBox();
            this.OtherNumericUpDownCounter = new System.Windows.Forms.NumericUpDown();
            this.PublicNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StudentsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TeachersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProfessionalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.viceDirectorGroupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VicePhoneTextBox = new System.Windows.Forms.TextBox();
            this.ViceEmailTextBox = new System.Windows.Forms.TextBox();
            this.ViceNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.directorGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DirectorPhoneTextBox = new System.Windows.Forms.TextBox();
            this.DirectorEmailTextBox = new System.Windows.Forms.TextBox();
            this.DirectorNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.compositionGroupBox.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OtherNumericUpDownCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublicNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfessionalNumericUpDown)).BeginInit();
            this.viceDirectorGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.directorGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Controls.Add(this.compositionGroupBox);
            this.mainPanel.Controls.Add(this.viceDirectorGroupBox);
            this.mainPanel.Controls.Add(this.directorGroupBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(578, 555);
            this.mainPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.UnitContactTextBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(309, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 157);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contato";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UnitContactTextBox
            // 
            this.UnitContactTextBox.Location = new System.Drawing.Point(117, 23);
            this.UnitContactTextBox.Name = "UnitContactTextBox";
            this.UnitContactTextBox.Size = new System.Drawing.Size(128, 20);
            this.UnitContactTextBox.TabIndex = 3;
            this.UnitContactTextBox.TextChanged += new System.EventHandler(this.UnitContactTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "E-mail (opcional)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Telefone 2 (opcional)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Telefone 1";
            // 
            // compositionGroupBox
            // 
            this.compositionGroupBox.Controls.Add(this.panel3);
            this.compositionGroupBox.Location = new System.Drawing.Point(309, 45);
            this.compositionGroupBox.Name = "compositionGroupBox";
            this.compositionGroupBox.Size = new System.Drawing.Size(251, 168);
            this.compositionGroupBox.TabIndex = 2;
            this.compositionGroupBox.TabStop = false;
            this.compositionGroupBox.Text = "Composição";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.OtherTextBox);
            this.panel3.Controls.Add(this.OtherNumericUpDownCounter);
            this.panel3.Controls.Add(this.PublicNumericUpDown);
            this.panel3.Controls.Add(this.StudentsNumericUpDown);
            this.panel3.Controls.Add(this.TeachersNumericUpDown);
            this.panel3.Controls.Add(this.ProfessionalNumericUpDown);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 149);
            this.panel3.TabIndex = 0;
            // 
            // OtherTextBox
            // 
            this.OtherTextBox.Location = new System.Drawing.Point(48, 116);
            this.OtherTextBox.Name = "OtherTextBox";
            this.OtherTextBox.Size = new System.Drawing.Size(133, 20);
            this.OtherTextBox.TabIndex = 10;
            this.OtherTextBox.TextChanged += new System.EventHandler(this.OtherTextBox_TextChanged);
            // 
            // OtherNumericUpDownCounter
            // 
            this.OtherNumericUpDownCounter.Location = new System.Drawing.Point(187, 116);
            this.OtherNumericUpDownCounter.Name = "OtherNumericUpDownCounter";
            this.OtherNumericUpDownCounter.Size = new System.Drawing.Size(44, 20);
            this.OtherNumericUpDownCounter.TabIndex = 9;
            this.OtherNumericUpDownCounter.ValueChanged += new System.EventHandler(this.OtherNumericUpDownCounter_ValueChanged);
            // 
            // PublicNumericUpDown
            // 
            this.PublicNumericUpDown.Location = new System.Drawing.Point(187, 89);
            this.PublicNumericUpDown.Name = "PublicNumericUpDown";
            this.PublicNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.PublicNumericUpDown.TabIndex = 8;
            this.PublicNumericUpDown.ValueChanged += new System.EventHandler(this.PublicNumericUpDown_ValueChanged);
            // 
            // StudentsNumericUpDown
            // 
            this.StudentsNumericUpDown.Location = new System.Drawing.Point(187, 61);
            this.StudentsNumericUpDown.Name = "StudentsNumericUpDown";
            this.StudentsNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.StudentsNumericUpDown.TabIndex = 7;
            this.StudentsNumericUpDown.ValueChanged += new System.EventHandler(this.StudentsNumericUpDown_ValueChanged);
            // 
            // TeachersNumericUpDown
            // 
            this.TeachersNumericUpDown.Location = new System.Drawing.Point(187, 7);
            this.TeachersNumericUpDown.Name = "TeachersNumericUpDown";
            this.TeachersNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.TeachersNumericUpDown.TabIndex = 6;
            this.TeachersNumericUpDown.ValueChanged += new System.EventHandler(this.TeachersNumericUpDown_ValueChanged);
            // 
            // ProfessionalNumericUpDown
            // 
            this.ProfessionalNumericUpDown.Location = new System.Drawing.Point(187, 34);
            this.ProfessionalNumericUpDown.Name = "ProfessionalNumericUpDown";
            this.ProfessionalNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.ProfessionalNumericUpDown.TabIndex = 5;
            this.ProfessionalNumericUpDown.ValueChanged += new System.EventHandler(this.ProfessionalNumericUpDown_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Outros:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Público";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Alunos e Estudantes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Profissionais Técnico-Administrativos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Profissionais  Docentes";
            // 
            // viceDirectorGroupBox
            // 
            this.viceDirectorGroupBox.Controls.Add(this.panel2);
            this.viceDirectorGroupBox.Location = new System.Drawing.Point(17, 228);
            this.viceDirectorGroupBox.Name = "viceDirectorGroupBox";
            this.viceDirectorGroupBox.Size = new System.Drawing.Size(283, 157);
            this.viceDirectorGroupBox.TabIndex = 1;
            this.viceDirectorGroupBox.TabStop = false;
            this.viceDirectorGroupBox.Text = "Vice-Diretor";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.VicePhoneTextBox);
            this.panel2.Controls.Add(this.ViceEmailTextBox);
            this.panel2.Controls.Add(this.ViceNameTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 138);
            this.panel2.TabIndex = 1;
            // 
            // VicePhoneTextBox
            // 
            this.VicePhoneTextBox.Location = new System.Drawing.Point(67, 104);
            this.VicePhoneTextBox.Name = "VicePhoneTextBox";
            this.VicePhoneTextBox.Size = new System.Drawing.Size(207, 20);
            this.VicePhoneTextBox.TabIndex = 9;
            this.VicePhoneTextBox.TextChanged += new System.EventHandler(this.VicePhoneTextBox_TextChanged);
            // 
            // ViceEmailTextBox
            // 
            this.ViceEmailTextBox.Location = new System.Drawing.Point(67, 63);
            this.ViceEmailTextBox.Name = "ViceEmailTextBox";
            this.ViceEmailTextBox.Size = new System.Drawing.Size(207, 20);
            this.ViceEmailTextBox.TabIndex = 8;
            this.ViceEmailTextBox.TextChanged += new System.EventHandler(this.ViceEmailTextBox_TextChanged);
            // 
            // ViceNameTextBox
            // 
            this.ViceNameTextBox.Location = new System.Drawing.Point(67, 23);
            this.ViceNameTextBox.Name = "ViceNameTextBox";
            this.ViceNameTextBox.Size = new System.Drawing.Size(207, 20);
            this.ViceNameTextBox.TabIndex = 7;
            this.ViceNameTextBox.TextChanged += new System.EventHandler(this.ViceNameTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome";
            // 
            // directorGroupBox
            // 
            this.directorGroupBox.Controls.Add(this.panel1);
            this.directorGroupBox.Location = new System.Drawing.Point(14, 45);
            this.directorGroupBox.Name = "directorGroupBox";
            this.directorGroupBox.Size = new System.Drawing.Size(286, 168);
            this.directorGroupBox.TabIndex = 0;
            this.directorGroupBox.TabStop = false;
            this.directorGroupBox.Text = "Diretor";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DirectorPhoneTextBox);
            this.panel1.Controls.Add(this.DirectorEmailTextBox);
            this.panel1.Controls.Add(this.DirectorNameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 149);
            this.panel1.TabIndex = 0;
            // 
            // DirectorPhoneTextBox
            // 
            this.DirectorPhoneTextBox.Location = new System.Drawing.Point(70, 100);
            this.DirectorPhoneTextBox.Name = "DirectorPhoneTextBox";
            this.DirectorPhoneTextBox.Size = new System.Drawing.Size(207, 20);
            this.DirectorPhoneTextBox.TabIndex = 8;
            this.DirectorPhoneTextBox.TextChanged += new System.EventHandler(this.DirectorPhoneTextBox_TextChanged);
            // 
            // DirectorEmailTextBox
            // 
            this.DirectorEmailTextBox.Location = new System.Drawing.Point(70, 61);
            this.DirectorEmailTextBox.Name = "DirectorEmailTextBox";
            this.DirectorEmailTextBox.Size = new System.Drawing.Size(207, 20);
            this.DirectorEmailTextBox.TabIndex = 7;
            this.DirectorEmailTextBox.TextChanged += new System.EventHandler(this.DirectorEmailTextBox_TextChanged);
            // 
            // DirectorNameTextBox
            // 
            this.DirectorNameTextBox.Location = new System.Drawing.Point(70, 23);
            this.DirectorNameTextBox.Name = "DirectorNameTextBox";
            this.DirectorNameTextBox.Size = new System.Drawing.Size(207, 20);
            this.DirectorNameTextBox.TabIndex = 6;
            this.DirectorNameTextBox.TextChanged += new System.EventHandler(this.DirectorNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-Mail";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(18, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nome";
            // 
            // TestTeamControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "TestTeamControl";
            this.Size = new System.Drawing.Size(578, 555);
            this.Load += new System.EventHandler(this.TestTeamControl_Load);
            this.mainPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.compositionGroupBox.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OtherNumericUpDownCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublicNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfessionalNumericUpDown)).EndInit();
            this.viceDirectorGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.directorGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox directorGroupBox;
        private System.Windows.Forms.GroupBox viceDirectorGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox compositionGroupBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown OtherNumericUpDownCounter;
        private System.Windows.Forms.NumericUpDown PublicNumericUpDown;
        private System.Windows.Forms.NumericUpDown StudentsNumericUpDown;
        private System.Windows.Forms.NumericUpDown TeachersNumericUpDown;
        private System.Windows.Forms.NumericUpDown ProfessionalNumericUpDown;
        private System.Windows.Forms.TextBox OtherTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox UnitContactTextBox;
        private System.Windows.Forms.TextBox VicePhoneTextBox;
        private System.Windows.Forms.TextBox ViceEmailTextBox;
        private System.Windows.Forms.TextBox ViceNameTextBox;
        private System.Windows.Forms.TextBox DirectorPhoneTextBox;
        private System.Windows.Forms.TextBox DirectorEmailTextBox;
        private System.Windows.Forms.TextBox DirectorNameTextBox;
    }
}