using System.Collections;

namespace Week4_ovning4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> Uppgiftshanteringssystem = new Queue<string>();
            bool KeepRunning = true;
            while (KeepRunning)
            {
                //Implementera ett enkelt uppgiftshanteringssystem med Queue<string>.
                //I menyn ska användaren kunna:
                Console.Clear();
                Console.WriteLine("Välkommen");
                Console.WriteLine("1: Lägga till nya uppgifter i kön(Enqueue).");
                Console.WriteLine("2: Visa nästa uppgift utan att ta bort den(Peek).");
                Console.WriteLine("3: Slutföra en uppgift – ta bort den översta(Dequeue) och visa vilken som slutförts.");
                Console.WriteLine("4: Visa alla återstående uppgifter i kön.");
                Console.WriteLine("5: För att avsluta");
                string UserMenySvar = Console.ReadLine()!;
                switch (UserMenySvar)
                {
                    case "1":
                        //➕ Lägga till nya uppgifter i kön(Enqueue).
                        Console.WriteLine("Fyll i uppgifter");
                        string UserInputUppgifter = Console.ReadLine()!;
                        Uppgiftshanteringssystem.Enqueue(UserInputUppgifter);
                    break;
                    case "2":
                        if (Uppgiftshanteringssystem.Count == 0)
                        {
                            Console.WriteLine("Kön är tom.");
                        }
                        else
                        {
                            //👀 Visa nästa uppgift utan att ta bort den(Peek).
                            Console.WriteLine(Uppgiftshanteringssystem.Peek());
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                        }
                    break;
                    case "3":
                        //✅ Slutföra en uppgift – ta bort den översta (Dequeue) och visa vilken som slutförts.
                        if (Uppgiftshanteringssystem.Count == 0)
                        {
                            Console.WriteLine("Kön är tom.");
                        }
                        else
                        {
                            Console.WriteLine($"Tar bort: {Uppgiftshanteringssystem.Peek()}");//Peek visar översta utan att ta bort/Slutför uppgiften
                            string FirstUppgift = Uppgiftshanteringssystem.Dequeue();//Deque tar bort/ slutför uppgiften.
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                        }
                        break;
                    case "4":
                        if (Uppgiftshanteringssystem.Count == 0)
                        {
                            Console.WriteLine("Kön är tom.");
                        }
                        else
                        {
                            foreach (var Uppgifter in Uppgiftshanteringssystem)
                            {
                                //📋 Visa alla återstående uppgifter i kön.
                                Console.WriteLine($"{Uppgifter}");
                            }
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                        }
                        break;
                    case "5":
                        KeepRunning = false;
                    break;

                        //💡 Tips:
                        //Använd while (queue.Count > 0) för att visa alla.
                        //Förklara skillnaden mellan Peek() och Dequeue().
                }

            }

            //Console.WriteLine("");
        }
    }
}
