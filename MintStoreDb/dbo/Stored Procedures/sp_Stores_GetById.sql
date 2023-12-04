CREATE PROCEDURE [dbo].[sp_Stores_GetById]
    @StoreId INT
AS
BEGIN
    SELECT * FROM [dbo].[Stores] WHERE [StoreId] = @StoreId;
END
