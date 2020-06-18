using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionFactory
{
    interface IShape
    {
        double Area { get; }
    }

    public class Circle : IShape
    {
        public double Area { get { return 5;} }
    }

    public class Square : IShape
    {
        public double Area { get { return 8; } }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Factory.Regester<Circle>("circle");
            Factory.Regester<Square>("square");

            var circle = Factory.Create<Circle>("circle");
            var someShape = Factory.Create<IShape>("circle");

            var square = Factory.Create<IShape>("square");
            var someOtherShape = Factory.Create<IShape>("circle");


            Console.WriteLine(square.Area);
            Console.WriteLine(someOtherShape.Area);
        }
    }
}
