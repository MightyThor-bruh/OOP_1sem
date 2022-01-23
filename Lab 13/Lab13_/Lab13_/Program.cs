using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SYIDiskInfo diskInfo = new SYIDiskInfo();
                diskInfo.DiskInfo();

                SYIFileInfo file = new SYIFileInfo();
                file.FileData("D:\\Стандартные папки\\Рабочий стол\\У(ч)ёба\\Дизайн и юзабилити\\Лаб 9\\9.docx");

                SYIDirInfo dirInfo = new SYIDirInfo();
                dirInfo.DirInfo("D:\\Стандартные папки\\Рабочий стол\\У(ч)ёба\\Дизайн и юзабилити\\Лаб 9");

                SYIFileManager fileManager = new SYIFileManager();
                fileManager.SYI("D:\\");


                Console.WriteLine("Folders SYI, SYIFiles will be deleted");
                if (Console.ReadKey().KeyChar == 'y')
                {
                    Directory.Delete("D:\\SYIInspect", true);
                    Directory.Delete("D:\\SYIFiles", true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
    }
}
