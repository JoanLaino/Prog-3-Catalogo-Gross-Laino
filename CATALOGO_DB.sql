USE [master]
GO
/****** Object:  Database [CATALOGO_DB]    Script Date: 1/5/2021 21:51:27 ******/
CREATE DATABASE [CATALOGO_DB] 
GO
ALTER DATABASE [CATALOGO_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CATALOGO_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CATALOGO_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CATALOGO_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CATALOGO_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CATALOGO_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CATALOGO_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CATALOGO_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CATALOGO_DB] SET  MULTI_USER 
GO
ALTER DATABASE [CATALOGO_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CATALOGO_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CATALOGO_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CATALOGO_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CATALOGO_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CATALOGO_DB] SET QUERY_STORE = OFF
GO
USE [CATALOGO_DB]
GO
/****** Object:  Table [dbo].[ARTICULOS]    Script Date: 1/5/2021 21:51:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARTICULOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](150) NULL,
	[IdMarca] [int] NULL,
	[IdCategoria] [int] NULL,
	[ImagenUrl] [varchar](1000) NULL,
	[Precio] [money] NULL,
 CONSTRAINT [PK_ARTICULOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORIAS]    Script Date: 1/5/2021 21:51:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_CATEGORIAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MARCAS]    Script Date: 1/5/2021 21:51:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MARCAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_MARCAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ARTICULOS] ON 
GO
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (1, N'S01', N'Galaxy S10', N'Una canoa cara', 1, 1, N'https://images.samsung.com/is/image/samsung/co-galaxy-s10-sm-g970-sm-g970fzyjcoo-frontcanaryyellow-thumb-149016542', 69.9990)
GO
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (2, N'M03', N'Moto G Play 7ma Gen', N'Ya siete de estos?', 1, 5, N'https://c8.alamy.com/compes/2a1gkwt/berlin-alemania-sep-2019-motorola-moto-power-g7-en-la-pantalla-del-smartphone-motorola-pabellon-showroom-innovaciones-mundiales-muestran-ifa-2019-2a1gkwt.jpg', 15699.0000)
GO
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (3, N'S99', N'Play 4', N'Ya no se cuantas versiones hay', 3, 3, N'https://www.euronics.cz/image/product/800x800/532620.jpg', 35000.0000)
GO
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (4, N'S56', N'Bravia 55', N'Alta tele', 3, 2, N'https://live.staticflickr.com/2437/3854906201_7a4633117f_z.jpg', 49500.0000)
GO
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (5, N'A23', N'Apple TV', N'lindo loro', 2, 3, N'https://www.macstation.com.ar/img/productos/small/868-apple-tv-32-gb-4k.jpg', 7850.0000)
GO
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (6, N'S01', N'Galaxy S10', N'Una canoa cara', 1, 1, N'https://images.samsung.com/is/image/samsung/co-galaxy-s10-sm-g970-sm-g970fzyjcoo-frontcanaryyellow-thumb-149016542', 69.9990)
GO
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (7, N'M03', N'Moto G Play 7ma Gen', N'Ya siete de estos?', 1, 5, N'https://c8.alamy.com/compes/2a1gkwt/berlin-alemania-sep-2019-motorola-moto-power-g7-en-la-pantalla-del-smartphone-motorola-pabellon-showroom-innovaciones-mundiales-muestran-ifa-2019-2a1gkwt.jpg', 15699.0000)
GO
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (8, N'S99', N'Play 4', N'Ya no se cuantas versiones hay', 3, 3, N'https://www.euronics.cz/image/product/800x800/532620.jpg', 35000.0000)
GO
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (9, N'S56', N'Bravia 55', N'Alta tele', 3, 2, N'https://live.staticflickr.com/2437/3854906201_7a4633117f_z.jpg', 49500.0000)
GO
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [ImagenUrl], [Precio]) VALUES (10, N'A23', N'Apple TV', N'lindo loro', 2, 3, N'https://www.macstation.com.ar/img/productos/small/868-apple-tv-32-gb-4k.jpg', 7850.0000)
GO
SET IDENTITY_INSERT [dbo].[ARTICULOS] OFF
GO
SET IDENTITY_INSERT [dbo].[CATEGORIAS] ON 
GO
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (1, N'Celulares')
GO
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (2, N'Televisores')
GO
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (3, N'Media')
GO
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (4, N'Audio')
GO
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (5, N'Celulares')
GO
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (6, N'Televisores')
GO
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (7, N'Media')
GO
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (8, N'Audio')
GO
SET IDENTITY_INSERT [dbo].[CATEGORIAS] OFF
GO
SET IDENTITY_INSERT [dbo].[MARCAS] ON 
GO
INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (1, N'Samsung')
GO
INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (2, N'Apple')
GO
INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (3, N'Sony')
GO
INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (4, N'Huawei')
GO
INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (5, N'Motorola')
GO
INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (6, N'Samsung')
GO
INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (7, N'Apple')
GO
INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (8, N'Sony')
GO
INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (9, N'Huawei')
GO
INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (10, N'Motorola')
GO
SET IDENTITY_INSERT [dbo].[MARCAS] OFF
GO
ALTER TABLE [dbo].[ARTICULOS]  WITH CHECK ADD FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[CATEGORIAS] ([Id])
GO
ALTER TABLE [dbo].[ARTICULOS]  WITH CHECK ADD FOREIGN KEY([IdMarca])
REFERENCES [dbo].[MARCAS] ([Id])
GO
USE [master]
GO
ALTER DATABASE [CATALOGO_DB] SET  READ_WRITE 
GO
