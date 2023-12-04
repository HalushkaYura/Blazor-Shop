CREATE PROCEDURE [dbo].[sp_Customers_UpdateCustomer]
    @CustomerId INT,
    @FirstName NVARCHAR(100) = NULL,
    @LastName NVARCHAR(100) = NULL,
    @Phone NVARCHAR(25) = NULL,
    @Email NVARCHAR(100) = NULL ,
    @Street NVARCHAR(100) = NULL,
    @City NVARCHAR(50) = NULL,
    @State NVARCHAR(25) = NULL,
    @ZipCode NVARCHAR(5) = NULL
AS
BEGIN
    UPDATE [dbo].[Customers]
    SET
        [FirstName] = ISNULL(@FirstName,[FirstName]),
        [LastName] = ISNULL(@LastName,[LastName]),
        [Phone] = ISNULL(@Phone,[Phone]),
        [Email] = ISNULL(@Email,[Email]),
        [Street] = ISNULL(@Street, [Street]),
        [City] = ISNULL(@City,[City]),
        [State] = ISNULL(@State,[State]),
        [ZipCode] = ISNULL(@ZipCode,[ZipCode])
    WHERE [CustomerId] = @CustomerId;
END