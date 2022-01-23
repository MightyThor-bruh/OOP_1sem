using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Пароход-------------");
            Steamer steamer = new Steamer();
            steamer.ToSit();
            steamer.GetVehicles();
            steamer.ToSit();
            steamer.ToSit();
            steamer.GetVehicles();
            steamer.Ride(3);
            if (steamer is Vehicle)
            {
                Console.WriteLine($"{steamer} is a vehicle");
            }

            Console.WriteLine("-----------Корвет-------------");
            Corvette corvette = new Corvette();
            IWarship corvette_2 = corvette;
            corvette_2.ToSit();
            corvette.ToSit();
            corvette.GetVehicles();
            corvette.Wheel();
            corvette.Shoot();

            Console.WriteLine("-----------Парусник-------------");
            Sailboat sailboat = new Sailboat();
            sailboat.ToSit();
            sailboat.ToSit();
            sailboat.Ride(2);
            sailboat.Wheel();
            sailboat.Steer();

            Printer printer = new Printer();
            printer.iAmPrinting(corvette);

            CollectionType<string> obj1 = new CollectionType<string>();
            IGeneric<string> a;
            obj1.Add("bye ");
            obj1.Add("adyos ");
            obj1.Add("sayonara ");
            a = obj1;
            a.Show();

            CollectionType<Vehicle> plnt = new CollectionType<Vehicle>();
            plnt.Add(new Steamer());
            plnt.Add(new Sailboat());
            plnt.Add(new Steamer());
            plnt.Show();

            Console.WriteLine("\n");
            CollectionType<Vehicle> obj2 = new CollectionType<Vehicle>();
            ParseFile(obj2);
            obj2.Show();

            obj2.WriteFile(obj2);
        }
    }
}
