CREATE TABLE [dbo].[OrderItems]
(
		[RowId]				INT							NOT NULL		IDENTITY(1,1)
	,	[Id]				UNIQUEIDENTIFIER			NOT NULL		DEFAULT(NewId())
	,	[Order]				INT							NOT NULL
	,	[Name]				VARCHAR(32)					NOT NULL
)
