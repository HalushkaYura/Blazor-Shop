CREATE TABLE [dbo].[OrderItems] (
    [OrderId]   INT             NOT NULL,
    [ItemId]    INT             NOT NULL,
    [ProductId] INT             NOT NULL,
    [Quantity]  INT             NOT NULL,
    [Price]     DECIMAL (10, 2) NOT NULL,
    [Discount]  DECIMAL (4, 2)  DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([OrderId] ASC, [ItemId] ASC),
    CONSTRAINT [FK_OrderItems_Orders] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Orders] ([OrderId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_OrderItems_Products] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([ProductId]) ON DELETE CASCADE ON UPDATE CASCADE
);

