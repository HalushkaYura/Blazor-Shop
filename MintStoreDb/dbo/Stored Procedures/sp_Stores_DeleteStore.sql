CREATE PROCEDURE [dbo].[sp_Stores_DeleteStore]
    @StoreId INT
AS
BEGIN
    DELETE FROM [dbo].[Stores]
    WHERE StoreId = @StoreId;
END
