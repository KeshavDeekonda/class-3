using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            // what grade you got in this class. number between 1 and 100
            Console.WriteLine("press enter your marks");
            {
                Console.WriteLine("please enter your marks");
                string input = Console.ReadLine();
                int score = int.Parse(input);
                string lettergrade = Getthegrade(score);
                Console.WriteLine(lettergrade);
            }
        }//end of main
        private static string Getthegrade(int score)
        {
            string lettergrade = "";
            if (score >= 95 & score <= 100)
            {
                lettergrade = "A+";

            }
            else if (score>=90 && score <95)
            {
                lettergrade = "A";
            }
            else if(score >=87 && score < 90)
            {
                lettergrade = "A-";
            }
            else if (score >= 84 && score < 87)
            {
                lettergrade = "B+";
            }
            else if (score >= 80 && score < 84)
            {
                lettergrade = "B";
            }
            else if (score >= 77 && score < 80)
            {
                lettergrade = "B-";
            }
            else if (score >= 74 && score < 77)
            {
                lettergrade = "C+";
            }
            else if (score >= 70 && score < 74)
            {
                lettergrade = "C";
            }
            else if (score >= 67 && score < 70)
            {
                lettergrade = "C-";
            }
            else if(score >= 63 && score < 67)
            {
                lettergrade = "D+";
            }
            else if (score >= 60 && score < 63)
            {
                lettergrade = "D";
            }
            else if (score < 60)
            {
                lettergrade = "F";
            }
            
                return lettergrade;

        }

    }
}
