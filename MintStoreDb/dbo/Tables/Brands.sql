CREATE TABLE [dbo].[Brands] (
    [BrandId]   INT            IDENTITY (1, 1) NOT NULL,
    [BrandName] NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([BrandId] ASC)
);

