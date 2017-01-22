ALTER TABLE [dbo].[TableПричиныНеПрохоженияСлужбы]
	ADD CONSTRAINT [ForeignKeyConstraintПричиныНеПрохоженияСлужбыСотрудник] 
	FOREIGN KEY (сотрудник)
	REFERENCES tableСотрудник (id)	

