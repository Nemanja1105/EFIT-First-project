USE [BodyWeight DB]
GO
/****** Object:  StoredProcedure [dbo].[EmailPasswordLogin]    Script Date: 11.12.2019. 21:32:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE EmailPasswordLogin
@email nvarchar(50)=null,
@password nvarchar(50)=null

AS
BEGIN
	
	SET NOCOUNT ON;
	SELECT Korisnik_ID$ FROM Login
	WHERE Email=@email AND Password=@password;
	
	

END
