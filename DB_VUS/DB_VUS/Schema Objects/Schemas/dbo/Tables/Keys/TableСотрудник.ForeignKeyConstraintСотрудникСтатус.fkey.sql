ALTER TABLE [dbo].[TableСотрудник]
	ADD CONSTRAINT [ForeignKeyConstraintСотрудникСтатус] 
	FOREIGN KEY (статус)
	REFERENCES tableСтатусСотрудника (id)	

