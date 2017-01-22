ALTER TABLE [dbo].[TableСведенияОРодственниках]
	ADD CONSTRAINT [ForeignKeyConstraintСведенияОРодственникахСотрудник] 
	FOREIGN KEY (сотрудник)
	REFERENCES tableСотрудник (id)	

