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


            FileAppendText("c:\\NetworkAkademi\\merhaba.txt", "Merhaba TXT");
            string metinDegeri = FileReadAllText("c:\\NetworkAkademi\\merhaba.txt");
            Console.WriteLine(metinDegeri);

            //FileCopy("c:\\NetworkAkademi\\merhaba.txt", "c:\\NetworkAkademi\\merhaba2.txt");
            //FileMove("c:\\NetworkAkademi\\merhaba2.txt", "c:\\NetworkAkademi2\\merhaba2.txt");

            FileDelete("c:\\NetworkAkademi2\\merhaba2.txt");


            Console.ReadLine();
        }

        static void FileCreate(string path)
        {
            FileStream Fs = File.Create(path);
            Fs.Close();
        }

        static void FileDelete(string path)
        {
            File.Delete(path);
        }

        static void FileMove(string kaynak, string hedef)
        {
            File.Move(kaynak, hedef);
        }

        static void FileCopy(string kaynak, string hedef)
        {
            File.Copy(kaynak, hedef);
        }

        static void FileAppendText(string path, string deger)
        {
            File.AppendAllText(path, deger);
        }

        static string FileReadAllText(string path)
        {
            string metinDegeri = File.ReadAllText(path);
            return metinDegeri;
        }


    }
}
