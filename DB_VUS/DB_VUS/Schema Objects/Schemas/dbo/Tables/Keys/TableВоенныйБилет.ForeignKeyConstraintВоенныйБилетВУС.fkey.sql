ALTER TABLE [dbo].[TableВоенныйБилет]
	ADD CONSTRAINT [ForeignKeyConstraintВоенныйБилетВУС] 
	FOREIGN KEY (ВУС)
	REFERENCES tableВУС (id)	

