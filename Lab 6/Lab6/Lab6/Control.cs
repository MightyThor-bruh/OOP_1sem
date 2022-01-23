using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    class ControlOfPort
    {
        private Port port;

        public void YoungCaptainsVehicles()
        {
            foreach (var items in port)
            {
                if (items.AgeOfCaptain < 35)
                {
                    Console.WriteLine(items.ToString() + " ID судна " + items.ID);
                }
            }
        }

        public void AverageOfPlacesOnStreamers()
        {
            int counter = 0;
            int number = 0;
            foreach (var items in port)
            {
                Type type = items.GetType();
                if (type.Name == "Steamer")
                {

                    counter += items.PlaceOnVehicles;
                    number++;
                }

            }
            Console.WriteLine("Среднее количество мест " + counter / number);
        }

        public void AverageDiaplacement()
        {
            int counter = 0;
            int number = 0;
            foreach (var items in port)
            {
                counter += items.Displacement;
                number++;
            }
            Console.WriteLine("Среднее водоизмещение в всех парусников в порту " + counter / number);
        }
        public ControlOfPort(Port port)
        {
            this.port = port;
        }


    }
}

