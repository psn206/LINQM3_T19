using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computerList = new List<Computer>()
            {
                new Computer(1,"HP","intel",3.2,16,512,4,1000,20),
                new Computer(2,"HP","AMD",2.1,8,512,2,1050,40),
                new Computer(3,"DELL","intel",2.3,8,1024,6,2000,30),
                new Computer(4,"DELL","intel",2.3,8,128,2,1500,10),
                new Computer(5,"HUAWEI","intel",3.1,32,1024,6,1200,50),
                new Computer(6,"HUAWEI","intel",3.1,8,512,2,1500,70),
                new Computer(7,"HUAWEI","AMD",3.0,16,8,4,1600,40),
                new Computer(8,"Asus","AMD",2.8,8,1024,4,1900,10),
                new Computer(9,"Apple","M2",3.1,32,2048,6,2000,0),
                new Computer(10,"Asus","AMD",2.6,16,512,2,1400,35),
            };

            Console.WriteLine("Введите название процессора:");
            string processor = Console.ReadLine();
            List<Computer> computersProcessor = computerList.Where(x => x.Processor == processor).ToList();
            Computer.Print(computersProcessor);

            Console.WriteLine("Введите объем ОЗУ:");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Computer> computersRAM = computerList.Where(computer => computer.RAM >= ram).ToList();
            Computer.Print(computersRAM);

            Console.WriteLine("Сортировка цены");
            List<Computer> computersPriceSort = computerList.OrderBy(computer => computer.Price).ToList();
            Computer.Print(computersPriceSort);

            Computer cMax = computerList.OrderBy(computer => computer.Price).LastOrDefault();
            Computer cMin = computerList.OrderBy(computer => computer.Price).FirstOrDefault();

            List<Computer> minMaxPrice = new List<Computer>
            { cMax,cMin };
            Console.WriteLine("Минимальная и максимальная цена:");
            Computer.Print(minMaxPrice);

            Console.WriteLine("Есть ли хотя бы один компьютер в количестве не менее 30 штук?");
            Console.WriteLine(computerList.Any(computer => computer.Available >= 30));

            Console.ReadKey();

        }
    }
}
