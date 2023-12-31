USE [master]
GO
/****** Object:  Database [DBVelovity]    Script Date: 26/6/2022 10:06:31 ******/
CREATE DATABASE [DBVelovity]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBVelovity', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DBVelovity.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBVelovity_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DBVelovity_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DBVelovity] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBVelovity].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBVelovity] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBVelovity] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBVelovity] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBVelovity] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBVelovity] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBVelovity] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBVelovity] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBVelovity] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBVelovity] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBVelovity] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBVelovity] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBVelovity] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBVelovity] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBVelovity] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBVelovity] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBVelovity] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBVelovity] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBVelovity] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBVelovity] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBVelovity] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBVelovity] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBVelovity] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBVelovity] SET RECOVERY FULL 
GO
ALTER DATABASE [DBVelovity] SET  MULTI_USER 
GO
ALTER DATABASE [DBVelovity] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBVelovity] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBVelovity] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBVelovity] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBVelovity] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBVelovity] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBVelovity', N'ON'
GO
ALTER DATABASE [DBVelovity] SET QUERY_STORE = OFF
GO
USE [DBVelovity]
GO
/****** Object:  Table [dbo].[Comentarios]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comentarios](
	[idComentario] [int] IDENTITY(1,1) NOT NULL,
	[Comentario] [varchar](500) NULL,
 CONSTRAINT [PK_Comentarios] PRIMARY KEY CLUSTERED 
(
	[idComentario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Conductores]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conductores](
	[idConductor] [int] IDENTITY(1,1) NOT NULL,
	[conductor] [varchar](100) NULL,
	[bus] [varchar](100) NULL,
	[ruta] [varchar](100) NULL,
	[telf] [varchar](9) NULL,
	[horario] [varchar](100) NULL,
 CONSTRAINT [PK_Conductores] PRIMARY KEY CLUSTERED 
(
	[idConductor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservacion]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservacion](
	[idBus] [int] IDENTITY(1,1) NOT NULL,
	[bus] [varchar](100) NULL,
	[paraderoInicial] [varchar](200) NULL,
	[paraderoFinal] [varchar](200) NULL,
	[horario] [varchar](50) NULL,
	[asiento] [int] NULL,
	[pasaje] [money] NULL,
 CONSTRAINT [PK_Reservacion] PRIMARY KEY CLUSTERED 
(
	[idBus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUser] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](100) NULL,
	[password] [char](60) NULL,
	[phone] [int] NULL,
	[TipoUsuario] [varchar](20) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_conductor]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_actualizar_conductor]
(
	@idConductor int,
	@conductor varchar (100),
	@bus varchar (100),
	@ruta varchar (100),
	@telf varchar (9),
	@horario varchar (100)
)
as
begin
	update Conductores
	set conductor = @conductor,
		bus = @bus,
		ruta = @ruta,
		telf = @telf,
		horario = @horario
	where idConductor = @idConductor
end
GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_usuario]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_agregar_usuario]
(
	@Nombre varchar(100),
	@Contraseña char(60),
	@Telefono int
)
as
begin
	insert into Usuarios(username,password,phone,TipoUsuario) values (@Nombre,@Contraseña,@Telefono,'Usuario')
end
GO
/****** Object:  StoredProcedure [dbo].[sp_cargarbuses]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_cargarbuses]
as
select bus FROM Conductores
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_conductor]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_eliminar_conductor]
(
	@idConductor int
)
as
begin
	delete from Conductores
	where idConductor = @idConductor
end
GO
/****** Object:  StoredProcedure [dbo].[sp_iniciar_sesion]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_iniciar_sesion]
(
	@Nombre varchar(100),
	@Contraseña char(60)
)
as
begin
	select username,password,TipoUsuario from Usuarios where username = @Nombre and password =@Contraseña
end
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_comentario]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertar_comentario]
(
	@Comentario varchar(500)
	
)
as
begin
	insert into Comentarios(Comentario) values (@Comentario)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_conductor]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertar_conductor]
(
	@conductor varchar(100),
	@bus varchar (100),
	@ruta varchar (100),
	@telf varchar (9),
	@horario varchar (100)
)
as
begin
	insert into Conductores(conductor, bus, ruta,telf,horario) values (@conductor,@bus,@ruta,@telf,@horario)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarReserva]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_InsertarReserva]
(
  @Bus varchar(100),
  @Paradero_inicial varchar(200),
  @Paradero_final varchar(200),
  @Horario varchar(50),
  @asiento int,
  @pasaje decimal
)
as
begin
    insert into Reservacion(bus,paraderoInicial,paraderoFinal,horario,asiento,pasaje) values (@Bus,@Paradero_inicial,@Paradero_final,@Horario,@asiento,@pasaje)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_limpiarcome]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_limpiarcome]
as
begin
   truncate table [Comentarios]
end
GO
/****** Object:  StoredProcedure [dbo].[sp_limpiarConductores]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_limpiarConductores]
as 
begin 

   TRUNCATE table [Conductores]
end
GO
/****** Object:  StoredProcedure [dbo].[sp_limpiarReserva]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_limpiarReserva]
as
begin
   Truncate table[Reservacion]
end
GO
/****** Object:  StoredProcedure [dbo].[sp_limpiarUsuario]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_limpiarUsuario]
as
begin
  Truncate table [Usuarios]
end
GO
/****** Object:  StoredProcedure [dbo].[sp_listaConductores]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_listaConductores]
as
begin
	select * from Conductores
end
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_come]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_mostrar_come]
as
begin
   select * from Comentarios
end
GO
/****** Object:  StoredProcedure [dbo].[sp_reporte2]    Script Date: 26/6/2022 10:06:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_reporte2]
as
begin
 select * from Reservacion
end
GO
USE [master]
GO
ALTER DATABASE [DBVelovity] SET  READ_WRITE 
GO
