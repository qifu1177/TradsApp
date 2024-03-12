
USE [master]
GO
-- Create Database--
CREATE DATABASE [TradsApp]
CONTAINMENT = NONE
GO

USE [TradsApp]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- create table traddata--
CREATE TABLE [dbo].[TradData](
	[OID] [bigint] IDENTITY(1,1) NOT NULL,
	[TimeStamp] [datetimeoffset](7) NOT NULL,
	[Price] [decimal](18, 3) NULL,
	[VolumeUnits] [int] NOT NULL,
	[VolumeEuro] [decimal](18, 3) NULL,
	[VolumePieces] [int] NOT NULL,
	[VolumeCumEuro] [decimal](18, 3) NULL,
 CONSTRAINT [PK_TradData] PRIMARY KEY CLUSTERED 
(
	[OID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

-- create table EmployeeTrade--
CREATE TABLE [dbo].[EmployeeTrade](
	[OID] [bigint] IDENTITY(1,1) NOT NULL,
	[Employee] [nvarchar](100) NOT NULL,
	[ISIN] [nvarchar](50) NOT NULL,
	[VOLUMEN] [int] NOT NULL,
	[BusinessType] [tinyint] NOT NULL,
	[TimeStamp] [datetimeoffset](7) NOT NULL,
 CONSTRAINT [PK_EmployeeTrade] PRIMARY KEY CLUSTERED 
(
	[OID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

--Add user for test--

--Create user for Admin---
CREATE LOGIN TradAdmin WITH PASSWORD = 'Test.1234.5';
CREATE USER TradAdmin FOR LOGIN TradAdmin;

ALTER ROLE db_datareader ADD MEMBER TradAdmin;
ALTER ROLE db_datawriter ADD MEMBER TradAdmin;

GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.EmployeeTrade TO TradAdmin;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.TradData TO TradAdmin;

--Create user for Compliance--
CREATE LOGIN Tester1 WITH PASSWORD = 'Test.1234.5';
CREATE USER Tester1 FOR LOGIN Tester1;

ALTER ROLE db_datareader ADD MEMBER Tester1;
ALTER ROLE db_datawriter ADD MEMBER Tester1;

GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.EmployeeTrade TO Tester1;
DENY SELECT, INSERT, UPDATE, DELETE ON dbo.TradData TO Tester1;

--Create user for Handelsüberwachung --
CREATE LOGIN Tester2 WITH PASSWORD = 'Test.1234.5';
CREATE USER Tester2 FOR LOGIN Tester2;

ALTER ROLE db_datareader ADD MEMBER Tester2;
ALTER ROLE db_datawriter ADD MEMBER Tester2;

DENY SELECT, INSERT, UPDATE, DELETE ON dbo.EmployeeTrade TO Tester2;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.TradData TO Tester2;
