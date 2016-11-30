USE [GD2C2016]
GO
/****** Object:  StoredProcedure [Select_Group].[sp_cancelacionProfesional]    Script Date: 30/11/2016 19:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [Select_Group].[sp_cancelacionProfesional](@Motivo varchar(45), @tipoMot int, @idProf int, @fechaDesde datetime, @fechaHasta datetime)
AS
BEGIN
	
	SET NOCOUNT ON;

    DECLARE turnos CURSOR FOR
	SELECT T.idTurno
	FROM Select_Group.Agenda A
	JOIN Select_Group.Turno T ON T.idAgenda = A.idAgenda
	WHERE A.profesional_IdProfesional = @idProf
	AND T.fechaTurno BETWEEN @fechaDesde AND @fechaHasta

	
	declare @idCanc int;
	declare @idTurno int;

	INSERT INTO Select_Group.Cancelacion(motivo, tipo_Cancelacion_idTipoCanc)
	VALUES(@Motivo, @tipoMot);

	SET @idCanc = (SELECT max(idCancelacion) FROM Select_Group.Cancelacion);

	OPEN turnos;

	FETCH NEXT FROM turnos INTO @idTurno;

	WHILE (@@FETCH_STATUS = 0)

	BEGIN

	UPDATE [Select_Group].[Turno]
	SET estado = 2,
	cancelacion_idCancelacion = @idCanc
	WHERE 
	idTurno = @idTurno;


	FETCH NEXT FROM turnos INTO @idTurno;
	END;

	CLOSE turnos;
	DEALLOCATE turnos;

END
