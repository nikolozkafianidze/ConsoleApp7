using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Laptop : Device
    {
        public Laptop() 
        {
            Console.WriteLine("Laptop was created");
        }

        public Laptop(string Name, Brand Brand, decimal Price, uint Ram, uint Quantity, string Color, string Size)
            : base(Name, Brand, Price, Ram, Quantity, Color, Size)
        {
            Console.WriteLine("Laptop was created");
        }

        public void Print()
        {
            Console.WriteLine($"Name = {Name}, Price = {Price}, Brand = {Brand}, Ram = {Ram}, Quantity = {Quantity}, Color = {Color}, Size = {Size} ");
        }

    }
}
