namespace Presentation
{
    partial class SettingsView
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
            this.btnOpenPresentation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenPresentation
            // 
            this.btnOpenPresentation.Location = new System.Drawing.Point(3, 111);
            this.btnOpenPresentation.Name = "btnOpenPresentation";
            this.btnOpenPresentation.Size = new System.Drawing.Size(144, 36);
            this.btnOpenPresentation.TabIndex = 0;
            this.btnOpenPresentation.Text = "Open presentation";
            this.btnOpenPresentation.UseVisualStyleBackColor = true;
            this.btnOpenPresentation.Click += new System.EventHandler(this.btnOpenPresentation_Click);
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOpenPresentation);
            this.Name = "SettingsView";
            this.Load += new System.EventHandler(this.SettingsView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenPresentation;
    }
}
