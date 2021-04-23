
namespace RyskTech.Forms.Lab.Controls
{
    partial class MechanicalAgentControl
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
            this.mechanicalAgentGroupBox = new System.Windows.Forms.GroupBox();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.mechanicalAgentsDataGridView = new System.Windows.Forms.DataGridView();
            this.agentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addAgentButton = new System.Windows.Forms.Button();
            this.removeAgentButton = new System.Windows.Forms.Button();
            this.mechanicalAgentGroupBox.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicalAgentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mechanicalAgentGroupBox
            // 
            this.mechanicalAgentGroupBox.Controls.Add(this.mainTableLayoutPanel);
            this.mechanicalAgentGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mechanicalAgentGroupBox.Location = new System.Drawing.Point(0, 0);
            this.mechanicalAgentGroupBox.Name = "mechanicalAgentGroupBox";
            this.mechanicalAgentGroupBox.Size = new System.Drawing.Size(820, 429);
            this.mechanicalAgentGroupBox.TabIndex = 0;
            this.mechanicalAgentGroupBox.TabStop = false;
            this.mechanicalAgentGroupBox.Text = "Agentes mecânicos";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 3;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.25126F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.74874F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 614F));
            this.mainTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.mechanicalAgentsDataGridView, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.addAgentButton, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.removeAgentButton, 1, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.73171F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.2683F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(814, 410);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainTableLayoutPanel.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(804, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preencha a tabela abaixo com os agentes mecânicos e riscos associados no seu espa" +
    "ço";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mechanicalAgentsDataGridView
            // 
            this.mechanicalAgentsDataGridView.AllowUserToAddRows = false;
            this.mechanicalAgentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mechanicalAgentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agentName,
            this.riks,
            this.additionalInfo});
            this.mainTableLayoutPanel.SetColumnSpan(this.mechanicalAgentsDataGridView, 3);
            this.mechanicalAgentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mechanicalAgentsDataGridView.Location = new System.Drawing.Point(5, 45);
            this.mechanicalAgentsDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.mechanicalAgentsDataGridView.Name = "mechanicalAgentsDataGridView";
            this.mechanicalAgentsDataGridView.Size = new System.Drawing.Size(804, 322);
            this.mechanicalAgentsDataGridView.TabIndex = 1;
            // 
            // agentName
            // 
            this.agentName.HeaderText = "Agente";
            this.agentName.Name = "agentName";
            // 
            // riks
            // 
            this.riks.HeaderText = "Risco";
            this.riks.Name = "riks";
            // 
            // additionalInfo
            // 
            this.additionalInfo.HeaderText = "Informações Adicionais";
            this.additionalInfo.Name = "additionalInfo";
            this.additionalInfo.Width = 550;
            // 
            // addAgentButton
            // 
            this.addAgentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addAgentButton.Location = new System.Drawing.Point(8, 380);
            this.addAgentButton.Margin = new System.Windows.Forms.Padding(8);
            this.addAgentButton.Name = "addAgentButton";
            this.addAgentButton.Size = new System.Drawing.Size(84, 22);
            this.addAgentButton.TabIndex = 2;
            this.addAgentButton.Text = "Adicionar";
            this.addAgentButton.UseVisualStyleBackColor = true;
            this.addAgentButton.Click += new System.EventHandler(this.addAgentButton_Click);
            // 
            // removeAgentButton
            // 
            this.removeAgentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeAgentButton.Location = new System.Drawing.Point(108, 380);
            this.removeAgentButton.Margin = new System.Windows.Forms.Padding(8);
            this.removeAgentButton.Name = "removeAgentButton";
            this.removeAgentButton.Size = new System.Drawing.Size(83, 22);
            this.removeAgentButton.TabIndex = 3;
            this.removeAgentButton.Text = "Remover";
            this.removeAgentButton.UseVisualStyleBackColor = true;
            this.removeAgentButton.Click += new System.EventHandler(this.removeAgentButton_Click);
            // 
            // MechanicalAgentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mechanicalAgentGroupBox);
            this.Name = "MechanicalAgentControl";
            this.Size = new System.Drawing.Size(820, 429);
            this.Load += new System.EventHandler(this.MechanicalAgentControl_Load);
            this.mechanicalAgentGroupBox.ResumeLayout(false);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicalAgentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mechanicalAgentGroupBox;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView mechanicalAgentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn riks;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInfo;
        private System.Windows.Forms.Button addAgentButton;
        private System.Windows.Forms.Button removeAgentButton;
    }
}
