using System;
using System.Collections.Generic;
using System.Text;

namespace CS3560_02_3
{
    abstract class UserAccount
    {
        int accountID;
        string name;
        string physicalAddress;
        string emailAddress;
        string phoneNumber;
        string dateOfBirth;
        string bankAccountNumber;
        string socialSecurityNumber;

        public void createIssue() { }
        public virtual void searchTimesheet(int accID) { }
    }
}
