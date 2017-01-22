ALTER TABLE [dbo].[TableСпециальность]
	ADD CONSTRAINT [ForeignKeyConstraintСпециальностьКлассификаторСпециальности] 
	FOREIGN KEY (классификатор)
	REFERENCES tableКлассификаторСпециальности (id)	

