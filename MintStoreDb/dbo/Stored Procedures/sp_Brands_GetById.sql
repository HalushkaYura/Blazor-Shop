CREATE   PROCEDURE [dbo].[sp_Brands_GetById]
    @BrandId INT
AS
BEGIN
    SELECT * FROM [dbo].[Brands] WHERE [BrandId] = @BrandId;
END
