CREATE TABLE [dbo].[Customers] (
    [CustomerId] INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (100) NOT NULL,
    [LastName]   NVARCHAR (100) NOT NULL,
    [Phone]      NVARCHAR (25)  NULL,
    [Email]      NVARCHAR (100) NOT NULL,
    [Street]     NVARCHAR (100) NULL,
    [City]       NVARCHAR (50)  NULL,
    [State]      NVARCHAR (25)  NULL,
    [ZipCode]    NVARCHAR (5)   NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

