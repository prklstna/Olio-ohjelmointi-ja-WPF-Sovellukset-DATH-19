using System;

namespace Harjoitus5_Laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;                   
            string operation;
            int answer;


            Console.Write("Ensimmäinen numero: ");
            firstNum = Convert.ToInt32(Console.ReadLine());

        
            Console.Write("Toinen numero: ");
            secondNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ok nyt laskun tyyppi ( x , / , +, -) ");
            operation = Console.ReadLine();

            if (operation == "x")
            {
                answer = firstNum * secondNum;
                Console.WriteLine(firstNum + " x " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "/")
            {
                answer = firstNum / secondNum;
                Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            
            else if (operation == "+")
            {
                answer = firstNum + secondNum;
                Console.WriteLine(firstNum + " + " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "-")
            {
                answer = firstNum - secondNum;
                Console.WriteLine(firstNum + " - " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ei ole oikea formaatti! Käynnistä uudelleen!");     
                Console.ReadLine();
            }
        }
    }
}
