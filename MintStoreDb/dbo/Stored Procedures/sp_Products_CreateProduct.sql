CREATE PROCEDURE [dbo].[sp_Products_CreateProduct]
    @ProductName NVARCHAR(100),
    @BrandId INT,
    @CategoryId INT,
    @ModelYear SMALLINT,
    @Price DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO [dbo].[Products] ([ProductName], [BrandId], [CategoryId], [ModelYear], [Price])
    VALUES (@ProductName, @BrandId, @CategoryId, @ModelYear, @Price);
END
