USE [master]
GO

/****** Object:  Database [CATALOGO_DB]    Script Date: 30/4/2021 22:04:54 ******/
CREATE DATABASE [CATALOGO_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CATALOGO_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CATALOGO_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CATALOGO_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CATALOGO_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
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

ALTER DATABASE [CATALOGO_DB] SET  READ_WRITE 
GO


