CREATE PROCEDURE [dbo].[sp_Customers_CreateCustomer]
    @FirstName NVARCHAR(100),
    @LastName NVARCHAR(100),
    @Phone NVARCHAR(25) = NULL,
    @Email NVARCHAR(100),
    @Street NVARCHAR(100) = NULL,
    @City NVARCHAR(50) = NULL,
    @State NVARCHAR(25) = NULL,
    @ZipCode NVARCHAR(5) = NULL
AS
BEGIN
    INSERT INTO [dbo].[Customers] (
        [FirstName], [LastName], [Phone], [Email], [Street], [City], [State], [ZipCode]
    )
    VALUES (
        @FirstName, @LastName, @Phone, @Email, @Street, @City, @State, @ZipCode
    );
END
