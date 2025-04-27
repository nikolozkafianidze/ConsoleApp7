using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Device : Product
    {
        protected uint _ram;

        public uint Ram { get =>  _ram; set => _ram = value;}

        public Device() 
        {
            Console.WriteLine("Device was created");
        }

        public Device(string Name, Brand Brand, decimal Price, uint Ram, uint Quantity, string Color, string Size) 
            : base(Name, Brand, Price, Quantity, Color, Size)
        {
            this._ram = Ram;
            Console.WriteLine("Device was created");
        }

        public void Print()
        {
            Console.WriteLine($"Ram = { Ram },");
        }

    }
}
