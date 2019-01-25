using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Класс-ошибка "Если место, на которое хотим поставить самолёта уже занято"
    /// </summary>
    public class AirportOccupiedPlaceException : Exception
    {
        public AirportOccupiedPlaceException(int i) : base("На месте " + i + " уже стоит самолёт")
        { }
    }

}
