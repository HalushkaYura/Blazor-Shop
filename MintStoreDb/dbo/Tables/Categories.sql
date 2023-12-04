CREATE TABLE [dbo].[Categories] (
    [CategoryId]   INT            IDENTITY (1, 1) NOT NULL,
    [CategoryName] NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([CategoryId] ASC)
);

