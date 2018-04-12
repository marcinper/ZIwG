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
            List<Pytanie> wszystkiePytania = new List<Pytanie>();
            wszystkiePytania = ReadFromExcel.Read();

            // wyswietlenie wszystkich pytan (dla sprawdzenia czy dziala poprawnie)
            //for (int i = 0; i < wszystkiePytania.Count(); i++)
            //{
            //    wszystkiePytania[i].WyswietlPytanie();
            //}

            // generowanie pliku *.pdf z pytaniami do testu (wczytanymi z Excela)
            ExportToPdf.GenerateTest(wszystkiePytania);       // TO BEDZIE DZIALAC JAK TO OPRACUJEMY
            /*
            ExportToPdf.GeneratePDF(wszystkiePytania);

            //do testow stworzono idTestu I nemeTest, potem "idTestu" bedzie zwracane z bazy a uzytkownik bedzie podawal "nameTest"
            int TestID = 15;
            string nameTest = "Przykladowy TestName";

            // generowanie klucza odpowiedzi do pliku *.csv, zeby potem ten plik wczytac do bazy danych
            GenerateCSV.Generate(wszystkiePytania, TestID, nameTest);
            */
            Console.WriteLine("\n\n\nWciśnij klawisz aby zamknąć program");
            //Console.ReadKey();      // czeka na wcisniecie jakiegokolwiek klawisza (tu zatrzymuje program przez natychmiastowym zamknieciem go
        }
    }
}
