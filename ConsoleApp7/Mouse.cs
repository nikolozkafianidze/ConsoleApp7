using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp7
{
    internal class Mouse : Accessory
    {
        public Mouse()
        {
            Console.WriteLine("Mouse was created");
        }

        public Mouse(string Name, Brand Brand, decimal Price, uint Quantity, string Color, string Wireless, string Size)
            : base(Name, Brand, Price, Quantity, Wireless, Color, Size)
        {
            Console.WriteLine("Mouse was created");
        }

        public void Print()
        {
            Console.WriteLine($"Name = {Name}, Price = {Price}, Brand = {Brand}, Quantity = {Quantity}, Color = {Color}, Size = {Size}, Wireless = { Wireless } ");
        }
    }
}
