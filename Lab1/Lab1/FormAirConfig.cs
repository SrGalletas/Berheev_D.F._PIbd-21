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

        public FormAirConfig()
        {
            InitializeComponent();
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
                    air = new Air(100, 500, Color.White);
                    break;
                case "Аэробус":
                    air = new AirBus(100, 500, Color.White, Color.Black, true, true,
                    true);
                    break;
            }
            DrawAir();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}
