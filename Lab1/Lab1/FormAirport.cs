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
    public partial class FormAirport : Form
    {
        /// <summary>
        /// Объект от класса многоуровневой парковки
        /// </summary>
        MultiLevelParking airport;

        /// <summary>
        /// Форма для добавления
        /// </summary>
        FormAirConfig form;

        /// <summary>
        /// Количество уровней-парковок
        /// </summary>
        private const int countLevel = 5;

        public FormAirport()
        {
            InitializeComponent();
            airport = new MultiLevelParking(countLevel, pictureBoxParking.Width,
            pictureBoxParking.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт
             //не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементуlistBox)
                Bitmap bmp = new Bitmap(pictureBoxParking.Width,
                pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                airport[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeAir_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    var air = airport[listBoxLevels.SelectedIndex] -
                    Convert.ToInt32(maskedTextBox.Text);
                    if (air != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeAir.Width, pictureBoxTakeAir.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        air.SetPosition(5, 5, pictureBoxTakeAir.Width,
                        pictureBoxTakeAir.Height);
                        air.DrawAir(gr);
                        pictureBoxTakeAir.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeAir.Width,
                        pictureBoxTakeAir.Height);
                        pictureBoxTakeAir.Image = bmp;
                    }
                    Draw();
                }
            }
        }
        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void buttonSetAir_Click_1(object sender, EventArgs e)
        {
            form = new FormAirConfig();
            form.AddEvent(AddAir);
            form.Show();
        }


        /// <summary>
        /// Метод добавления самолёта
        /// </summary>
        /// <param name="car"></param>
        private void AddAir(ITransport air)
        {
            if (air != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = airport[listBoxLevels.SelectedIndex] + air;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Самолёт не удалось поставить");
                }
            }
        }
    }
}
