using System.Collections;

namespace Week4_ovning4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool KeepRunning = true;
            while (KeepRunning) ;
            {
                //Implementera ett enkelt uppgiftshanteringssystem med Queue<string>.
                //I menyn ska användaren kunna:
                Console.WriteLine("Välkommen");
                Console.WriteLine("1: Lägga till nya uppgifter i kön(Enqueue).");
                Console.WriteLine("2: Visa nästa uppgift utan att ta bort den(Peek).");
                Console.WriteLine("3: Slutföra en uppgift – ta bort den översta(Dequeue) och visa vilken som slutförts.");
                Console.WriteLine("4: Visa alla återstående uppgifter i kön.");
                Console.WriteLine("5: För att avsluta");
                string UserMenySvar = Console.ReadLine()!;
                Queue<string> Uppgiftshanteringssystem = new Queue<string>();
                switch (UserMenySvar)
                {
                    case "1":
                    //➕ Lägga till nya uppgifter i kön(Enqueue).

                    break;
                        //👀 Visa nästa uppgift utan att ta bort den(Peek).
                        //✅ Slutföra en uppgift – ta bort den översta(Dequeue) och visa vilken som slutförts.
                        //📋 Visa alla återstående uppgifter i kön.

                        //💡 Tips:
                        //Använd while (queue.Count > 0) för att visa alla.
                        //Förklara skillnaden mellan Peek() och Dequeue().
                }

            }

            //Console.WriteLine("");
        }
    }
}
