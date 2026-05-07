
Use Bank_Management_System;



 -------------------------------------------------------------
					-- Person Exists
Create Procedure SP_CheckPersonExistsByPersonID
@PersonID INT
AS
BEGIN

IF EXISTS (Select 1 From People Where PersonID = @PersonID)
BEGIN
return 1;
END

return 0 ;
END

----------------------------------------------------------------
Create Procedure SP_CheckPersonExistsByNationalNo
@NationalNo nvarchar(30)
AS
BEGIN

IF EXISTS (Select 1 From People Where NationalNo = @NationalNo)
BEGIN
return 1;
END

return 0 ;
END



 -------------------------------------------------------------


 -------------------------------------------------------------
				-- User Exists

Create Procedure SP_CheckUserExistsUserID
@UserID INT
AS
BEGIN

IF EXISTS (Select 1 From Users Where UserID = @UserID)
BEGIN
return 1;
END

return 0 ;
END


----------------------------------------------------------------
Create Procedure SP_CheckUserExistsByUsername 
@Username nvarchar(20)
AS
BEGIN

IF EXISTS (Select 1 From Users Where Username = @Username)
BEGIN
return 1;
END

return 0 ;
END

-------------------------------------------------------------------



 --------------------------------------------------------------------------
				-- Customer Exists

Create Procedure SP_CheckCustomerExistsByCustomerID
@CustomerID INT
AS
BEGIN

IF EXISTS (Select 1 From Customers Where CustomerID = @CustomerID)
BEGIN
return 1;
END

return 0 ;
END

-------------------------------------------------------------


 -------------------------------------------------------------
				-- Account Exists

Create Procedure SP_CheckAccountExistsByAccountID
@AccountID INT
AS
BEGIN

IF EXISTS (Select 1 From Accounts Where AccountID = @AccountID)
BEGIN
return 1;
END

return 0 ;
END

-------------------------------------------------------------