SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE TreningPostoji
@korisnikId int=null,
@dan nvarchar(50)=null
AS
BEGIN
	SET NOCOUNT ON;
	SELECT CAST(COUNT(*)AS BIT) FROM Treninzi
	WHERE KorisnikId=@korisnikId AND Dan=@dan;

END
GO
