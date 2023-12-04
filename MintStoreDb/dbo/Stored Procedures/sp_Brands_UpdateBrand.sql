CREATE PROCEDURE [dbo].[sp_Brands_UpdateBrand]
    @BrandId INT,
    @BrandName NVARCHAR(100) 
AS
BEGIN
    UPDATE [dbo].[Brands]
    SET
        [BrandName] = @BrandName
    WHERE [BrandId] = @BrandId;
END
