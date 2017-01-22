CREATE TABLE [dbo].[TableСтатусСотрудника]
(
	id int identity(1,1) NOT NULL, 
	наименование nvarchar(20) NOT NULL,
	[код классификации] int NOT NULL
)
