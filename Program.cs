using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COWS_and_BULLS____Y9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random(); 
            int num1 = random.Next(0, 10);
            int num2 = random.Next(0, 10);
            int num3 = random.Next(0, 10);
            int num4 = random.Next(0, 10);


            while (num1 == num2 || num1 == num3 || num1 == num4 || num2 == num3 || num2 == num4 || num3 == num4)

            {
                num1 = random.Next(0, 10);
                num2 = random.Next(0, 10);
                num3 = random.Next(0, 10);
                num4 = random.Next(0, 10);
            }

            string stringNUM1 = Convert.ToString(num1);
            string stringNUM2 = Convert.ToString(num2);
            string stringNUM3 = Convert.ToString(num3);
            string stringNUM4 = Convert.ToString(num4);

            string NumTOguess = (stringNUM1 + stringNUM1 + stringNUM1 + stringNUM1);

            Console.WriteLine("THIS IS COWS AND BULLS!");
            Console.WriteLine("ENTER GUESS:");


            string USERguess = Console.ReadLine();
            if (USERguess.Length != 4)
            {
                Console.WriteLine("INVALID GUESS: WRONG LENGTH");
            }
            else if (USERguess[0] == USERguess[1] || USERguess[0] == USERguess[2] || USERguess[0] == USERguess[3] || USERguess[1] == USERguess[2] || USERguess[1] == USERguess[3] || USERguess[2] == USERguess[3])

            {
                Console.WriteLine("INVALID GUESS: REPEATING DIGITS");
            }
            else
            {
                int cows = 0;
                int bulls = 0;


                if (USERguess[0] == NumTOguess[0] || USERguess[1] == NumTOguess[1] || USERguess[2] == NumTOguess[2] || USERguess[3] == NumTOguess[3])
                {
                    bulls++;
                }



                if (USERguess[0] == NumTOguess[1] || USERguess[0] == NumTOguess[2] || USERguess[0] == NumTOguess[3])

                {
                    cows++;
                }
                else if (USERguess[1] == NumTOguess[0] || USERguess[1] == NumTOguess[2] || USERguess[1] == NumTOguess[3])
                {
                    cows++;
                }
                else if (USERguess[2] == NumTOguess[0] || USERguess[2] == NumTOguess[1] || USERguess[2] == NumTOguess[3])
                {
                    cows++;
                }
                else if (USERguess[3] == NumTOguess[0] || USERguess[3] == NumTOguess[1] || USERguess[3] == NumTOguess[2])
                {
                    cows++;
                }



               ;

                Console.WriteLine("Number of cows:" + " " + cows + "Number of bulls" + " " + bulls);




                if (bulls == 4)
                {
                    Console.WriteLine("CONGRATULATIONS!");
                }
                else
                {
                    Console.WriteLine("TRY AGAIN:");
                }
















            }
        }













    }
}


