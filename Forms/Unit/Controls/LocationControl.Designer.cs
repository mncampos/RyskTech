
namespace RyskTech.Forms.Unit.Controls
{
    partial class LocationControl
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.webBrowserGroupBox = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UnitSearchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComplementTextBox = new System.Windows.Forms.TextBox();
            this.ZIPTextBox = new System.Windows.Forms.TextBox();
            this.NeighborhoodTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            this.webBrowserGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.webBrowserGroupBox, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.panel1, 0, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.69185F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.30815F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(598, 503);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // webBrowserGroupBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.webBrowserGroupBox, 2);
            this.webBrowserGroupBox.Controls.Add(this.webBrowser1);
            this.webBrowserGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserGroupBox.Location = new System.Drawing.Point(3, 3);
            this.webBrowserGroupBox.Name = "webBrowserGroupBox";
            this.webBrowserGroupBox.Padding = new System.Windows.Forms.Padding(8);
            this.webBrowserGroupBox.Size = new System.Drawing.Size(592, 419);
            this.webBrowserGroupBox.TabIndex = 0;
            this.webBrowserGroupBox.TabStop = false;
            this.webBrowserGroupBox.Text = "Mapa";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(8, 21);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(576, 390);
            this.webBrowser1.TabIndex = 0;
            // 
            // panel1
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.UnitSearchButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ComplementTextBox);
            this.panel1.Controls.Add(this.ZIPTextBox);
            this.panel1.Controls.Add(this.NeighborhoodTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NumberTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.StreetTextBox);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 72);
            this.panel1.TabIndex = 1;
            // 
            // UnitSearchButton
            // 
            this.UnitSearchButton.Location = new System.Drawing.Point(497, 39);
            this.UnitSearchButton.Name = "UnitSearchButton";
            this.UnitSearchButton.Size = new System.Drawing.Size(59, 23);
            this.UnitSearchButton.TabIndex = 11;
            this.UnitSearchButton.Text = "Procurar";
            this.UnitSearchButton.UseVisualStyleBackColor = true;
            this.UnitSearchButton.Click += new System.EventHandler(this.UnitSearchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Complemento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CEP";
            // 
            // ComplementTextBox
            // 
            this.ComplementTextBox.Location = new System.Drawing.Point(391, 41);
            this.ComplementTextBox.Name = "ComplementTextBox";
            this.ComplementTextBox.Size = new System.Drawing.Size(100, 20);
            this.ComplementTextBox.TabIndex = 8;
            this.ComplementTextBox.TextChanged += new System.EventHandler(this.ComplementTextBox_TextChanged);
            // 
            // ZIPTextBox
            // 
            this.ZIPTextBox.Location = new System.Drawing.Point(191, 41);
            this.ZIPTextBox.Name = "ZIPTextBox";
            this.ZIPTextBox.Size = new System.Drawing.Size(117, 20);
            this.ZIPTextBox.TabIndex = 7;
            this.ZIPTextBox.TextChanged += new System.EventHandler(this.ZIPTextBox_TextChanged);
            // 
            // NeighborhoodTextBox
            // 
            this.NeighborhoodTextBox.Location = new System.Drawing.Point(50, 41);
            this.NeighborhoodTextBox.Name = "NeighborhoodTextBox";
            this.NeighborhoodTextBox.Size = new System.Drawing.Size(100, 20);
            this.NeighborhoodTextBox.TabIndex = 6;
            this.NeighborhoodTextBox.TextChanged += new System.EventHandler(this.NeighborhoodTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bairro ";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(472, 11);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(62, 20);
            this.NumberTextBox.TabIndex = 4;
            this.NumberTextBox.TextChanged += new System.EventHandler(this.NumberTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número";
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(220, 11);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(195, 20);
            this.StreetTextBox.TabIndex = 2;
            this.StreetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rua",
            "Av.",
            "Al.",
            "Tv.",
            "Rod."});
            this.comboBox1.Location = new System.Drawing.Point(169, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(45, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minha unidade se localiza no(a)";
            // 
            // TestLocationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "TestLocationControl";
            this.Size = new System.Drawing.Size(598, 503);
            this.Load += new System.EventHandler(this.TestLocationControl_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.webBrowserGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.GroupBox webBrowserGroupBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NeighborhoodTextBox;
        private System.Windows.Forms.TextBox ComplementTextBox;
        private System.Windows.Forms.TextBox ZIPTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UnitSearchButton;
        private System.Windows.Forms.Label label5;
    }
}
