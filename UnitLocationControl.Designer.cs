
namespace RyskTech
{
    partial class UnitLocationControl
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
            this.UnitLocationGroupBox = new System.Windows.Forms.GroupBox();
            this.RuaButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.AvenidaButton = new System.Windows.Forms.RadioButton();
            this.AlamedaButton = new System.Windows.Forms.RadioButton();
            this.TravessaButton = new System.Windows.Forms.RadioButton();
            this.UnitSearchButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.RodoviaButton = new System.Windows.Forms.RadioButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.UnitLocationGroupBox.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnitLocationGroupBox
            // 
            this.UnitLocationGroupBox.Controls.Add(this.tableLayoutPanel8);
            this.UnitLocationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitLocationGroupBox.Location = new System.Drawing.Point(0, 0);
            this.UnitLocationGroupBox.Name = "UnitLocationGroupBox";
            this.UnitLocationGroupBox.Size = new System.Drawing.Size(599, 335);
            this.UnitLocationGroupBox.TabIndex = 4;
            this.UnitLocationGroupBox.TabStop = false;
            this.UnitLocationGroupBox.Text = "Localização";
            this.UnitLocationGroupBox.Enter += new System.EventHandler(this.UnitLocationGroupBox_Enter);
            // 
            // RuaButton
            // 
            this.RuaButton.AutoSize = true;
            this.RuaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RuaButton.Location = new System.Drawing.Point(3, 3);
            this.RuaButton.Name = "RuaButton";
            this.RuaButton.Size = new System.Drawing.Size(53, 46);
            this.RuaButton.TabIndex = 16;
            this.RuaButton.TabStop = true;
            this.RuaButton.Text = "Rua";
            this.RuaButton.UseVisualStyleBackColor = true;
            this.RuaButton.CheckedChanged += new System.EventHandler(this.RuaButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 7, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Complemento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox6
            // 
            this.tableLayoutPanel8.SetColumnSpan(this.textBox6, 2);
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(62, 263);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(112, 20);
            this.textBox6.TabIndex = 13;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox5
            // 
            this.tableLayoutPanel8.SetColumnSpan(this.textBox5, 2);
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(62, 211);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(112, 20);
            this.textBox5.TabIndex = 12;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.tableLayoutPanel8.SetColumnSpan(this.textBox4, 2);
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(62, 159);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.tableLayoutPanel8.SetColumnSpan(this.textBox3, 2);
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(62, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 7, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CEP";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 7, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bairro";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 7, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StreetTextBox
            // 
            this.tableLayoutPanel8.SetColumnSpan(this.StreetTextBox, 5);
            this.StreetTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StreetTextBox.Location = new System.Drawing.Point(3, 57);
            this.StreetTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(289, 20);
            this.StreetTextBox.TabIndex = 5;
            this.StreetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // AvenidaButton
            // 
            this.AvenidaButton.AutoSize = true;
            this.AvenidaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvenidaButton.Location = new System.Drawing.Point(62, 3);
            this.AvenidaButton.Name = "AvenidaButton";
            this.AvenidaButton.Size = new System.Drawing.Size(53, 46);
            this.AvenidaButton.TabIndex = 17;
            this.AvenidaButton.TabStop = true;
            this.AvenidaButton.Text = "Avenida";
            this.AvenidaButton.UseVisualStyleBackColor = true;
            this.AvenidaButton.CheckedChanged += new System.EventHandler(this.AvenidaButton_CheckedChanged);
            // 
            // AlamedaButton
            // 
            this.AlamedaButton.AutoSize = true;
            this.AlamedaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlamedaButton.Location = new System.Drawing.Point(121, 3);
            this.AlamedaButton.Name = "AlamedaButton";
            this.AlamedaButton.Size = new System.Drawing.Size(53, 46);
            this.AlamedaButton.TabIndex = 18;
            this.AlamedaButton.TabStop = true;
            this.AlamedaButton.Text = "Alameda";
            this.AlamedaButton.UseVisualStyleBackColor = true;
            this.AlamedaButton.CheckedChanged += new System.EventHandler(this.AlamedaButton_CheckedChanged);
            // 
            // TravessaButton
            // 
            this.TravessaButton.AutoSize = true;
            this.TravessaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TravessaButton.Location = new System.Drawing.Point(180, 3);
            this.TravessaButton.Name = "TravessaButton";
            this.TravessaButton.Size = new System.Drawing.Size(53, 46);
            this.TravessaButton.TabIndex = 19;
            this.TravessaButton.TabStop = true;
            this.TravessaButton.Text = "Travessa";
            this.TravessaButton.UseVisualStyleBackColor = true;
            this.TravessaButton.CheckedChanged += new System.EventHandler(this.TravessaButton_CheckedChanged);
            // 
            // UnitSearchButton
            // 
            this.UnitSearchButton.Location = new System.Drawing.Point(239, 107);
            this.UnitSearchButton.Name = "UnitSearchButton";
            this.UnitSearchButton.Size = new System.Drawing.Size(53, 23);
            this.UnitSearchButton.TabIndex = 0;
            this.UnitSearchButton.Text = "Procurar";
            this.UnitSearchButton.UseVisualStyleBackColor = true;
            this.UnitSearchButton.Click += new System.EventHandler(this.UnitSearchButton_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 6;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.RodoviaButton, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.TravessaButton, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.AlamedaButton, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.AvenidaButton, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.StreetTextBox, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.textBox4, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.textBox5, 1, 4);
            this.tableLayoutPanel8.Controls.Add(this.textBox6, 1, 5);
            this.tableLayoutPanel8.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel8.Controls.Add(this.RuaButton, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.webBrowser1, 5, 1);
            this.tableLayoutPanel8.Controls.Add(this.UnitSearchButton, 4, 2);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 6;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(593, 316);
            this.tableLayoutPanel8.TabIndex = 0;
            this.tableLayoutPanel8.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel8_Paint);
            // 
            // RodoviaButton
            // 
            this.RodoviaButton.AutoSize = true;
            this.RodoviaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RodoviaButton.Location = new System.Drawing.Point(239, 3);
            this.RodoviaButton.Name = "RodoviaButton";
            this.RodoviaButton.Size = new System.Drawing.Size(53, 46);
            this.RodoviaButton.TabIndex = 20;
            this.RodoviaButton.TabStop = true;
            this.RodoviaButton.Text = "Rodovia";
            this.RodoviaButton.UseVisualStyleBackColor = true;
            this.RodoviaButton.CheckedChanged += new System.EventHandler(this.RodoviaButton_CheckedChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(298, 55);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.tableLayoutPanel8.SetRowSpan(this.webBrowser1, 5);
            this.webBrowser1.Size = new System.Drawing.Size(292, 258);
            this.webBrowser1.TabIndex = 21;
            // 
            // UnitLocationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UnitLocationGroupBox);
            this.Name = "UnitLocationControl";
            this.Size = new System.Drawing.Size(599, 335);
            this.UnitLocationGroupBox.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UnitLocationGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button UnitSearchButton;
        private System.Windows.Forms.RadioButton RodoviaButton;
        private System.Windows.Forms.RadioButton TravessaButton;
        private System.Windows.Forms.RadioButton AlamedaButton;
        private System.Windows.Forms.RadioButton AvenidaButton;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RuaButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}
