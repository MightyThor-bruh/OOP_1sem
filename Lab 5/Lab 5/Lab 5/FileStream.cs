using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_5
{
    partial class Program
    {
        public static void ParseFile(CollectionType<Vehicle> objColl)
        {
            using (StreamReader stream = new StreamReader(@"D:\Стандартные папки\Рабочий стол\У(ч)ёба\ООП\Lab 5\Lab 5\Lab 5\lab5.txt"))
            {
                while (stream.ReadLine() is string line)
                {
                    switch (line)
                    {
                        case "Steamer":
                            objColl.Add(new Steamer());
                            break;
                        case "Ship":
                            objColl.Add(new Ship());
                            break;
                        case "Sailboat":
                            objColl.Add(new Sailboat());
                            break;
                        case "Corvette":
                            objColl.Add(new Corvette());
                            break;
                    }
                }
            }
        }
    }

    partial class CollectionType<T>
    {
        public void WriteFile(CollectionType<Vehicle> objColl)
        {
            List<Vehicle> res = objColl.list;
            using (StreamWriter write = new StreamWriter(@"D:\Стандартные папки\Рабочий стол\У(ч)ёба\ООП\Lab 5\Lab 5\Lab 5\Write.txt"))
            {
                foreach (Vehicle item in res)
                {
                    write.WriteLine(item);
                }
            }
        }
    }
}
