using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building();
            MultiBuilding multiBuilding = new MultiBuilding();
            building.Print();
            multiBuilding.Print();
        }
    }
    class Building
    {
        public string Address { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Building()
        {

        }
        public Building(string a, int l, int w, int h)
        {
            Address = a;
            Length = l;
            Width = w;
            Height = h;
        }
        public void Print()
        {
            string a = Console.ReadLine();
            int l = Convert.ToInt32(Console.ReadLine());
            int w = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(l);
            Console.WriteLine(w);
            Console.WriteLine(h);
            Console.ReadKey();
        }
    }
    sealed class MultiBuilding : Building
    {
        public int Floor { get; set; }
        public MultiBuilding(string a, int l, int w, int h, int f)
        : base(a, l, w, h)
        {
            Floor = f;
        }
        public MultiBuilding()
        {

        }
        public new void Print()
        {
            base.Print();
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}
