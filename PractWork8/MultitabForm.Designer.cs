namespace PractWork8
{
    partial class MultitabForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTabPage = new System.Windows.Forms.TabPage();
            this.gameTabPage = new System.Windows.Forms.TabPage();
            this.leaderboardTabPage = new System.Windows.Forms.TabPage();
            this.manualTabPage = new System.Windows.Forms.TabPage();
            this.playButton = new System.Windows.Forms.Button();
            this.leaderboardButton = new System.Windows.Forms.Button();
            this.manualButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.backButton1 = new System.Windows.Forms.Button();
            this.backButton2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.playerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.mainTabPage.SuspendLayout();
            this.gameTabPage.SuspendLayout();
            this.leaderboardTabPage.SuspendLayout();
            this.manualTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTabPage);
            this.tabControl1.Controls.Add(this.gameTabPage);
            this.tabControl1.Controls.Add(this.leaderboardTabPage);
            this.tabControl1.Controls.Add(this.manualTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // mainTabPage
            // 
            this.mainTabPage.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.mainTabPage.Controls.Add(this.manualButton);
            this.mainTabPage.Controls.Add(this.leaderboardButton);
            this.mainTabPage.Controls.Add(this.playButton);
            this.mainTabPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTabPage.Location = new System.Drawing.Point(4, 22);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabPage.Size = new System.Drawing.Size(792, 424);
            this.mainTabPage.TabIndex = 0;
            this.mainTabPage.Text = "Главная";
            // 
            // gameTabPage
            // 
            this.gameTabPage.BackgroundImage = global::PractWork8.Properties.Resources.пример_карты__3_;
            this.gameTabPage.Controls.Add(this.backButton);
            this.gameTabPage.Location = new System.Drawing.Point(4, 22);
            this.gameTabPage.Name = "gameTabPage";
            this.gameTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gameTabPage.Size = new System.Drawing.Size(792, 424);
            this.gameTabPage.TabIndex = 1;
            this.gameTabPage.Text = "Игра";
            this.gameTabPage.UseVisualStyleBackColor = true;
            this.gameTabPage.Click += new System.EventHandler(this.gameTabPage_Click);
            // 
            // leaderboardTabPage
            // 
            this.leaderboardTabPage.Controls.Add(this.dataGridView1);
            this.leaderboardTabPage.Controls.Add(this.backButton1);
            this.leaderboardTabPage.Location = new System.Drawing.Point(4, 22);
            this.leaderboardTabPage.Name = "leaderboardTabPage";
            this.leaderboardTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.leaderboardTabPage.Size = new System.Drawing.Size(792, 424);
            this.leaderboardTabPage.TabIndex = 2;
            this.leaderboardTabPage.Text = "Рекорды";
            this.leaderboardTabPage.UseVisualStyleBackColor = true;
            // 
            // manualTabPage
            // 
            this.manualTabPage.Controls.Add(this.label2);
            this.manualTabPage.Controls.Add(this.label1);
            this.manualTabPage.Controls.Add(this.backButton2);
            this.manualTabPage.Location = new System.Drawing.Point(4, 22);
            this.manualTabPage.Name = "manualTabPage";
            this.manualTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.manualTabPage.Size = new System.Drawing.Size(792, 424);
            this.manualTabPage.TabIndex = 3;
            this.manualTabPage.Text = "Справка";
            this.manualTabPage.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(320, 242);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(148, 43);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Играть";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // leaderboardButton
            // 
            this.leaderboardButton.Location = new System.Drawing.Point(320, 291);
            this.leaderboardButton.Name = "leaderboardButton";
            this.leaderboardButton.Size = new System.Drawing.Size(148, 43);
            this.leaderboardButton.TabIndex = 1;
            this.leaderboardButton.Text = "Таблица рекордов";
            this.leaderboardButton.UseVisualStyleBackColor = true;
            this.leaderboardButton.Click += new System.EventHandler(this.leaderboardButton_Click);
            // 
            // manualButton
            // 
            this.manualButton.Location = new System.Drawing.Point(320, 340);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(148, 43);
            this.manualButton.TabIndex = 2;
            this.manualButton.Text = "Справка";
            this.manualButton.UseVisualStyleBackColor = true;
            this.manualButton.Click += new System.EventHandler(this.manualButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(700, 390);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(84, 26);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // backButton1
            // 
            this.backButton1.Location = new System.Drawing.Point(700, 392);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(84, 26);
            this.backButton1.TabIndex = 1;
            this.backButton1.Text = "Назад";
            this.backButton1.UseVisualStyleBackColor = true;
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
            // 
            // backButton2
            // 
            this.backButton2.Location = new System.Drawing.Point(700, 392);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(84, 26);
            this.backButton2.TabIndex = 1;
            this.backButton2.Text = "Назад";
            this.backButton2.UseVisualStyleBackColor = true;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerColumn,
            this.scoreColumn});
            this.dataGridView1.Location = new System.Drawing.Point(262, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(247, 261);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // playerColumn
            // 
            this.playerColumn.HeaderText = "Игрок";
            this.playerColumn.Name = "playerColumn";
            // 
            // scoreColumn
            // 
            this.scoreColumn.HeaderText = "Счёт";
            this.scoreColumn.Name = "scoreColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сделал Дмитриенко Глеб, студент группы ПКС-95";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Преподаватель: Маломан Юлия Сергеевна";
            // 
            // MultitabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MultitabForm";
            this.Text = "MultitabForm";
            this.Load += new System.EventHandler(this.MultitabForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.mainTabPage.ResumeLayout(false);
            this.gameTabPage.ResumeLayout(false);
            this.leaderboardTabPage.ResumeLayout(false);
            this.manualTabPage.ResumeLayout(false);
            this.manualTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainTabPage;
        private System.Windows.Forms.TabPage gameTabPage;
        private System.Windows.Forms.TabPage leaderboardTabPage;
        private System.Windows.Forms.TabPage manualTabPage;
        private System.Windows.Forms.Button manualButton;
        private System.Windows.Forms.Button leaderboardButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button backButton1;
        private System.Windows.Forms.Button backButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}