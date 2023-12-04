CREATE PROCEDURE sp_Products_GetByCategory
    @CategoryId INT
AS
BEGIN
    SELECT * FROM Products
    WHERE CategoryId = @CategoryId;
END