USE [master]
GO
/****** Object:  Database [baul]    Script Date: 15/03/2022 1:36:06 a. m. ******/
CREATE DATABASE [baul]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'baul', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\baul.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'baul_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\baul_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [baul] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [baul].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [baul] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [baul] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [baul] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [baul] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [baul] SET ARITHABORT OFF 
GO
ALTER DATABASE [baul] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [baul] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [baul] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [baul] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [baul] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [baul] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [baul] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [baul] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [baul] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [baul] SET  ENABLE_BROKER 
GO
ALTER DATABASE [baul] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [baul] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [baul] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [baul] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [baul] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [baul] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [baul] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [baul] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [baul] SET  MULTI_USER 
GO
ALTER DATABASE [baul] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [baul] SET DB_CHAINING OFF 
GO
ALTER DATABASE [baul] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [baul] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [baul] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [baul] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [baul] SET QUERY_STORE = OFF
GO
USE [baul]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 15/03/2022 1:36:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[documento] [bigint] NOT NULL,
	[nombre] [varchar](300) NOT NULL,
	[apellido] [varchar](300) NOT NULL,
	[direccion] [varchar](300) NOT NULL,
	[telefono] [bigint] NOT NULL,
	[email] [varchar](254) NULL,
	[fecha_ingreso] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cotizacion]    Script Date: 15/03/2022 1:36:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cotizacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[subtotal] [bigint] NOT NULL,
	[total] [bigint] NOT NULL,
	[envio] [bigint] NOT NULL,
	[estado] [int] NOT NULL,
	[fecha_ingreso] [datetime] NULL,
	[adjunto] [varchar](100) NULL,
	[cliente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_cotizacion]    Script Date: 15/03/2022 1:36:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_cotizacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [bigint] NOT NULL,
	[valor] [bigint] NOT NULL,
	[fecha_ingreso] [datetime] NULL,
	[id_cotizacion] [int] NULL,
	[id_producto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_facturacion]    Script Date: 15/03/2022 1:36:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_facturacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [bigint] NOT NULL,
	[valor] [bigint] NOT NULL,
	[fecha_ingreso] [datetime] NULL,
	[id_factura] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[facturacion]    Script Date: 15/03/2022 1:36:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[facturacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numero_factura] [bigint] NOT NULL,
	[subtotal] [bigint] NOT NULL,
	[total] [bigint] NOT NULL,
	[envio] [bigint] NOT NULL,
	[fecha_ingreso] [datetime] NULL,
	[adjunto] [varchar](100) NULL,
	[cliente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[imagen_producto]    Script Date: 15/03/2022 1:36:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[imagen_producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](300) NOT NULL,
	[adjunto] [varchar](100) NULL,
	[id_producto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[log]    Script Date: 15/03/2022 1:36:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[log](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[modulo] [varchar](300) NOT NULL,
	[request] [varchar](800) NOT NULL,
	[excepcion] [varchar](600) NOT NULL,
	[fecha_ingreso] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[motivo_producto]    Script Date: 15/03/2022 1:36:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[motivo_producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [char](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 15/03/2022 1:36:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [bigint] NOT NULL,
	[descripcion] [varchar](300) NOT NULL,
	[detalle_producto] [varchar](300) NOT NULL,
	[talla] [varchar](100) NOT NULL,
	[precio_unitario] [bigint] NOT NULL,
	[valor] [bigint] NOT NULL,
	[valor_venta] [bigint] NOT NULL,
	[descuento] [decimal](18, 0) NOT NULL,
	[cantidad] [int] NOT NULL,
	[valor_descuento] [bigint] NOT NULL,
	[id_motivo] [int] NOT NULL,
	[referencia] [int] NOT NULL,
	[fecha_ingreso] [datetime] NULL,
	[pieza] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stock]    Script Date: 15/03/2022 1:36:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha_movimiento] [datetime] NULL,
	[precio_unitario] [bigint] NOT NULL,
	[valor] [bigint] NOT NULL,
	[valor_venta] [bigint] NOT NULL,
	[descuento] [decimal](18, 0) NOT NULL,
	[cantidad] [int] NOT NULL,
	[valor_descuento] [bigint] NOT NULL,
	[motivo_traslado] [varchar](300) NULL,
	[id_producto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cliente] ADD  DEFAULT (getdate()) FOR [fecha_ingreso]
GO
ALTER TABLE [dbo].[cotizacion] ADD  DEFAULT (getdate()) FOR [fecha_ingreso]
GO
ALTER TABLE [dbo].[detalle_cotizacion] ADD  DEFAULT (getdate()) FOR [fecha_ingreso]
GO
ALTER TABLE [dbo].[detalle_facturacion] ADD  DEFAULT (getdate()) FOR [fecha_ingreso]
GO
ALTER TABLE [dbo].[facturacion] ADD  DEFAULT (getdate()) FOR [fecha_ingreso]
GO
ALTER TABLE [dbo].[log] ADD  DEFAULT (getdate()) FOR [fecha_ingreso]
GO
ALTER TABLE [dbo].[producto] ADD  DEFAULT (getdate()) FOR [fecha_ingreso]
GO
ALTER TABLE [dbo].[stock] ADD  DEFAULT (getdate()) FOR [fecha_movimiento]
GO
ALTER TABLE [dbo].[cotizacion]  WITH CHECK ADD  CONSTRAINT [fk_cotizacion_cliente] FOREIGN KEY([cliente])
REFERENCES [dbo].[cliente] ([id])
GO
ALTER TABLE [dbo].[cotizacion] CHECK CONSTRAINT [fk_cotizacion_cliente]
GO
ALTER TABLE [dbo].[detalle_cotizacion]  WITH CHECK ADD  CONSTRAINT [fk_detalle_cotizacion_id_cotizacion] FOREIGN KEY([id_cotizacion])
REFERENCES [dbo].[cotizacion] ([id])
GO
ALTER TABLE [dbo].[detalle_cotizacion] CHECK CONSTRAINT [fk_detalle_cotizacion_id_cotizacion]
GO
ALTER TABLE [dbo].[detalle_cotizacion]  WITH CHECK ADD  CONSTRAINT [fk_detalle_cotizacion_id_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id])
GO
ALTER TABLE [dbo].[detalle_cotizacion] CHECK CONSTRAINT [fk_detalle_cotizacion_id_producto]
GO
ALTER TABLE [dbo].[detalle_facturacion]  WITH CHECK ADD  CONSTRAINT [fk_detalle_facturacion_id_factura] FOREIGN KEY([id_factura])
REFERENCES [dbo].[facturacion] ([id])
GO
ALTER TABLE [dbo].[detalle_facturacion] CHECK CONSTRAINT [fk_detalle_facturacion_id_factura]
GO
ALTER TABLE [dbo].[detalle_facturacion]  WITH CHECK ADD  CONSTRAINT [fk_detalle_facturacion_id_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id])
GO
ALTER TABLE [dbo].[detalle_facturacion] CHECK CONSTRAINT [fk_detalle_facturacion_id_producto]
GO
ALTER TABLE [dbo].[facturacion]  WITH CHECK ADD  CONSTRAINT [fk_facturacion_cliente] FOREIGN KEY([cliente])
REFERENCES [dbo].[cliente] ([id])
GO
ALTER TABLE [dbo].[facturacion] CHECK CONSTRAINT [fk_facturacion_cliente]
GO
ALTER TABLE [dbo].[imagen_producto]  WITH CHECK ADD  CONSTRAINT [fk_imagen_producto_id_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id])
GO
ALTER TABLE [dbo].[imagen_producto] CHECK CONSTRAINT [fk_imagen_producto_id_producto]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [fk_producto_id_motivo] FOREIGN KEY([id_motivo])
REFERENCES [dbo].[motivo_producto] ([id])
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [fk_producto_id_motivo]
GO
ALTER TABLE [dbo].[stock]  WITH CHECK ADD  CONSTRAINT [fk_stock_id_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id])
GO
ALTER TABLE [dbo].[stock] CHECK CONSTRAINT [fk_stock_id_producto]
GO
USE [master]
GO
ALTER DATABASE [baul] SET  READ_WRITE 
GO
