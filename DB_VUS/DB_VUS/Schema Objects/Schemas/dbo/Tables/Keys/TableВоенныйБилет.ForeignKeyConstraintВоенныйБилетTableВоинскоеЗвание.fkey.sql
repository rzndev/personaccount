ALTER TABLE [dbo].[TableВоенныйБилет]
	ADD CONSTRAINT [ForeignKeyConstraintВоенныйБилетTableВоинскоеЗвание] 
	FOREIGN KEY ([Воинское звание])
	REFERENCES tableВоинскоеЗвание (id)	

