ALTER TABLE [dbo].[TableСотрудник]
	ADD CONSTRAINT [ForeignKeyConstraintСотрудникСпециальность] 
	FOREIGN KEY (специальность)
	REFERENCES tableСпециальность (id)	

