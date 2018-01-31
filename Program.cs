using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_VowTrue
{
    class Program
    {
        static void Main(string[] args)

        {
            /*Write a function that receives a character and returns true if the 
              character is a vowel and false otherwise.*/

            char[] vow = { 'A', 'E', 'I', 'O', 'U' };       //set an array, remember flower brackets
            vow[0] = 'A';
            vow[1] = 'E';
            vow[2] = 'I';
            vow[3] = 'O';
            vow[4] = 'U';

            Console.WriteLine("Enter Character");
            char x = Convert.ToChar(Console.ReadLine());        //converting array to unicode 

            Console.WriteLine(isVow(x));        //call method

            Console.Read();                     //allow visiual of input and results 
        }

        static bool isVow (char x)
        {
            if (x == 'A' || x == 'E' || x == 'I' || x == 'O' || x == 'U')       //method behavior 
            {
                return true;
            }

            else
                return false;
        }
        
    } 
}

