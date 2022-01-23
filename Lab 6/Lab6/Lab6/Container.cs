using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Lab_5
{
    class Port : IEnumerable<Vehicle>
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public List<Vehicle> Vehicle
        {
            get
            {
                return vehicles;
            }
            set
            {
                vehicles = value;
            }

        }

        public Vehicle this[int index]
        {

            get
            {
                return vehicles[index];
            }

            set
            {
                vehicles[index] = value;
            }

        }

        public void Add(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void Remove(Vehicle vehicle)
        {
            vehicles.Remove(vehicle);
        }

        public void OnConsole()
        {
            foreach (var items in vehicles)
            {
                Console.WriteLine(items.ToString());
            }
        }
        public IEnumerator<Vehicle> GetEnumerator()
        {
            return vehicles.GetEnumerator();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)vehicles).GetEnumerator();
        }
    }
}

