using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace A01_simple_Class
{
    class A01_program
    {
        static void Main( string[] args ) {
            Console.WriteLine("Hello Classes in C#.\n");
            bool moreDataToEnter = true;
            var StudentsList = new List<StudentData>(); // List of Student objects

            while (moreDataToEnter==true) {

                var newStudentRecord = new StudentData();

                #region ASK FUNCTION INFORMATION
                /* Observe in A01_main.cs the use of the function Ask(). It has been used
                 * in every other question ("Enter First Name: ", "Enter Last Name: ",
                 * "Enter DOB: ", "Enter Grade: ", and "Enter status: ", to illustrate
                 * the way it replaces the use of 'Console.WriteLine' and 'Console.ReadLine'
                 */
                #endregion

                // Console.WriteLine("Enter First Name: ");
                // newStudentRecord.FirstName=Console.ReadLine().ToLower();
                newStudentRecord.FirstName = myUtilityClass.Console.Ask("Enter First Name: ");

                Console.WriteLine("Enter Last Name: ");
                newStudentRecord.LastName=Console.ReadLine().ToLower();
                //newStudentRecord.LastName=myUtilityClass.Console.Ask("Enter Last Name: ");

                Console.WriteLine("Enter DOB: ");
                newStudentRecord.DOB=Console.ReadLine();
                //newStudentRecord.DOB=myUtilityClass.Console.Ask("Enter DOB: ");

                // Console.WriteLine("Enter Grade: ");
                //newStudentRecord.Grade=int.Parse(Console.ReadLine());
                newStudentRecord.Grade=int.Parse(myUtilityClass.Console.Ask("Enter Grade: "));

                Console.WriteLine("Enter status: ");
                newStudentRecord.setStatus(Console.ReadLine()); // Using the setter

                StudentsList.Add(newStudentRecord); // New object is assigned to StudentsList
                StudentData.Count++;

                foreach (var studentRecord in StudentsList) { //var let C# to pick the type
                    Console.WriteLine("=====================================");
                    Console.WriteLine($" First Name: {studentRecord.FirstName}");
                    Console.WriteLine($" Last Name: {studentRecord.LastName}");
                    Console.WriteLine($" DOB: {studentRecord.DOB}");
                    Console.WriteLine($" Grade: {studentRecord.Grade}");
                    Console.WriteLine($" Status: {studentRecord.getStatus()}");
                    Console.WriteLine("=====================================");
                }

                Console.WriteLine($"Students count (objects) : { StudentData.Count }");
                Console.WriteLine("\nDo you have more data to enter? Type 'y' or 'n' : ");
                moreDataToEnter=(Console.ReadLine()=="y");
                Console.WriteLine($"{ moreDataToEnter}");
            }

            Console.WriteLine("Press enter to exit program ...");
            Console.ReadLine();

        }
    }
}


class StudentData
{
    static public int Count = 0;    //Variable to count the instances fo the class (static)

    public string FirstName = "";
    public string LastName = "";
    public string DOB = "";
    public int Grade = -1;
    // status will be set to private. The lowercase "s" indicates private property
    private string status = "";  

    public  StudentData() {
        Console.WriteLine("Constructor in Action");
    }

    public void setStatus( string inputStatus ) {
        status=inputStatus; 
    }

    public string getStatus() {
        return status;
    }

    // This code is missing the property for Satus
    // The declarared variables from lines 57 - 61, are called fields. Once they have
    // a setter and a getter, they become (are considered) properties.
    //A property behaves like a function.
}


