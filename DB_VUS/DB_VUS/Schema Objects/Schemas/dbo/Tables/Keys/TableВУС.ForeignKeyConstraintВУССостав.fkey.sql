ALTER TABLE [dbo].[TableВУС]
	ADD CONSTRAINT [ForeignKeyConstraintВУССостав] 
	FOREIGN KEY (состав)
	REFERENCES tableСоставПрофиль (id)	

