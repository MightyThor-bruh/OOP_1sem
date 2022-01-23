using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionType<int> collectInt = new CollectionType<int>();
            CollectionType<float> collectFloat = new CollectionType<float>();
            CollectionType<string> collectString = new CollectionType<string>();

            collectInt.Add(5);
            collectInt.Add(100);
            collectInt.Add(200);
            collectInt.Delete(1);
            collectInt.Show();

            CollectionType<Vehicle> collectVehicle = new CollectionType<Vehicle>();

            collectVehicle.Add(new Vehicle(1920, 2000, 3));

            Console.ReadKey();
        }
    }
}
