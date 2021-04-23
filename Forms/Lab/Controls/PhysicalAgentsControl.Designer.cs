
namespace RyskTech.Forms.Lab.Controls
{
    partial class PhysicalAgentsControl
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
            this.physicalAgentsGroupBox = new System.Windows.Forms.GroupBox();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.physicalAgentLabel = new System.Windows.Forms.Label();
            this.phyisicalAgentsDataGridView = new System.Windows.Forms.DataGridView();
            this.addPhyisicalAgentButton = new System.Windows.Forms.Button();
            this.removePhyisicalAgentButton = new System.Windows.Forms.Button();
            this.physicalAgentsGroupBox.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phyisicalAgentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // physicalAgentsGroupBox
            // 
            this.physicalAgentsGroupBox.Controls.Add(this.mainTableLayoutPanel);
            this.physicalAgentsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.physicalAgentsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.physicalAgentsGroupBox.Name = "physicalAgentsGroupBox";
            this.physicalAgentsGroupBox.Size = new System.Drawing.Size(820, 429);
            this.physicalAgentsGroupBox.TabIndex = 0;
            this.physicalAgentsGroupBox.TabStop = false;
            this.physicalAgentsGroupBox.Text = "Agentes Físicos";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 3;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.91646F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.02211F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.93858F));
            this.mainTableLayoutPanel.Controls.Add(this.physicalAgentLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.phyisicalAgentsDataGridView, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.addPhyisicalAgentButton, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.removePhyisicalAgentButton, 1, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.17073F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.07317F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(814, 410);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // physicalAgentLabel
            // 
            this.physicalAgentLabel.AutoSize = true;
            this.physicalAgentLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.physicalAgentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainTableLayoutPanel.SetColumnSpan(this.physicalAgentLabel, 3);
            this.physicalAgentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.physicalAgentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalAgentLabel.Location = new System.Drawing.Point(3, 0);
            this.physicalAgentLabel.Name = "physicalAgentLabel";
            this.physicalAgentLabel.Size = new System.Drawing.Size(808, 53);
            this.physicalAgentLabel.TabIndex = 0;
            this.physicalAgentLabel.Text = "Preencha a tabela abaixo com os agentes e riscos físicos presentes em seu espaço";
            this.physicalAgentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phyisicalAgentsDataGridView
            // 
            this.phyisicalAgentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainTableLayoutPanel.SetColumnSpan(this.phyisicalAgentsDataGridView, 3);
            this.phyisicalAgentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phyisicalAgentsDataGridView.Location = new System.Drawing.Point(3, 56);
            this.phyisicalAgentsDataGridView.Name = "phyisicalAgentsDataGridView";
            this.phyisicalAgentsDataGridView.Size = new System.Drawing.Size(808, 309);
            this.phyisicalAgentsDataGridView.TabIndex = 1;
            // 
            // addPhyisicalAgentButton
            // 
            this.addPhyisicalAgentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPhyisicalAgentButton.Location = new System.Drawing.Point(8, 376);
            this.addPhyisicalAgentButton.Margin = new System.Windows.Forms.Padding(8);
            this.addPhyisicalAgentButton.Name = "addPhyisicalAgentButton";
            this.addPhyisicalAgentButton.Size = new System.Drawing.Size(81, 26);
            this.addPhyisicalAgentButton.TabIndex = 2;
            this.addPhyisicalAgentButton.Text = "Adicionar";
            this.addPhyisicalAgentButton.UseVisualStyleBackColor = true;
            this.addPhyisicalAgentButton.Click += new System.EventHandler(this.addPhyisicalAgentButton_Click);
            // 
            // removePhyisicalAgentButton
            // 
            this.removePhyisicalAgentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removePhyisicalAgentButton.Location = new System.Drawing.Point(105, 376);
            this.removePhyisicalAgentButton.Margin = new System.Windows.Forms.Padding(8);
            this.removePhyisicalAgentButton.Name = "removePhyisicalAgentButton";
            this.removePhyisicalAgentButton.Size = new System.Drawing.Size(90, 26);
            this.removePhyisicalAgentButton.TabIndex = 3;
            this.removePhyisicalAgentButton.Text = "Remover";
            this.removePhyisicalAgentButton.UseVisualStyleBackColor = true;
            this.removePhyisicalAgentButton.Click += new System.EventHandler(this.removePhyisicalAgentButton_Click);
            // 
            // PhysicalAgentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.physicalAgentsGroupBox);
            this.Name = "PhysicalAgentsControl";
            this.Size = new System.Drawing.Size(820, 429);
            this.Load += new System.EventHandler(this.PhysicalAgentsControl_Load);
            this.physicalAgentsGroupBox.ResumeLayout(false);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phyisicalAgentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox physicalAgentsGroupBox;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Label physicalAgentLabel;
        private System.Windows.Forms.DataGridView phyisicalAgentsDataGridView;
        private System.Windows.Forms.Button addPhyisicalAgentButton;
        private System.Windows.Forms.Button removePhyisicalAgentButton;
    }
}
