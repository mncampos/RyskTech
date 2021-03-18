
namespace RyskTech
{
    partial class UnitTeamControl
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
            this.UnitTeamGroupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // UnitTeamGroupBox
            // 
            this.UnitTeamGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitTeamGroupBox.Location = new System.Drawing.Point(0, 0);
            this.UnitTeamGroupBox.Name = "UnitTeamGroupBox";
            this.UnitTeamGroupBox.Size = new System.Drawing.Size(502, 353);
            this.UnitTeamGroupBox.TabIndex = 0;
            this.UnitTeamGroupBox.TabStop = false;
            this.UnitTeamGroupBox.Text = "Equipe";
            // 
            // UnitTeamControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UnitTeamGroupBox);
            this.Name = "UnitTeamControl";
            this.Size = new System.Drawing.Size(502, 353);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UnitTeamGroupBox;
    }
}
