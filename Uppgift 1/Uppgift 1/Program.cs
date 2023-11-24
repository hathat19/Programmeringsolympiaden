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

            string word = "";

            while (true)
            {
                Console.WriteLine("Vilket ord vill du upprepa?");
                word = Console.ReadLine();

                if (word.Length > 9)
                {
                    Console.WriteLine("Ordet får inte vara längre än 9 tecken.");
                    continue;
                }
                else
                {
                    break;
                }
            }


            Console.WriteLine("Hur många gånger ska ordet upprepas?");
            int repeat = int.Parse(Console.ReadLine());
            repeat = repeat > 9 ? 9 : repeat;

            Console.WriteLine("Svar:");
            for (int i = 0; i < repeat; i++)
            {
                Console.Write(word);
            }
        }
    }
}
/*Reduplikation är när man upprepar ett ord flera gånger, ofta för att förstärka eller ändra
betydelsen. I vissa språk som indonesiska är reduplikation väldigt vanligt, och där har
det många olika grammatiska funktioner. Även i svenska används reduplikation ibland,
till exempel är det vanligt att man säger "hej hej" istället för "hej".
Rama är en flitig användare av reduplikation när han chattar med sina kompisar. Han
skriver ibland samma ord upp till nio gånger, vilket tar lång tid. Därför brukar han
istället skriva ordet en gång, åtföljt av en siffra som visar hur många gånger ordet ska
upprepas.
Skriv ett program som läser in ett ord som Rama tänker upprepa (som består av som
mest 9 bokstäver) och hur många gånger det ska upprepas (som mest 9). Programmet
ska sedan skriva ut ordet upprepat rätt antal gånger.
Poängsättning: För testfall värda 1 poäng (utav 5 möjliga) gäller att antalet gånger
ordet ska upprepas är 1.

Körningsexempel 1
Ordet ? hej
Antal upprepningar ? 3
Svar: hejhejhej

Körningsexempel 2
Ordet ? ha
Antal upprepningar ? 4
Svar: hahahaha*/