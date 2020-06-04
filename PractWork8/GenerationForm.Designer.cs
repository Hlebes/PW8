namespace PractWork8
{
    partial class GenerationForm
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
            this.openDialogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openDialogButton
            // 
            this.openDialogButton.Location = new System.Drawing.Point(637, 395);
            this.openDialogButton.Name = "openDialogButton";
            this.openDialogButton.Size = new System.Drawing.Size(151, 43);
            this.openDialogButton.TabIndex = 0;
            this.openDialogButton.Text = "Выбрать файл";
            this.openDialogButton.UseVisualStyleBackColor = true;
            this.openDialogButton.Click += new System.EventHandler(this.openDialogButton_Click);
            // 
            // GenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openDialogButton);
            this.Name = "GenerationForm";
            this.Text = "GenerationForm";
            this.Load += new System.EventHandler(this.GenerationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openDialogButton;
    }
}