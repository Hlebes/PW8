namespace PractWork8
{
    partial class AnimationForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimationForm));
            this.heroImageList = new System.Windows.Forms.ImageList(this.components);
            this.heroTimer = new System.Windows.Forms.Timer(this.components);
            this.hero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            this.SuspendLayout();
            // 
            // heroImageList
            // 
            this.heroImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("heroImageList.ImageStream")));
            this.heroImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.heroImageList.Images.SetKeyName(0, "shime1.png");
            this.heroImageList.Images.SetKeyName(1, "shime2.png");
            this.heroImageList.Images.SetKeyName(2, "shime3.png");
            // 
            // heroTimer
            // 
            this.heroTimer.Tick += new System.EventHandler(this.heroTimer_Tick);
            // 
            // hero
            // 
            this.hero.Location = new System.Drawing.Point(184, 184);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(128, 128);
            this.hero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hero.TabIndex = 0;
            this.hero.TabStop = false;
            // 
            // AnimationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hero);
            this.Name = "AnimationForm";
            this.Text = "AnimationForm";
            this.Load += new System.EventHandler(this.AnimationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList heroImageList;
        private System.Windows.Forms.Timer heroTimer;
        private System.Windows.Forms.PictureBox hero;
    }
}