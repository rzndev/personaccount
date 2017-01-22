CREATE TABLE [dbo].[TableСведенияОбОрганизации]
(
	id int identity(1,1) NOT NULL, 
	наименование nvarchar(200) NOT NULL,
	адрес nvarchar(200) NOT NULL,
	телефон nvarchar(100) NOT NULL
)
