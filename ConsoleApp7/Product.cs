using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    enum Brand { Apple, LG, Sony, Samsung }
    internal class Product
    {
        protected string _name;
        protected decimal _price;
        protected Brand _brand;
        protected uint _quantity;
        protected string _color;
        protected string _size;

        public string Name { get { return _name; } set { _name = value; } }

        public decimal Price { get => _price; }

        public Brand Brand { get => _brand; set => _brand = value; }

        public uint Quantity { get => _quantity; set => _quantity = value; }

        public string Color {  get => _color;}

        public string Size { get => _size;}

        public Product() 
        {
            Console.WriteLine("Product was created");
        }

        public Product(string Name, Brand Brand, decimal Price, uint Quantity, string Color, string Size)
        {
            this._name = Name;
            this._price = Price;
            this._brand = Brand;
            this._quantity = Quantity;
            this._color = Color;
            this._size = Size;
            Console.WriteLine("Product was created");
        }

        public void Print()
        {
            Console.WriteLine($"Name = { Name }, Price = { Price }, Brand = { Brand }, Quantity = { Quantity }, Color = { Color }, Size = { Size } ");
        }
    }
}
