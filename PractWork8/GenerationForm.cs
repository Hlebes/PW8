using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PractWork8
{
    public partial class GenerationForm : Form
    {
        public GenerationForm()
        {
            InitializeComponent();
        }

        private void GenerationForm_Load(object sender, EventArgs e)
        {

        }

        private void openDialogButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) // используем поток для чтения
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "txt files|*.txt"; // фильтр файлов в формате txt
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    int X = 0; // кол-во полей по горизонтали
                    int Y = 0; // кол-во полей по вертикали
                    using (StreamReader reader = new StreamReader(openFile.FileName))
                    {
                        string result = ""; // инициализируем строку чтения строки из файла
                        while ((result = reader.ReadLine()) != null) // цикл чтения каждой строки в файле
                        {
                            X = (result.Split(' ')).Length; // находим ширину полей
                            Y++; // к каждой строке прибавляем строку с полями
                        }
                    }
                    int cellSize = 30; // устанавливаем размер полей
                    for (int x = 1; x <= X; x++) // цикл по столбцам
                    {
                        for (int y = 1; y <= Y; y++) // цикл по строкам
                        {
                            Panel cell = new Panel(); // создаём новое поле
                            cell.Width = cellSize; // устанавливаем ширину
                            cell.Height = cellSize; // устанавливаем высоту
                            cell.Location = new Point(x * cellSize, y * cellSize); // перемещаем поле на нужное место
                            cell.BorderStyle = BorderStyle.FixedSingle; // устанавливаем стиль границы обрамления
                            this.Controls.Add(cell); // добавление поля в коллекцию элементов управления
                        }
                    }
                }
            }
        }
    }
}