using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Owner
    {
        private readonly int id;
        private readonly string fio;

        public Owner(int id, string fio)
        {
            this.id = id;
            this.fio = fio;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Owner – ID: {id}, FIO: {fio}.");
        }
    }
}
