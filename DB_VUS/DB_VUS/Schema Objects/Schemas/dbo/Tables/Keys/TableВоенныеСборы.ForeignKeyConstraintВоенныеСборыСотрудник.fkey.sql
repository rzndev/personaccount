ALTER TABLE [dbo].[TableВоенныеСборы]
	ADD CONSTRAINT [ForeignKeyConstraintВоенныеСборыСотрудник] 
	FOREIGN KEY (сотрудник)
	REFERENCES tableСотрудник (id)	

