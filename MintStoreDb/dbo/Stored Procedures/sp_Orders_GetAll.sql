CREATE PROCEDURE [dbo].[sp_Orders_GetAll]
AS
BEGIN
    SELECT * FROM [dbo].[Orders];
END
