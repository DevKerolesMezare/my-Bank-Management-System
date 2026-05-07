
CREATE PROCEDURE SP_AddNewCountries
@CountryName nvarchar(20), 
@CountryCode nvarchar (5),

@NewCountryID int OUT

AS
BEGIN

	insert into Countries 
	(
		CountryName,
		CountryCode
	)
	VALUES
	(
		@CountryName,
		@CountryCode
	)

SET @NewCountryID = SCOPE_IDENTITY();
END



Create PROCEDURE SP_AddNewPerson

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
	@ImagePath NVARCHAR(250),
    @NewPersonID INT OUTPUT

AS
BEGIN 
 INSERT INTO People
    (
        NationalNo,
        FirstName,
        SecondName,
        ThirdName,
        LastName,
        DateOfBirth,
        Gender,
        Address,
        Phone,
        Email,
        CountryID,
        ImagePath
    )
	values
	(
	 @NationalNo,
	 @FirstName ,
	 @SecondName,
	 @ThirdName ,
	 @LastName,
	 @DateOfBirth,
	 @Gender ,
	 @Address,
	 @Phone,
	 @Email,
	 @CountryID,
	 @ImagePath
	);


    SET @NewPersonID = SCOPE_IDENTITY();
END;






Create Procedure SP_AddNewUser
@UserName nvarchar(20),
@Password nvarchar(20), 
@IsActive bit , 
@PersonID int,

@NewUserID int OUTPUT
AS 
BEGIN

	Insert into Users
	(
		UserName ,
		Password,
		IsActive,
		PersonID
	)
	
	Values
	(
		@UserName,
		@Password,
		@IsActive,
		@PersonID
	)

SET @NewUserID = SCOPE_IDENTITY();
END;






CREATE PROCEDURE SP_AddNewCustomers

@Notes nvarchar(300),
@IsBlocked bit , 

@PersonID int, 
@CreatedByUserID int,

@NewCustomerID int OUT

AS
BEGIN

	Insert into Customers 
	(
		Notes,
		IsBlocked,
		PersonID,
		CreatedByUserID
	)
	Values
	(
		@Notes,
		@IsBlocked,
		@PersonID,
		@CreatedByUserID
	)

Set @NewCustomerID = SCOPE_IDENTITY();

END;




Create Procedure SP_AddNewAccount

@AccountNumber nvarchar(30),
@PinCode nvarchar (5),
@AccountBalance decimal,
@IsActive bit ,

@CustomerID	int,
@AccountTypeID	int,
@CreatedByUserID   int,

@NewAccountID int OUTPUT

AS
BEGIN
	insert into Accounts
	(
		AccountNumber,
		PinCode,
		AccountBalance,
		IsActive,
		CustomerID,
		AccountTypeID,
		CreatedByUserID
	)
	values
	(
		@AccountNumber,
		@PinCode,
		@AccountBalance,
		@IsActive,
		@CustomerID,
		@AccountTypeID,
		@CreatedByUserID
	)

Set @NewAccountID = SCOPE_IDENTITY();

END;




Create Procedure SP_AddNewTransaction

@Amount decimal ,
@Note nvarchar(300),

@AccountID int ,
@TransactionTypeID int ,
@CreatedByUserID int,

@NewTransactionID int OUT
AS
BEGIN

	insert into Transactions
	(
		Amount,
		Note,
		AccountID,
		TransactionTypeID,
		CreatedByUserID
	)
	Values
	(
		@Amount,
		@Note,
		@AccountID,
		@TransactionTypeID,
		@CreatedByUserID
	);


Set @NewTransactionID = SCOPE_IDENTITY();
END;






Create PROCEDURE SP_AddNewTransfer

@Amount decimal ,
@Note nvarchar(300),

@FromAccountID int ,
@ToAccountID int,
@TransactionTypeID int ,
@CreatedByUserID int,

@NewTransactionID int OUT
AS
BEGIN

	insert into Transfers
	(
		Amount,
		Note,
		FromAccountID,
		ToAccountID,
		TransactionTypeID,
		CreatedByUserID
	)
	VALUES
	(
		@Amount,
		@Note,
		@FromAccountID,
		@ToAccountID,
		@TransactionTypeID,
		@CreatedByUserID
	);


	SET @NewTransactionID = SCOPE_IDENTITY();

END;

