using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Класс-ошибка "Если на аэродроме уже заняты все места"
    /// </summary>
    class AirportOverflowException : Exception
    {
        public AirportOverflowException() : base("На аэродроме нет свободных мест")
        { }
    }
}
