INSERT INTO CategoriasDePermiso(description) VALUES
('A'),
('B'),
('C');
GO

INSERT INTO Permisos(description, code, type, category_id) VALUES
('ver el saldo de la sucursal', 69, 1, 1),
('editar la informacion de sucursales', 420, 2, 2),
('Eliminar sucursales', 69420, 3, 3),
('Ver reporte de transacciones de la sucursal', 42069, 1, 1);
GO

INSERT INTO Roles(name) VALUES
('usuario'),
('administrador'),
('desarrollador'),
('mantenimiento');
GO

INSERT INTO Sucursal(saldo, nombre) VALUES
(2, 'Montes de Oca')
GO

INSERT INTO [User](name, email, password, sucursal_id) VALUES
('abc123', 'abc123@gmail.com', '14afd551e6b3048a20a23265f4b7f3fa6e02b184e620dc986a329b982a232dbb', 1),
('palomitademaiz','palomitademaiz@sumama.cr', '9acf59589c3a23aedc40cc58984cfc12922f02377d4275750a332694d97422c4', 1),
('Elena_Nito.DelBosque', 'Elena_Nito.DelBosque@wonderland.disney', 'c96ece3e7f461ae1b6de070760507392c109b2b4ca5b508c901e909010ff43c7', 1),
('HelenChufe123', 'HelenChufe123@hotmail.com', '0aa86850aa797970b27e50d065de8393e67dbdbea8d70c663f549e6f1fc07406', 1),
('ElsaPato-Nike', 'ElsaPato-Nike@flexthatbitch.usa', 'a594e5d84e770d52864410a051abc008f786937302fe2cf82010c129223da6ba', 1);
GO

INSERT INTO UserPorRol(user_id, rol_id) VALUES
(1, 1),
(2, 2),
(3, 3),
(5, 4);
GO

INSERT INTO PermisosPorRol(rol_id, permiso_id, postTime, deleted) VALUES
(1, 1, getdate(), 0),
(2, 1, getdate(), 0),
(2, 2, getdate(), 0),
(2, 3, getdate(), 0),
(2, 4, getdate(), 0),
(3, 2, getdate(), 0),
(3, 3, getdate(), 0),
(4, 2, getdate(), 0),
(4, 3, getdate(), 0),
(4, 4, getdate(), 0);
GO

INSERT INTO PermisosPorUsuario(user_id, permiso_id, postTime, deleted) VALUES
(4, 1, getdate(), 0),
(4, 2, getdate(), 0),
(4, 4, getdate(), 0);
GO


EXEC SP_LOGIN 'ElsaPato-Nike@flexthatbitch.usa','a594e5d84e770d52864410a051abc008f786937302fe2cf82010c129223da6ba'
