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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void taskoneFormButton_Click(object sender, EventArgs e)
        {
            Form form = new Task1();
            form.Show();
        }

        private void animationFormButton_Click(object sender, EventArgs e)
        {
            Form form = new AnimationForm();
            form.Show();
        }

        private void mutitabFormButton_Click(object sender, EventArgs e)
        {
            Form form = new MultitabForm();
            form.Show();
        }

        private void generationFormButton_Click(object sender, EventArgs e)
        {
            Form form = new GenerationForm();
            form.Show();
        }
    }
}
