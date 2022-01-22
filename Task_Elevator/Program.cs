using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задание лифт
//в лифт заходит N человек (число N вводится с клавиатуры пользователем) 
//у лифта есть грузоподъемность - она должна быть рандомной от 100 до 500 кг. 
//средний вес человека указывается пользователем с клавиатуры
//выводится значение:
//если все помещаются, то пишет " все поместились" 
//если не поместились то писало " выкиньте одного"










namespace Task_Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int PersonsCount;
            int AvarageWeight;

            Console.WriteLine("Введите количество человек:");
            PersonsCount = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВведите средний вес человека:");
            AvarageWeight = int.Parse(Console.ReadLine());

            Console.WriteLine(Elevator.GetResult(PersonsCount, AvarageWeight)); // выводим результат

            Console.ReadLine();








        }
    }
}
