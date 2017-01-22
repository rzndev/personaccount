CREATE TABLE [dbo].[TableСведенияОРодственниках]
(
	id int identity(1,1) NOT NULL, 
	сотрудник int NOT NULL,
	ФИО nvarchar(20) NULL,
	ДатаРождения Date NOT NULL,
	Пол char(1) NOT NULL,
	[Степень родства] int NOT NULL,
	[Проживает с сотрудником] int NOT NULL,
	Адрес nvarchar(20) NULL
)
