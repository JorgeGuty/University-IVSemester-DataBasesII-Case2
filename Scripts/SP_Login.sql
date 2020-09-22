-- =============================================
-- Author:		Jorge Gutiérrez Cordero
-- Create date: 9/18/2020
-- Description:	Created SP_LogIn
-- =============================================
-- Author:		Jorge Gutiérrez Cordero
-- Change date: 9/19/2020
-- Description:	Updated column call names
-- =============================================

CREATE OR ALTER PROCEDURE SP_LogIn
	
	@pEmail     varchar(100)
	,@pPassword varchar(150)

AS
BEGIN
	
	DECLARE @UserId INT

	DECLARE @InvalidLogInSeverity INT
	SET     @InvalidLogInSeverity = 16

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

    SELECT
		p.Code
	FROM 
		Permisos AS p
	INNER JOIN
		PermisosPorRol AS pr
		ON
			p.ID = pr.Permiso_id
	INNER JOIN 
		UserPorRol AS ur
		ON
			ur.[User_id] = @UserId AND ur.Rol_id = pr.Rol_id
	UNION
    SELECT P.CODE
    FROM PERMISOS P
        INNER JOIN PermisosPorUsuario PPU on P.id = PPU.permiso_id AND PPU.user_id = @UserId
END
go

