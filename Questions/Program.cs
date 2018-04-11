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

            //ReadFromExcel.Read();


            List<Pytanie> listaPytaaaan = new List<Pytanie>();
            listaPytaaaan = ReadFromExcel.Read();

            for (int i = 0; i < listaPytaaaan.Count(); i++)
            {
                listaPytaaaan[i].WyswietlPytanie();
            }

            //listaPytaaaan.Add(new Pytanie(1, "Dupa", "Aaa", "Bbb", "Ccc", "Ddd", "0010101"));
            // ReadFromExcel.Read.listaPytaaaan();

            Console.WriteLine("\n\n\nWciśnij klawisz aby zamknąć program");
            Console.ReadKey();      // czeka na wcisniecie jakiegokolwiek klawisza (tu zatrzymuje program przez natychmiastowym zamknieciem go

            


        }
    }
}
