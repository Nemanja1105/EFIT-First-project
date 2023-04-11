
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE UpdateVjezba
	@id int=null,
	@naziv nvarchar(50)=null,
	@ytCode nvarchar(50)=null,
	@tezina nvarchar(50)=null,
	@opis nvarchar(MAX)=null,
	@tipVjezbe nvarchar(50)=null,
	@dioTijela nvarchar(50)=null
AS
BEGIN
	UPDATE Vjezbe
	SET naziv=@naziv,ytCode=@ytCode,tezinaVjezbe=@tezina,opis=@opis,tipVjezbe=@tipVjezbe,dioTijela=@dioTijela
	WHERE @id=vjezbaId;
	SET NOCOUNT ON;
END
GO
