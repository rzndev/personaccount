CREATE TABLE [dbo].[TableПричиныНеПрохоженияСлужбы]
(
	id int identity(1,1) NOT NULL, 
	сотрудник int not NULL,
	дата date not null,
	причина int not NULL,
	комментарий nvarchar(200)
)
