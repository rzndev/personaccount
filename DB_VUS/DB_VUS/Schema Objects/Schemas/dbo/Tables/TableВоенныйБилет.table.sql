CREATE TABLE [dbo].[TableВоенныйБилет]
(
	id int identity(1,1) NOT NULL, 
	сотрудник int NOT NULL,
	[дата выдачи] Date NOT NULL,
	[вид документа] int NOT NULL,
	[Воинское звание] int NOT NULL,
	[ВУС] int NOT NULL,
	[Рост] int NOT NULL,
	[Размер головы] int NOT NULL,
	[Размер обуви] int NOT NULL  
)
