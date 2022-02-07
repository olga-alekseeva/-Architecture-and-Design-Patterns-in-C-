using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Alekseeva_Homework_Lesson1
{
    class Program : ProgramBase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте вас приветствует математическая программа");
            Console.WriteLine("Пожалуйста, введите число. ");
            String userNumber = Console.ReadLine();

            if (userNumber == "q")
            {
                return;
            }
            int enteredNumber = Int32.Parse(userNumber);
            ProgramBase programBase = new ProgramBase();
            int Result = programBase.Factorial(enteredNumber);
            int maxEvenNumber = 0;
            int sum = 0;
            for (int i = 0; i<= enteredNumber; i++)
            {
                sum = sum + i;
                if (i % 2 == 0 && i < enteredNumber)
                {
                    maxEvenNumber = i;
                }
            }

            Console.WriteLine("Факториал равен " + Result); 
            Console.WriteLine("Сумма от 1 до N равна " + sum);
            Console.WriteLine("Максимальное четное число меньше N равно " + maxEvenNumber);
            Console.ReadLine();
        }
    }
}
