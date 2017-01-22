ALTER TABLE [dbo].[TableСведенияОВоеннойПодготовке]
	ADD CONSTRAINT [ForeignKeyConstraintСведенияОВоеннойПодготовкеСотрудник] 
	FOREIGN KEY (сотрудник)
	REFERENCES tableСотрудник (id)	

