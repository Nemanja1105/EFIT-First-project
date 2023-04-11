
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE UpdateVerified
@korisnikId int,
@verified bit=null
AS
BEGIN

	SET NOCOUNT ON;
	UPDATE Login
	SET IsVerified=@verified
	WHERE Korisnik_ID$=@korisnikId;
END
GO
