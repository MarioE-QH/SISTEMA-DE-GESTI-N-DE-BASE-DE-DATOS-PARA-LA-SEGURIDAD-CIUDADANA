CREATE DATABASE Seguridad_Ciudadana
GO
USE Seguridad_Ciudadana
GO
CREATE TABLE AREA_SEGURIDAD
( 
	FFundacion           datetime  NULL ,
	idArea               int IDENTITY ( 1,1 ) ,
	IdEmpleado           int  NULL ,
	IdMunicipalidad      int  NOT NULL 
)
go



ALTER TABLE AREA_SEGURIDAD
	ADD CONSTRAINT XPKAREA_SEGURIDAD PRIMARY KEY  CLUSTERED (idArea ASC,IdMunicipalidad ASC)
go



CREATE TABLE ATENCION_VICTIMAS
( 
	IdAtencion           int IDENTITY ( 1,1 ) ,
	IdServicio           int  NOT NULL ,
	IdVictima            int  NULL ,
	idDelito             int  NULL ,
	IdMunicipalidad      int  NOT NULL ,
	CodOperacion         char(9)  NULL 
)
go



ALTER TABLE ATENCION_VICTIMAS
	ADD CONSTRAINT XPKATENCION_VICTIMAS PRIMARY KEY  CLUSTERED (IdAtencion ASC,IdServicio ASC,IdMunicipalidad ASC)
go



CREATE TABLE CAMARA
( 
	IdCamara             int IDENTITY ( 1,1 ) ,
	Marca                varchar(50)  NULL ,
	IdTipoCamara         int  NULL ,
	AñoFabricacion       char(4)  NULL ,
	Ubicacion            varchar(50)  NULL 
)
go



ALTER TABLE CAMARA
	ADD CONSTRAINT XPKCAMARA PRIMARY KEY  CLUSTERED (IdCamara ASC)
go



CREATE TABLE COMISARIA
( 
	IdComisaria          int IDENTITY ( 1,1 ) ,
	Nombre               varchar(50)  NULL ,
	Direccion            varchar(50)  NULL ,
	Telefono             char(9)  NULL 
)
go



ALTER TABLE COMISARIA
	ADD CONSTRAINT XPKCOMISARIA PRIMARY KEY  CLUSTERED (IdComisaria ASC)
go



CREATE TABLE CONTROL__PERSECUCCION
( 
	IdControl            int IDENTITY ( 1,1 ) ,
	IdServicio           int  NOT NULL ,
	IdMunicipalidad      int  NOT NULL ,
	Detalle              varchar(50)  NULL ,
	IdDelicuencial       int  NOT NULL ,
	CodOperación         char(9)  NULL 
)
go



ALTER TABLE CONTROL__PERSECUCCION
	ADD CONSTRAINT XPKCONTROL__PERSECUCCION PRIMARY KEY  CLUSTERED (IdControl ASC,IdServicio ASC,IdMunicipalidad ASC,IdDelicuencial ASC)
go



CREATE TABLE DELINCUENCIAL
( 
	IdServicio           int  NOT NULL ,
	IdMunicipalidad      int  NOT NULL ,
	Ubicacion            varchar(50)  NULL ,
	IdDelicuencial       int IDENTITY ( 1,1 ) ,
	IdTipoDelincuencial  int  NULL 
)
go



ALTER TABLE DELINCUENCIAL
	ADD CONSTRAINT XPKDELINCUENCIAL PRIMARY KEY  CLUSTERED (IdDelicuencial ASC,IdServicio ASC,IdMunicipalidad ASC)
go



CREATE TABLE DELITO
( 
	idDelito             int IDENTITY ( 1,1 ) ,
	DescripcionDelito    varchar(50)  NULL 
)
go



ALTER TABLE DELITO
	ADD CONSTRAINT XPKDELITO PRIMARY KEY  CLUSTERED (idDelito ASC)
go



CREATE TABLE DETALLE_CAMARA
( 
	IdVigilancia         int  NOT NULL ,
	IdServicio           int  NOT NULL ,
	IdMunicipalidad      int  NOT NULL ,
	IdCamara             int  NOT NULL 
)
go



ALTER TABLE DETALLE_CAMARA
	ADD CONSTRAINT XPKDETALLE_CAMARA PRIMARY KEY  CLUSTERED (IdVigilancia ASC,IdServicio ASC,IdMunicipalidad ASC,IdCamara ASC)
go



CREATE TABLE DETALLE_POLICIA
( 
	IdServicio           int  NOT NULL ,
	IdMunicipalidad      int  NOT NULL ,
	IdPolicia            int  NOT NULL ,
	IdDelicuencial       int  NOT NULL 
)
go



ALTER TABLE DETALLE_POLICIA
	ADD CONSTRAINT XPKDETALLE_POLICIA PRIMARY KEY  CLUSTERED (IdServicio ASC,IdMunicipalidad ASC,IdPolicia ASC,IdDelicuencial ASC)
go



CREATE TABLE DETALLE_SERENAZGO
( 
	IdSerenazgo          int  NOT NULL ,
	IdServicio           int  NOT NULL ,
	IdMunicipalidad      int  NOT NULL 
)
go



ALTER TABLE DETALLE_SERENAZGO
	ADD CONSTRAINT XPKDETALLE_SERENAZGO PRIMARY KEY  CLUSTERED (IdSerenazgo ASC,IdServicio ASC,IdMunicipalidad ASC)
go



CREATE TABLE EMPLEADO_SEGURIDAD
( 
	IdEmpleado           int IDENTITY ( 1,1 ) ,
	NombreE              varchar(50)  NULL ,
	ApellidoE            varchar(50)  NULL ,
	DNIE                 char(8)  NULL ,
	TelefonoE            char(9)  NULL ,
	FInicio              datetime  NULL ,
	FFin                 datetime  NULL ,
	IdTipo               int  NULL ,
	Sueldo               int  NULL 
)
go



ALTER TABLE EMPLEADO_SEGURIDAD
	ADD CONSTRAINT XPKEMPLEADO_SEGURIDAD PRIMARY KEY  CLUSTERED (IdEmpleado ASC)
go



CREATE TABLE EMPRESA
( 
	IdEmpresa            int IDENTITY ( 1,1 ) ,
	RUC                  char(16)  NULL ,
	FFundacion           datetime  NULL ,
	NombreEmpresa        varchar(50)  NULL ,
	IdRubro              int  NULL ,
	Viaticos             int  NULL 
)
go



ALTER TABLE EMPRESA
	ADD CONSTRAINT XPKEMPRESA PRIMARY KEY  CLUSTERED (IdEmpresa ASC)
go



CREATE TABLE ESTADO_EVALLUACION
( 
	IdEstadoEva          int IDENTITY ( 1,1 ) ,
	Descripcion          varchar(50)  NULL 
)
go



ALTER TABLE ESTADO_EVALLUACION
	ADD CONSTRAINT XPKESTADO_EVALLUACION PRIMARY KEY  CLUSTERED (IdEstadoEva ASC)
go



CREATE TABLE ESTADO_SERVICIO
( 
	IdEstado             int IDENTITY ( 1,1 ) ,
	DescripcionEstado    varchar(50)  NULL 
)
go



ALTER TABLE ESTADO_SERVICIO
	ADD CONSTRAINT XPKESTADO_SERVICIO PRIMARY KEY  CLUSTERED (IdEstado ASC)
go



CREATE TABLE ESTADO_VICTIMA
( 
	IdEstado             int IDENTITY ( 1,1 ) ,
	Descripcion          varchar(50)  NULL 
)
go



ALTER TABLE ESTADO_VICTIMA
	ADD CONSTRAINT XPKESTADO_VICTIMA PRIMARY KEY  CLUSTERED (IdEstado ASC)
go



CREATE TABLE EVALUACION
( 
	IdEvaluacion         int IDENTITY ( 1,1 ) ,
	FechaEvaluacion      datetime  NULL ,
	IdEstadoEva          int  NULL 
)
go



ALTER TABLE EVALUACION
	ADD CONSTRAINT XPKEVALUACION PRIMARY KEY  CLUSTERED (IdEvaluacion ASC)
go



CREATE TABLE MANTENIMIENTO
( 
	IdMantenimiento      int IDENTITY ( 1,1 ) ,
	Fechamantenimiento   datetime  NULL ,
	IdEmpresa            int  NULL ,
	CostoMantenimiento   int  NULL 
)
go



ALTER TABLE MANTENIMIENTO
	ADD CONSTRAINT XPKMANTENIMIENTO PRIMARY KEY  CLUSTERED (IdMantenimiento ASC)
go



CREATE TABLE MUNICIPALIDAD
( 
	IdMunicipalidad      int IDENTITY ( 1,1 ) ,
	NombreMunicipalidad  varchar(50)  NULL ,
	FechaFundación       datetime  NULL ,
	Dirección            varchar(50)  NULL 
)
go



ALTER TABLE MUNICIPALIDAD
	ADD CONSTRAINT XPKMUNICIPALIDAD PRIMARY KEY  CLUSTERED (IdMunicipalidad ASC)
go



CREATE TABLE PERSONA
( 
	IdPersona            int IDENTITY ( 1,1 ) ,
	DettalleDenuncia     varchar(50)  NULL ,
	Telefono             char(9)  NULL ,
	NombrePersona        varchar(50)  NULL 
)
go



ALTER TABLE PERSONA
	ADD CONSTRAINT XPKPERSONA PRIMARY KEY  CLUSTERED (IdPersona ASC)
go



CREATE TABLE PERSONA_JURIDICA
( 
	IdPersona            int  NOT NULL ,
	RUC                  char(16)  NULL ,
	IdRazon              int  NULL 
)
go



ALTER TABLE PERSONA_JURIDICA
	ADD CONSTRAINT XPKPERSONA_JURIDICA PRIMARY KEY  CLUSTERED (IdPersona ASC)
go



CREATE TABLE PERSONA_NATURAL
( 
	IdPersona            int  NOT NULL ,
	DNI                  char(8)  NULL ,
	Sexo                 char(1)  NULL 
)
go



ALTER TABLE PERSONA_NATURAL
	ADD CONSTRAINT XPKPERSONA_NATURAL PRIMARY KEY  CLUSTERED (IdPersona ASC)
go



CREATE TABLE POLICIA
( 
	IdPolicia            int IDENTITY ( 1,1 ) ,
	NombrePolicia        varchar(50)  NULL ,
	ApellidoMaterno      varchar(50)  NULL ,
	DNIPM                char(8)  NULL ,
	Sexo                 char(1)  NULL ,
	FNacimiento          datetime  NULL ,
	ApellidoPaterno      varchar(50)  NULL ,
	IdRango              int  NULL ,
	FechaInicioServicio  datetime  NULL ,
	IdComisaria          int  NULL 
)
go



ALTER TABLE POLICIA
	ADD CONSTRAINT XPKPOLICIA PRIMARY KEY  CLUSTERED (IdPolicia ASC)
go



CREATE TABLE PREVENCION_DELITO
( 
	IdPrevencion         int IDENTITY ( 1,1 ) ,
	IdServicio           int  NOT NULL ,
	IdMunicipalidad      int  NOT NULL ,
	Detalle              varchar(50)  NULL ,
	IdDelicuencial       int  NOT NULL ,
	CodOperacion         char(09)  NULL 
)
go



ALTER TABLE PREVENCION_DELITO
	ADD CONSTRAINT XPKPREVENCION_DELITO PRIMARY KEY  CLUSTERED (IdPrevencion ASC,IdServicio ASC,IdMunicipalidad ASC,IdDelicuencial ASC)
go



CREATE TABLE PROGRAMACIÓN
( 
	IdMantenimiento      int  NULL ,
	idProgramacion       int IDENTITY ( 1,1 ) ,
	IdEvaluacion         int  NULL ,
	IdMunicipalidad      int  NULL 
)
go



ALTER TABLE PROGRAMACIÓN
	ADD CONSTRAINT XPKPROGRAMACIÓN PRIMARY KEY  CLUSTERED (idProgramacion ASC)
go



CREATE TABLE RANGO_POLICIA
( 
	IdRango              int IDENTITY ( 1,1 ) ,
	DescripcionRango     varchar(50)  NULL 
)
go



ALTER TABLE RANGO_POLICIA
	ADD CONSTRAINT XPKRANGO_POLICIA PRIMARY KEY  CLUSTERED (IdRango ASC)
go



CREATE TABLE RAZON_SOCIAL
( 
	IdRazon              int IDENTITY ( 1,1 ) ,
	DescripcionRazon     varchar(50)  NULL 
)
go



ALTER TABLE RAZON_SOCIAL
	ADD CONSTRAINT XPKRAZON_SOCIAL PRIMARY KEY  CLUSTERED (IdRazon ASC)
go



CREATE TABLE RUBRO
( 
	IdRubro              int IDENTITY ( 1,1 ) ,
	DescrpcionRubro      varchar(50)  NULL 
)
go



ALTER TABLE RUBRO
	ADD CONSTRAINT XPKRUBRO PRIMARY KEY  CLUSTERED (IdRubro ASC)
go



CREATE TABLE SERENAZGO
( 
	IdSerenazgo          int IDENTITY ( 1,1 ) ,
	NombreSereno         varchar(50)  NULL ,
	ApellidoSereno       varchar(50)  NULL ,
	DNISerenazgo         char(8)  NULL ,
	TelefonoSereno       char(9)  NULL ,
	FechaNacimientoSereno datetime  NULL ,
	FechaInicioSereno    datetime  NULL ,
	Sexo                 char(1)  NOT NULL ,
	IdPatrulla           int  NULL 
)
go



ALTER TABLE SERENAZGO
	ADD CONSTRAINT XPKSERENAZGO PRIMARY KEY  CLUSTERED (IdSerenazgo ASC)
go



CREATE TABLE SERVICIO
( 
	IdServicio           int IDENTITY ( 1,1 ) ,
	Fecha                datetime  NULL ,
	IdPersona            int  NULL ,
	IdEstado             int  NULL ,
	Hora                 char(5)  NULL ,
	Numero               char(9)  NULL ,
	IdTipoDescripcion    int  NULL ,
	IdMunicipalidad      int  NOT NULL ,
	IdTipoServicio       int  NULL 
)
go



ALTER TABLE SERVICIO
	ADD CONSTRAINT XPKSERVICIO PRIMARY KEY  CLUSTERED (IdServicio ASC,IdMunicipalidad ASC)
go



CREATE TABLE TIPO_CAMARA
( 
	IdTipoCamara         int IDENTITY ( 1,1 ) ,
	Descripcion          varchar(50)  NULL 
)
go



ALTER TABLE TIPO_CAMARA
	ADD CONSTRAINT XPKTIPO_CAMRA PRIMARY KEY  CLUSTERED (IdTipoCamara ASC)
go



CREATE TABLE TIPO_COMUNICACION
( 
	IdTipoDescripcion    int IDENTITY ( 1,1 ) ,
	DetalleTipoDescripcion varchar(50)  NULL 
)
go



ALTER TABLE TIPO_COMUNICACION
	ADD CONSTRAINT XPKTIPO_COMUNICACION PRIMARY KEY  CLUSTERED (IdTipoDescripcion ASC)
go



CREATE TABLE TIPO_DELINCUENCIAL
( 
	IdTipoDelincuencial  int IDENTITY ( 1,1 ) ,
	Descripcion          varchar(50)  NULL 
)
go



ALTER TABLE TIPO_DELINCUENCIAL
	ADD CONSTRAINT XPKTIPO_DELINCUENCIAL PRIMARY KEY  CLUSTERED (IdTipoDelincuencial ASC)
go



CREATE TABLE TIPO_SEGURIDAD
( 
	IdTipo               int IDENTITY ( 1,1 ) ,
	Descripcion          varchar(50)  NULL 
)
go



ALTER TABLE TIPO_SEGURIDAD
	ADD CONSTRAINT XPKTIPO_SEGURIDAD PRIMARY KEY  CLUSTERED (IdTipo ASC)
go



CREATE TABLE TIPO_SERVICIO
( 
	IdTipoServicio       int IDENTITY ( 1,1 ) ,
	Descripcion          varchar(50)  NULL 
)
go



ALTER TABLE TIPO_SERVICIO
	ADD CONSTRAINT XPKTIPO_SERVICIO PRIMARY KEY  CLUSTERED (IdTipoServicio ASC)
go



CREATE TABLE TIPO_VEHICULO
( 
	IdTipoV              int IDENTITY ( 1,1 ) ,
	Descripcion          varchar(50)  NULL 
)
go



ALTER TABLE TIPO_VEHICULO
	ADD CONSTRAINT XPKTIPO_VEHICULO PRIMARY KEY  CLUSTERED (IdTipoV ASC)
go



CREATE TABLE VEHICULOS
( 
	IdPatrulla           int IDENTITY ( 1,1 ) ,
	PlacaPatrulla        char(6)  NULL ,
	Año                  char(4)  NULL ,
	Asientos             int  NULL ,
	IdTipoV              int  NULL ,
	Costo                int  NULL ,
	CEquipacion          int  NULL 
)
go



ALTER TABLE VEHICULOS
	ADD CONSTRAINT XPKVEHICULOS PRIMARY KEY  CLUSTERED (IdPatrulla ASC)
go



CREATE TABLE VICTIMA
( 
	IdVictima            int IDENTITY ( 1,1 ) ,
	NombreVictima        varchar(50)  NULL ,
	ApellidoPaternoVictima varchar(50)  NULL ,
	DNI                  char(8)  NULL ,
	Sexo                 char(1)  NULL ,
	FNacimiento          datetime  NULL ,
	IdEstado             int  NULL 
)
go



ALTER TABLE VICTIMA
	ADD CONSTRAINT XPKVICTIMA PRIMARY KEY  CLUSTERED (IdVictima ASC)
go



CREATE TABLE VIDEO_OPERADOR
( 
	IdVO                 int IDENTITY ( 1,1 ) ,
	NombreVO             varchar(50)  NULL ,
	ApellidoVO           varchar(50)  NULL ,
	DNIVO                char(8)  NULL 
)
go



ALTER TABLE VIDEO_OPERADOR
	ADD CONSTRAINT XPKVIDEO_OPERADOR PRIMARY KEY  CLUSTERED (IdVO ASC)
go



CREATE TABLE VIDEOVIGILANCIA
( 
	IdVigilancia         int IDENTITY ( 1,1 ) ,
	IdVO                 int  NULL ,
	IdServicio           int  NOT NULL ,
	IdMunicipalidad      int  NOT NULL ,
	CodOperacion         char(9)  NULL 
)
go



ALTER TABLE VIDEOVIGILANCIA
	ADD CONSTRAINT XPKVIDEOVIGILANCIA PRIMARY KEY  CLUSTERED (IdVigilancia ASC,IdServicio ASC,IdMunicipalidad ASC)
go




ALTER TABLE AREA_SEGURIDAD
	ADD CONSTRAINT R_207 FOREIGN KEY (IdEmpleado) REFERENCES EMPLEADO_SEGURIDAD(IdEmpleado)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE AREA_SEGURIDAD
	ADD CONSTRAINT R_214 FOREIGN KEY (IdMunicipalidad) REFERENCES MUNICIPALIDAD(IdMunicipalidad)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE ATENCION_VICTIMAS
	ADD  FOREIGN KEY (IdServicio,IdMunicipalidad) REFERENCES SERVICIO(IdServicio,IdMunicipalidad)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go




ALTER TABLE ATENCION_VICTIMAS
	ADD CONSTRAINT R_155 FOREIGN KEY (IdVictima) REFERENCES VICTIMA(IdVictima)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE ATENCION_VICTIMAS
	ADD CONSTRAINT R_156 FOREIGN KEY (idDelito) REFERENCES DELITO(idDelito)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE CAMARA
	ADD CONSTRAINT R_190 FOREIGN KEY (IdTipoCamara) REFERENCES TIPO_CAMARA(IdTipoCamara)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE CONTROL__PERSECUCCION
	ADD  FOREIGN KEY (IdDelicuencial,IdServicio,IdMunicipalidad) REFERENCES DELINCUENCIAL(IdDelicuencial,IdServicio,IdMunicipalidad)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go




ALTER TABLE DELINCUENCIAL
	ADD  FOREIGN KEY (IdServicio,IdMunicipalidad) REFERENCES SERVICIO(IdServicio,IdMunicipalidad)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go




ALTER TABLE DELINCUENCIAL
	ADD CONSTRAINT R_248 FOREIGN KEY (IdTipoDelincuencial) REFERENCES TIPO_DELINCUENCIAL(IdTipoDelincuencial)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DETALLE_CAMARA
	ADD CONSTRAINT R_238 FOREIGN KEY (IdVigilancia,IdServicio,IdMunicipalidad) REFERENCES VIDEOVIGILANCIA(IdVigilancia,IdServicio,IdMunicipalidad)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DETALLE_CAMARA
	ADD CONSTRAINT R_239 FOREIGN KEY (IdCamara) REFERENCES CAMARA(IdCamara)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DETALLE_POLICIA
	ADD CONSTRAINT R_229 FOREIGN KEY (IdDelicuencial,IdServicio,IdMunicipalidad) REFERENCES DELINCUENCIAL(IdDelicuencial,IdServicio,IdMunicipalidad)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DETALLE_POLICIA
	ADD CONSTRAINT R_230 FOREIGN KEY (IdPolicia) REFERENCES POLICIA(IdPolicia)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DETALLE_SERENAZGO
	ADD CONSTRAINT R_234 FOREIGN KEY (IdSerenazgo) REFERENCES SERENAZGO(IdSerenazgo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE DETALLE_SERENAZGO
	ADD CONSTRAINT R_235 FOREIGN KEY (IdServicio,IdMunicipalidad) REFERENCES SERVICIO(IdServicio,IdMunicipalidad)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE EMPLEADO_SEGURIDAD
	ADD CONSTRAINT R_208 FOREIGN KEY (IdTipo) REFERENCES TIPO_SEGURIDAD(IdTipo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE EMPRESA
	ADD CONSTRAINT R_162 FOREIGN KEY (IdRubro) REFERENCES RUBRO(IdRubro)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE EVALUACION
	ADD CONSTRAINT R_194 FOREIGN KEY (IdEstadoEva) REFERENCES ESTADO_EVALLUACION(IdEstadoEva)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE MANTENIMIENTO
	ADD CONSTRAINT R_161 FOREIGN KEY (IdEmpresa) REFERENCES EMPRESA(IdEmpresa)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE PERSONA_JURIDICA
	ADD  FOREIGN KEY (IdPersona) REFERENCES PERSONA(IdPersona)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go




ALTER TABLE PERSONA_JURIDICA
	ADD CONSTRAINT R_245 FOREIGN KEY (IdRazon) REFERENCES RAZON_SOCIAL(IdRazon)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE PERSONA_NATURAL
	ADD  FOREIGN KEY (IdPersona) REFERENCES PERSONA(IdPersona)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go




ALTER TABLE POLICIA
	ADD CONSTRAINT R_134 FOREIGN KEY (IdRango) REFERENCES RANGO_POLICIA(IdRango)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE POLICIA
	ADD CONSTRAINT R_222 FOREIGN KEY (IdComisaria) REFERENCES COMISARIA(IdComisaria)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE PREVENCION_DELITO
	ADD  FOREIGN KEY (IdDelicuencial,IdServicio,IdMunicipalidad) REFERENCES DELINCUENCIAL(IdDelicuencial,IdServicio,IdMunicipalidad)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go




ALTER TABLE PROGRAMACIÓN
	ADD CONSTRAINT R_163 FOREIGN KEY (IdMantenimiento) REFERENCES MANTENIMIENTO(IdMantenimiento)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE PROGRAMACIÓN
	ADD CONSTRAINT R_193 FOREIGN KEY (IdEvaluacion) REFERENCES EVALUACION(IdEvaluacion)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE PROGRAMACIÓN
	ADD CONSTRAINT R_197 FOREIGN KEY (IdMunicipalidad) REFERENCES MUNICIPALIDAD(IdMunicipalidad)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE SERENAZGO
	ADD CONSTRAINT R_219 FOREIGN KEY (IdPatrulla) REFERENCES VEHICULOS(IdPatrulla)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE SERVICIO
	ADD CONSTRAINT R_145 FOREIGN KEY (IdPersona) REFERENCES PERSONA(IdPersona)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE SERVICIO
	ADD CONSTRAINT R_146 FOREIGN KEY (IdEstado) REFERENCES ESTADO_SERVICIO(IdEstado)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE SERVICIO
	ADD CONSTRAINT R_192 FOREIGN KEY (IdTipoDescripcion) REFERENCES TIPO_COMUNICACION(IdTipoDescripcion)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE SERVICIO
	ADD CONSTRAINT R_216 FOREIGN KEY (IdMunicipalidad) REFERENCES MUNICIPALIDAD(IdMunicipalidad)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE SERVICIO
	ADD CONSTRAINT R_246 FOREIGN KEY (IdTipoServicio) REFERENCES TIPO_SERVICIO(IdTipoServicio)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE VEHICULOS
	ADD CONSTRAINT R_218 FOREIGN KEY (IdTipoV) REFERENCES TIPO_VEHICULO(IdTipoV)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE VICTIMA
	ADD CONSTRAINT R_154 FOREIGN KEY (IdEstado) REFERENCES ESTADO_VICTIMA(IdEstado)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE VIDEOVIGILANCIA
	ADD CONSTRAINT R_187 FOREIGN KEY (IdVO) REFERENCES VIDEO_OPERADOR(IdVO)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE VIDEOVIGILANCIA
	ADD  FOREIGN KEY (IdServicio,IdMunicipalidad) REFERENCES SERVICIO(IdServicio,IdMunicipalidad)
		ON DELETE CASCADE
		ON UPDATE CASCADE
go


