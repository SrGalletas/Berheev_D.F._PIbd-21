using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Класс-ошибка "Если на парковке уже есть самолёт с такими же характеристиками"
    /// </summary>
    class AirportAlreadyHaveException : Exception
    {
        public AirportAlreadyHaveException() : base("В аэропорту уже есть такой самолёт")
        { }
    }
}
