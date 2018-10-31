﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Direction
{
    Up,
    Down,
    Left,
    Right
}

namespace Lab1
{
    class AirBus
    {
        /// <summary>
        /// Левая координата отрисовки аэробуса
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки аэробуса
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        ///Высота окна отрисовки
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки аэробуса
        /// </summary>
        private const int airWidth = 130;
        /// <summary>
        /// Высота отрисовки аэробуса
        /// </summary>
        private const int airHeight = 60;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес аэробуса
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>/// Основной цвет кузова
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия турбин
        /// </summary>
        public bool DownTurb { private set; get; }
        /// <summary>
        /// Признак наличия крыльев
        /// </summary>
        public bool SideSpoiler { private set; get; }
        /// <summary>
        /// Признак наличия хвоста
        /// </summary>
        public bool BackSpoiler { private set; get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес аэробуса</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="downTurb">Признак наличия турбины</param>
        /// <param name="sideSpoiler">Признак наличия боковых спойлеров</param>
        /// <param name="backSpoiler">Признак наличия заднего спойлера</param>
        public AirBus(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
        downTurb, bool sideSpoiler, bool backSpoiler)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            DownTurb = downTurb;
            SideSpoiler = sideSpoiler;
            BackSpoiler = backSpoiler;
        }
        /// <summary>
        /// Установка позиции аэробуса
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
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
        /// <summary>
        /// Отрисовка аэробуса
        /// </summary>
        /// <param name="g"></param>
        public void DrawAirBus(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            // отрисуем сперва турбины (чтобы потом отрисовка крыльев на них "легла") 
            Brush brGray = new SolidBrush(MainColor);

            if (DownTurb)
            {
                Brush black = new SolidBrush(Color.Black);

                g.FillRectangle(black, _startPosX + 15, _startPosY - 5, 15, 10);
                g.FillRectangle(brGray, _startPosX + 17, _startPosY - 2, 11, 4);
                g.FillRectangle(black, _startPosX + 15, _startPosY + 43, 15, 10);
                g.FillRectangle(brGray, _startPosX + 17, _startPosY + 46, 11, 4);
            }
            //крылья
            if (SideSpoiler)
            {
                Pen gray = new Pen(Color.Gray, 10);
                g.DrawLine(gray, _startPosX + 20, _startPosY - 20, _startPosX + 45, _startPosY + 25);
                g.DrawLine(gray, _startPosX + 20, _startPosY + 65, _startPosX + 45, _startPosY + 25);
            }
            // теперь отрисуем основной кузов аэробуса

            Pen grayPen = new Pen(Color.Gray, 10);
            g.DrawEllipse(pen, _startPosX - 5, _startPosY + 15, 100, 20);
            g.FillEllipse(brGray, _startPosX - 5, _startPosY + 15, 100, 20);

            //хвост
            g.DrawLine(grayPen, _startPosX - 15, _startPosY, _startPosX, _startPosY + 25);


            // рисуем окна аэробуса
            if (BackSpoiler)
            {
                Brush spoiler = new SolidBrush(Color.Blue);

                g.FillEllipse(spoiler, _startPosX + 15, _startPosY + 20, 10, 10);
                g.DrawEllipse(pen, _startPosX + 15, _startPosY + 20, 10, 10);
                g.FillEllipse(spoiler, _startPosX + 30, _startPosY + 20, 10, 10);
                g.DrawEllipse(pen, _startPosX + 30, _startPosY + 20, 10, 10);
                g.FillEllipse(spoiler, _startPosX + 45, _startPosY + 20, 10, 10);
                g.DrawEllipse(pen, _startPosX + 45, _startPosY + 20, 10, 10);
                g.FillEllipse(spoiler, _startPosX + 60, _startPosY + 20, 10, 10);
                g.DrawEllipse(pen, _startPosX + 60, _startPosY + 20, 10, 10);

                Pen white = new Pen(Color.White, 3);
                g.DrawLine(white, _startPosX + 80, _startPosY + 20, _startPosX + 90, _startPosY + 25);

            }
        }
    }
}
