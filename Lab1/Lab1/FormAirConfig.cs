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
    public partial class FormAirConfig : Form
    {
        /// <summary>
        /// Переменная-выбранный самолёт
        /// </summary>
        ITransport air = null;

        /// <summary>
        /// Событие
        /// </summary>
        private event airDelegate eventAddAir;

        public FormAirConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown; buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        /// <summary>
        /// Отрисовать самолёт
        /// </summary>
        private void DrawAir()
        {
            if (air != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxAir.Width, pictureBoxAir.Height);
                Graphics gr = Graphics.FromImage(bmp);
                air.SetPosition(5, 5, pictureBoxAir.Width, pictureBoxAir.Height);
                air.DrawAir(gr);
                pictureBoxAir.Image = bmp;
            }
        }

        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(airDelegate ev)
        {
            if (eventAddAir == null)
            {
                eventAddAir = new airDelegate(ev);
            }
            else
            {
                eventAddAir += ev;
            }
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelAir_MouseDown(object sender, MouseEventArgs e)
        {
            labelAir.DoDragDrop(labelAir.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelAirBus_MouseDown(object sender, MouseEventArgs e)
        {
            labelAirBus.DoDragDrop(labelAirBus.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelAir_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void panelAir_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный самолёт":
                    air = new Air(100, 500, Color.Black);
                    break;
                case "Аэробус":
                    air = new AirBus(100, 500, Color.Gray, Color.Yellow, true, true,
                    true);
                    break;
            }
            DrawAir();
        }
        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
            DragDropEffects.Move | DragDropEffects.Copy);
        }



        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (air != null)
            {
                air.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawAir();
            }
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (air != null)
            {
                if (air is AirBus)
                {
                    (air as AirBus).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawAir();
                }
            }
        }

        /// <summary>
        /// Добавление машины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddAir_Click(object sender, EventArgs e)
        {
            eventAddAir?.Invoke(air);
            Close();
        }
    }
}
