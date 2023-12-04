CREATE PROCEDURE [dbo].[sp_Customers_GetAll]
AS
BEGIN
    SELECT * FROM [dbo].[Customers];
END
