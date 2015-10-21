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
            this.btnToggleFullscreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToggleFullscreen
            // 
            this.btnToggleFullscreen.Location = new System.Drawing.Point(3, 45);
            this.btnToggleFullscreen.Name = "btnToggleFullscreen";
            this.btnToggleFullscreen.Size = new System.Drawing.Size(144, 36);
            this.btnToggleFullscreen.TabIndex = 1;
            this.btnToggleFullscreen.Text = "Toggle fullscreen";
            this.btnToggleFullscreen.UseVisualStyleBackColor = true;
            this.btnToggleFullscreen.Click += new System.EventHandler(this.btnToggleFullscreen_Click);
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnToggleFullscreen);
            this.Name = "SettingsView";
            this.Size = new System.Drawing.Size(283, 180);
            this.Load += new System.EventHandler(this.SettingsView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnToggleFullscreen;
    }
}
