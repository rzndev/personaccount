ALTER TABLE [dbo].[TableСотрудник]
	ADD CONSTRAINT [ForeignKeyConstraintСотрудникКатегорияГодности] 
	FOREIGN KEY ([категория годности])
	REFERENCES tableКатегорияГодностиКВС (id)	

