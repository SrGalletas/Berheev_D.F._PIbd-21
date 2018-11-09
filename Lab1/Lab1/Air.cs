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
            //границы автомобиля
            g.DrawEllipse(pen, _startPosX, _startPosY, 20, 20);
            g.DrawEllipse(pen, _startPosX, _startPosY + 30, 20, 20);
            g.DrawEllipse(pen, _startPosX + 70, _startPosY, 20, 20);
            g.DrawEllipse(pen, _startPosX + 70, _startPosY + 30, 20, 20);
            g.DrawRectangle(pen, _startPosX - 1, _startPosY + 10, 10, 30);
            g.DrawRectangle(pen, _startPosX + 80, _startPosY + 10, 10, 30);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY - 1, 70, 52);
            //задние фары
            Brush brRed = new SolidBrush(Color.Red);
            g.FillEllipse(brRed, _startPosX, _startPosY, 20, 20);
            g.FillEllipse(brRed, _startPosX, _startPosY + 30, 20, 20);
            //передние фары
            Brush brYellow = new SolidBrush(Color.Yellow);
            g.FillEllipse(brYellow, _startPosX + 70, _startPosY, 20, 20);
            g.FillEllipse(brYellow, _startPosX + 70, _startPosY + 30, 20, 20);
            //кузов
            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX, _startPosY + 10, 10, 30);
            g.FillRectangle(br, _startPosX + 80, _startPosY + 10, 10, 30);
            g.FillRectangle(br, _startPosX + 10, _startPosY, 70, 50);
            //стекла
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, _startPosX + 60, _startPosY + 5, 5, 40);
            g.FillRectangle(brBlue, _startPosX + 20, _startPosY + 5, 5, 40);
            g.FillRectangle(brBlue, _startPosX + 25, _startPosY + 3, 35, 2);
            g.FillRectangle(brBlue, _startPosX + 25, _startPosY + 46, 35, 2);
            //выделяем рамкой крышу
            g.DrawRectangle(pen, _startPosX + 25, _startPosY + 5, 35, 40);
            g.DrawRectangle(pen, _startPosX + 65, _startPosY + 10, 25, 30);
            g.DrawRectangle(pen, _startPosX, _startPosY + 10, 15, 30);
        }
    }
}
