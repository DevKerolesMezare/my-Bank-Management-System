
Use Bank_Management_System;



-----------------------------------------------------------
                     -- GetPersonByID
Create Procedure GetPersonByID
@PersonID INT
AS
BEGIN

SELECT        PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, ImagePath, CountryID, IsActive
FROM            People Where PersonID = @PersonID 
END

----------------------------------------------------------




-----------------------------------------------------------
                     -- GetPersonByNationalNo

Create Procedure GetPersonByNationalNo
@NationalNo nvarchar(30)
AS
BEGIN

SELECT        PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, ImagePath, CountryID, IsActive
FROM            People Where NationalNo = @NationalNo 
END

---------------------------------------------------------------


---------------------------------------------------------------
						--	GetUserByID
Create Procedure GetUserByID
@UserID INT
AS
BEGIN
SELECT        UserID, PersonID, UserName,Password ,IsActive
FROM            Users Where UserID = @UserID

END

---------------------------------------------------------------


---------------------------------------------------------------
						--	GetUserByUserNameAndPassword

Create Procedure GetUserByUserNameAndPassword
@UserName Nvarchar(25),
@Password Nvarchar(25)

AS
BEGIN
SELECT        UserID, PersonID, UserName, Password, IsActive
FROM            Users Where UserName = @UserName AND Password = @Password

END
---------------------------------------------------------------


---------------------------------------------------------------
						--	GetUserByUserName
Create Procedure GetUserByUserName
@UserName Nvarchar(25)

AS
BEGIN
SELECT        UserID, PersonID, UserName, Password , IsActive
FROM            Users Where UserName = @UserName

END
---------------------------------------------------------------



---------------------------------------------------------------
						-- GetCustomerByCustomerID

Create Procedure GetCustomerByID
@CustomerID INT
AS
BEGIN
SELECT        CustomerID, PersonID, CreatedByUserID, CreatedAT, IsBlocked
FROM            Customers Where CustomerID = @CustomerID

END

---------------------------------------------------------------



---------------------------------------------------------------
					    -- GetTransactionTypeByID


Create Procedure GetTransactionTypeByID
@TransactionTypeID INT
AS
BEGIN

SELECT        TransactionTypeID, TypeName, IsActive
FROM            TransactionTypes Where TransactionTypeID = @TransactionTypeID

END

---------------------------------------------------------------



--------------------------------------------------------------- 
					-- GetTransactionByID
Create Procedure GetTransactionByID
@TransactionID INT
AS
BEGIN
SELECT        TransactionID, CreatedByUserID, AccountID, TransactionTypeID, Amount, Note, TransactionDate
FROM            Transactions Where TransactionID = @TransactionID
END


---------------------------------------------------------------



---------------------------------------------------------------
							-- GetTransferByID

Create Procedure GetTransferByID
@TransferID INT
AS
BEGIN

SELECT        TransferID, CreatedByUserID, FromAccountID, ToAccountID, TransactionTypeID, Amount, Note, CreatedDate
FROM            Transfers Where TransferID = @TransferID
END

---------------------------------------------------------------




---------------------------------------------------------------
						-- GetAccountTypeByID

Create Procedure GetAccountTypeByID
@AccountTypeID INT
AS
BEGIN

SELECT        AccountTypeID, TypeName, IsActive
FROM            AccountTypes Where AccountTypeID = @AccountTypeID

END

---------------------------------------------------------------



---------------------------------------------------------------
						-- GetCountryByID

Create Procedure GetCountryByID
@CountryID INT

AS
BEGIN

SELECT        CountryID, CountryName, CountryCode
FROM            Countries Where CountryID = @CountryID

END

---------------------------------------------------------------


---------------------------------------------------------------
						-- GetAccountByID

Create Procedure GetAccountByID
@AccountID INT
AS
BEGIN
SELECT        AccountID, CustomerID, CreatedByUserID, UpdatedByUserID, AccountNumber, PinCode, AccountBalance, CreatedDate, UpdatedDate, AccountTypeID, IsActive
FROM            Accounts Where AccountID = @AccountID
END

---------------------------------------------------------------


---------------------------------------------------------------
						-- GetAccountByAccountNumberAndPinCode

Create Procedure GetAccountByAccountNumberAndPinCode
@AccountNumber   NVARCHAR(50),
@PinCode  NVARCHAR(10)
AS
BEGIN
SELECT        AccountID, CustomerID, CreatedByUserID, UpdatedByUserID, AccountNumber, PinCode, AccountBalance, CreatedDate, UpdatedDate, AccountTypeID, IsActive
FROM            Accounts Where AccountNumber = @AccountNumber AND PinCode = @PinCode
END

---------------------------------------------------------------
