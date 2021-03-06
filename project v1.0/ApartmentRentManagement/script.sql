USE [master]
GO
/****** Object:  Database [apartmentManagement]    Script Date: 4/28/2017 12:09:36 AM ******/
CREATE DATABASE [apartmentManagement] ON  PRIMARY 
( NAME = N'apartmentManagement', FILENAME = N'D:\Study\7th semester\apartmentManagement.mdf' , SIZE = 14336KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'apartmentManagement_log', FILENAME = N'D:\Study\7th semester\apartmentManagement_log.ldf' , SIZE = 10176KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [apartmentManagement] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [apartmentManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [apartmentManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [apartmentManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [apartmentManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [apartmentManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [apartmentManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [apartmentManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [apartmentManagement] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [apartmentManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [apartmentManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [apartmentManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [apartmentManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [apartmentManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [apartmentManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [apartmentManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [apartmentManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [apartmentManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [apartmentManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [apartmentManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [apartmentManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [apartmentManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [apartmentManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [apartmentManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [apartmentManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [apartmentManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [apartmentManagement] SET  MULTI_USER 
GO
ALTER DATABASE [apartmentManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [apartmentManagement] SET DB_CHAINING OFF 
GO
USE [apartmentManagement]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 4/28/2017 12:09:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[admin](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[charges]    Script Date: 4/28/2017 12:09:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[charges](
	[gas] [int] NOT NULL,
	[water] [int] NOT NULL,
	[utility] [int] NOT NULL,
	[no] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[flat]    Script Date: 4/28/2017 12:09:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[flat](
	[flatId] [int] IDENTITY(1,1) NOT NULL,
	[flatName] [varchar](50) NOT NULL,
	[info] [varchar](10) NOT NULL,
	[rent] [int] NOT NULL,
	[tenantId] [int] NULL,
 CONSTRAINT [PK_flat] PRIMARY KEY CLUSTERED 
(
	[flatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[record]    Script Date: 4/28/2017 12:09:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[record](
	[recordId] [int] NOT NULL,
	[month] [varchar](50) NOT NULL,
	[year] [varchar](50) NOT NULL,
	[flatname] [varchar](50) NOT NULL,
	[tenantName] [varchar](50) NOT NULL,
	[totalBill] [varchar](50) NOT NULL,
	[remarks] [varchar](50) NULL,
	[electricityBill] [int] NOT NULL,
	[date] [datetime] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tenant]    Script Date: 4/28/2017 12:09:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tenant](
	[tenantId] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[gender] [varchar](50) NOT NULL,
	[fatherName] [varchar](50) NOT NULL,
	[motherName] [varchar](50) NOT NULL,
	[phoneNo] [varchar](50) NOT NULL,
	[email] [varchar](50) NULL,
	[availability] [varchar](50) NULL,
	[balance] [int] NOT NULL,
	[occupation] [varchar](50) NOT NULL,
	[country] [varchar](50) NOT NULL,
	[address] [varchar](50) NOT NULL,
	[rentDate] [datetime] NOT NULL,
	[leftDate] [datetime] NULL,
	[photo] [image] NOT NULL,
	[nid] [image] NOT NULL,
	[nidno] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tenant] PRIMARY KEY CLUSTERED 
(
	[tenantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_flat]    Script Date: 4/28/2017 12:09:36 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_flat] ON [dbo].[flat]
(
	[flatName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_record]    Script Date: 4/28/2017 12:09:36 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_record] ON [dbo].[record]
(
	[recordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[flat]  WITH CHECK ADD  CONSTRAINT [FK_flat_tenant] FOREIGN KEY([tenantId])
REFERENCES [dbo].[tenant] ([tenantId])
GO
ALTER TABLE [dbo].[flat] CHECK CONSTRAINT [FK_flat_tenant]
GO
USE [master]
GO
ALTER DATABASE [apartmentManagement] SET  READ_WRITE 
GO
