CREATE PROCEDURE [dbo].[sp_Products_DeleteProduct]
	@ProductId INT
AS
BEGIN
	DELETE FROM [dbo].[Products]
	WHERE [ProductId] = @ProductId
END