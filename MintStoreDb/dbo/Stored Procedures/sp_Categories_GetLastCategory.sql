CREATE PROCEDURE [dbo].[sp_Categories_GetLastCategory]
AS
BEGIN
    SELECT TOP 1 *
    FROM [dbo].[Categories]
    ORDER BY [CategoryId] DESC;
END