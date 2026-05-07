
Use Bank_Management_System;

-------------------------------------------------------------------------
                       --- People
Create PROCEDURE SP_UpdatePerson
    @PersonID INT,

    @NationalNo NVARCHAR(20),
	@FirstName NVARCHAR(20),
	@SecondName NVARCHAR(20),
	@ThirdName NVARCHAR(20),
	@LastName NVARCHAR(20),
    @DateOfBirth datetime,
	@Gender tinyint,
	@Address NVARCHAR(500),
	@Phone NVARCHAR(20),
    @Email NVARCHAR(50),
	@CountryID int,
	@ImagePath NVARCHAR(250)
AS
BEGIN 

UPDATE People
SET 
    NationalNo  = @NationalNo,
    FirstName   = @FirstName,
    SecondName  = @SecondName,
    ThirdName   = @ThirdName,
    LastName    = @LastName,
    DateOfBirth = @DateOfBirth,
    Gender      = @Gender,
    Address     = @Address,
    Phone       = @Phone,
    Email       = @Email,
    CountryID   = @CountryID,
    ImagePath   = @ImagePath
WHERE 
    PersonID = @PersonID;
END;

---------------------------------------------------------------------------

---------------------------------------------------------------------------
                          -- Users

CREATE PROCEDURE SP_UpdateUserPassword
    @UserID INT,
    @NewPassword NVARCHAR(20)
AS
BEGIN
    UPDATE Users
    SET Password = @NewPassword
    WHERE UserID = @UserID;
END


Create Procedure SP_UpdateUser

@UserName nvarchar(20),
@Password nvarchar(20), 
@IsActive bit , 
@PersonID int,

@UserID int OUTPUT
AS 
BEGIN

	Update Users
		Set 
		 UserName = @UserName,
		 Password = @Password,
		 IsActive = @IsActive,
		 PersonID = @PersonID
Where UserID = @UserID;
END

---------------------------------------------------------------------------


---------------------------------------------------------------------------
                  -- Customers
CREATE PROCEDURE SP_UpdateCustomers
@Notes nvarchar(300),
@IsBlocked bit , 

@CustomerID int

AS
BEGIN

Update Customers
	Set
		Notes = @Notes , 
		IsBlocked = @IsBlocked
	Where
		CustomerID = @CustomerID;
END

-------------------------------------------------------------------

-------------------------------------------------------------------
                         -- Accounts

ALTER TABLE Accounts
ADD 
    UpdatedByUserID INT NULL,
    UpdatedDate DATETIME NULL;


CREATE PROCEDURE SP_UpdateAccountDetails
    @AccountID INT,
    @AccountNumber NVARCHAR(30),
    @PinCode NVARCHAR(5),
    @AccountBalance DECIMAL,
    @IsActive BIT,
    @AccountTypeID INT,
    @UpdatedByUserID INT
AS
BEGIN
    UPDATE Accounts
    SET 
        AccountNumber = @AccountNumber,
        PinCode = @PinCode,
        AccountBalance = @AccountBalance,
        IsActive = @IsActive,
        AccountTypeID = @AccountTypeID,
        UpdatedByUserID = @UpdatedByUserID,
        UpdatedDate = GETDATE()
    WHERE AccountID = @AccountID;
END;
--------------------------------------------------------------------


--------------------------------------------------------------------
                          -- Transaction



---------------------------------------------------------------------

---------------------------------------------------------------------
               -- Transfers



------------------------------------------------------


----------------------------------------------------
                     -- TransactionType

CREATE PROCEDURE SP_UpdateTransactionTypeStatus
    @TransactionTypeID INT,
    @IsActive BIT
AS
BEGIN
    UPDATE TransactionTypes
    SET IsActive = @IsActive
    WHERE TransactionTypeID = @TransactionTypeID;
END;


-----------------------------------------------



-----------------------------------------------
                -- Transfers

CREATE PROCEDURE SP_UpdateTransfer
    @TransferID INT,
    @Amount DECIMAL,
    @Note NVARCHAR(300),
    @ToAccountID INT,
    @TransactionTypeID INT,
    @UpdatedByUserID INT
AS
BEGIN
    UPDATE Transfers
    SET 
        Amount = @Amount,
        Note = @Note,
        ToAccountID = @ToAccountID,
        TransactionTypeID = @TransactionTypeID,
        CreatedByUserID = @UpdatedByUserID
    WHERE TransferID = @TransferID;
END
