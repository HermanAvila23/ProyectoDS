
Create table [EMPRESA]
(
	[ID_EMPRESA] Nvarchar(50) NOT NULL,
	[NIT_EMPRESA] Nvarchar(50) NOT NULL,
	[NOMBRE_EMPRESA] Nvarchar(50) NOT NULL,
	[TELEFONO_1] Nvarchar(20) NOT NULL,
	[TELEFONO_2] Nvarchar(20) NOT NULL,
	[CORREO_EMPRESA] Nvarchar(50) NOT NULL,
	[ID_TIPO_EMPRESA] Nvarchar(50) NOT NULL,
	[ID_REPRESENTANTE] Nvarchar(50) NOT NULL,
	[ID_DIRECION] Nvarchar(50) NOT NULL,
Primary Key ([ID_EMPRESA])
) 
go

Create table [ESTADO]
(
	[ID_ESTADO] Nvarchar(50) NOT NULL,
	[NOMBRE_ESTADO] Nvarchar(50) NOT NULL,
Primary Key ([ID_ESTADO])
) 
go

Create table [TIPO_EMPRESA]
(
	[ID_TIPO_EMPRESA] Nvarchar(50) NOT NULL,
	[NOMBRE_TIPO] Nvarchar(50) NOT NULL,
Primary Key ([ID_TIPO_EMPRESA])
) 
go

Create table [CONTRATO]
(
	[ID_CONTRATO] Nvarchar(50) NOT NULL,
	[ID_USUARIO] Nvarchar(50) NOT NULL,
	[PRECIO_INSCRIPCION] Money NOT NULL,
	[MORA] Money NOT NULL,
	[PRECIO_MES] Money NOT NULL,
	[FECHA_CONTRATO] Date NOT NULL,
	[FECHA_FINAL] Date NOT NULL,
	[HORA_INICIAL] Time NOT NULL,
	[HORA_FINAL] Time NOT NULL,
	[PRECIO_PASAJE] Money NOT NULL,
	[ID_RUTA] Nvarchar(50) NOT NULL,
	[ID_ANIO] Nvarchar(50) NOT NULL,
	[ID_VEHICULO] Nvarchar(50) NOT NULL,
	[ID_ESTADO] Nvarchar(50) NOT NULL,
Primary Key ([ID_CONTRATO])
) 
go

Create table [ANIO]
(
	[ID_ANIO] Nvarchar(50) NOT NULL,
	[ANIO] INTEGER NOT NULL,
Primary Key ([ID_ANIO])
) 
go

Create table [MENSUALIDAD]
(
	[ID_MENSUALIDAD] Nvarchar(50) NOT NULL,
	[MES] Nvarchar(50) NOT NULL,
	[ESTADO] Bit NOT NULL,
	[ID_CONTRATO] Nvarchar(50) NOT NULL,
Primary Key ([ID_MENSUALIDAD])
) 
go

Create table [REPRESENTANTE_LEGAL]
(
	[ID_REPRESENTANTE] Nvarchar(50) NOT NULL,
	[NIT_REPRESENTANTE] Nvarchar(50) NOT NULL,
	[NOMBRE_REPRESENTANTE] Nvarchar(50) NOT NULL,
	[APELLIDO_1_REPRESENTANTE] Nvarchar(50) NOT NULL,
	[APELLIDO_2_REPRESENTANTE] Nvarchar(50) NOT NULL,
	[TELEFONO_REPRESENTANTE] Nvarchar(20) NOT NULL,
	[CORREO_REPRESENTANTE] Nvarchar(50) NULL,
Primary Key ([ID_REPRESENTANTE])
) 
go

Create table [PILOTO]
(
	[ID_PILOTO] Nvarchar(50) NOT NULL,
	[NIT_PILOTO] Nvarchar(50) NOT NULL, UNIQUE ([NIT_PILOTO]),
	[DPI_PILOTO] Nvarchar(50) NOT NULL, UNIQUE ([DPI_PILOTO]),
	[NUMERO_LICENCIA_PILOTO] Nvarchar(50) NOT NULL, UNIQUE ([NUMERO_LICENCIA_PILOTO]),
	[NOMBRE_PILOTO] Nvarchar(50) NOT NULL,
	[APELLIDO_1_PILOTO] Nvarchar(50) NOT NULL,
	[APELLIDO_2_PILOTO] Nvarchar(50) NOT NULL,
	[TELEFONO_1_PILOTO] Nvarchar(20) NOT NULL,
	[TELEFONO_2_PILOTO] Nvarchar(20) NOT NULL,
	[CORREO_PILOTO] Nvarchar(50) NOT NULL,
	[ID_EMPRESA] Nvarchar(50) NOT NULL,
	[ID_TIPO_LICENCIA] Nvarchar(50) NOT NULL,
	[ID_TIPO_SANGRE] Nvarchar(50) NOT NULL,
	[ID_DIRECION] Nvarchar(50) NOT NULL,
Primary Key ([ID_PILOTO])
) 
go

Create table [TIPO_LICENCIA]
(
	[ID_TIPO_LICENCIA] Nvarchar(50) NOT NULL,
	[NOMBRE_TIPO_LICENCIA] Nvarchar(50) NOT NULL,
Primary Key ([ID_TIPO_LICENCIA])
) 
go

Create table [MORA]
(
	[ID_MORA] Nvarchar(50) NOT NULL,
	[ESTADO] Bit NOT NULL,
	[ID_MENSUALIDAD] Nvarchar(50) NOT NULL,
Primary Key ([ID_MORA])
) 
go

Create table [TIPO_SANGRE]
(
	[ID_TIPO_SANGRE] Nvarchar(50) NOT NULL,
	[NOMBRE_TIPO_SANGRE] Nvarchar(20) NOT NULL,
Primary Key ([ID_TIPO_SANGRE])
) 
go

Create table [DEPARTAMENTO]
(
	[ID_DEPARTAMENTO] Nvarchar(50) NOT NULL,
	[NOMBRE_DEPARTAMENTO] Nvarchar(50) NOT NULL,
	[LONGITUD] Float NOT NULL,
	[LATITUD] Float NOT NULL,
Primary Key ([ID_DEPARTAMENTO])
) 
go

Create table [MUNICIPIO]
(
	[ID_MUNICIPIO] Nvarchar(50) NOT NULL,
	[NOMBRE_MUNICIPIO] Nvarchar(50) NOT NULL,
	[ID_DEPARTAMENTO] Nvarchar(50) NOT NULL,
Primary Key ([ID_MUNICIPIO])
) 
go

Create table [DIRECCION]
(
	[ID_DIRECION] Nvarchar(50) NOT NULL,
	[ZONA] Nvarchar(20) NOT NULL,
	[CALLE] Nvarchar(50) NOT NULL,
	[DESCRIPCION_CASA] Nvarchar(150) NOT NULL,
	[LONGITUD] Float NOT NULL,
	[LATITUD] Float NOT NULL,
	[ID_MUNICIPIO] Nvarchar(50) NOT NULL,
Primary Key ([ID_DIRECION])
) 
go

Create table [VEHICULO]
(
	[ID_VEHICULO] Nvarchar(50) NOT NULL,
	[NUMERO_PLACA] Nvarchar(50) NOT NULL,
	[NUMERO_TARJETA_CIRCULACION] Nvarchar(50) NOT NULL,
	[MARCA] Nvarchar(50) NOT NULL,
	[MODELO] Nvarchar(50) NOT NULL,
	[COLOR] Nvarchar(50) NOT NULL,
	[CILINDRAJE] Nvarchar(50) NOT NULL,
	[NUMERO_ASIENTOS] Integer NOT NULL,
	[SOLVENCIA_TRANSITO] Bit NOT NULL,
	[ID_EMPRESA] Nvarchar(50) NOT NULL,
	[ID_PROPIETARIO] Nvarchar(50) NOT NULL,
	[ID_TIPO_VEHICULO] Nvarchar(50) NOT NULL,
Primary Key ([ID_VEHICULO])
) 
go

Create table [TIPO_VEHICULO]
(
	[ID_TIPO_VEHICULO] Nvarchar(50) NOT NULL,
	[NOMBRE_TIPO] Nvarchar(50) NOT NULL,
Primary Key ([ID_TIPO_VEHICULO])
) 
go

Create table [PROPIETARIO_VEHICULO]
(
	[ID_PROPIETARIO] Nvarchar(50) NOT NULL,
	[NOMBRE_PROPIETARIO] Nvarchar(50) NOT NULL,
	[APELLIDO_1_PROPIETARIO] Nvarchar(50) NOT NULL,
	[APELLIDO_2_PROPIETARIO] Nvarchar(50) NOT NULL,
	[NIT_PROPIETARIO] Nvarchar(50) NOT NULL,
	[DPI_PROPIETARIO] Nvarchar(50) NOT NULL,
	[ID_DIRECION] Nvarchar(50) NOT NULL,
Primary Key ([ID_PROPIETARIO])
) 
go

Create table [CIUDAD]
(
	[ID_CIUDAD] Nvarchar(50) NOT NULL,
	[NOMBRE_CIUDAD] Nvarchar(50) NOT NULL,
	[ID_MUNICIPIO] Nvarchar(50) NOT NULL,
Primary Key ([ID_CIUDAD])
) 
go

Create table [RUTA]
(
	[ID_RUTA] Nvarchar(50) NOT NULL,
	[NOMBRE_RUTA] Nvarchar(50) NOT NULL,
	[TIEMPO_PROMEDIO] TIME NOT NULL,
	[ID_CIUDAD] Nvarchar(50) NOT NULL,
Primary Key ([ID_RUTA])
) 
go

Create table [PUNTO]
(
	[ID_PUNTO] Nvarchar(50) NOT NULL,
	[LONGITUD] Float NOT NULL,
	[LATITUD] Float NOT NULL,
	[ID_RUTA] Nvarchar(50) NOT NULL,
Primary Key ([ID_PUNTO])
) 
go

Create table [TIPO_PASAJE]
(
	[ID_TIPO_PASAJE] Nvarchar(50) NOT NULL,
	[NOMBRE_TIPO] Nvarchar(50) NOT NULL,
Primary Key ([ID_TIPO_PASAJE])
) 
go

Create table [PRECIO_PASAJE]
(
	[ID_PRECIO_PASAJE] Nvarchar(50) NOT NULL,
	[PRECIO] Money NOT NULL,
	[ID_RUTA] Nvarchar(50) NOT NULL,
	[ID_TIPO_PASAJE] Nvarchar(50) NOT NULL,
Primary Key ([ID_PRECIO_PASAJE])
) 
go

Create table [TIPO_CHECKEO]
(
	[ID_TIPO_CHECKEO] Nvarchar(50) NOT NULL,
	[NOMBRE_CHECKEO] Nvarchar(50) NOT NULL,
Primary Key ([ID_TIPO_CHECKEO])
) 
go

Create table [CHECKEO]
(
	[ID_CHECKEO] Nvarchar(50) NOT NULL,
	[FECHA_CHECKEO] Date NOT NULL,
	[ID_TIPO_CHECKEO] Nvarchar(50) NOT NULL,
	[ID_ESTADO_CHECKEO] Nvarchar(50) NOT NULL,
	[ID_RESULTADO] Nvarchar(50) NOT NULL,
	[ID_VEHICULO] Nvarchar(50) NOT NULL,
	[ID_USUARIO] Nvarchar(50) NOT NULL,
Primary Key ([ID_CHECKEO])
) 
go

Create table [RESULTADO]
(
	[ID_RESULTADO] Nvarchar(50) NOT NULL,
	[NOMBRE_RESULTADO] Nvarchar(50) NOT NULL,
Primary Key ([ID_RESULTADO])
) 
go

Create table [ESTADO_CHECKEO]
(
	[ID_ESTADO_CHECKEO] Nvarchar(50) NOT NULL,
	[NOMBRE_ESTADO_CHECKEO] Nvarchar(50) NOT NULL,
Primary Key ([ID_ESTADO_CHECKEO])
) 
go

Create table [DETALLE_CHECKEO]
(
	[ID_DETALLE_CHECKEO] Nvarchar(50) NOT NULL,
	[DESCRIPCION_CHECKEO] Nvarchar(100) NOT NULL,
	[ID_ESTADO_PARTE] Nvarchar(50) NOT NULL,
	[ID_CHECKEO] Nvarchar(50) NOT NULL,
	[ID_PARTE] Nvarchar(50) NOT NULL,
Primary Key ([ID_DETALLE_CHECKEO])
) 
go

Create table [PARTE]
(
	[ID_PARTE] Nvarchar(50) NOT NULL,
	[NOMBRE_PARTE] Nvarchar(50) NOT NULL,
	[ID_TIPO_PARTE] Nvarchar(50) NOT NULL,
Primary Key ([ID_PARTE])
) 
go

Create table [TIPO_PARTE]
(
	[ID_TIPO_PARTE] Nvarchar(50) NOT NULL,
	[NOMBRE_TIPO] Nvarchar(50) NOT NULL,
Primary Key ([ID_TIPO_PARTE])
) 
go

Create table [ESTADO_PARTE]
(
	[ID_ESTADO_PARTE] Nvarchar(50) NOT NULL,
	[NOMBRE_ESTADO_PARTE] Nvarchar(50) NOT NULL,
Primary Key ([ID_ESTADO_PARTE])
) 
go

Create table [HISTORIAL_VEHICULO]
(
	[ID_HISTORIAL_VEHICULO] Nvarchar(50) NOT NULL,
	[FECHA_INSIDENTE] Date NOT NULL,
	[DESCRIPCION] Nvarchar(300) NOT NULL,
	[ID_REPORTADOR] Nvarchar(50) NOT NULL,
	[ID_VEHICULO] Nvarchar(50) NOT NULL,
	[ID_TIPO_INSIDENTE] Nvarchar(50) NOT NULL,
	[ID_PILOTO] Nvarchar(50) NULL,
Primary Key ([ID_HISTORIAL_VEHICULO])
) 
go

Create table [TIPO_INSIDENTE]
(
	[ID_TIPO_INSIDENTE] Nvarchar(50) NOT NULL,
	[NOMBRE_TIPO_INSIDENTE] Nvarchar(50) NOT NULL,
Primary Key ([ID_TIPO_INSIDENTE])
) 
go

Create table [DATOS_REPORTADOR]
(
	[ID_REPORTADOR] Nvarchar(50) NOT NULL,
	[NOMBRE_REPORTADOR] Nvarchar(50) NOT NULL,
	[APELLIDO_REPORTADOR] Nvarchar(50) NOT NULL,
	[DPI_REPORTADOR] Nvarchar(50) NOT NULL,
Primary Key ([ID_REPORTADOR])
) 
go

Create table [TIPO_PAGO]
(
	[ID_PAGO] Nvarchar(50) NOT NULL,
	[NOMBRE_PAGO] Nvarchar(50) NOT NULL,
	[ID_DETALLE_PAGO] Nvarchar(50) NOT NULL,
Primary Key ([ID_PAGO])
) 
go

Create table [ENCABEZADO_PAGO]
(
	[ID_ENCABEZADO_PAGO] Nvarchar(50) NOT NULL,
	[FECHA_PAGO] Date NOT NULL,
	[TOTAL] Money NOT NULL,
	[ID_CONTRATO] Nvarchar(50) NOT NULL,
	[ID_USUARIO] Nvarchar(50) NOT NULL,
Primary Key ([ID_ENCABEZADO_PAGO])
) 
go

Create table [DETALLE_PAGO]
(
	[ID_DETALLE_PAGO] Nvarchar(50) NOT NULL,
	[COSTO_PAGO] Money NOT NULL,
	[DESCRIPCION_PAGO] Nvarchar(50) NOT NULL,
	[ID_ENCABEZADO_PAGO] Nvarchar(50) NOT NULL,
Primary Key ([ID_DETALLE_PAGO])
) 
go

Create table [COBRO_MORA]
(
	[ID_MORA] Nvarchar(50) NOT NULL,
	[FECHA_CREACION] Date NOT NULL,
	[DIAS_ATRASO] Integer NOT NULL,
	[PORSENTAJE] Integer NOT NULL,
	[ESTADO] Bit NOT NULL,
Primary Key ([ID_MORA])
) 
go

Create table [USUARIO]
(
	[ID_USUARIO] Nvarchar(50) NOT NULL,
	[NOMBRE_USUARIO] Nvarchar(50) NOT NULL, UNIQUE ([NOMBRE_USUARIO]),
	[CONTRASEÑA] Nvarchar(50) NOT NULL,
	[ID_TIPO_USUARIO] Nvarchar(50) NOT NULL,
	[ID_DATOS_USUARIO] Nvarchar(50) NOT NULL,
Primary Key ([ID_USUARIO])
) 
go

Create table [TIPO_USUARIO]
(
	[ID_TIPO_USUARIO] Nvarchar(50) NOT NULL,
	[NOMBRE_TIPO_USUARIO] Nvarchar(50) NOT NULL,
Primary Key ([ID_TIPO_USUARIO])
) 
go

Create table [DATOS_USUARIO]
(
	[ID_DATOS_USUARIO] Nvarchar(50) NOT NULL,
	[NOMBRE_EMPLEADO] Nvarchar(50) NOT NULL,
	[APELLIDO_1_EMPLEADO] Nvarchar(50) NOT NULL,
	[APELLIDO_2_EMPLEADO] Nvarchar(50) NOT NULL,
	[DPI_EMPLEADO] Nvarchar(50) NOT NULL,
	[TELEFONO_EMPLEADO] Nvarchar(20) NULL,
Primary Key ([ID_DATOS_USUARIO])
) 
go

Create table [TIPO_BITACORA]
(
	[ID_TIPO_BITACORA] Nvarchar(50) NOT NULL,
	[NOMBRE_TIPO_BITACORA] Nvarchar(50) NOT NULL,
Primary Key ([ID_TIPO_BITACORA])
) 
go

Create table [BITACORA]
(
	[ID_BITACORA] Nvarchar(50) NOT NULL,
	[DESCRIPCION_BITACORA] Nvarchar(100) NOT NULL,
	[FECHA_BITACORA] Date NOT NULL,
	[ID_USUARIO] Nvarchar(50) NOT NULL,
	[ID_TIPO_BITACORA] Nvarchar(50) NOT NULL,
Primary Key ([ID_BITACORA])
) 
go


Alter table [PILOTO] add  foreign key([ID_EMPRESA]) references [EMPRESA] ([ID_EMPRESA])  on update no action on delete no action 
go
Alter table [VEHICULO] add  foreign key([ID_EMPRESA]) references [EMPRESA] ([ID_EMPRESA])  on update no action on delete no action 
go
Alter table [CONTRATO] add  foreign key([ID_ESTADO]) references [ESTADO] ([ID_ESTADO])  on update no action on delete no action 
go
Alter table [EMPRESA] add  foreign key([ID_TIPO_EMPRESA]) references [TIPO_EMPRESA] ([ID_TIPO_EMPRESA])  on update no action on delete no action 
go
Alter table [MENSUALIDAD] add  foreign key([ID_CONTRATO]) references [CONTRATO] ([ID_CONTRATO])  on update no action on delete no action 
go
Alter table [ENCABEZADO_PAGO] add  foreign key([ID_CONTRATO]) references [CONTRATO] ([ID_CONTRATO])  on update no action on delete no action 
go
Alter table [CONTRATO] add  foreign key([ID_ANIO]) references [ANIO] ([ID_ANIO])  on update no action on delete no action 
go
Alter table [MORA] add  foreign key([ID_MENSUALIDAD]) references [MENSUALIDAD] ([ID_MENSUALIDAD])  on update no action on delete no action 
go
Alter table [EMPRESA] add  foreign key([ID_REPRESENTANTE]) references [REPRESENTANTE_LEGAL] ([ID_REPRESENTANTE])  on update no action on delete no action 
go
Alter table [HISTORIAL_VEHICULO] add  foreign key([ID_PILOTO]) references [PILOTO] ([ID_PILOTO])  on update no action on delete no action 
go
Alter table [PILOTO] add  foreign key([ID_TIPO_LICENCIA]) references [TIPO_LICENCIA] ([ID_TIPO_LICENCIA])  on update no action on delete no action 
go
Alter table [PILOTO] add  foreign key([ID_TIPO_SANGRE]) references [TIPO_SANGRE] ([ID_TIPO_SANGRE])  on update no action on delete no action 
go
Alter table [MUNICIPIO] add  foreign key([ID_DEPARTAMENTO]) references [DEPARTAMENTO] ([ID_DEPARTAMENTO])  on update no action on delete no action 
go
Alter table [DIRECCION] add  foreign key([ID_MUNICIPIO]) references [MUNICIPIO] ([ID_MUNICIPIO])  on update no action on delete no action 
go
Alter table [CIUDAD] add  foreign key([ID_MUNICIPIO]) references [MUNICIPIO] ([ID_MUNICIPIO])  on update no action on delete no action 
go
Alter table [PILOTO] add  foreign key([ID_DIRECION]) references [DIRECCION] ([ID_DIRECION])  on update no action on delete no action 
go
Alter table [EMPRESA] add  foreign key([ID_DIRECION]) references [DIRECCION] ([ID_DIRECION])  on update no action on delete no action 
go
Alter table [PROPIETARIO_VEHICULO] add  foreign key([ID_DIRECION]) references [DIRECCION] ([ID_DIRECION])  on update no action on delete no action 
go
Alter table [CONTRATO] add  foreign key([ID_VEHICULO]) references [VEHICULO] ([ID_VEHICULO])  on update no action on delete no action 
go
Alter table [CHECKEO] add  foreign key([ID_VEHICULO]) references [VEHICULO] ([ID_VEHICULO])  on update no action on delete no action 
go
Alter table [HISTORIAL_VEHICULO] add  foreign key([ID_VEHICULO]) references [VEHICULO] ([ID_VEHICULO])  on update no action on delete no action 
go
Alter table [VEHICULO] add  foreign key([ID_TIPO_VEHICULO]) references [TIPO_VEHICULO] ([ID_TIPO_VEHICULO])  on update no action on delete no action 
go
Alter table [VEHICULO] add  foreign key([ID_PROPIETARIO]) references [PROPIETARIO_VEHICULO] ([ID_PROPIETARIO])  on update no action on delete no action 
go
Alter table [RUTA] add  foreign key([ID_CIUDAD]) references [CIUDAD] ([ID_CIUDAD])  on update no action on delete no action 
go
Alter table [CONTRATO] add  foreign key([ID_RUTA]) references [RUTA] ([ID_RUTA])  on update no action on delete no action 
go
Alter table [PUNTO] add  foreign key([ID_RUTA]) references [RUTA] ([ID_RUTA])  on update no action on delete no action 
go
Alter table [PRECIO_PASAJE] add  foreign key([ID_RUTA]) references [RUTA] ([ID_RUTA])  on update no action on delete no action 
go
Alter table [PRECIO_PASAJE] add  foreign key([ID_TIPO_PASAJE]) references [TIPO_PASAJE] ([ID_TIPO_PASAJE])  on update no action on delete no action 
go
Alter table [CHECKEO] add  foreign key([ID_TIPO_CHECKEO]) references [TIPO_CHECKEO] ([ID_TIPO_CHECKEO])  on update no action on delete no action 
go
Alter table [DETALLE_CHECKEO] add  foreign key([ID_CHECKEO]) references [CHECKEO] ([ID_CHECKEO])  on update no action on delete no action 
go
Alter table [CHECKEO] add  foreign key([ID_RESULTADO]) references [RESULTADO] ([ID_RESULTADO])  on update no action on delete no action 
go
Alter table [CHECKEO] add  foreign key([ID_ESTADO_CHECKEO]) references [ESTADO_CHECKEO] ([ID_ESTADO_CHECKEO])  on update no action on delete no action 
go
Alter table [DETALLE_CHECKEO] add  foreign key([ID_PARTE]) references [PARTE] ([ID_PARTE])  on update no action on delete no action 
go
Alter table [PARTE] add  foreign key([ID_TIPO_PARTE]) references [TIPO_PARTE] ([ID_TIPO_PARTE])  on update no action on delete no action 
go
Alter table [DETALLE_CHECKEO] add  foreign key([ID_ESTADO_PARTE]) references [ESTADO_PARTE] ([ID_ESTADO_PARTE])  on update no action on delete no action 
go
Alter table [HISTORIAL_VEHICULO] add  foreign key([ID_TIPO_INSIDENTE]) references [TIPO_INSIDENTE] ([ID_TIPO_INSIDENTE])  on update no action on delete no action 
go
Alter table [HISTORIAL_VEHICULO] add  foreign key([ID_REPORTADOR]) references [DATOS_REPORTADOR] ([ID_REPORTADOR])  on update no action on delete no action 
go
Alter table [DETALLE_PAGO] add  foreign key([ID_ENCABEZADO_PAGO]) references [ENCABEZADO_PAGO] ([ID_ENCABEZADO_PAGO])  on update no action on delete no action 
go
Alter table [TIPO_PAGO] add  foreign key([ID_DETALLE_PAGO]) references [DETALLE_PAGO] ([ID_DETALLE_PAGO])  on update no action on delete no action 
go
Alter table [CHECKEO] add  foreign key([ID_USUARIO]) references [USUARIO] ([ID_USUARIO])  on update no action on delete no action 
go
Alter table [CONTRATO] add  foreign key([ID_USUARIO]) references [USUARIO] ([ID_USUARIO])  on update no action on delete no action 
go
Alter table [ENCABEZADO_PAGO] add  foreign key([ID_USUARIO]) references [USUARIO] ([ID_USUARIO])  on update no action on delete no action 
go
Alter table [BITACORA] add  foreign key([ID_USUARIO]) references [USUARIO] ([ID_USUARIO])  on update no action on delete no action 
go
Alter table [USUARIO] add  foreign key([ID_TIPO_USUARIO]) references [TIPO_USUARIO] ([ID_TIPO_USUARIO])  on update no action on delete no action 
go
Alter table [USUARIO] add  foreign key([ID_DATOS_USUARIO]) references [DATOS_USUARIO] ([ID_DATOS_USUARIO])  on update no action on delete no action 
go
Alter table [BITACORA] add  foreign key([ID_TIPO_BITACORA]) references [TIPO_BITACORA] ([ID_TIPO_BITACORA])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


