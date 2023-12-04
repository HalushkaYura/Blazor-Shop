CREATE PROCEDURE [dbo].[sp_Products_UpdateProduct]
    @ProductId INT,
    @ProductName NVARCHAR(255),
    @BrandId INT,
    @CategoryId INT,
    @ModelYear SMALLINT,
    @Price DECIMAL(18, 2)
AS
BEGIN
    UPDATE Products
    SET
        ProductName = @ProductName,
        BrandId = @BrandId,
        CategoryId = @CategoryId,
        ModelYear = @ModelYear,
        Price = @Price
    WHERE
        ProductId = @ProductId;
END;