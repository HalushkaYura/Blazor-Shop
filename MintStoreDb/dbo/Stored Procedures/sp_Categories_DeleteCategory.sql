CREATE PROCEDURE [dbo].[sp_Categories_DeleteCategory]
	@CategoryId INT
AS
BEGIN
	DELETE FROM [dbo].[Categories]
	WHERE [CategoryId] = @CategoryId
END