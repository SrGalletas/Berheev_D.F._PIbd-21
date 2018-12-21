using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Класс-ошибка "Если не найден аэробус по определенному месту"
    /// </summary>
    public class AirportNotFoundException : Exception
    {
        public AirportNotFoundException(int i) : base("Не найден автомобиль по месту " + i)
        { }
    }
}
