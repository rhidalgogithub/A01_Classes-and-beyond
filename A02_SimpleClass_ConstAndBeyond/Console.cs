using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Observe in A01_main.cs the use of the function Ask(). It has been used
 * in every other question ("Enter First Name: ", "Enter Last Name: ",
 * "Enter DOB: ", "Enter Grade: ", and "Enter status: ", to illustrate
 * the way it replaces the use of 'Console.WriteLine' and 'Console.ReadLine'
 */

namespace myUtilityClass
{
    class Console
    {
        #region READ INFORMATION
        /* The name of the class, "Console", was assigned purposely to create a conflict
         * with the Console class of the namespace "System". 
         */
        #endregion

        static public string Ask( string question ) {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }
    }
}


