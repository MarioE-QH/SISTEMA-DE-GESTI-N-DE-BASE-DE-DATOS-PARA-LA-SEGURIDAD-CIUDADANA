USE Seguridad_Ciudadana
GO

--1
USE Seguridad_Ciudadana
GO
CREATE TRIGGER TR_SERENAZGO
	ON SERENAZGO
	 FOR INSERT
AS
BEGIN
	DECLARE
	@IDPPATRULLA			INT

	SELECT 
		@IDPPATRULLA = COUNT(S.IdPatrulla)
		
		FROM SERENAZGO S, inserted I
	
		WHERE S.IdPatrulla = I.IdPatrulla
	

	IF @IDPPATRULLA	<3
	BEGIN
		COMMIT TRANSACTION
	END
	ELSE
	BEGIN
		RAISERROR('ERROR ESTA PATRULLA YA ESTA ASIGNADA A DOS SEREZAGOS',16,2)
		ROLLBACK TRANSACTION
		
	END
END
GO


--2 

CREATE TRIGGER TR_EMPLEADO_SEGURIDAD
	ON EMPLEADO_SEGURIDAD
	 FOR INSERT
AS
BEGIN
	DECLARE
	@IDEMPLEADO			INT
	
	SELECT 
	@IDEMPLEADO	= I.IdEmpleado
	FROM inserted I

	INSERT INTO  AREA_SEGURIDAD VALUES(GETDATE(),@IDEMPLEADO,1)

END
GO

--3

CREATE trigger NOBAJARRANGO 
on POLICIA 
for Update 
as 
Begin 

	begin transaction 
	declare @IdPoli integer
	declare @IdRango integer 
	declare @ranguitoant integer
	--declare @rangodespues integer

	select @IdPoli=d.IdPolicia ,
			@ranguitoant = d.IdRango
	from deleted d
	
	select @IdRango=i.IdRango 
	from inserted i

	If @IdRango<@ranguitoant 
	BEGIN
		UPDATE POLICIA 
		set IdRango = @IdRango
		where IdPolicia =@IdPoli 
		commit transaction 
	END
	ELSE
	BEGIN
		RAISERROR('No se puede bajar lvl ps',16,2)
		ROLLBACK TRANSACTION
	END
	End 
go

