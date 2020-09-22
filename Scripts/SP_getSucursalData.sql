-- =============================================
-- Author:		Jorge Gutiérrez Cordero
-- Create date: 9/18/2020
-- Description:	Created SP_getSucursalData
-- =============================================

-- This SP assumes that the user only has assigned ONE sucursal at a time.

CREATE OR ALTER PROCEDURE SP_getSucursalData
	
	@pEmail varchar(100)

AS
BEGIN
	
    SELECT 
        sucursal.nombre AS [Name], 
        sucursal.saldo  AS Balance
    FROM 
        dbo.Sucursal AS sucursal
    INNER JOIN 
        dbo.[User]   AS [user]
        ON
            sucursal.id = [user].sucursal_id
    WHERE 
        [user].email = @pEmail
        
END
go