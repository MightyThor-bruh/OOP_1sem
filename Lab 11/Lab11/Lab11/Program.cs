using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] month = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            var stringLength = from q1 in month
                               where q1.Length == 6
                               select q1;

            var monthReturn = from q2 in month
                              where q2 == "June" || q2 == "July" || q2 == "August"
                              || q2 == "January" || q2 == "December" || q2 == "February"
                              select q2;

            var monthAlphabet = from q3 in month
                                orderby q3 ascending
                                select q3;

            var lengthAndU = (from q4 in month
                              where q4.Contains("u") && q4.Length >= 4
                              select q4).Count();

            Console.WriteLine("First request:");
            foreach (string i in stringLength)
            {
                Console.Write($"   {i}");
            }
            Console.WriteLine("\n\nSecond request:");
            foreach (string i in monthReturn)
            {
                Console.Write($"   {i}");
            }
            Console.WriteLine("\n\nThird request:");
            foreach (string i in monthAlphabet)
            {
                Console.Write($"   {i}");
            }
            Console.WriteLine($"\n\nFourth request: {lengthAndU}");
            Console.ReadLine();
            Console.ReadLine();
            Console.Clear();

            List<Lot> lots = new List<Lot>();
            Lot ewe = new Lot(2, 12, 12, 12, 12);
            lots.Add(new Lot(12, 124, 16, 7, 98));
            lots.Add(new Lot(121, 141, 20, 141, 48));
            lots.Add(new Lot(45, 14, 76, 17, 8));
            lots.Add(new Lot(-45, 124, 41, 17, 8));
            lots.Add(new Lot(18, 19, 20, 14, 48));
            lots.Add(ewe);



            var sequene = (from n in lots
                           where n.lot1 + n.lot2 + n.lot3 + n.lot4 + n.lot5 > 300
                           select n).Max();
            Console.WriteLine(sequene.lot1 + " " + sequene.lot2 + " " + sequene.lot3 + " " + sequene.lot4 + " " + sequene.lot5);


            IEnumerable<Lot> sequeneTwo = from n1 in lots
                                          where n1.lot1 < 0 || n1.lot2 < 0 || n1.lot3 < 0 || n1.lot4 < 0 || n1.lot5 < 0
                                          select n1;
            Console.WriteLine("\nМножества с отрицательными элементами: ");

            foreach (var n1 in sequeneTwo)
            {
                n1.Priint();
            }
            var sequeneThree = (from n2 in lots
                                where n2.lot1 == 17 || n2.lot2 == 17 || n2.lot3 == 17 || n2.lot4 == 17 || n2.lot5 == 17
                                select n2).Count();
            Console.WriteLine("\n\nКоличество множеств, содержащих заданное значение: " + sequeneThree);

            var sequeneFour = (from n4 in lots
                               where n4.lot1 == 17 || n4.lot2 == 17 || n4.lot3 == 17 || n4.lot4 == 17 || n4.lot5 == 17
                               select n4).First();

            Console.WriteLine("\nПервое множество с заданным элементом:");
            Console.WriteLine(sequeneFour.lot1 + " " + sequeneFour.lot2 + " " + sequeneFour.lot3 + " " + sequeneFour.lot4 + " " + sequeneFour.lot5);

            var sequeneFier = from n5 in lots
                              orderby n5.lot1
                              select n5;
            Console.WriteLine("\nУпорядоченный массив множеств по первому элементу:");
            foreach (var k in sequeneFier)
            {
                k.Priint();
            }

            List<int> nums = new List<int>() { 1, 54, 42, 12, 23, 64, 37 };
            var res2 = nums.OrderBy(i => i).Take(4).Skip(1).Where(i => i > 20).Aggregate((x, y) => x + y);

            Console.WriteLine(res2);
        }
    }
}
