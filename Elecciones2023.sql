USE [master]
GO
/****** Object:  Database [Elecciones2023]    Script Date: 30/7/2023 19:29:46 ******/
CREATE DATABASE [Elecciones2023]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Elecciones2023', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Elecciones2023.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Elecciones2023_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Elecciones2023_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Elecciones2023] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Elecciones2023].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Elecciones2023] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Elecciones2023] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Elecciones2023] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Elecciones2023] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Elecciones2023] SET ARITHABORT OFF 
GO
ALTER DATABASE [Elecciones2023] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Elecciones2023] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Elecciones2023] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Elecciones2023] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Elecciones2023] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Elecciones2023] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Elecciones2023] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Elecciones2023] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Elecciones2023] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Elecciones2023] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Elecciones2023] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Elecciones2023] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Elecciones2023] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Elecciones2023] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Elecciones2023] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Elecciones2023] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Elecciones2023] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Elecciones2023] SET RECOVERY FULL 
GO
ALTER DATABASE [Elecciones2023] SET  MULTI_USER 
GO
ALTER DATABASE [Elecciones2023] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Elecciones2023] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Elecciones2023] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Elecciones2023] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Elecciones2023] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Elecciones2023] SET QUERY_STORE = OFF
GO
USE [Elecciones2023]
GO
/****** Object:  Table [dbo].[Candidato]    Script Date: 30/7/2023 19:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Candidato](
	[IdCandidato] [int] IDENTITY(1,1) NOT NULL,
	[IdPartido] [int] NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Foto] [varchar](50) NOT NULL,
	[Postulacion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Candidato] PRIMARY KEY CLUSTERED 
(
	[IdCandidato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partido]    Script Date: 30/7/2023 19:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partido](
	[IdPartido] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Logo] [varchar](50) NOT NULL,
	[SitioWeb] [varchar](50) NOT NULL,
	[FechaFundacion] [date] NOT NULL,
	[CantidadDiputados] [int] NOT NULL,
	[CantidadSenadores] [int] NOT NULL,
 CONSTRAINT [PK_Partido] PRIMARY KEY CLUSTERED 
(
	[IdPartido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Candidato] ON 

INSERT [dbo].[Candidato] ([IdCandidato], [IdPartido], [Apellido], [Nombre], [FechaNacimiento], [Foto], [Postulacion]) VALUES (1, 1, N'Cwirenbaum', N'Uriel', CAST(N'2007-04-04' AS Date), N'uriel.jpg', N'nolose')
INSERT [dbo].[Candidato] ([IdCandidato], [IdPartido], [Apellido], [Nombre], [FechaNacimiento], [Foto], [Postulacion]) VALUES (3, 1, N'Jais', N'Ueopor', CAST(N'2190-04-04' AS Date), N'img/imagen.png', N'nose')
SET IDENTITY_INSERT [dbo].[Candidato] OFF
GO
SET IDENTITY_INSERT [dbo].[Partido] ON 

INSERT [dbo].[Partido] ([IdPartido], [Nombre], [Logo], [SitioWeb], [FechaFundacion], [CantidadDiputados], [CantidadSenadores]) VALUES (1, N'Juntos por el cambio', N'img/juntos.png', N'url', CAST(N'2000-10-10' AS Date), 5, 3)
INSERT [dbo].[Partido] ([IdPartido], [Nombre], [Logo], [SitioWeb], [FechaFundacion], [CantidadDiputados], [CantidadSenadores]) VALUES (2, N'Frente de todos', N'img/frente.png', N'url', CAST(N'1998-10-10' AS Date), 3, 2)
INSERT [dbo].[Partido] ([IdPartido], [Nombre], [Logo], [SitioWeb], [FechaFundacion], [CantidadDiputados], [CantidadSenadores]) VALUES (5, N'La libertad avanza', N'img/avanza.png', N'url', CAST(N'1898-10-10' AS Date), 4, 2)
SET IDENTITY_INSERT [dbo].[Partido] OFF
GO
ALTER TABLE [dbo].[Candidato]  WITH CHECK ADD  CONSTRAINT [FK_Candidato_Partido] FOREIGN KEY([IdPartido])
REFERENCES [dbo].[Partido] ([IdPartido])
GO
ALTER TABLE [dbo].[Candidato] CHECK CONSTRAINT [FK_Candidato_Partido]
GO
USE [master]
GO
ALTER DATABASE [Elecciones2023] SET  READ_WRITE 
GO
