CREATE   PROCEDURE [dbo].[sp_Categories_GetById]
    @CategoryId INT
AS
BEGIN
    SELECT * FROM [dbo].[Categories] WHERE [CategoryId] = @CategoryId;
END
