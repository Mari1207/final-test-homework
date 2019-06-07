using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_final_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            getGreatestValue();

            Console.ReadKey();

        }
        public static decimal getGreatestValue()
        {
            int greatestVal = 0;

            Console.WriteLine("Enter the Quiz score");
            int val1 = 0;
            int.TryParse(Console.ReadLine().ToString(), out val1);

            Console.WriteLine("");

            Console.WriteLine("Enter Mid score");
            int val2 = 0;
            int.TryParse(Console.ReadLine().ToString(), out val2);

            Console.WriteLine("");

            Console.WriteLine("Enter Final score");
            int val3 = 0;
            int.TryParse(Console.ReadLine().ToString(), out val3);

            Console.WriteLine("");

            int[] arTempt = new int[3];
            arTempt[0] = val1;
            arTempt[1] = val2;
            arTempt[2] = val3;
            Array.Sort(arTempt);



            //1.process for chosing the greatest value
            if (val1 > val2)
                if (val3 > val1)
                    greatestVal = val3;
                else greatestVal = val1;
            else
            {

                if (val3 > val2)
                    greatestVal = val3;
                else
                    greatestVal = val2;

            }
            Console.WriteLine("Greatest Values is  " + greatestVal.ToString());

            //2.Average
            decimal average = (val1 + val2 + val3) / 3;
            Console.WriteLine("");
            Console.WriteLine("Average grade is " + average.ToString());
            //Grade
            decimal averagepar = average;
            Console.WriteLine("");
            Console.WriteLine("Average score is " + averagepar.ToString("N2") + "%");


            if (averagepar >= 90)
            {
                Console.WriteLine("Grade A");
            }
            if (averagepar >= 70 && averagepar < 90)
            {
                Console.WriteLine("Grade B");

            }
            if (averagepar >= 50 && averagepar < 70)
            {
                Console.WriteLine("Grade C");

            }
            if (averagepar < 50)
            {
                Console.WriteLine("Grade F");
            }


            //3.Find digit
            int i = val1;
            int Numlength = i.ToString().Length;
            Console.WriteLine("");

            Console.WriteLine("The number of Quiz score's digit is   " + Numlength.ToString());
            //4.


            //5.
           /* char c;
            string input;
            string.Format(Console.ReadLine().ToString(),out );
            c = (char)input;*/

                                 
            return greatestVal;

        }
        


    


    


    }

}

