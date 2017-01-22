ALTER TABLE [dbo].[TableВоенныйБилет]
	ADD CONSTRAINT [ForeignKeyConstraintВоенныйБилетВидВоенныйБилет] 
	FOREIGN KEY ([вид документа])
	REFERENCES TableВидВоенныйБилет (id)	

