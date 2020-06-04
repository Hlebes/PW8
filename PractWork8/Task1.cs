using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWork8
{
    public partial class Task1 : Form
    {
        public int seconds = 0; // открытое поле с количеством тиков
        public Task1()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            gameTimer.Start(); // активирует таймер
            seconds++; // каждый тик прибавляет 1 к полю
            timeLabel.Text = $"{seconds / 60}:{seconds % 60}"; // выводит информацию о количестве "секунд" в формате 00:00
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            gameTimer.Start(); // активирует таймер
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            gameTimer.Stop(); // останавливает таймер
        }
    }
}
