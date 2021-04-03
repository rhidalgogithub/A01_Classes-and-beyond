using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace A04_ExceptionHandling
{
    class A04_main
    {
        static void Main( string[] args ) {

            string myName = "";
            int myAge = -1;
            int numberOfChildren = -1;

            Console.WriteLine("What is your name? : ");
            myName = Console.ReadLine();

            #region HANDLING AN EXCEPTION
            //The following exception is handled by using TryParse( x1, x2)
            Console.WriteLine("How old are you? : ");
            bool resultTryParse = int.TryParse(Console.ReadLine() , out myAge);

            if (!resultTryParse) {
                Console.WriteLine($"++++++++++ ({resultTryParse}) basic type ++++++++++++++");
                Console.WriteLine("A type error for the answer to, How old are you?, was generated.");
                Console.WriteLine("Please, re-enter your age :");
                resultTryParse = int.TryParse(Console.ReadLine() , out myAge);
                if (!resultTryParse) {
                    Console.WriteLine("++++++++++++ Persistent type error. ++++++++++++");
                }
            }
            Console.WriteLine($"myName is {myName}, and myAge is {myAge}");
            #endregion

            #region TRY & CATCH, NO THROW
            try {
                Console.WriteLine("How many children do you have? ");
                numberOfChildren = int.Parse(Console.ReadLine());
            } catch (FormatException) {
                Console.WriteLine("The system has detected a Type error.");
            }
            #endregion



            #region TRY, CATCH, & THROW
            //When placing more than one exception, one after the other, locate the more
            //generic (non-specific) exceptions first.
            //This section deals with a 
            try {
                Console.WriteLine("Initializing division routine ...\n");
                int numerator = 4;
                int denominator = 0;
                double myDecimalResult = numerator / denominator;

            } catch (Exception) {
                Console.WriteLine("Error. Division by zero is undefined.");

                throw new FormatException("My error message for a division by 0");
            }
            #endregion



            Console.WriteLine("Press enter to exit application.");
            Console.Read();
        }
    }
}
