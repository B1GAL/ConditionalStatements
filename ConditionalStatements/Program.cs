using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your lucky # (whole number) >>");
            string answer = Console.ReadLine();
            int luckyNbr = Convert.ToInt32(answer);

            bool isAnswerAInteger = int.TryParse(answer, out luckyNbr);

            if (isAnswerAInteger == false)
            {

                Console.WriteLine("Sorry that was an incorrect number. Goodbye ");
                Environment.Exit(-1);
            }

            

            int remainder = luckyNbr % 7; 
            
            if (remainder == 0)
            {
                Console.WriteLine($"{luckyNbr.ToString("N0")} is really a lucky number !!!");

            }
            else if (luckyNbr % 13 == 0)
            {
                Console.WriteLine($"{luckyNbr.ToString("N0")} is really an unlucky number :( ");
            }
            else 
            {
                Console.WriteLine($"meh......{luckyNbr.ToString("N0")} ");
            }

            Console.WriteLine("what is your first name >>");
            string name = Console.ReadLine();

            switch (name)
            {
                case "alex":
                    Console.WriteLine("Thats a good name");
                    break;

           


            }


        }
    }
}
