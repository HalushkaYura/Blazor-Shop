CREATE TABLE [dbo].[Staffs] (
    [StaffId]   INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (100) NOT NULL,
    [LastName]  NVARCHAR (100) NOT NULL,
    [Email]     NVARCHAR (100) NOT NULL,
    [Phone]     NVARCHAR (25)  NULL,
    [Active]    BIT            NULL,
    [StoreId]   INT            NOT NULL,
    [ManagerId] INT            NULL,
    PRIMARY KEY CLUSTERED ([StaffId] ASC),
    CONSTRAINT [FK_Staffs_Manager] FOREIGN KEY ([ManagerId]) REFERENCES [dbo].[Staffs] ([StaffId]),
    CONSTRAINT [FK_Staffs_Stores] FOREIGN KEY ([StoreId]) REFERENCES [dbo].[Stores] ([StoreId]) ON DELETE CASCADE ON UPDATE CASCADE,
    UNIQUE NONCLUSTERED ([Email] ASC)
);

