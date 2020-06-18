using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Instance.Log("Singleton implemented");


            //LINQ
            var rng = new Random();
            var numbers = Enumerable.Range(0, 5).Select(n => rng.Next());

            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
