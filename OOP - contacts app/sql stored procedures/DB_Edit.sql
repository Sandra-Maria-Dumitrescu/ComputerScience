USE [Agenda]
GO

/****** Object:  StoredProcedure [dbo].[DB_Edit]    Script Date: 09/03/2017 14:05:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[DB_Edit]
@id int,
@name varchar(50),
@fname varchar(50),
@phone varchar(50),
@email varchar(50)
as
begin
	update Contact 
	set name = @name, [first name] = @fname, phone =@phone, email = @email
	where id = @id

end
GO

