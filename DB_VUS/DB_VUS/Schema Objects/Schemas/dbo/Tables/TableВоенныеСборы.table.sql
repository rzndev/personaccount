CREATE TABLE [dbo].[TableВоенныеСборы]
(
	id int identity(1,1) NOT NULL, 
    сотрудник int NOT NULL,
	[Дата начала] Date not null,
	[Дата окончания] Date not null,
	[место проведения] nvarchar (300)
)
