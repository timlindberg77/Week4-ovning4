using System;
using System.Collections.Generic;
using System.Text;

namespace Week4_ovning4
{
    public class Klasser
    {
        public static void Meny()
        {
            //I menyn ska användaren kunna:
            Console.Clear();
            Console.WriteLine("Välkommen");
            Console.WriteLine("1: Lägga till nya uppgifter i kön(Enqueue).");
            Console.WriteLine("2: Visa nästa uppgift utan att ta bort den(Peek).");
            Console.WriteLine("3: Slutföra en uppgift – ta bort den översta(Dequeue) och visa vilken som slutförts.");
            Console.WriteLine("4: Visa alla återstående uppgifter i kön.");
            Console.WriteLine("5: För att avsluta");
        }
        public static void OmQueTom(string UserMenySvar, Queue<string> Uppgiftshanteringssystem)
        {
            Console.WriteLine("Kön är tom. Lägg till en uppgift först.");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

        }
        public static void Enqueue(Queue<string> Uppgiftshanteringssystem)
        {
            //➕ Lägga till nya uppgifter i kön(Enqueue).
            Console.WriteLine("Fyll i uppgifter");
            string UserInputUppgifter = Console.ReadLine()!;
            Uppgiftshanteringssystem.Enqueue(UserInputUppgifter);
        }
        public static void Peak(Queue<string> Uppgiftshanteringssystem)
        {

                //👀 Visa nästa uppgift utan att ta bort den(Peek).
                Console.WriteLine(Uppgiftshanteringssystem.Peek());
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();

        }
        public static void Dequeue(Queue<string> Uppgiftshanteringssystem)
        {
            //✅ Slutföra en uppgift – ta bort den översta (Dequeue) och visa vilken som slutförts.

                Console.WriteLine($"Tar bort: {Uppgiftshanteringssystem.Peek()}");//Peek visar översta utan att ta bort/Slutför uppgiften
                string FirstUppgift = Uppgiftshanteringssystem.Dequeue();//Deque tar bort/ slutför uppgiften.
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
        }
        public static void ShowAll(Queue<string> Uppgiftshanteringssystem)
        {
                foreach (var Uppgifter in Uppgiftshanteringssystem)
                {
                    //📋 Visa alla återstående uppgifter i kön.
                    Console.WriteLine($"{Uppgifter}");
                }
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
        }
    }
}
