using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int len = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a string: ");
            string str = Convert.ToString(Console.ReadLine());

            string output = "";
         
            string series = ""; string cur_char = "";

            for (int i = 0; i < str.Length; i++)
            {

                if (i == 0 || cur_char != str[i].ToString())
                {
                    series = str[i].ToString();
                    cur_char = str[i].ToString();
                    output = output + cur_char;
                }
                else if (series.Length < len)
                {
                    series = series + str[i].ToString();
                    output = output + cur_char;
                }
            }
            Console.Write("The Output String is : " + output);
            Console.ReadLine();
        }
    }
}
