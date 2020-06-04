namespace PractWork8
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskoneFormButton = new System.Windows.Forms.Button();
            this.animationFormButton = new System.Windows.Forms.Button();
            this.mutitabFormButton = new System.Windows.Forms.Button();
            this.generationFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskoneFormButton
            // 
            this.taskoneFormButton.Location = new System.Drawing.Point(12, 12);
            this.taskoneFormButton.Name = "taskoneFormButton";
            this.taskoneFormButton.Size = new System.Drawing.Size(198, 47);
            this.taskoneFormButton.TabIndex = 0;
            this.taskoneFormButton.Text = "Задание 1";
            this.taskoneFormButton.UseVisualStyleBackColor = true;
            this.taskoneFormButton.Click += new System.EventHandler(this.taskoneFormButton_Click);
            // 
            // animationFormButton
            // 
            this.animationFormButton.Location = new System.Drawing.Point(12, 65);
            this.animationFormButton.Name = "animationFormButton";
            this.animationFormButton.Size = new System.Drawing.Size(198, 47);
            this.animationFormButton.TabIndex = 1;
            this.animationFormButton.Text = "Задание 2";
            this.animationFormButton.UseVisualStyleBackColor = true;
            this.animationFormButton.Click += new System.EventHandler(this.animationFormButton_Click);
            // 
            // mutitabFormButton
            // 
            this.mutitabFormButton.Location = new System.Drawing.Point(12, 118);
            this.mutitabFormButton.Name = "mutitabFormButton";
            this.mutitabFormButton.Size = new System.Drawing.Size(198, 47);
            this.mutitabFormButton.TabIndex = 2;
            this.mutitabFormButton.Text = "Задание 3";
            this.mutitabFormButton.UseVisualStyleBackColor = true;
            this.mutitabFormButton.Click += new System.EventHandler(this.mutitabFormButton_Click);
            // 
            // generationFormButton
            // 
            this.generationFormButton.Location = new System.Drawing.Point(12, 171);
            this.generationFormButton.Name = "generationFormButton";
            this.generationFormButton.Size = new System.Drawing.Size(198, 47);
            this.generationFormButton.TabIndex = 3;
            this.generationFormButton.Text = "Задание 4";
            this.generationFormButton.UseVisualStyleBackColor = true;
            this.generationFormButton.Click += new System.EventHandler(this.generationFormButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 450);
            this.Controls.Add(this.generationFormButton);
            this.Controls.Add(this.mutitabFormButton);
            this.Controls.Add(this.animationFormButton);
            this.Controls.Add(this.taskoneFormButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button taskoneFormButton;
        private System.Windows.Forms.Button animationFormButton;
        private System.Windows.Forms.Button mutitabFormButton;
        private System.Windows.Forms.Button generationFormButton;
    }
}

