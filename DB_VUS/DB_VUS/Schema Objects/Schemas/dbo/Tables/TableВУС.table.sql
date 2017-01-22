CREATE TABLE [dbo].[TableВУС]
(
	id int identity(1,1) NOT NULL, 
	[код спечиальности] nvarchar(50) NOT NULL,
	[наименование] nvarchar(200) NOT NULL,
	состав int NOT NULL
)
