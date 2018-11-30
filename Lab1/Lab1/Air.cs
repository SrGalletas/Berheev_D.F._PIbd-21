using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Air : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки аэробуса
        /// </summary>
        protected const int airWidth = 130;
        /// <summary>
        /// Ширина отрисовки аэробуса
        /// </summary>
        protected const int airHeight = 60;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес аэробуса</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public Air(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public Air(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - airWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - airHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawAir(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brGray = new SolidBrush(MainColor);
            //крылья
            Pen gray = new Pen(Color.Gray, 10);
            g.DrawLine(gray, _startPosX + 40, _startPosY, _startPosX + 65, _startPosY + 40);
            g.DrawLine(gray, _startPosX + 40, _startPosY + 75, _startPosX + 65, _startPosY + 40);

            //хвост
            Pen grayPen = new Pen(Color.Gray, 10);
            g.DrawLine(grayPen, _startPosX, _startPosY + 7, _startPosX + 15, _startPosY + 32);

            // теперь отрисуем основной кузов аэробуса
          
            g.DrawEllipse(pen, _startPosX + 10, _startPosY + 25, 100, 20);
            g.FillEllipse(brGray, _startPosX + 10, _startPosY + 25, 100, 20);

                       
            // рисуем окно аэробуса
            Pen white = new Pen(Color.White, 3);
            g.DrawLine(white, _startPosX + 96, _startPosY + 31, _startPosX + 105, _startPosY + 36);
        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
    }
}
