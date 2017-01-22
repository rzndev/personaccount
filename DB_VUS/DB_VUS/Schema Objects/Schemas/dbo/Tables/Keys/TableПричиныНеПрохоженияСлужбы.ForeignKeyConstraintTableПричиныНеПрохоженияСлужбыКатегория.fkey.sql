ALTER TABLE [dbo].[TableПричиныНеПрохоженияСлужбы]
	ADD CONSTRAINT [ForeignKeyConstraintTableПричиныНеПрохоженияСлужбыКатегория] 
	FOREIGN KEY (причина)
	REFERENCES TableКлассификаторПричиныНеПрохожденияСлужбы (id)	

