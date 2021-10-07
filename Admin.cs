using System;
using System.Collections.Generic;
using System.Text;

namespace CS3560_02_3
{
    class Admin : UserAccount
    {
        int adminNumber;

        public void createEmployee(string name, string address, string email, string phoneNumber, string dateOfBirth, string bankAccountNumber, string sSN) { }
        public void searchEmployee(int accID) { } //set to return UserAccount?
        public void updateEmployee(int accID, string name, string address, string email, string phoneNumber, string dateOfBirth, string bankAccountNumber, string sSN, string jobTitle) { }
        public void removeEmployee(int accID) { }
        public void createAdmin(string name, string address, string email, string phoneNumber, string dateOfBirth, string bankAccountNumber, string sSN) { }
        public void searchAdmin(int accID) { }
        public void updateAdmin(int accID, string name, string address, string email, string phoneNumber, string dateOfBirth, string bankAccountNumber, string sSN) { }
        public void removeAdmin(int accID) { }
        public void removeTimeLog(int accID) { }
        public void updateTimeLog(int logID) { } //and check in/out time to edit?
        public void assignJob(string jobTitle) { }
        public void updateTimesheet(int accID) { }
    }
}
