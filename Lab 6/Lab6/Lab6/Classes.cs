using System;
using Lab6.Exceptions;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Printer
    {
        public void iAmPrinting(Vehicle someobj)
        {
            Console.WriteLine("Тип объекта = " + someobj.ToString());
        }
    }

    abstract class Vehicle
    {
        public int Displacement { get; set; }
        public int PlaceOnVehicles { get; set; }
        public int ID { get; set; }
        public int AgeOfCaptain { get; set; }
        protected int numOfVehicles = 0;
        public override string ToString() => "Vehicle";

        enum vehicle
        {
            Sailboat, 
            Steamer, 
            Corvette
        }

        struct Boat
        {
            public string number;
            public int cap;

            public void Print()
            {
                Console.WriteLine($"Порядок: {number}  Капитан: {cap}");
            }
        }

        public Vehicle(int ageOfCaptain, int id, int placeOnVehicles, int displacement)
        {
            AgeOfCaptain = ageOfCaptain;
            ID = id;
            PlaceOnVehicles = placeOnVehicles;
            Displacement = displacement;
        }
        public virtual void Ride(int number)
        {
            if (number < 0)
                throw new RideException("Вы не можете прокатиться на стольких видах транспорта", number);
            Debug.Assert(number < 50);
            Console.WriteLine($"Вы прокатились на {number} видах транспорта");
        }
        public abstract void ToSit();
        public void GetVehicles() => Console.WriteLine($"Всего {numOfVehicles} транспорта вида {ToString()}");
    }

    sealed class Ship : Vehicle
    {
        public Ship(int ageOfCaptain, int id, int placeOnVehicles, int displacement) : base(ageOfCaptain, id, placeOnVehicles, displacement)
        {

        }
        public override string ToString() => "Ship";
        public override void ToSit() => Console.WriteLine("Вы сели на корабль", numOfVehicles += 1);


    }

    class Boat : Vehicle
    {
        public override string ToString() => "Boat";
        public override void ToSit() => Console.WriteLine("Вы сели в лодку", numOfVehicles += 1);

        public Boat(int ageOfCaptain, int id, int placeOnVehicles, int displacement) : base(ageOfCaptain, id, placeOnVehicles, displacement)
        {

        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;
            Boat other = (Boat)obj;
            return (numOfVehicles == other.numOfVehicles);
        }

        public override int GetHashCode()
        {
            return DateTime.Now.Millisecond;
        }

    }

    class Steamer : Boat, ICaptain
    {
        public Steamer(int ageOfCaptain, int id, int placeOnVehicles, int displacement) : base(ageOfCaptain, id, placeOnVehicles, displacement)
        {

        }
        public override string ToString() => "Steamer";
        public override void ToSit() => Console.WriteLine("Вы сели на пароход", numOfVehicles += 1);
        public void Wheel() => Console.WriteLine("Вы взялись за штурвал парохода");
        public void Steer() => Console.WriteLine("Вы управляете штурвалом");
    }

    class Sailboat : Boat, ICaptain
    {
        public Sailboat(int ageOfCaptain, int id, int placeOnVehicles, int displacement) : base(ageOfCaptain, id, placeOnVehicles, displacement)
        {

        }
        public override string ToString() => "Sailboat";
        public override void ToSit() => Console.WriteLine("Вы сели на парусник", numOfVehicles += 1);
        public void Wheel() => Console.WriteLine("Вы взялись за штурвал парусника");
        public void Steer() => Console.WriteLine("Вы управляете штурвалом");
    }
    class Corvette : Boat, IWarship
    {
        public Corvette(int ageOfCaptain, int id, int placeOnVehicles, int displacement) : base(ageOfCaptain, id, placeOnVehicles, displacement)
        {

        }
        public override string ToString() => "Corvette";
        public override void ToSit() => Console.WriteLine("Вы сели на корвет (abstract)", numOfVehicles += 1);
        void IWarship.ToSit() => Console.WriteLine("Вы сели на корвет (interface)", numOfVehicles += 1);
        public void Wheel() => Console.WriteLine("Вы взялись за штурвал корвета");
        public void Shoot() => Console.WriteLine("Вы стреляете из пушки");
    }

}
