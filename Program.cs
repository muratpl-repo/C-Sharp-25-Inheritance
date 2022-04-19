using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66DersInharitance    //Inheritance - Kalitim
{
    class Program
    {
        class Hayvan
        {
            public int yas { get; set; }
            public void ortakOzellik()
            {
                Console.WriteLine("Hayvanlarin ortak fiilleri vardir");
            }
        }

        class Kedi : Hayvan // Hayvan sinifini miras aldik. Eger birden fazla siniftan miras almak isteseydik inheritance degil interface olmasi gerekirdi...
        {
            public string Miyavla()
            {
                return "Miyav!";
            }
        }

        class Kopek : Hayvan // Hayvan sinifini miras aldik.    EK NOT: Bu siniftan bir nesne olustururken, once miras aldigi siniftaki kodlar derlenir!!
        {
            public int ayakSayisi { get; set; }
            public string Havla()
            {   
                return "Hav hav!";
            }
        }
        static void Main(string[] args)
        {
            Kopek k1 = new Kopek();
            Kedi kedi1 = new Kedi();
            k1.yas = 12;
            k1.ayakSayisi = 4;
            kedi1.yas = 13;

            Console.WriteLine(k1.yas + " " + k1.ayakSayisi + " " + k1.Havla());
            Console.WriteLine(kedi1.yas + " " + kedi1.Miyavla());
            k1.ortakOzellik();
            kedi1.ortakOzellik();
        }
    }
}
