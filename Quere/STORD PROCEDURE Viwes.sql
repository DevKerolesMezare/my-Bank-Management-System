
Use Bank_Management_System ;

-------------------------------------------------------------------
                 -- vw_CustomerProfile

Create View CustomerProfile_View AS
SELECT    
Customers.CustomerID, 
Concat (People.FirstName,' ', People.SecondName,' ', People.ThirdName,' ', People.LastName) AS FullName, 
Case
	When Gender = 1 Then 'Male'
	Else 'Female'
END AS Gender,
People.Address,
People.Phone, 
People.Email, 
Countries.CountryName,
Case
	When IsBlocked = 1 Then 'Yes'
	Else 'No'
END AS IsBlocked,
Customers.CreatedAT,
Users.UserName AS CreatedBy

FROM Customers INNER JOIN
     People ON Customers.PersonID = People.PersonID INNER JOIN
     Countries ON People.CountryID = Countries.CountryID INNER JOIN
     Users ON Customers.CreatedByUserID = Users.UserID AND People.PersonID = Users.PersonID


----------------------------------------------------------------------------



-------------------------------------------------------------------
                            -- vw_AccountDetails

Create View AccountDetails_View AS
SELECT
Customers.CustomerID,
CONCAT(People_1.FirstName, ' ', People_1.SecondName, ' ', People_1.ThirdName, ' ', People_1.LastName)As FullName,
CASE WHEN Gender = 1 THEN 'Male' ELSE 'Female' END AS Gender, 
Countries.CountryName,
Customers.CreatedAT,
Accounts.AccountNumber,
Accounts.PinCode, 
 CONCAT(Accounts.AccountBalance , '$') AS AccountBalance,
AccountTypes.TypeName, 
CASE WHEN Accounts.IsActive = 1 Then 'Yes' ELSE 'NO' END AS IsActive,
Users.UserName AS CreatedBy

FROM Customers INNER JOIN
                         Accounts ON Customers.CustomerID = Accounts.CustomerID INNER JOIN
                         People AS People_1 ON Customers.PersonID = People_1.PersonID INNER JOIN
                         Countries ON People_1.CountryID = Countries.CountryID INNER JOIN
                         Users ON Customers.CreatedByUserID = Users.UserID AND Accounts.CreatedByUserID = Users.UserID AND People_1.PersonID = Users.PersonID INNER JOIN
			  AccountTypes ON Accounts.AccountTypeID = AccountTypes.AccountTypeID
              
---------------------------------------------------------------------------------------


----------------------------------------------------------------------------------------
                               -- 





-----------------------------------------------------------------------------------------

