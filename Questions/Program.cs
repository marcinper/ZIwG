using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nic nie robie caly dzien. Sprawdzam czy to dziala");

            // lista obiektow Pytanie, wczytanie do niej pytan z Excela i wyswietlenie wszystkich pytan
            //List<Pytanie> listaPytaaaan = new List<Pytanie>();
            //listaPytaaaan = ReadFromExcel.Read();

            //for (int i = 0; i < listaPytaaaan.Count(); i++)
            //{
            //    listaPytaaaan[i].WyswietlPytanie();
            //}

            //ExportToPdf.ExportPdf(listaPytaaaan);     // zrobic tak ze przekazuje mu liste pytan a on sam to generuje
            ExportToPdf.ExportPdf();


            Console.WriteLine("\n\n\nWciśnij klawisz aby zamknąć program");
            Console.ReadKey();      // czeka na wcisniecie jakiegokolwiek klawisza (tu zatrzymuje program przez natychmiastowym zamknieciem go
        }
    }
}
