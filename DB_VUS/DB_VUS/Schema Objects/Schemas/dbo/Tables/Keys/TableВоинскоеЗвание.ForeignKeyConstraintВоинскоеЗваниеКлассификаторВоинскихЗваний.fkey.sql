ALTER TABLE [dbo].[TableВоинскоеЗвание]
	ADD CONSTRAINT [ForeignKeyConstraintВоинскоеЗваниеКлассификаторВоинскихЗваний] 
	FOREIGN KEY (классификатор)
	REFERENCES tableКлассификаторВоинскихЗваний (id)	

