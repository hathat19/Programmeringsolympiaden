using System;
namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            //Färger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            //-------------------------------------------

            int N = 0;

            Console.WriteLine("N =");
            N = int.Parse(Console.ReadLine());
            int antalTreigaTal = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if ((j*(j+1)*(j+2) == i))
                    {
                        antalTreigaTal++;
                    }
                    else if (j * (j + 1) * (j + 2) > i)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Svar: " + antalTreigaTal);
        }
    }
}
/*Matematikern Lenore Oljer har gjort så mycket matte att hon har tröttnat på primtal.
Hon har nu börjat studera så kallade trevliga tripletter. Det är väldigt lätt att skapa en
trevlig triplett. Börja med ett heltal a som är större än noll och skapa sedan tripletten
(a, a + 1, a + 2). Alla tripletter som skapats på detta sätt är trevliga. Några exempel på
trevliga tripletter är (4, 5, 6) och (15, 16, 17).
För att lära sig mer om trevliga tripletter vill Lenore hitta hur många tal som kan
skrivas som produkten av alla talen i en trevlig triplett. Hon kallar dessa tal “treiga
tal”. Några exempel på treiga tal är 24 = 2 · 3 · 4 och 336 = 6 · 7 · 8. Lenore vill nu veta hur
många treiga tal det finns som är mindre än talet N.
Skriv ett program som läser in talet N och skriver ut hur många tal som är mindre än
N och är treiga.
Poängsättning:
De fem testfallen som vardera ger 1 poäng har följande begränsningar:
(1) N ≤ 25
(2) N ≤ 80
(3) N ≤ 1000
(4) N ≤ 105
(5) N ≤ 109

Körningsexempel 1
N ? 75
Svar: 3
Förklaring: De treiga talen mindre än 75 är 6, 24 och 60.
Körningsexempel 2
N ? 24
Svar: 1
Förklaring: Eftersom det treiga talet 24 inte är mindre än N räknar vi bara 6.
Körningsexempel 3
N ? 1234
Svar: 9*/