CREATE TABLE usuarioSCHARP
(
Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
nombre nvarchar(40) null,
aPaterno NVARCHAR(40) NULL,
aMaterno NVARCHAR(40) NULL,
fechaNac DATETIME,
tipoCuenta NVARCHAR(20) NOT NULL,
nombreUsuario NVARCHAR(50) NOT NULL	,
clave NVARCHAR(50) NOT NULL
);

SELECT * FROM usuarioSCHARP;

insert into db_owner.usuarioSCHARP(nombre, aPaterno,aMaterno,fechaNac,tipoCuenta,nombreUsuario,clave)
VALUES('Oscar','Bautista','Gaytan','2000-04-26','Administrador','oscarBG','pass123')

--Eliminar una fila cuando *****
DELETE  FROM db_owner.usuarioSCHARP WHERE nombre = 'fdf';
SELECT nombreUsuario FROM db_owner.usuarioSCHARP WHERE nombreUsuario = 'oscar04';