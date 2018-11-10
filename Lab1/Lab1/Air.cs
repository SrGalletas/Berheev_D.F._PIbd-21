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
        protected const int carWidth = 130;
        /// <summary>
        /// Ширина отрисовки аэробуса
        /// </summary>
        protected const int carHeight = 60;
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
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
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
                    if (_startPosY + step < _pictureHeight - carHeight)
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
            g.DrawLine(gray, _startPosX + 30, _startPosY, _startPosX + 55, _startPosY + 40);
            g.DrawLine(gray, _startPosX + 30, _startPosY + 80, _startPosX + 55, _startPosY + 40);

            // теперь отрисуем основной кузов аэробуса
            Pen grayPen = new Pen(Color.Gray, 10);
            g.DrawEllipse(pen, _startPosX, _startPosY + 20, 100, 15);
            g.FillEllipse(brGray, _startPosX, _startPosY + 20, 100, 15);

            //хвост
            g.DrawLine(grayPen, _startPosX - 15, _startPosY, _startPosX, _startPosY + 25);
            
            // рисуем окно аэробуса
            Pen white = new Pen(Color.White, 3);
            g.DrawLine(white, _startPosX + 80, _startPosY + 20, _startPosX + 90, _startPosY + 25);
        }
    }
}
