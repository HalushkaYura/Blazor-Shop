CREATE PROCEDURE [dbo].[sp_Stores_GetLastStore]
AS
BEGIN
    SELECT TOP 1 *
    FROM [dbo].[Stores]
    ORDER BY [StoreId] DESC;
END