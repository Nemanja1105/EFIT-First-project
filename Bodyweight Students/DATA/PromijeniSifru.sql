
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE PromjeniSifru
@korisnikId int,
@password nvarchar(50)=null

AS
BEGIN
	SET NOCOUNT ON;
	update Login
	SET Password=@password
	WHERE Korisnik_ID$=@korisnikId;
END
GO
