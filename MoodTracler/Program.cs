using System;

namespace MoodTracker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Muuttujat mielialan ja kunnon tallentamiseen
            int uni;
            int vireys;
            int nalka;
            int moodIndex;

            Console.WriteLine("Hyvää huomenta, miltä sinusta tuntuu tänään?");
            Console.WriteLine("______________________________________________");
            Console.WriteLine();

            Console.WriteLine("😴 Miten hyvin nukuit? 1-5: 1:Huonosti, 5:Kuin tukki");
            uni = int.Parse(Console.ReadLine());

            Console.WriteLine("😀 Arvoi vireyttäsi, 1-5: 1:Unelias, 5:Täynnä räjähtävää toimintatarmoa");
            vireys = int.Parse(Console.ReadLine());

            Console.WriteLine("🍕 Miten nälkäinen olet? 1-5: 1:Kaamea nälkä, 5:Ei muruakaan");
            nalka = int.Parse(Console.ReadLine());
            Console.WriteLine("______________________________________________");
            moodIndex = vireys + uni + nalka;

            Console.WriteLine("Mielialaindeksisi on:" + moodIndex);

            if (uni == 5 & vireys == 5 & nalka == 5)
            {
                Console.WriteLine("🌟 Vaikutat olevan tiptop kunnossa!");
                Console.ReadLine();
            }
            else if (uni < 3)
            {
                Console.WriteLine("🙁 Voi ei! Yritä nukkua paremmin");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}