using System;

namespace class_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a integer value between 1 & 20");
            try
            {
                // variable to gather data from user input
                string input = Console.ReadLine();
                // variable to be used to perform various iterative statements
                int value_of_input = int.Parse(input);
                // for user input between 1 & 5, execute for loop:
                if ((value_of_input >0) && (value_of_input <= 5))
                {
                    Console.WriteLine("executing a For Loop");
                    Console.WriteLine("the for loop will iterate" + value_of_input.ToString());

                    // for loop:
                    for ( int i=0; i < value_of_input; i++)
                    {
                        Console.WriteLine("the value of the variable i in this iteration is:");
                    }

                    Console.WriteLine("press any key to exit the program...");
                    // pause the program and await the user to press a key to end the program
                    Console.ReadKey(true);
                } //end of if stmt

                else if ((value_of_input>5) && (value_of_input<= 10))
                {
                    Console.WriteLine("executing a while loop");
                    Console.WriteLine("the do while loop will iterate" + value_of_input.ToString);

                    while ( value_of_input>0)
                    {
                        Console.WriteLine("the value of the iterative variable is:"+ value_of_input);
                        value_of_input--;
                    }

                    Console.WriteLine("press any key to exit the program...");
                    Console.ReadKey(true);
                } //end of else if

                // for between 11 & 20
                else if((value_of_input >10) && (value_of_input <= 20))
                {
                    Console.WriteLine("executing a Do while loop");
                    Console.WriteLine("the do while loop will iterate" + value_of_input.ToString);

                    do
                    {
                        Console.WriteLine("the value of the iterative variable is:" + value_of_input.ToString);
                        value_of_input--;

                    }
                    while (value_of_input > 0);
                    Console.WriteLine("press any key to exit the program...");
                    console.readkey(true);

                }
                // if value is not between 1 and 20, display a message
                else
                {
                    Console.WriteLine("please enter an integer between 1 and 20 and try again");
                    Console.WriteLine("press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
            } //end of try
            catch
            {




                Console.ReadKey(true);
            } // end of catch
        } // end of main
    } //end of class
} // end of namespace
