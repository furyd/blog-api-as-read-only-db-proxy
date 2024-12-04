ALTER TABLE [dbo].[OrderItems]
	ADD CONSTRAINT [OrderItems_Order_Orders_ID_FK]
	FOREIGN KEY ([Order])
	REFERENCES [Orders] ([RowId])
