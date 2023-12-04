CREATE PROCEDURE [dbo].[sp_Stores_UpdateStore]
    @StoreId INT,
    @StoreName NVARCHAR(100),
    @Phone NVARCHAR(25) = NULL,
    @Email NVARCHAR(100) = NULL,
    @Street NVARCHAR(100) =NULL,
    @City NVARCHAR(50) = NULL,
    @State NVARCHAR(25) = NULL,
    @ZipCode NVARCHAR(5) = NULL
AS
BEGIN
    UPDATE [dbo].[Stores]
    SET
        [StoreName] = @StoreName,
        [Phone] = ISNULL(@Phone, [Phone]),
        [Email] = ISNULL(@Email, [Email]),
        [Street] = ISNULL(@Street, [Street]),
        [City] = ISNULL(@City, [City]),
        [State] = ISNULL(@State, [State]),
        [ZipCode] = ISNULL(@ZipCode, [ZipCode])
    WHERE StoreId = @StoreId;
END