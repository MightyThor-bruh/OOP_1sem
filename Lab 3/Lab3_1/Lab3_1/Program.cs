using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
   

    class Program
    {
        static void Main(string[] args)
        {

            Lot kek = new Lot();
            kek.Add(4);
            kek.Add(5);
            kek.Add(6);
            Lot dww = new Lot(11111, 13);
            Lot wdd = new Lot(32, 534, 331456);
            dww.Max();
            wdd.Max();
            wdd.Print();
            dww.Print();
            Lot.AboutDate(); //вызов статика
            kek.ToString();
            kek.number = 2;
            Console.Write(kek.number);
            kek.Partial();

        }
    }
} 
