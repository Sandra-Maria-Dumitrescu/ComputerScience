USE [Agenda]
GO

/****** Object:  StoredProcedure [dbo].[DB_Add]    Script Date: 09/03/2017 14:04:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[DB_Add]
@id int,
@name varchar(50),
@fname varchar(50),
@phone varchar(50),
@email varchar(50)
as
begin
	insert into Contact values (@name, @fname, @phone, @email)

end
GO

