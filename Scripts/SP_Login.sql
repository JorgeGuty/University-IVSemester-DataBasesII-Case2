SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jorge Gutiérrez
-- Create date: 9/18/2020
-- Description:	Created SP_LogIn
-- =============================================
CREATE PROCEDURE SP_LogIn
	
	@pEmail     varchar(100)
	,@pPassword varchar(150)

AS
BEGIN
	
	DECLARE @UserId INT

	DECLARE @InvalidLogInSeverity INT
	SET     @InvalidLogInSeverity = 1

	DECLARE @InvalidLoginState INT
	SET     @InvalidLoginState = 5000

	-- Email and password validation

	SELECT 
		@UserId = u.ID
	FROM 
		dbo.[User] AS u
	WHERE 
		u.Email = @pEmail AND u.Password = @pPassword

	IF @UserId IS NULL
	BEGIN
		RAISERROR('Email o contraseña invalidos.', @InvalidLogInSeverity, @InvalidLoginState)
	END

	-- Select de los permisos

    SELECT DISTINCT
		p.Codigo
	FROM 
		[dbo].[Permisos] AS p
	INNER JOIN
		[dbo].[PermisosXRole] AS pr
		ON
			p.ID = pr.[PermisosId]
	INNER JOIN 
		[dbo].[UsersXRol] AS ur
		ON
			ur.IdUser = @UserId AND ur.idRole = pr.RolId
	INNER JOIN 
		[dbo].[PermisosXUser] AS pu
		ON 
			pu.ID = p.PermisosId AND pu.idUser = @UserId

END
GO
