ALTER TABLE [dbo].[TableСотрудник]
	ADD CONSTRAINT [ForeignKeyConstraintСотрудникСведенияОбОрганизации] 
	FOREIGN KEY (организация)
	REFERENCES tableСведенияОбОрганизации (id)	

