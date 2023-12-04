CREATE PROCEDURE [dbo].[sp_Categories_CreateCategory]
		  @CategoryName NVARCHAR(50)
AS
BEGIN

	INSERT INTO [dbo].[Categories]([CategoryName])
    VALUES (@CategoryName);

END
