USE [Agenda]
GO

/****** Object:  StoredProcedure [dbo].[GUI_getMaxID]    Script Date: 09/03/2017 14:05:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[GUI_getMaxID]
as
begin
SELECT max(id)
FROM Contact
end
GO

