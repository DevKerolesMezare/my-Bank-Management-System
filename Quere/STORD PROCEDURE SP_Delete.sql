

Use Bank_Management_System;

----------------------------------------------------------
                         -- People
						 					 
CREATE PROCEDURE SP_DeletePerson
@PersonID INT
AS
BEGIN
    DELETE FROM People WHERE PersonID = @PersonID;
END
------------------------------------------------------------

------------------------------------------------------------
                -- Users

CREATE PROCEDURE SP_DeleteUser
@UserID INT

AS
BEGIN
Delete Users Where UserID = @UserID
END
---------------------------------------------------

---------------------------------------------------
               -- Customers
CREATE PROCEDURE SP_DeleteCustomer
@CustomerID INT

AS
BEGIN
Delete Customers Where CustomerID = @CustomerID
END

------------------------------------------------------



