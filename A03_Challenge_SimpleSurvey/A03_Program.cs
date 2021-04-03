using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A03_Challenge_SimpleSurvey
{
    class A03_Program
    {
        static void Main( string[] args ) {
            Console.WriteLine("Hello, simple survey and political program");

            DirectBaseData(); 
            var politicalRecord = new politicalSurvey("Angel", "Nikkeiro", 42, "Republican");

            
            politicalRecord.showPoliticalResults();
           
            utilityPause();

        }//End of A03_Main

         
        static void utilityPause() {
            Console.WriteLine("Press enter to exit application.");
            Console.ReadLine();
        }//End of utilityPause();

        static void DirectBaseData() { //Creating a new record from class baseSurvey
            var Direct = new baseSurvey ("Michael", "Schumager", 45);
            Direct.showSurveyResults();
        }
    }//End of A03_Program

    class baseSurvey
    {
        public string FirstName;
        public string LastName;
        public int Age; 

        public baseSurvey() {
            Console.WriteLine("baseSurvey Constructor --No parameters-- in Action");
        }
        public baseSurvey( string fName , string lName , int ageInput ) {
            Console.WriteLine("Parameterized constructor Survey class");
            FirstName = fName;
            LastName = lName;
            Age = ageInput;
        }

        public void showSurveyResults() {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($" First Name: {this.FirstName}");
            Console.WriteLine($" Last Name: {this.LastName}");
            Console.WriteLine($" Grade: {this.Age}");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
        }

    }//End of class survey

    class politicalSurvey : baseSurvey
    {
        public string partyAfiliation;

        public politicalSurvey() {
            Console.WriteLine("politicalSurvey Constructor --No parameters-- in Action");
        }

        public politicalSurvey( string fName , string lName , int ageInput, string afiliation ) {
            Console.WriteLine("politicalSurvey Constructor -- PARAMETERIZED -- in Action");
            FirstName = fName;
            LastName = lName;
            Age = ageInput;
            partyAfiliation = afiliation;
        }
        public void showPoliticalResults() {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($" First Name: {this.FirstName}");
            Console.WriteLine($" Last Name: {this.LastName}");
            Console.WriteLine($" Age: {this.Age}");
            Console.WriteLine($" Party Afiliation : {this.partyAfiliation}");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
        }

    }//End of class politicalSurvey


}//End of namespace
