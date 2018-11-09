using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormAir : Form
    {
        private ITransport air;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormAir()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод отрисовки аэробуса
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAir.Width, pictureBoxAir.Height);
            Graphics gr = Graphics.FromImage(bmp);
            air.DrawAir(gr);
            pictureBoxAir.Image = bmp;
        }
        /// <summary>/// Обработка нажатия кнопки "Создать самолёт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonCreateAir_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            air = new Air(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
            air.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAir.Width,
            pictureBoxAir.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать аэробус"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateAirBus_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            air = new AirBus(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
            Color.Gray, true, true, true);
            air.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAir.Width,
            pictureBoxAir.Height);
            Draw();
        }
            /// <summary>
            /// Обработка нажатия кнопок управления
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    air.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    air.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    air.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    air.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
