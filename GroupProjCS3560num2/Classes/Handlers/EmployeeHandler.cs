using System;
using System.Collections.Generic;
using System.Text;
using GroupProjCS3560num2.Database;

namespace GroupProjCS3560num2.Classes.Handlers
{
    class EmployeeHandler
    {
        // VERIFY THAT THEY ARE NOT EMPTY
        // name
        // phone + check for correct digits of numbers
        // email
        // address
        // birthdate
        // ssn + check for right amount of number
        // bank account number 
        // password
        // job
        // adjustment

        // THIS IS THE PURPOSE OF EMPLOYEEHANDLER
        // take all the information 
        // when click confirm
        // push all the data into the database
        // use datbaseHelper command to put the information to the database

        // NOT SURE IF WE SHOUDL KEEP IT PUBLIC OR PRIVATE
        // when in doubt, make it public lol
        // lol
        // lets look at how Chris is making his new handler
        // im having call with vu
        // got it

        // are we allowed to modify DatabaseHelper.cs??
        // cause as far as i know we are using databasehelper to inser the new employee information to the database
        // there's an insertEmployee method but idont have acces to it. seems like it's private

/*        int employeeID;
        int jobID;
        string password;
        string empName;
        string physicalAddress;
        string emailAddress;
        string phoneNumber;
        DateTime dateOfBirth;
        string bankAccNumber;
        string sSN;
        double adjustment;*/

        public static void createEmployee(int jobID, string password, string empName, string physicalAddress, string emailAddress, 
            string phoneNumber, DateTime dateOfBirth, string bankAccNumber, string sSN, double adjustment)
        {
            Employee emp = new Employee(jobID, phoneNumber, adjustment, dateOfBirth, empName, physicalAddress, emailAddress, bankAccNumber, sSN, password);

            // InsertEmployee needs to be updated since we do not need to create the employeeID.
            LilyDatabaseHelper.InsertEmployee(emp);
        }



        public static void setName(string name)
        {
            //wheres the code example?

         
        }

        public static void setPhoneNumber(string phoneNumber)
        {

        }


        public static void setEmail(string email)
        {

        }

        public static void setAddress(string address)
        {

        }

        public static void setBirthdate(DateTime birthDate)
        {

        }

        public static void setSSN(string sSN)
        {

        }
    }
}
