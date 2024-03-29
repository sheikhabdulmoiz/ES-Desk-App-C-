USE [master]
GO
/****** Object:  Database [DBElectricStore]    Script Date: 2/18/2024 8:05:03 PM ******/
CREATE DATABASE [DBElectricStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Electric Store', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Electric Store.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Electric Store_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Electric Store_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DBElectricStore] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBElectricStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBElectricStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBElectricStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBElectricStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBElectricStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBElectricStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBElectricStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBElectricStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBElectricStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBElectricStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBElectricStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBElectricStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBElectricStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBElectricStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBElectricStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBElectricStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBElectricStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBElectricStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBElectricStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBElectricStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBElectricStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBElectricStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBElectricStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBElectricStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBElectricStore] SET  MULTI_USER 
GO
ALTER DATABASE [DBElectricStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBElectricStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBElectricStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBElectricStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBElectricStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBElectricStore] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DBElectricStore] SET QUERY_STORE = ON
GO
ALTER DATABASE [DBElectricStore] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DBElectricStore]
GO
/****** Object:  Table [dbo].[tblCart]    Script Date: 2/18/2024 8:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCart](
	[CartId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [char](20) NULL,
	[ItemName] [char](20) NULL,
	[Type] [char](20) NULL,
	[Qty] [int] NULL,
	[Subtl] [bigint] NULL,
 CONSTRAINT [PK_tblCart] PRIMARY KEY CLUSTERED 
(
	[CartId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCategory]    Script Date: 2/18/2024 8:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCategory](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CtdName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblCategory] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCategoryItems]    Script Date: 2/18/2024 8:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCategoryItems](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NULL,
	[itemsId] [int] NULL,
 CONSTRAINT [PK_tblCategoryItems] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCustomers]    Script Date: 2/18/2024 8:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[Total] [bigint] NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_tblCustomers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblItems]    Script Date: 2/18/2024 8:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblItems](
	[itemsId] [int] IDENTITY(1,1) NOT NULL,
	[itemName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblItems] PRIMARY KEY CLUSTERED 
(
	[itemsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblItemSold]    Script Date: 2/18/2024 8:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblItemSold](
	[SellItemId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nchar](20) NULL,
	[ItemsName] [char](20) NULL,
	[ItemType] [char](20) NULL,
	[Qty] [int] NULL,
	[Subtl] [bigint] NULL,
	[Date] [datetime] NULL,
	[CustomerId] [int] NULL,
 CONSTRAINT [PK_tblItemSold] PRIMARY KEY CLUSTERED 
(
	[SellItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPermenant_Purchase]    Script Date: 2/18/2024 8:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPermenant_Purchase](
	[PurchaseId] [int] IDENTITY(1,1) NOT NULL,
	[CName] [nchar](15) NULL,
	[IName] [nchar](15) NULL,
	[Typo] [nchar](10) NULL,
	[Qty] [int] NULL,
	[UnitPrice] [int] NULL,
	[TCost] [int] NULL,
	[Date] [datetime] NULL,
 CONSTRAINT [PK_tblPermenant_Purchase] PRIMARY KEY CLUSTERED 
(
	[PurchaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPurchase]    Script Date: 2/18/2024 8:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPurchase](
	[PurchaseId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nchar](15) NULL,
	[ItemName] [nchar](15) NULL,
	[Type] [nchar](20) NULL,
	[Qty] [int] NULL,
	[UnitPrice] [int] NULL,
	[TotalCost] [bigint] NULL,
 CONSTRAINT [PK_tblPurchase] PRIMARY KEY CLUSTERED 
(
	[PurchaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSelling]    Script Date: 2/18/2024 8:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSelling](
	[SellId] [int] NOT NULL,
	[ItemName] [nchar](50) NULL,
	[Type] [nchar](10) NULL,
	[CategoryName] [nchar](50) NULL,
	[Date] [date] NULL,
	[SellingPrice] [int] NULL,
 CONSTRAINT [PK_tblSelling] PRIMARY KEY CLUSTERED 
(
	[SellId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblServices]    Script Date: 2/18/2024 8:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblServices](
	[ServiceId] [int] IDENTITY(1,1) NOT NULL,
	[SName] [nvarchar](50) NULL,
	[SCustomerName] [nchar](10) NOT NULL,
	[SDesc] [nvarchar](50) NULL,
	[SContact] [nvarchar](50) NULL,
	[SType] [nchar](10) NOT NULL,
	[SAdd] [nvarchar](50) NULL,
	[SCharges] [money] NOT NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStock]    Script Date: 2/18/2024 8:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStock](
	[StockId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [char](20) NULL,
	[ItemName] [char](20) NULL,
	[TypeName] [char](20) NULL,
	[QuantityBuy] [bigint] NULL,
	[QuantitySold] [bigint] NULL,
	[Date] [datetime] NULL,
 CONSTRAINT [PK_tblStock] PRIMARY KEY CLUSTERED 
(
	[StockId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblType]    Script Date: 2/18/2024 8:05:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblType](
	[TypeId] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [char](20) NULL,
	[UnitPrice] [bigint] NULL,
	[ItemId] [int] NULL,
 CONSTRAINT [PK_tblType] PRIMARY KEY CLUSTERED 
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblCategoryItems]  WITH CHECK ADD  CONSTRAINT [fk_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[tblCategory] ([CategoryId])
GO
ALTER TABLE [dbo].[tblCategoryItems] CHECK CONSTRAINT [fk_Category]
GO
ALTER TABLE [dbo].[tblCategoryItems]  WITH CHECK ADD  CONSTRAINT [FK_tblCategoryItems_tblCategoryItems] FOREIGN KEY([id])
REFERENCES [dbo].[tblCategoryItems] ([id])
GO
ALTER TABLE [dbo].[tblCategoryItems] CHECK CONSTRAINT [FK_tblCategoryItems_tblCategoryItems]
GO
ALTER TABLE [dbo].[tblCategoryItems]  WITH CHECK ADD  CONSTRAINT [FK_tblItems] FOREIGN KEY([itemsId])
REFERENCES [dbo].[tblItems] ([itemsId])
GO
ALTER TABLE [dbo].[tblCategoryItems] CHECK CONSTRAINT [FK_tblItems]
GO
ALTER TABLE [dbo].[tblItemSold]  WITH CHECK ADD  CONSTRAINT [FK_tblItemSold_tblCustomers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[tblCustomers] ([CustomerId])
GO
ALTER TABLE [dbo].[tblItemSold] CHECK CONSTRAINT [FK_tblItemSold_tblCustomers]
GO
ALTER TABLE [dbo].[tblType]  WITH CHECK ADD  CONSTRAINT [Fk_itemsId] FOREIGN KEY([ItemId])
REFERENCES [dbo].[tblItems] ([itemsId])
GO
ALTER TABLE [dbo].[tblType] CHECK CONSTRAINT [Fk_itemsId]
GO
ALTER TABLE [dbo].[tblType]  WITH CHECK ADD  CONSTRAINT [FK_tblType_tblType] FOREIGN KEY([TypeId])
REFERENCES [dbo].[tblType] ([TypeId])
GO
ALTER TABLE [dbo].[tblType] CHECK CONSTRAINT [FK_tblType_tblType]
GO
USE [master]
GO
ALTER DATABASE [DBElectricStore] SET  READ_WRITE 
GO
