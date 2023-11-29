CREATE TABLE [dbo].[Orders] (
    [OrderId]      INT      IDENTITY (1, 1) NOT NULL,
    [CustomerId]   INT      NULL,
    [OrderStatus]  TINYINT  NOT NULL,
    [OrderDate]    DATETIME NOT NULL,
    [RequiredDate] DATETIME NOT NULL,
    [ShippedDate]  DATETIME NULL,
    [StoreId]      INT      NOT NULL,
    [StaffId]      INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([OrderId] ASC),
    CONSTRAINT [FK_Orders_Customers] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Orders_Staffs] FOREIGN KEY ([StaffId]) REFERENCES [dbo].[Staffs] ([StaffId]),
    CONSTRAINT [FK_Orders_Stores] FOREIGN KEY ([StoreId]) REFERENCES [dbo].[Stores] ([StoreId]) ON DELETE CASCADE ON UPDATE CASCADE
);

