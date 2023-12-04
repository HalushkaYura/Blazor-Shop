CREATE PROCEDURE [dbo].[sp_Products_GetLastProduct]
AS
BEGIN
    SELECT TOP 1 *
    FROM [dbo].[Products]
    ORDER BY [ProductId] DESC;
END