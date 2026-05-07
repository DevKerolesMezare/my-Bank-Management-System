
use Bank_Management_System;

Create Table Countries (
CountryID int IDENTITY(1,1) Primary KEY , 
CountryName nvarchar(30),
CountryCode nvarchar(5),
)



Create Table People
(
PersonID int Identity(1,1) Primary Key, 
NationalID nvarchar(30) UNIQUE ,
FirstName nvarchar(30),
SecondName nvarchar(30),
ThirdName nvarchar(30), 
LastName nvarchar(30),
DateOfBirth DATETIME, 
Gender bit, 
Phone nvarchar(30), 
Email nvarchar(50), 
Address nvarchar(250), 
ImagePath nvarchar(300),
CountryID INT,
FOREIGN KEY (CountryID) REFERENCES Countries(CountryID)
)



Create Table Users
(
UserID INT IDENTITY(1,1) PRIMARY KEY, 

UserName nvarchar(20),
Password nvarchar(30),
IsActive BIT , 

PersonID INT , 
FOREIGN KEY (PersonID) REFERENCES People(PersonID)
)

Create Table Customers (
CustomerID INT IDENTITY(1,1) Primary Key, 
Notes nvarchar(250),
IsBlocked bit,
CreatedAT DateTime DEFAULT GETDATE() ,

PersonID int Foreign key (PersonID) REFERENCES People(PersonID),
CreatedByUserID INT Foreign key (CreatedByUserID) REFERENCES Users(UserID)
)




Create Table AccountTypes (
AccountTypeID int Primary KEY , 
TypeName nvarchar(30),
)


Create Table Accounts 
(
AccountID INT IDENTITY(1,1) Primary Key ,

AccountNumber nvarchar(50), 
PinCode nvarchar (10),
AccountBalance decimal , 
CreatedDate datetime DEFAULT Getdate() ,
IsActive bit , 


CustomerID int Foreign key (CustomerID) REFERENCES Customers(CustomerID),
CreatedByUserID INT Foreign key (CreatedByUserID) REFERENCES Users(UserID),
AccountTypeID int Foreign key (AccountTypeID) REFERENCES AccountTypes(AccountTypeID)
)


Create Table TransactionTypes(
TransactionTypeID INT Primary Key ,
TypeName nvarchar (20)
)



Create Table Transactions 
(
TransactionID INT IDENTITY(1,1) Primary Key ,

Amount Decimal , 
TransactionDate DateTime, 
Note nvarchar (250),


AccountID int Foreign key (AccountID) REFERENCES Accounts(AccountID),
CreatedByUserID INT Foreign key (CreatedByUserID) REFERENCES Users(UserID),
AccountTypeID int Foreign key (AccountTypeID) REFERENCES AccountTypes(AccountTypeID)
)




