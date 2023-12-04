CREATE PROCEDURE [dbo].[sp_Categories_UpdateCategory]
	-- Add the parameters for the stored procedure here
	@CategoryId INT,
	@CategoryName NVARCHAR(50)
	AS
BEGIN
	UPDATE [dbo].[Categories]
	SET [CategoryName] = @CategoryName
	WHERE  [CategoryId] = @CategoryId
END
