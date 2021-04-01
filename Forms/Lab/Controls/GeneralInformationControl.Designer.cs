
namespace RyskTech.Forms.Lab.Controls
{
    partial class GeneralInformationControl
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
            this.responsibleGroupBox = new System.Windows.Forms.GroupBox();
            this.managerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.whoIsResponsibleLabel = new System.Windows.Forms.Label();
            this.responsibleLabel = new System.Windows.Forms.Label();
            this.responsiblePersonTextBox = new System.Windows.Forms.TextBox();
            this.contactLabel = new System.Windows.Forms.Label();
            this.responsiblePersonContactTextBox = new System.Windows.Forms.TextBox();
            this.spaceLocationGroupBox = new System.Windows.Forms.GroupBox();
            this.locationTableGridLayout = new System.Windows.Forms.TableLayoutPanel();
            this.buildingLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.descriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.spaceCharacterizationTextBox = new System.Windows.Forms.TextBox();
            this.spaceCharacterizationLabel = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            this.responsibleGroupBox.SuspendLayout();
            this.managerTableLayoutPanel.SuspendLayout();
            this.spaceLocationGroupBox.SuspendLayout();
            this.locationTableGridLayout.SuspendLayout();
            this.descriptionGroupBox.SuspendLayout();
            this.descriptionTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.96439F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.03561F));
            this.mainTableLayoutPanel.Controls.Add(this.responsibleGroupBox, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.spaceLocationGroupBox, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.descriptionGroupBox, 1, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(674, 440);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // responsibleGroupBox
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.responsibleGroupBox, 2);
            this.responsibleGroupBox.Controls.Add(this.managerTableLayoutPanel);
            this.responsibleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.responsibleGroupBox.Location = new System.Drawing.Point(3, 3);
            this.responsibleGroupBox.Name = "responsibleGroupBox";
            this.responsibleGroupBox.Size = new System.Drawing.Size(668, 193);
            this.responsibleGroupBox.TabIndex = 0;
            this.responsibleGroupBox.TabStop = false;
            this.responsibleGroupBox.Text = "Responsável";
            // 
            // managerTableLayoutPanel
            // 
            this.managerTableLayoutPanel.ColumnCount = 2;
            this.managerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.27795F));
            this.managerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.72205F));
            this.managerTableLayoutPanel.Controls.Add(this.whoIsResponsibleLabel, 0, 0);
            this.managerTableLayoutPanel.Controls.Add(this.responsibleLabel, 0, 1);
            this.managerTableLayoutPanel.Controls.Add(this.responsiblePersonTextBox, 1, 1);
            this.managerTableLayoutPanel.Controls.Add(this.contactLabel, 0, 2);
            this.managerTableLayoutPanel.Controls.Add(this.responsiblePersonContactTextBox, 1, 2);
            this.managerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managerTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.managerTableLayoutPanel.Name = "managerTableLayoutPanel";
            this.managerTableLayoutPanel.RowCount = 3;
            this.managerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.managerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.managerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.managerTableLayoutPanel.Size = new System.Drawing.Size(662, 174);
            this.managerTableLayoutPanel.TabIndex = 0;
            // 
            // whoIsResponsibleLabel
            // 
            this.whoIsResponsibleLabel.AutoSize = true;
            this.whoIsResponsibleLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.whoIsResponsibleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.managerTableLayoutPanel.SetColumnSpan(this.whoIsResponsibleLabel, 2);
            this.whoIsResponsibleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whoIsResponsibleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whoIsResponsibleLabel.Location = new System.Drawing.Point(12, 12);
            this.whoIsResponsibleLabel.Margin = new System.Windows.Forms.Padding(12);
            this.whoIsResponsibleLabel.Name = "whoIsResponsibleLabel";
            this.whoIsResponsibleLabel.Size = new System.Drawing.Size(638, 62);
            this.whoIsResponsibleLabel.TabIndex = 1;
            this.whoIsResponsibleLabel.Text = "Informe quem é responsável pelo controle  deste espaço e alguma forma de contato " +
    "com esta pessoa";
            this.whoIsResponsibleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // responsibleLabel
            // 
            this.responsibleLabel.AutoSize = true;
            this.responsibleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.responsibleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.responsibleLabel.Location = new System.Drawing.Point(8, 94);
            this.responsibleLabel.Margin = new System.Windows.Forms.Padding(8);
            this.responsibleLabel.Name = "responsibleLabel";
            this.responsibleLabel.Size = new System.Drawing.Size(105, 27);
            this.responsibleLabel.TabIndex = 0;
            this.responsibleLabel.Text = "Responsável";
            this.responsibleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // responsiblePersonTextBox
            // 
            this.responsiblePersonTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.responsiblePersonTextBox.Location = new System.Drawing.Point(133, 98);
            this.responsiblePersonTextBox.Margin = new System.Windows.Forms.Padding(12);
            this.responsiblePersonTextBox.Name = "responsiblePersonTextBox";
            this.responsiblePersonTextBox.Size = new System.Drawing.Size(517, 20);
            this.responsiblePersonTextBox.TabIndex = 2;
            this.responsiblePersonTextBox.TextChanged += new System.EventHandler(this.responsiblePersonTextBox_TextChanged);
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactLabel.Location = new System.Drawing.Point(8, 137);
            this.contactLabel.Margin = new System.Windows.Forms.Padding(8);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(105, 29);
            this.contactLabel.TabIndex = 3;
            this.contactLabel.Text = "Contato\r\n(telefone ou e-mail)";
            this.contactLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // responsiblePersonContactTextBox
            // 
            this.responsiblePersonContactTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.responsiblePersonContactTextBox.Location = new System.Drawing.Point(133, 141);
            this.responsiblePersonContactTextBox.Margin = new System.Windows.Forms.Padding(12);
            this.responsiblePersonContactTextBox.Name = "responsiblePersonContactTextBox";
            this.responsiblePersonContactTextBox.Size = new System.Drawing.Size(517, 20);
            this.responsiblePersonContactTextBox.TabIndex = 4;
            this.responsiblePersonContactTextBox.TextChanged += new System.EventHandler(this.responsiblePersonContactTextBox_TextChanged);
            // 
            // spaceLocationGroupBox
            // 
            this.spaceLocationGroupBox.Controls.Add(this.locationTableGridLayout);
            this.spaceLocationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spaceLocationGroupBox.Location = new System.Drawing.Point(3, 202);
            this.spaceLocationGroupBox.Name = "spaceLocationGroupBox";
            this.spaceLocationGroupBox.Size = new System.Drawing.Size(168, 235);
            this.spaceLocationGroupBox.TabIndex = 1;
            this.spaceLocationGroupBox.TabStop = false;
            this.spaceLocationGroupBox.Text = "Localização";
            // 
            // locationTableGridLayout
            // 
            this.locationTableGridLayout.ColumnCount = 1;
            this.locationTableGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.locationTableGridLayout.Controls.Add(this.buildingLabel, 0, 0);
            this.locationTableGridLayout.Controls.Add(this.roomLabel, 0, 2);
            this.locationTableGridLayout.Controls.Add(this.buildingTextBox, 0, 1);
            this.locationTableGridLayout.Controls.Add(this.roomTextBox, 0, 3);
            this.locationTableGridLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationTableGridLayout.Location = new System.Drawing.Point(3, 16);
            this.locationTableGridLayout.Name = "locationTableGridLayout";
            this.locationTableGridLayout.RowCount = 4;
            this.locationTableGridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.locationTableGridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.locationTableGridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.locationTableGridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.locationTableGridLayout.Size = new System.Drawing.Size(162, 216);
            this.locationTableGridLayout.TabIndex = 0;
            // 
            // buildingLabel
            // 
            this.buildingLabel.AutoSize = true;
            this.buildingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buildingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildingLabel.Location = new System.Drawing.Point(12, 12);
            this.buildingLabel.Margin = new System.Windows.Forms.Padding(12);
            this.buildingLabel.Name = "buildingLabel";
            this.buildingLabel.Size = new System.Drawing.Size(138, 30);
            this.buildingLabel.TabIndex = 0;
            this.buildingLabel.Text = "Prédio utilizado";
            this.buildingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomLabel.Location = new System.Drawing.Point(12, 120);
            this.roomLabel.Margin = new System.Windows.Forms.Padding(12);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(138, 30);
            this.roomLabel.TabIndex = 1;
            this.roomLabel.Text = "Sala utilizada";
            this.roomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buildingTextBox
            // 
            this.buildingTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildingTextBox.Location = new System.Drawing.Point(12, 66);
            this.buildingTextBox.Margin = new System.Windows.Forms.Padding(12);
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.Size = new System.Drawing.Size(138, 20);
            this.buildingTextBox.TabIndex = 2;
            this.buildingTextBox.TextChanged += new System.EventHandler(this.buildingTextBox_TextChanged);
            // 
            // roomTextBox
            // 
            this.roomTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomTextBox.Location = new System.Drawing.Point(12, 174);
            this.roomTextBox.Margin = new System.Windows.Forms.Padding(12);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(138, 20);
            this.roomTextBox.TabIndex = 3;
            this.roomTextBox.TextChanged += new System.EventHandler(this.roomTextBox_TextChanged);
            // 
            // descriptionGroupBox
            // 
            this.descriptionGroupBox.Controls.Add(this.descriptionTableLayoutPanel);
            this.descriptionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionGroupBox.Location = new System.Drawing.Point(177, 202);
            this.descriptionGroupBox.Name = "descriptionGroupBox";
            this.descriptionGroupBox.Size = new System.Drawing.Size(494, 235);
            this.descriptionGroupBox.TabIndex = 2;
            this.descriptionGroupBox.TabStop = false;
            this.descriptionGroupBox.Text = "Caracterização";
            // 
            // descriptionTableLayoutPanel
            // 
            this.descriptionTableLayoutPanel.ColumnCount = 2;
            this.descriptionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.descriptionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.descriptionTableLayoutPanel.Controls.Add(this.spaceCharacterizationTextBox, 0, 1);
            this.descriptionTableLayoutPanel.Controls.Add(this.spaceCharacterizationLabel, 0, 0);
            this.descriptionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.descriptionTableLayoutPanel.Name = "descriptionTableLayoutPanel";
            this.descriptionTableLayoutPanel.RowCount = 2;
            this.descriptionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.05556F));
            this.descriptionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.94444F));
            this.descriptionTableLayoutPanel.Size = new System.Drawing.Size(488, 216);
            this.descriptionTableLayoutPanel.TabIndex = 0;
            // 
            // spaceCharacterizationTextBox
            // 
            this.descriptionTableLayoutPanel.SetColumnSpan(this.spaceCharacterizationTextBox, 2);
            this.spaceCharacterizationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spaceCharacterizationTextBox.Location = new System.Drawing.Point(3, 42);
            this.spaceCharacterizationTextBox.Multiline = true;
            this.spaceCharacterizationTextBox.Name = "spaceCharacterizationTextBox";
            this.spaceCharacterizationTextBox.Size = new System.Drawing.Size(482, 171);
            this.spaceCharacterizationTextBox.TabIndex = 0;
            this.spaceCharacterizationTextBox.TextChanged += new System.EventHandler(this.spaceCharacterizationTextBox_TextChanged);
            // 
            // spaceCharacterizationLabel
            // 
            this.spaceCharacterizationLabel.AutoSize = true;
            this.spaceCharacterizationLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spaceCharacterizationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTableLayoutPanel.SetColumnSpan(this.spaceCharacterizationLabel, 2);
            this.spaceCharacterizationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spaceCharacterizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceCharacterizationLabel.Location = new System.Drawing.Point(5, 5);
            this.spaceCharacterizationLabel.Margin = new System.Windows.Forms.Padding(5);
            this.spaceCharacterizationLabel.Name = "spaceCharacterizationLabel";
            this.spaceCharacterizationLabel.Size = new System.Drawing.Size(478, 29);
            this.spaceCharacterizationLabel.TabIndex = 1;
            this.spaceCharacterizationLabel.Text = "Descreva brevemente as atividades realizadas no seu espaço";
            this.spaceCharacterizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GeneralInformationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "GeneralInformationControl";
            this.Size = new System.Drawing.Size(674, 440);
            this.Load += new System.EventHandler(this.GeneralInformationControl_Load);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.responsibleGroupBox.ResumeLayout(false);
            this.managerTableLayoutPanel.ResumeLayout(false);
            this.managerTableLayoutPanel.PerformLayout();
            this.spaceLocationGroupBox.ResumeLayout(false);
            this.locationTableGridLayout.ResumeLayout(false);
            this.locationTableGridLayout.PerformLayout();
            this.descriptionGroupBox.ResumeLayout(false);
            this.descriptionTableLayoutPanel.ResumeLayout(false);
            this.descriptionTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.GroupBox responsibleGroupBox;
        private System.Windows.Forms.GroupBox spaceLocationGroupBox;
        private System.Windows.Forms.GroupBox descriptionGroupBox;
        private System.Windows.Forms.TableLayoutPanel locationTableGridLayout;
        private System.Windows.Forms.TableLayoutPanel descriptionTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel managerTableLayoutPanel;
        private System.Windows.Forms.Label responsibleLabel;
        private System.Windows.Forms.Label whoIsResponsibleLabel;
        private System.Windows.Forms.TextBox responsiblePersonTextBox;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox responsiblePersonContactTextBox;
        private System.Windows.Forms.Label buildingLabel;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.TextBox buildingTextBox;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.TextBox spaceCharacterizationTextBox;
        private System.Windows.Forms.Label spaceCharacterizationLabel;
    }
}
