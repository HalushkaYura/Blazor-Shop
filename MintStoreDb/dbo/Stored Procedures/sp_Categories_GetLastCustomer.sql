CREATE PROCEDURE [dbo].[sp_Categories_GetLastCustomer]
AS
BEGIN
    SELECT TOP 1 *
    FROM [dbo].[Customers]
    ORDER BY [CustomerId] DESC;
END