CREATE PROCEDURE [dbo].[sp_Customers_GetById]
    @CustomerId INT
AS
BEGIN
    SELECT * FROM [dbo].[Customers] WHERE [CustomerId] = @CustomerId;
END
