using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1
{
    public class AirBus : Air
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия турбин
        /// </summary>
        public bool Turbines { private set; get; }
        /// <summary>
        /// Признак наличия крыльев
        /// </summary>
        public bool Wings { private set; get; }
        /// <summary>
        /// Признак наличия хвоста
        /// </summary>
        public bool Tail { private set; get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес аэробуса</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="turbines">Признак наличия турбины</param>
        /// <param name="wings">Признак наличия крыльев</param>
        /// <param name="tail">Признак наличия хвоста</param>
        public AirBus(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
        turbines, bool wings, bool tail) :
            base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Turbines = turbines;
            Wings = wings;
            Tail = tail;
        }
     
        /// <summary>
        /// Отрисовка аэробуса
        /// </summary>
        /// <param name="g"></param>
        public override void DrawAir(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            // отрисуем сперва турбины (чтобы потом отрисовка крыльев на них "легла") 
            Brush brGray = new SolidBrush(MainColor);

            if (Turbines)
            {
                Brush black = new SolidBrush(Color.Black);

                g.FillRectangle(black, _startPosX + 15, _startPosY - 5, 15, 10);
                g.FillRectangle(brGray, _startPosX + 17, _startPosY - 2, 11, 4);
                g.FillRectangle(black, _startPosX + 15, _startPosY + 43, 15, 10);
                g.FillRectangle(brGray, _startPosX + 17, _startPosY + 46, 11, 4);
            }
            //крылья
            if (Wings)
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
            if (Tail)
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
