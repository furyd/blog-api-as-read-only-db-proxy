CREATE TABLE [dbo].[Orders]
(
		[RowId]				INT							NOT NULL		IDENTITY(1,1)
	,	[Id]				UNIQUEIDENTIFIER			NOT NULL		DEFAULT(NewId())
	,	[Name]				VARCHAR(32)					NOT NULL
)
