CREATE PROCEDURE [dbo].[sp_Stores_CreateStore]
    @StoreName NVARCHAR(100),
    @Phone NVARCHAR(25) = NULL,
    @Email NVARCHAR(100) = NULL,
    @Street NVARCHAR(100) = NULL,
    @City NVARCHAR(50) = NULL,
    @State NVARCHAR(25) = NULL,
    @ZipCode NVARCHAR(5) = NULL
AS
BEGIN
    INSERT INTO [dbo].[Stores] ([StoreName], [Phone], [Email], [Street], [City], [State], [ZipCode])
    VALUES (@StoreName, @Phone, @Email, @Street, @City, @State, @ZipCode);
END