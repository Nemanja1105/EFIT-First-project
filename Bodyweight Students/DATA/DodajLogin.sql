
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE DodajLogin
@email nvarchar(50)=null,
@password nvarchar(50)=null,
@verified bit=null,
@korisnikId int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Login(Email,Password,IsVerified,Korisnik_ID$)
	VALUES(@email,@password,@verified,@korisnikId);

END
GO
