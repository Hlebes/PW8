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
    public partial class AnimationForm : Form
    {
        int xSpeed = 5; // скорость по х (x<0: движение влево, x>0: движение вправо)
        int currentFrame = 0; // текущий кадр (номер рисунка)
        public AnimationForm()
        {
            InitializeComponent();
        }

        private void AnimationForm_Load(object sender, EventArgs e)
        {
            ChangeHeroImage(); // установка начального кадра
            heroTimer.Start(); // запуск таймера
        }

        private void ChangeHeroImage()
        {
            hero.Image = heroImageList.Images[currentFrame];
            if (xSpeed > 0) // проверка, что герой движется вправо
            {
                hero.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
        }

        private void heroTimer_Tick(object sender, EventArgs e)
        {
            // проверка столкновения с левой или правой границей формы
            if (hero.Location.X + xSpeed < 0 ||
            hero.Location.X + xSpeed + hero.Width > this.Width)
            {
                xSpeed = -xSpeed;// смена вектора движения при столкновении с краем формы
            }
            // изменение положения героя на форме
            hero.Location = new Point(hero.Location.X + xSpeed, hero.Location.Y);
            // смена текущего кадра
            currentFrame = currentFrame != 1 ? 1 : 2;
            ChangeHeroImage();
        }
    }
}
