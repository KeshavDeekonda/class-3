using System;

namespace inclass_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age between 18 and 100");
            try
            {
                string age = Console.ReadLine();
                int age = int.Parse(age);
                if (age >= 17 && age < 100)
                {


                }

            }//end of try

            catch
            {


            }//end of catch
        }
    }
}
