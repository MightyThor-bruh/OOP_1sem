using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Vehicle
    {
        public int Displacement { get; set; }
        public int PlaceOnVehicles { get; }
        public int ID { get; set; }

        public Vehicle(int displacement, int placeOnVehicles, int id)
        {
            Displacement = displacement;
            PlaceOnVehicles = placeOnVehicles;
            ID = id;
        }

        public void Show()
        {
            Console.WriteLine($"{Displacement}, {PlaceOnVehicles}, {ID}");
        }
    }
}
