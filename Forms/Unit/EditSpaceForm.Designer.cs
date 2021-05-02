
namespace RyskTech.Forms.Unit
{
    partial class EditSpaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSpaceForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.concludeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.floorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startHourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startMinutesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endMinuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endHourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.surroundingInfoTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startHourNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinutesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMinuteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endHourNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.37729F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.62271F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(342, 273);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 243);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.concludeButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 243);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 30);
            this.panel2.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(170, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // concludeButton
            // 
            this.concludeButton.Location = new System.Drawing.Point(252, 3);
            this.concludeButton.Name = "concludeButton";
            this.concludeButton.Size = new System.Drawing.Size(75, 23);
            this.concludeButton.TabIndex = 0;
            this.concludeButton.Text = "Concluir";
            this.concludeButton.UseVisualStyleBackColor = true;
            this.concludeButton.Click += new System.EventHandler(this.concludeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prédio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sala";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Andar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.floorTextBox);
            this.groupBox1.Controls.Add(this.roomTextBox);
            this.groupBox1.Controls.Add(this.buildingTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.endMinuteNumericUpDown);
            this.groupBox2.Controls.Add(this.endHourNumericUpDown);
            this.groupBox2.Controls.Add(this.startMinutesNumericUpDown);
            this.groupBox2.Controls.Add(this.startHourNumericUpDown);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(171, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 102);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atividade";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.surroundingInfoTextBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 109);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exterior";
            // 
            // buildingTextBox
            // 
            this.buildingTextBox.Location = new System.Drawing.Point(64, 14);
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.Size = new System.Drawing.Size(83, 20);
            this.buildingTextBox.TabIndex = 3;
            // 
            // roomTextBox
            // 
            this.roomTextBox.Location = new System.Drawing.Point(64, 40);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(83, 20);
            this.roomTextBox.TabIndex = 4;
            // 
            // floorTextBox
            // 
            this.floorTextBox.Location = new System.Drawing.Point(64, 68);
            this.floorTextBox.Name = "floorTextBox";
            this.floorTextBox.Size = new System.Drawing.Size(83, 20);
            this.floorTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Início do turno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fim do turno";
            // 
            // startHourNumericUpDown
            // 
            this.startHourNumericUpDown.Location = new System.Drawing.Point(9, 32);
            this.startHourNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.startHourNumericUpDown.Name = "startHourNumericUpDown";
            this.startHourNumericUpDown.Size = new System.Drawing.Size(33, 20);
            this.startHourNumericUpDown.TabIndex = 3;
            // 
            // startMinutesNumericUpDown
            // 
            this.startMinutesNumericUpDown.Location = new System.Drawing.Point(54, 32);
            this.startMinutesNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.startMinutesNumericUpDown.Name = "startMinutesNumericUpDown";
            this.startMinutesNumericUpDown.Size = new System.Drawing.Size(33, 20);
            this.startMinutesNumericUpDown.TabIndex = 4;
            // 
            // endMinuteNumericUpDown
            // 
            this.endMinuteNumericUpDown.Location = new System.Drawing.Point(54, 74);
            this.endMinuteNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.endMinuteNumericUpDown.Name = "endMinuteNumericUpDown";
            this.endMinuteNumericUpDown.Size = new System.Drawing.Size(33, 20);
            this.endMinuteNumericUpDown.TabIndex = 6;
            // 
            // endHourNumericUpDown
            // 
            this.endHourNumericUpDown.Location = new System.Drawing.Point(9, 74);
            this.endHourNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.endHourNumericUpDown.Name = "endHourNumericUpDown";
            this.endHourNumericUpDown.Size = new System.Drawing.Size(33, 20);
            this.endHourNumericUpDown.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(305, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Caso ache pertinente, informe sobre os arredores deste espaço";
            // 
            // surroundingInfoTextBox
            // 
            this.surroundingInfoTextBox.Location = new System.Drawing.Point(6, 37);
            this.surroundingInfoTextBox.Multiline = true;
            this.surroundingInfoTextBox.Name = "surroundingInfoTextBox";
            this.surroundingInfoTextBox.Size = new System.Drawing.Size(303, 66);
            this.surroundingInfoTextBox.TabIndex = 1;
            // 
            // EditSpaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(342, 273);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditSpaceForm";
            this.Text = "Adicionar Espaço";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startHourNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinutesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMinuteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endHourNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button concludeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox buildingTextBox;
        private System.Windows.Forms.TextBox floorTextBox;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown startHourNumericUpDown;
        private System.Windows.Forms.NumericUpDown startMinutesNumericUpDown;
        private System.Windows.Forms.NumericUpDown endMinuteNumericUpDown;
        private System.Windows.Forms.NumericUpDown endHourNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox surroundingInfoTextBox;
    }
}