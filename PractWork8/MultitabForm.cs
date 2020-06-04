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
    public partial class MultitabForm : Form
    {
        public MultitabForm()
        {
            InitializeComponent();
        }

        private void MultitabForm_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = mainTabPage; // при загрузке активируется главная вкладка
            tabControl1.Appearance = TabAppearance.FlatButtons; // устанавливается вид плоских кнопок
            tabControl1.ItemSize = new Size(0, 1); // изменяется размер вкладок
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = gameTabPage; // переход на игровую вкладку при нажатии
        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = leaderboardTabPage; // переход на вкладку рекордов при нажатии
        }

        private void manualButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = manualTabPage; // переход на справочную вкладку при нажатии
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = mainTabPage; // переход на главную вкладку при нажатии
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = mainTabPage; // переход на главную вкладку при нажатии
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = mainTabPage; // переход на главную вкладку при нажатии
        }

        private void gameTabPage_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
