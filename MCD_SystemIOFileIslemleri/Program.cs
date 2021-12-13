using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MCD_SystemIOFileIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {

            //bool kontrol = File.Exists("c:\\NetworkAkademi\\merhaba.txt");
            //if (kontrol)
            //{
            //    Console.WriteLine("Belirtmiş olduğunuz dosya sistem içerisinde bulunmaktadır.");
            //}
            //else
            //{
            //    FileCreate("c:\\NetworkAkademi\\merhaba.txt");
            //}

            Console.ReadLine();


        }

        static void FileCreate(string path)
        {
            FileStream Fs = File.Create(path);
            Fs.Close();
        }

        static string FileReadAllText(string path)
        {
            string metinDegeri = File.ReadAllText(path);
            return metinDegeri;
        }


    }
}
