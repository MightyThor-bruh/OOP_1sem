using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_
{
    public class SYILog
    {
        public void Search()
        {
            string curTimeLong = DateTime.Now.ToLongTimeString();
            using (StreamWriter sw = new StreamWriter(@"D:\Стандартные папки\Рабочий стол\У(ч)ёба\ООП\Lab 13\Lab13_\Lab13_\SYIlogfile.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine("File created time : " + curTimeLong);
            }
        }
    }
}
