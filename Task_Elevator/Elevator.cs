using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Elevator
{
    internal class Elevator
    {
        public static string GetResult (int PersonsCount, int AvarageWeight)
        {
            var rnd = new Random();
            var LoadCapacity = rnd.Next(100, 900);                                      // грузоподъемность 
            double LoadCapacityReserv = LoadCapacity - (PersonsCount * AvarageWeight);  // резерв грузоподъмности, или соттвественно перегруз
            double PersonsReserv = LoadCapacityReserv / AvarageWeight;                  // резерв грузоподъемности в людях 

            if (LoadCapacityReserv >= AvarageWeight) //если лифт вмещает этих людей и остается место как минимум для одного человека
            {       
                return $"\nГрузоподъемность лифта = {LoadCapacity} кг.\nЛифт сможет перевезти {PersonsCount} человек.\n" +
                    $"Места хватит еще на {Math.Truncate(PersonsReserv)} человек."; //округляем число отбрасывая значение после точки  

            }
            if (LoadCapacity >= 0 && LoadCapacity < AvarageWeight) // если грузоподъемности хватает но больше человек не влезет
            {
                return $"\nГрузоподъемность лифта = {LoadCapacity} кг.\nЛифт сможет перевезти максимум {PersonsCount} человека.";
            }
            else   // если грузоподъемности не хватает
            {
                return $"\nГрузоподъемность лифта = {LoadCapacity} кг.\nЛифт не сможет перевезти {PersonsCount} человек.\n" +
                    $"{-Math.Floor(PersonsReserv)} человек должны покинуть лифт для начала движения."; 
                //PersonsReserv округляем до наименьшего целого числа, поскольку тут PersonsReserv - число отрицательное
            }
        }
    }
}
