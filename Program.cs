using System;

namespace ACA_Homework_1_4
{
    class Program
    {
        static void f(string str)
        {
            string[] splitList = str.Split(new char[] { ' ', ',', '.' });
            string[] NewString = new string[splitList.Length];

            for (int i = 0; i < splitList.Length; i++)
            {
                if (splitList[i] != "")
                {
                    char first = splitList[i][0];
                    NewString[i] = splitList[i].Substring(1, splitList[i].Length - 1) + splitList[i].Substring(0, 1) + "ey";
                }
            }
            for (int i = 0; i < NewString.Length; i++)
            {
                Console.Write(NewString[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string please!");
            string str = Console.ReadLine();
            f(str);
        }
    }
}
