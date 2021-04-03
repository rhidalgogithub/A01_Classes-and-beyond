using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A05_enumerators
{
    #region NOTES ABOUT ENUMS
    //enumerators do not have to be defined using numbers. By default, the first element
    //is "0", the second one is "1", and so on. You can also redefine the starting number
    //by assigning the first one a number different than "0".
    #endregion
    enum enumSchool
    {
        NO_SELECTION = 0,
        HOGWART = 1,
        HARVARD = 2,
        MIT = 3
    }
    class A05_main
    {
        static void Main( string[] args ) {

            enumSchool schoolSelection = 0;

            Console.WriteLine("Select your school: \n 1 - HOGWART \n 2 - HARVARD \n 3 - MIT \n");
            #region CASTING ENUM VARIABLE
            //The assignment of an integer in the line below this #endregion, is casting the integer
            //value into an enum variable using (enumSchool). See below.
            #endregion
            schoolSelection = (enumSchool)int.Parse((Console.ReadLine()));

            Console.WriteLine($"Selected School is {schoolSelection}");

            Console.WriteLine("\n ++++++++++++++++\n ");


            int myInteger = -10;
            myOutFunction(ref myInteger);
            Console.WriteLine($"The value of myInteger after calling 'myOutFunction' is {myInteger}. ");

            Console.WriteLine("Press enter to exit program");
            Console.ReadLine();

        }//End of Main Fn()

        #region USE OF THE KEY WORD ref
        //Use of the key word "ref"; the equivalent to C++ reference.
        #endregion
        static void myOutFunction( ref int x ) {
            x = x * 5;
        }





    }//End of class (A05_class Program)



}//End of namespace
