USE [GD2C2016]
GO
/****** Object:  StoredProcedure [Select_Group].[ActualizarPlan]    Script Date: 06/12/2016 18:19:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--=============================================================================================================
--TIPO		: Store Procedure
--NOMBRE	: ActualizarPlan
--OBJETIVO  : Actualiza el plan de un afiliado.                                     
--=============================================================================================================

ALTER PROCEDURE [Select_Group].[ActualizarPlan](@idPlan int,@nroAfiliado int, @motivo varchar(45))
		
AS

BEGIN
	SET NOCOUNT ON;
	
	DECLARE @planAnterior int;
	DECLARE @idAfiliado int;


	BEGIN TRAN
	SET @planAnterior = (SELECT plan_idPlan FROM Select_Group.Afiliado WHERE nroAfiliado = @nroAfiliado);
	SET @idAfiliado = (SELECT idAfiliado FROM Select_Group.Afiliado WHERE nroAfiliado = @nroAfiliado);

		UPDATE Select_Group.Afiliado
		Set plan_idPlan = @idPlan
		Where nroAfiliado = @nroAfiliado

		INSERT INTO Select_Group.Plan_Historico(planNuevo,motivoCambio,fechaCambio,planAnterior,afiliado_idAfiliado)
		VALUES(@idPlan,@motivo, getdate(),@planAnterior,@idAfiliado)

	COMMIT TRAN

END
