using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1
{
    public class AirBus : Air, IComparable<AirBus>, IEquatable<AirBus>
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

        public AirBus(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Turbines = Convert.ToBoolean(strs[4]);
                Wings = Convert.ToBoolean(strs[5]);
                Tail = Convert.ToBoolean(strs[6]);
            }
        }

        /// <summary>
        /// Отрисовка аэробуса
        /// </summary>
        /// <param name="g"></param>
        public override void DrawAir(Graphics g)
        {
            Pen pen = new Pen(DopColor);
            // отрисуем сперва турбины (чтобы потом отрисовка крыльев на них "легла") 
            Brush brGray = new SolidBrush(MainColor);

            if (Turbines)
            {
                Brush black = new SolidBrush(Color.Black);

                g.FillRectangle(black, _startPosX + 28, _startPosY + 10, 18, 10);
                g.FillRectangle(black, _startPosX + 28, _startPosY + 53, 19, 10);

            }
            //крылья
            if (Wings)
            {
                Pen gray = new Pen(Color.Gray, 10);
                g.DrawLine(gray, _startPosX + 33, _startPosY, _startPosX + 63, _startPosY + 35);
                g.DrawLine(gray, _startPosX + 35, _startPosY + 73, _startPosX + 63, _startPosY + 35);
            }


            Pen grayPen = new Pen(DopColor, 10);

            //хвост
            g.DrawLine(grayPen, _startPosX, _startPosY + 10, _startPosX + 15, _startPosY + 35);

            // теперь отрисуем основной кузов аэробуса
            g.DrawEllipse(pen, _startPosX + 8, _startPosY + 27, 113, 18);
            g.FillEllipse(brGray, _startPosX + 8, _startPosY + 27, 113, 18);




            // рисуем окна аэробуса
            if (Tail)
            {
                Brush spoiler = new SolidBrush(Color.Blue);

                g.FillEllipse(spoiler, _startPosX + 35, _startPosY + 30, 10, 10);
                g.DrawEllipse(pen, _startPosX + 35, _startPosY + 30, 10, 10);
                g.FillEllipse(spoiler, _startPosX + 50, _startPosY + 30, 10, 10);
                g.DrawEllipse(pen, _startPosX + 50, _startPosY + 30, 10, 10);
                g.FillEllipse(spoiler, _startPosX + 65, _startPosY + 30, 10, 10);
                g.DrawEllipse(pen, _startPosX + 65, _startPosY + 30, 10, 10);
                g.FillEllipse(spoiler, _startPosX + 80, _startPosY + 30, 10, 10);
                g.DrawEllipse(pen, _startPosX + 80, _startPosY + 30, 10, 10);

                Pen white = new Pen(Color.White, 3);
                g.DrawLine(white, _startPosX + 103, _startPosY + 30, _startPosX + 113, _startPosY + 37);

            }
        }
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Turbines + ";" +
            Wings + ";" + Tail;
        }
        /// <summary>
        /// Метод интерфейса IComparable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(AirBus other)
        {
            var res = (this is Air).CompareTo(other is Air);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Turbines != other.Turbines)
            {
                return Turbines.CompareTo(other.Turbines);
            }
            if (Wings != other.Wings)
            {
                return Wings.CompareTo(other.Wings);
            }
            if (Tail != other.Tail)
            {
                return Tail.CompareTo(other.Tail);
            }

            return 0;
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(AirBus other)
        {
            var res = (this as Air).Equals(other as Air);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Turbines != other.Turbines)
            {
                return false;
            }
            if (Wings != other.Wings)
            {
                return false;
            }
            if (Tail != other.Tail)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            AirBus airObj = obj as AirBus;
            if (airObj == null)
            {
                return false;
            }
            else
            {
                return Equals(airObj);
            }
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
