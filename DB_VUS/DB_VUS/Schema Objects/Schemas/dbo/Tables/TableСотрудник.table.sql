CREATE TABLE [dbo].[TableСотрудник]
(
	id int identity(1,1) NOT NULL, 
	организация int NOT NULL,
	фамилия nvarchar(20) NULL,
	имя nvarchar(20) NULL,
	отчество nvarchar(20) NULL,
	датарождения date NOT NULL,
	пол      CHAR(1) NOT NULL,
	[паспортные данные] nvarchar(100) NOT NULL,
	[адрес жительства] nvarchar(200) NOT NULL,
	[адрес пребывания] nvarchar(200),
	статус int NOT NULL,
	[дата приема] Date NOT NULL,
	[дата увольнения] Date NULL,
	[категория годности] int NOT NULL,
	специальность int NOT NULL
)
