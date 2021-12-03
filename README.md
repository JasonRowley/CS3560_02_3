# Student's Involved:
# Christopher Tomes, Jason Rowley, Vu Nguyen, Leonardo Langgeng, Lily Hou Wu
# This is our group's final submission for CS3560_02_3 Object Oriented Programming. 2021 Fall

This project is windows forms application responsible for interacting with a MySQL Database. 
The application's responsibilities include: maintaining a database of Employee/Job information, while also providing a service for maintaining records for timesheets.

# Configuration
inside DatabaseHelper lies the configuration information necessary to communicate with MySQL
To set up your own database, here are the following commands:
create table Job(jobID int auto_increment, jobTitle varchar(50), basePayrate double, primary key(jobID));
create table Employee(employeeID int auto_increment, jobID int, pw varchar(50), empName varchar(50), physicalAddress varchar(50), emailAddress varchar(50), phoneNumber int, dateOfBirth date, bankAccNumber varchar(50), sSN varchar(50), adjustment double, primary key(employeeID), foreign key(jobID) references Job(jobID));
create table TimeLog(logID int auto_increment, employeeID int, checkIn datetime, checkOut datetime, primary key(logID), foreign key(employeeID) references Employee(employeeID));
create table Issue(issueID int auto_increment, employeeID int, adminID int, issueStr varchar(500), solved bool, primary key(issueID), foreign key(employeeID) references Employee(employeeID), foreign key(adminID) references Employee(employeeID));

insert into Job(jobTitle, basePayrate) value ('Admin', '20.0');
insert into Employee(jobID, pw, empName, physicalAddress, emailAddress, phoneNumber, dateOfBirth, bankAccNumber, sSN, adjustment) value(1, 'password', 'Joe Smith', 'address', 'email', '5621232264','1993-12-04','121313123','123221234', 1.0);

