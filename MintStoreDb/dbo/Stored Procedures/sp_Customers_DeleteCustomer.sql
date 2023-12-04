CREATE PROCEDURE [dbo].[sp_Customers_DeleteCustomer]
    @CustomerId INT
AS
BEGIN
    DELETE FROM [dbo].[Customers]
    WHERE [CustomerId] = @CustomerId;
END
