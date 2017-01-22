ALTER TABLE [dbo].[TableВоенныйБилет]
	ADD CONSTRAINT [ForeignKeyConstraintВоенныйБилетСотрудник] 
	FOREIGN KEY (сотрудник)
	REFERENCES tableСотрудник (id)	

