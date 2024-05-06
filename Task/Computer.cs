using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Computer
    {
        int code;
        string brand;
        string processor;
        double frequency;
        int rAM;
        int volumeHardDisk;
        int memoryVideoCard;
        int price;
        int available;

        public Computer()
        {

        }

        public Computer(int code, string brand, string processor, double frequency, int rAM, int volumeHardDisk, int memoryVideoCard, int price, int available)
        {
            this.Code = code;
            this.Brand = brand;
            this.Processor = processor;
            this.Frequency = frequency;
            this.rAM = rAM;
            this.VolumeHardDisk = volumeHardDisk;
            this.MemoryVideoCard = memoryVideoCard;
            this.Price = price;
            this.Available = available;
        }

        public int Code { get => code; set => code = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Processor { get => processor; set => processor = value; }
        public double Frequency { get => frequency; set => frequency = value; }
        public int RAM { get => rAM; set => rAM = value; }
        public int VolumeHardDisk { get => volumeHardDisk; set => volumeHardDisk = value; }
        public int MemoryVideoCard { get => memoryVideoCard; set => memoryVideoCard = value; }
        public int Price { get => price; set => price = value; }
        public int Available { get => available; set => available = value; }

        public static void Print(List<Computer> computerList)
        {
            foreach(Computer computer in computerList)
            {
                Console.WriteLine($"{computer.Code} {computer.Processor} {computer.Frequency} {computer.RAM}"+
                    $" {computer.volumeHardDisk} {computer.MemoryVideoCard}, {computer.Price} {computer.Available}");
            }
        }
    }
}
