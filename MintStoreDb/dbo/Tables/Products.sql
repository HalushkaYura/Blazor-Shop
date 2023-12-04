CREATE TABLE [dbo].[Products] (
    [ProductId]   INT             IDENTITY (1, 1) NOT NULL,
    [ProductName] NVARCHAR (100)  NOT NULL,
    [BrandId]     INT             NOT NULL,
    [CategoryId]  INT             NOT NULL,
    [ModelYear]   SMALLINT        NOT NULL,
    [Price]       DECIMAL (10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([ProductId] ASC),
    CONSTRAINT [FK_Products_Brands] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brands] ([BrandId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Products_Categories] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([CategoryId]) ON DELETE CASCADE ON UPDATE CASCADE
);

