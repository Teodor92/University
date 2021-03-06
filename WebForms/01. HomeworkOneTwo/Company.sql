USE [master]
GO
/****** Object:  Database [Company]    Script Date: 10/13/2014 12:02:34 PM ******/
CREATE DATABASE [Company]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Company”', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\TestDb\Company”.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Company”_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\TestDb\Company”_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Company] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Company].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Company] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Company] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Company] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Company] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Company] SET ARITHABORT OFF 
GO
ALTER DATABASE [Company] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Company] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Company] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Company] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Company] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Company] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Company] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Company] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Company] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Company] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Company] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Company] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Company] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Company] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Company] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Company] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Company] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Company] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Company] SET RECOVERY FULL 
GO
ALTER DATABASE [Company] SET  MULTI_USER 
GO
ALTER DATABASE [Company] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Company] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Company] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Company] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Company', N'ON'
GO
USE [Company]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 10/13/2014 12:02:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] NOT NULL,
	[CustomerName] [varchar](50) NOT NULL,
	[ContactName] [varchar](50) NULL,
	[Address] [nvarchar](max) NULL,
	[Telephone] [numeric](18, 0) NULL,
	[Bulstat] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 10/13/2014 12:02:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Position] [varchar](50) NULL,
	[EGN] [numeric](18, 0) NULL,
	[Address] [nvarchar](max) NULL,
	[Telephone] [nvarchar](50) NULL,
	[Salary] [money] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Materials]    Script Date: 10/13/2014 12:02:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Materials](
	[MaterialID] [int] NOT NULL,
	[MaterialName] [varchar](50) NOT NULL,
	[QtyLeft] [int] NULL,
	[type] [nvarchar](50) NULL,
 CONSTRAINT [PK_Materials] PRIMARY KEY CLUSTERED 
(
	[MaterialID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Order_Materials]    Script Date: 10/13/2014 12:02:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Materials](
	[MaterialID] [int] NOT NULL,
	[SupplierID] [int] NOT NULL,
	[InvoiceNum] [nvarchar](50) NULL,
	[Qty] [int] NULL,
	[UnitPrice] [money] NULL,
 CONSTRAINT [PK_Order_Materials] PRIMARY KEY CLUSTERED 
(
	[MaterialID] ASC,
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 10/13/2014 12:02:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Qty] [int] NULL,
	[UnityPrice] [money] NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 10/13/2014 12:02:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] NOT NULL,
	[OrderNumber] [numeric](18, 0) NOT NULL,
	[InvoiceNum] [nvarchar](50) NULL,
	[EmployeeID] [int] NULL,
	[CustomerID] [int] NULL,
	[date] [date] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product_Materials]    Script Date: 10/13/2014 12:02:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Materials](
	[ProductID] [int] NOT NULL,
	[MaterialID] [int] NOT NULL,
	[QtyUsed] [int] NULL,
	[QtyProduced] [int] NULL,
 CONSTRAINT [PK_Product_Materials] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[MaterialID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 10/13/2014 12:02:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] NOT NULL,
	[ProductName] [varbinary](50) NOT NULL,
	[QtyLeft] [int] NULL,
	[type] [varchar](50) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 10/13/2014 12:02:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] NOT NULL,
	[SupplierName] [varchar](50) NOT NULL,
	[ContactName] [varchar](50) NULL,
	[Address] [nvarchar](max) NULL,
	[Telephone] [numeric](18, 0) NULL,
	[Bulstat] [nvarchar](50) NULL,
	[Email] [nvarchar](max) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Order_Materials]  WITH CHECK ADD  CONSTRAINT [FK_Order_Materials_Materials] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Materials] ([MaterialID])
GO
ALTER TABLE [dbo].[Order_Materials] CHECK CONSTRAINT [FK_Order_Materials_Materials]
GO
ALTER TABLE [dbo].[Order_Materials]  WITH CHECK ADD  CONSTRAINT [FK_Order_Materials_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[Order_Materials] CHECK CONSTRAINT [FK_Order_Materials_Suppliers]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
ALTER TABLE [dbo].[Product_Materials]  WITH CHECK ADD  CONSTRAINT [FK_Product_Materials_Materials] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Materials] ([MaterialID])
GO
ALTER TABLE [dbo].[Product_Materials] CHECK CONSTRAINT [FK_Product_Materials_Materials]
GO
ALTER TABLE [dbo].[Product_Materials]  WITH CHECK ADD  CONSTRAINT [FK_Product_Materials_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[Product_Materials] CHECK CONSTRAINT [FK_Product_Materials_Products]
GO
USE [master]
GO
ALTER DATABASE [Company] SET  READ_WRITE 
GO
