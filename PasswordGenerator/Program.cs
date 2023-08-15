using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The program is a simple password generator written in C#. It generates a random password of a specified length using a combination of uppercase letters, lowercase letters, digits, and symbols.

            Console.WriteLine("...Random Password Generator...\n");
            //Prompt user for Password length
            Console.Write("Enter the length of your password: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine(geek_Password(length));
            //Press any key to exit
            Console.ReadKey();
        }

        static char[] geek_Password(int len)
        {
            Console.Write("Your new password is: ");
            string Upper_Caps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string Lower_Caps = "abcdefghijklomnopqrstuvwxyz";
            string numbers = "0123456789";
            string symbols = "*!@#$%^&*()_+=/.?<>";
            
            string values = Upper_Caps + Lower_Caps + numbers + symbols;

            Random rand = new Random();
            char[] pass = new char[len];
            for (int i = 0; i < len; i++)
            {
                pass[i] = values[rand.Next(values.Length)];
            }
            return pass;
        }
    }
}
