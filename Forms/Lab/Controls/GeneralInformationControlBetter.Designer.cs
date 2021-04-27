
namespace RyskTech.Forms.Lab.Controls
{
    partial class GeneralInformationControlBetter
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spaceCharacterizationTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contactGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.responsiblePersonContactTextBox = new System.Windows.Forms.TextBox();
            this.responsiblePersonTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contactGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.groupBox2);
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Controls.Add(this.contactGroupBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(596, 467);
            this.mainPanel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.roomTextBox);
            this.groupBox2.Controls.Add(this.buildingTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(372, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 161);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Localização";
            // 
            // roomTextBox
            // 
            this.roomTextBox.Location = new System.Drawing.Point(15, 121);
            this.roomTextBox.Margin = new System.Windows.Forms.Padding(12);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(170, 20);
            this.roomTextBox.TabIndex = 4;
            this.roomTextBox.TextChanged += new System.EventHandler(this.roomTextBox_TextChanged);
            // 
            // buildingTextBox
            // 
            this.buildingTextBox.Location = new System.Drawing.Point(15, 47);
            this.buildingTextBox.Margin = new System.Windows.Forms.Padding(12);
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.Size = new System.Drawing.Size(170, 20);
            this.buildingTextBox.TabIndex = 3;
            this.buildingTextBox.TextChanged += new System.EventHandler(this.buildingTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sala";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Prédio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spaceCharacterizationTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(22, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caracterização";
            // 
            // spaceCharacterizationTextBox
            // 
            this.spaceCharacterizationTextBox.Location = new System.Drawing.Point(24, 41);
            this.spaceCharacterizationTextBox.Multiline = true;
            this.spaceCharacterizationTextBox.Name = "spaceCharacterizationTextBox";
            this.spaceCharacterizationTextBox.Size = new System.Drawing.Size(511, 189);
            this.spaceCharacterizationTextBox.TabIndex = 1;
            this.spaceCharacterizationTextBox.TextChanged += new System.EventHandler(this.spaceCharacterizationTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(367, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Descreva brevemente as atividades realizadas no seu espaço ou laboratório";
            // 
            // contactGroupBox
            // 
            this.contactGroupBox.Controls.Add(this.panel1);
            this.contactGroupBox.Location = new System.Drawing.Point(19, 28);
            this.contactGroupBox.Name = "contactGroupBox";
            this.contactGroupBox.Size = new System.Drawing.Size(341, 168);
            this.contactGroupBox.TabIndex = 0;
            this.contactGroupBox.TabStop = false;
            this.contactGroupBox.Text = "Responsável";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.responsiblePersonContactTextBox);
            this.panel1.Controls.Add(this.responsiblePersonTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 149);
            this.panel1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(71, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(254, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // responsiblePersonContactTextBox
            // 
            this.responsiblePersonContactTextBox.Location = new System.Drawing.Point(71, 75);
            this.responsiblePersonContactTextBox.Name = "responsiblePersonContactTextBox";
            this.responsiblePersonContactTextBox.Size = new System.Drawing.Size(254, 20);
            this.responsiblePersonContactTextBox.TabIndex = 5;
            this.responsiblePersonContactTextBox.TextChanged += new System.EventHandler(this.responsiblePersonContactTextBox_TextChanged);
            // 
            // responsiblePersonTextBox
            // 
            this.responsiblePersonTextBox.Location = new System.Drawing.Point(71, 48);
            this.responsiblePersonTextBox.Name = "responsiblePersonTextBox";
            this.responsiblePersonTextBox.Size = new System.Drawing.Size(254, 20);
            this.responsiblePersonTextBox.TabIndex = 4;
            this.responsiblePersonTextBox.TextChanged += new System.EventHandler(this.responsiblePersonTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indique quem é o responsável pelo laboratório ou espaço";
            // 
            // GeneralInformationControlBetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "GeneralInformationControlBetter";
            this.Size = new System.Drawing.Size(596, 467);
            this.Load += new System.EventHandler(this.GeneralInformationControlBetter_Load);
            this.mainPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contactGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox contactGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox responsiblePersonContactTextBox;
        private System.Windows.Forms.TextBox responsiblePersonTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox spaceCharacterizationTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox buildingTextBox;
        private System.Windows.Forms.TextBox roomTextBox;
    }
}
