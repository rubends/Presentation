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
            this.btnOpenFolderBrowser = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnReloadImages = new System.Windows.Forms.Button();
            this.btnPrevSlide = new System.Windows.Forms.Button();
            this.btnNextSlide = new System.Windows.Forms.Button();
            this.numericSlideTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericSlideTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToggleFullscreen
            // 
            this.btnToggleFullscreen.Location = new System.Drawing.Point(3, 3);
            this.btnToggleFullscreen.Name = "btnToggleFullscreen";
            this.btnToggleFullscreen.Size = new System.Drawing.Size(144, 40);
            this.btnToggleFullscreen.TabIndex = 1;
            this.btnToggleFullscreen.Text = "Toggle fullscreen";
            this.btnToggleFullscreen.UseVisualStyleBackColor = true;
            this.btnToggleFullscreen.Click += new System.EventHandler(this.btnToggleFullscreen_Click);
            // 
            // btnOpenFolderBrowser
            // 
            this.btnOpenFolderBrowser.Location = new System.Drawing.Point(153, 3);
            this.btnOpenFolderBrowser.Name = "btnOpenFolderBrowser";
            this.btnOpenFolderBrowser.Size = new System.Drawing.Size(144, 40);
            this.btnOpenFolderBrowser.TabIndex = 2;
            this.btnOpenFolderBrowser.Text = "Choose image folder";
            this.btnOpenFolderBrowser.UseVisualStyleBackColor = true;
            this.btnOpenFolderBrowser.Click += new System.EventHandler(this.btnOpenFolderBrowser_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "v";
            // 
            // btnReloadImages
            // 
            this.btnReloadImages.Location = new System.Drawing.Point(303, 3);
            this.btnReloadImages.Name = "btnReloadImages";
            this.btnReloadImages.Size = new System.Drawing.Size(144, 40);
            this.btnReloadImages.TabIndex = 3;
            this.btnReloadImages.Text = "Reload images";
            this.btnReloadImages.UseVisualStyleBackColor = true;
            this.btnReloadImages.Click += new System.EventHandler(this.btnReloadImages_Click);
            // 
            // btnPrevSlide
            // 
            this.btnPrevSlide.Location = new System.Drawing.Point(3, 65);
            this.btnPrevSlide.Name = "btnPrevSlide";
            this.btnPrevSlide.Size = new System.Drawing.Size(144, 40);
            this.btnPrevSlide.TabIndex = 4;
            this.btnPrevSlide.Text = "<<";
            this.btnPrevSlide.UseVisualStyleBackColor = true;
            this.btnPrevSlide.Click += new System.EventHandler(this.btnPrevSlide_Click);
            // 
            // btnNextSlide
            // 
            this.btnNextSlide.Location = new System.Drawing.Point(153, 65);
            this.btnNextSlide.Name = "btnNextSlide";
            this.btnNextSlide.Size = new System.Drawing.Size(144, 40);
            this.btnNextSlide.TabIndex = 5;
            this.btnNextSlide.Text = ">>";
            this.btnNextSlide.UseVisualStyleBackColor = true;
            this.btnNextSlide.Click += new System.EventHandler(this.btnNextSlide_Click);
            // 
            // numericSlideTime
            // 
            this.numericSlideTime.Location = new System.Drawing.Point(312, 77);
            this.numericSlideTime.Name = "numericSlideTime";
            this.numericSlideTime.Size = new System.Drawing.Size(120, 20);
            this.numericSlideTime.TabIndex = 6;
            this.numericSlideTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericSlideTime.ValueChanged += new System.EventHandler(this.numericSlideTime_ValueChanged);
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericSlideTime);
            this.Controls.Add(this.btnNextSlide);
            this.Controls.Add(this.btnPrevSlide);
            this.Controls.Add(this.btnReloadImages);
            this.Controls.Add(this.btnOpenFolderBrowser);
            this.Controls.Add(this.btnToggleFullscreen);
            this.Name = "SettingsView";
            this.Size = new System.Drawing.Size(453, 138);
            this.Load += new System.EventHandler(this.SettingsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSlideTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnToggleFullscreen;
        private System.Windows.Forms.Button btnOpenFolderBrowser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnReloadImages;
        private System.Windows.Forms.Button btnPrevSlide;
        private System.Windows.Forms.Button btnNextSlide;
        private System.Windows.Forms.NumericUpDown numericSlideTime;
    }
}
