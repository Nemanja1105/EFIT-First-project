
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE IzmjeniTrening
@naziv nvarchar(50)=null,
@opis nvarchar(MAX)=null,
@treningId int=null
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Treninzi
	SET Naziv=@naziv,Opis=@opis
	WHERE @treningId=TreningId;
END
GO
