CREATE TABLE [dbo].[TableСведенияОВоеннойПодготовке]
(
	id int identity(1,1) NOT NULL,
	сотрудник int NOT NULL, 
	[Военная кафедра] nvarchar(200) NULL,
	[Дата] Date NOT NULL,

)
