using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Accessory : Product
    {
        private string _wireless;

        public string Wireless { get => _wireless; set => _wireless = value; }

        public Accessory()
        {
            Console.WriteLine("Accessory was created");
        }

        public Accessory(string Name, Brand Brand, decimal Price, uint Quantity, string Wireless, string Color, string Size)
            : base(Name, Brand, Price, Quantity, Color, Size)
        {
            this._wireless = Wireless;
            Console.WriteLine("Accessory was created");
        }

        public void Print()
        {
            Console.WriteLine($"Usage = { Wireless }");
        }
    }
}
