using System.Collections;

namespace Week4_ovning4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> Uppgiftshanteringssystem = new Queue<string>();
            bool KeepRunning = true;
            while (KeepRunning)//hej
            {
                //Implementera ett enkelt uppgiftshanteringssystem med Queue<string>.
                Klasser.Meny();             
                string UserMenySvar = Console.ReadLine()!;
                if ((UserMenySvar == "2" || UserMenySvar == "3" || UserMenySvar == "4") && Uppgiftshanteringssystem.Count == 0)
                {
                    Klasser.OmQueTom(UserMenySvar, Uppgiftshanteringssystem);
                    continue;
                }
                switch (UserMenySvar)
                {
                    case "1"://➕ Lägga till nya uppgifter i kön(Enqueue).
                        Klasser.Enqueue(Uppgiftshanteringssystem);
                    break;
                    case "2"://👀 Visa nästa uppgift utan att ta bort den(Peek).
                        Klasser.Peak(Uppgiftshanteringssystem);
                    break;
                    case "3"://✅ Slutföra en uppgift – ta bort den översta (Dequeue) och visa vilken som slutförts.
                        Klasser.Dequeue(Uppgiftshanteringssystem);
                    break;
                    case "4"://📋 Visa alla återstående uppgifter i kön.
                        Klasser.ShowAll(Uppgiftshanteringssystem);
                        break;
                    case "5":
                        KeepRunning = false;
                    break;
                    default:
                        Console.WriteLine("Icke giltigt alternativ");
                        break;
                }

            }

            //Console.WriteLine("");
        }
    }
}
