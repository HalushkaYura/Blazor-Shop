CREATE TABLE [dbo].[Stores] (
    [StoreId]   INT            IDENTITY (1, 1) NOT NULL,
    [StoreName] NVARCHAR (100) NOT NULL,
    [Phone]     NVARCHAR (25)  NULL,
    [Email]     NVARCHAR (100) NULL,
    [Street]    NVARCHAR (100) NULL,
    [City]      NVARCHAR (50)  NULL,
    [State]     NVARCHAR (25)  NULL,
    [ZipCode]   NVARCHAR (5)   NULL,
    PRIMARY KEY CLUSTERED ([StoreId] ASC)
);

