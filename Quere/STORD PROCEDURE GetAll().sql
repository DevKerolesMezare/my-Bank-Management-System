Use Bank_Management_System;


-----------------------------------------------------------
                 -- GetAllPeople

Create Procedure GetAllPeople
AS
Begin
SELECT
People.PersonID,
People.NationalNo, 
People.FirstName,
People.SecondName,
People.ThirdName,
People.LastName,
People.DateOfBirth,
Case When Gender = 1 Then 'Male' Else 'Female' End AS Gender,
Countries.CountryName,
People.Phone, 
People.Email
                     
FROM  People INNER JOIN Countries ON People.CountryID = Countries.CountryID
End
-----------------------------------------------------------

-----------------------------------------------------------
                      -- GetAllUsers
Create Procedure GetAllUsers
AS
BEGIN
SELECT     
Users.UserID, 
People.PersonID,
CONCAT(
People.FirstName, ' ',
People.SecondName, ' ',
People.ThirdName, ' ',
People.LastName) As FullName,
Users.UserName,
Users.IsActive

FROM Users INNER JOIN
                 People ON Users.PersonID = People.PersonID
END
-----------------------------------------------------------




-----------------------------------------------------------
                       -- GetAll Customers
CREATE Procedure GetAllCustomers
AS
BEGIN				   
SELECT    
Customers.CustomerID,
People.PersonID, 
Users.UserID, 
ConCat(
People.FirstName, ' ',
People.SecondName, ' ',
People.ThirdName, ' ',
People.LastName) AS FullName,
Customers.CreatedAT, 
Customers.IsBlocked
FROM Customers INNER JOIN
               People ON Customers.PersonID = People.PersonID INNER JOIN
               Users ON Customers.CreatedByUserID = Users.UserID
END

-----------------------------------------------------------



-----------------------------------------------------------
                   -- GetAllAccounts
CREATE Procedure GetAllAccounts
AS
BEGIN
SELECT       
Accounts.AccountID, 
Customers.CustomerID,
Users.UserID,
ConCat(
People.FirstName, ' ',
People.SecondName, ' ',
People.ThirdName, ' ',
People.LastName) AS FullName,
Accounts.AccountNumber,
Accounts.AccountBalance, 
AccountTypes.TypeName,
Accounts.CreatedDate, 
Accounts.IsActive
FROM AccountTypes INNER JOIN
                         Accounts ON AccountTypes.AccountTypeID = Accounts.AccountTypeID INNER JOIN
                         Customers ON Accounts.CustomerID = Customers.CustomerID INNER JOIN
                         People ON Customers.PersonID = People.PersonID INNER JOIN
                         Users ON Accounts.CreatedByUserID = Users.UserID 
END

---------------------------------------------------------


--------------------------------------------------------- 
                      -- GetAllTransactions

CREATE Procedure GetAllTransactions
AS
BEGIN

SELECT        Transactions.TransactionID, Accounts.AccountID, Users.UserID, TransactionTypes.TypeName, Transactions.Amount, Transactions.TransactionDate
FROM            Transactions INNER JOIN
                         TransactionTypes ON Transactions.TransactionTypeID = TransactionTypes.TransactionTypeID INNER JOIN
                         Users ON Transactions.CreatedByUserID = Users.UserID INNER JOIN
                         Accounts ON Transactions.AccountID = Accounts.AccountID AND Users.UserID = Accounts.CreatedByUserID

END



----------------------------------------------------------

----------------------------------------------------------
					--SP_GetAllTransactionTypes
	
Create Procedure SP_GetAllTransactionTypes
As
BEGIN
SELECT        TransactionTypeID, TypeName, IsActive
FROM            TransactionTypes
END

----------------------------------------------------------