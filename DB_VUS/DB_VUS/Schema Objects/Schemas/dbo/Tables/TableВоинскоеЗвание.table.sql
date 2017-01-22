CREATE TABLE [dbo].[TableВоинскоеЗвание]
(
	id int identity(1,1) NOT NULL, 
	наименование NVARCHAR(200) NOT NULL,
	классификатор int NOT NULL
)
