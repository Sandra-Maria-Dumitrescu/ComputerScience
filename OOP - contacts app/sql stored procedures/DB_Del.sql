USE [Agenda]
GO

/****** Object:  StoredProcedure [dbo].[DB_Del]    Script Date: 09/03/2017 14:05:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[DB_Del]
@id int
as
begin
	delete from Contact where id = @id

end
GO

