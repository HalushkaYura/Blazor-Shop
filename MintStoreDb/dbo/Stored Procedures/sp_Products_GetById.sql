CREATE PROCEDURE [dbo].[sp_Products_GetById]
    @ProductId INT
AS
BEGIN
    SELECT * FROM [dbo].[Products] WHERE [ProductId] = @ProductId;
END
