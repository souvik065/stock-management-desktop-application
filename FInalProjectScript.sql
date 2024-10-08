USE [master]
GO
/****** Object:  Database [FinancialProject]    Script Date: 05-24-2023 17:40:31 ******/
CREATE DATABASE [FinancialProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FinancialProject', FILENAME = N'D:\BCA\C#(.Net)\Databases\FinancialYearAccountingProject\FinancialProject.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FinancialProject_log', FILENAME = N'D:\BCA\C#(.Net)\Databases\FinancialYearAccountingProject\FinancialProject_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FinancialProject] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FinancialProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FinancialProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FinancialProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FinancialProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FinancialProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FinancialProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [FinancialProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FinancialProject] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [FinancialProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FinancialProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FinancialProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FinancialProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FinancialProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FinancialProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FinancialProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FinancialProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FinancialProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FinancialProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FinancialProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FinancialProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FinancialProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FinancialProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FinancialProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FinancialProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FinancialProject] SET RECOVERY FULL 
GO
ALTER DATABASE [FinancialProject] SET  MULTI_USER 
GO
ALTER DATABASE [FinancialProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FinancialProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FinancialProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FinancialProject] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FinancialProject', N'ON'
GO
USE [FinancialProject]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCategoryDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[DeleteCategoryDetails]
@CATEGORYID int

AS
BEGIN
	DELETE FROM  CategoryMaster  WHERE CATEGORYID = @CATEGORYID
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteFromPurchaseDetailTable]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteFromPurchaseDetailTable]
@PurchaseDetailID int

AS
BEGIN
	Delete from PurchaseDetail where PurchasedetailID = @PurchaseDetailID
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteFromPurchaseReturnDetailTable]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteFromPurchaseReturnDetailTable]
@PurchaseReturnDetailID int

AS
BEGIN
	Delete from PurchaseReturnDetail where PurchaseReturnDetailID = @PurchaseReturnDetailID
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteFromSalesDetailTable]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE  PROCEDURE [dbo].[DeleteFromSalesDetailTable]
@SalesDetailID int

AS
BEGIN
	Delete from SalesDetail where SalesDetailID = @SalesDetailID
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteFromSalesReturnDetailTable]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteFromSalesReturnDetailTable]
@SalesReturnDetailID int

AS
BEGIN
	Delete from SalesReturnDetail where SalesReturnDetailID = @SalesReturnDetailID
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteFromSupplierMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteFromSupplierMaster]
@SUPPLIERID INT
AS
BEGIN
	DELETE FROM SupplierMaster WHERE SUPPLIERID = @SUPPLIERID
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteIntoProductMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteIntoProductMaster]
@PRODUCTID INT
AS
BEGIN
	DELETE FROM ProductMaster WHERE PRODUCTID = @PRODUCTID
END

GO
/****** Object:  StoredProcedure [dbo].[DeletePrductDetail]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeletePrductDetail]
@PRODUCTDETAILID INT
AS
BEGIN
	DELETE FROM ProductDetails WHERE PRODUCTDETAILID = @PRODUCTDETAILID
   
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteSubCategoryDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[DeleteSubCategoryDetails]
@SUBCATEGORYID int

AS
BEGIN
	DELETE FROM SubCategoryMaster WHERE SUBCATEGORYID  = @SUBCATEGORYID
END

GO
/****** Object:  StoredProcedure [dbo].[GetCategoryDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetCategoryDetails]

AS
BEGIN
	SELECT CATEGORYID, CATEGORYNAME FROM CategoryMaster
END

GO
/****** Object:  StoredProcedure [dbo].[GetProductDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetProductDetails]

@PRODUCTID INT

AS
BEGIN
	SELECT PRODUCTDETAILID, PRODUCTID, QTY, UNIT, PURCHASERATE, SALESRATE, CGSTPERCENTAGE, CGSTAMOUNT, SGSTPERCENTAGE, SGSTAMOUNT, IGSTPERCENTAGE, IGSTAMOUNT, BASICRATE, MRP FROM ProductDetails WHERE PRODUCTID = @PRODUCTID
END

GO
/****** Object:  StoredProcedure [dbo].[GetPurchaseDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetPurchaseDetails]
@PurchaseId int
AS
BEGIN
	select PurchasedetailID, PurchaseID,pd.ProductID, prom.PRODUCTNAME, IsExpire, [ExpireDate], Rate, Qty, HSNCode, Total, DiscountPercentage, DiscountAmount, TaxableAmount, 
	CGSTPercentage, CGSTAmount, SGSTPercentage, SGSTAmount, IGSTPercentage, IGSTAmount, NetAmount from PurchaseDetail as pd inner join ProductMaster prom on 
	pd.ProductID = prom.PRODUCTID   Where PurchaseID = @PurchaseId
END

GO
/****** Object:  StoredProcedure [dbo].[GetPurchaseReturnDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetPurchaseReturnDetails]
@PurchaseReturnId int
AS
BEGIN
	select PurchaseReturnDetailID, PurchaseReturnID,pd.ProductID, prom.PRODUCTNAME, IsExpire, [ExpireDate], Rate, Qty, HSNCode, Total, DiscountPercentage, DiscountAmount, TaxableAmount, 
	CGSTPercentage, CGSTAmount, SGSTPercentage, SGSTAmount, IGSTPercentage, IGSTAmount, NetAmount from PurchaseReturnDetail as pd inner join ProductMaster prom on 
	pd.ProductID = prom.PRODUCTID   Where PurchaseReturnID = @PurchaseReturnId
END

GO
/****** Object:  StoredProcedure [dbo].[GetPurchaseReturnTotalAmount]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,> 


-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetPurchaseReturnTotalAmount]
@PurchaseReturnMasterID int
AS
BEGIN
	Select sum(Total) as GrossAmount
	,sum(DiscountAmount) as DiscountAmount
	,sum(TaxableAmount) as TaxableAmount
	,sum(CGSTAmount) as CGSTAmount
	,sum(SGSTAmount) as SGSTAmount
	,sum(IGSTAmount) as IGSTAmount
	,sum(NetAmount) as TotalNetAmount from PurchaseReturnDetail where PurchaseReturnID = @PurchaseReturnMasterID
END

GO
/****** Object:  StoredProcedure [dbo].[GetRateOfTheProduct]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetRateOfTheProduct]
@ProductID int
AS
BEGIN
	Select SALESRATE from ProductDetails where PRODUCTID = @ProductID
END

GO
/****** Object:  StoredProcedure [dbo].[GetSalesDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetSalesDetails]
@SalesId int
AS
BEGIN
	select SalesDetailID, SalesID,sd.ProductID, prom.PRODUCTNAME,Rate, Qty, HSNCode, Total, DiscountPercentage, DiscountAmount, TaxableAmount, 
	CGSTPercentage, CGSTAmount, SGSTPercentage, SGSTAmount, IGSTPercentage, IGSTAmount, NetAmount from SalesDetail as sd inner join ProductMaster prom on 
	sd.ProductID = prom.PRODUCTID   Where SalesID = @SalesId
END

GO
/****** Object:  StoredProcedure [dbo].[GetSalesMasterTotalAmount]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetSalesMasterTotalAmount]
@SalesMasterID int
AS
BEGIN
	Select sum(Total) as GrossAmount
	,sum(DiscountAmount) as DiscountAmount
	,sum(TaxableAmount) as TaxableAmount
	,sum(CGSTAmount) as CGSTAmount
	,sum(SGSTAmount) as SGSTAmount
	,sum(IGSTAmount) as IGSTAmount
	,sum(NetAmount) as TotalNetAmount from SalesDetail where SalesID = @SalesMasterID
END

GO
/****** Object:  StoredProcedure [dbo].[GetSalesReturnDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>	
-- =============================================
Create PROCEDURE [dbo].[GetSalesReturnDetails]
@SalesReturnId int
AS
BEGIN
	select SalesReturnDetailID, SalesReturnID,sd.ProductID, prom.PRODUCTNAME,Rate, Qty, HSNCode, Total, DiscountPercentage, DiscountAmount, TaxableAmount, 
	CGSTPercentage, CGSTAmount, SGSTPercentage, SGSTAmount, IGSTPercentage, IGSTAmount, NetAmount from SalesReturnDetail as sd inner join ProductMaster prom on 
	sd.ProductID = prom.PRODUCTID   Where SalesReturnId = @SalesReturnId
END

GO
/****** Object:  StoredProcedure [dbo].[GetSalesReturnMasterTotalAmount]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,> 


-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[GetSalesReturnMasterTotalAmount]
@SalesReturnMasterID int
AS
BEGIN
	Select sum(Total) as GrossAmount
	,sum(DiscountAmount) as DiscountAmount
	,sum(TaxableAmount) as TaxableAmount
	,sum(CGSTAmount) as CGSTAmount
	,sum(SGSTAmount) as SGSTAmount
	,sum(IGSTAmount) as IGSTAmount
	,sum(NetAmount) as TotalNetAmount from SalesReturnDetail where SalesReturnID = @SalesReturnMasterID
END

GO
/****** Object:  StoredProcedure [dbo].[GetSubCategoryDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetSubCategoryDetails]

AS
BEGIN
	SELECT SUBCATEGORYID,CATEGORYNAME,SUBCAT.CATEGORYID, SUBCATEGORYNAME FROM SubCategoryMaster SUBCAT INNER JOIN CategoryMaster ON SUBCAT.CATEGORYID = CategoryMaster.CATEGORYID
END
GO
/****** Object:  StoredProcedure [dbo].[GetSupplierMasterDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetSupplierMasterDetails]

AS
BEGIN
	SELECT SUPPLIERID, SUPPLIERNAME, [ADDRESS], EMAILID, MOBILENO, CONTACTPERSON, REMARK FROM SupplierMaster

    
END

GO
/****** Object:  StoredProcedure [dbo].[GetTotalAmount]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,> 


-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetTotalAmount]
@PurchaseMasterID int
AS
BEGIN
	Select sum(Total) as GrossAmount
	,sum(DiscountAmount) as DiscountAmount
	,sum(TaxableAmount) as TaxableAmount
	,sum(CGSTAmount) as CGSTAmount
	,sum(SGSTAmount) as SGSTAmount
	,sum(IGSTAmount) as IGSTAmount
	,sum(NetAmount) as TotalNetAmount from PurchaseDetail where PurchaseID = @PurchaseMasterID
END

GO
/****** Object:  StoredProcedure [dbo].[InsertCategoryDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCategoryDetails]
@CATEGORYNAME varchar(50)

AS
BEGIN
	INSERT INTO CategoryMaster(CATEGORYNAME) VALUES(@CATEGORYNAME)
END

GO
/****** Object:  StoredProcedure [dbo].[InsertIntoProductDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertIntoProductDetails]
@PRODUCTID  int,
@QTY decimal(18,2),
@UNIT varchar(50),
@PURCHASERATE decimal(18,2),
@SALESRATE decimal(18,2),
@CGSTPERCENTAGE decimal(18,2), 
@CGSTAMOUNT decimal(18,2), 
@SGSTPERCENTAGE decimal(18,2),
@SGSTAMOUNT decimal(18,2), 
@IGSTPERCENTAGE decimal(18,2), 
@IGSTAMOUNT decimal(18,2), 
@BASICRATE decimal(18,2), 
@MRP decimal(18,2)

AS
BEGIN
	INSERT INTO ProductDetails (PRODUCTID, QTY, UNIT, PURCHASERATE, SALESRATE, CGSTPERCENTAGE, CGSTAMOUNT, SGSTPERCENTAGE, SGSTAMOUNT, IGSTPERCENTAGE, IGSTAMOUNT, BASICRATE, MRP)
	VALUES(@PRODUCTID, @QTY, @UNIT, @PURCHASERATE, @SALESRATE, @CGSTPERCENTAGE, @CGSTAMOUNT, @SGSTPERCENTAGE, @SGSTAMOUNT, @IGSTPERCENTAGE, @IGSTAMOUNT, @BASICRATE, @MRP)

END

GO
/****** Object:  StoredProcedure [dbo].[InsertIntoProductMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertIntoProductMaster]
@PRODUCTNAME varchar(50),
@SUBCATEGORYID int
AS
BEGIN
	INSERT INTO ProductMaster (PRODUCTNAME,SUBCATEGORYID) VALUES(@PRODUCTNAME,@SUBCATEGORYID)
	SELECT @@IDENTITY PRODUCTID
END

GO
/****** Object:  StoredProcedure [dbo].[InsertIntoPurchaseDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertIntoPurchaseDetails]
@PurchaseID int,
@ProductID int,
@IsExpire bit, 
@ExpireDate date,
@Rate decimal(18,2),
@Qty decimal(18,2),
@HSNCode numeric(18,0),
@Total decimal(18,2),
@DiscountPercentage decimal(18,2),
@DiscountAmount decimal(18,2),
@TaxableAmount decimal(18,2),
@CGSTPercentage decimal(18,2),
@CGSTAmount decimal(18,2),
@SGSTPercentage decimal(18,2),
@SGSTAmount decimal(18,2),
@IGSTPercentage decimal(18,2),
@IGSTAmount decimal(18,2),
@NetAmount decimal(18,2)
AS
BEGIN
	Insert into PurchaseDetail(PurchaseID, ProductID, IsExpire, [ExpireDate], Rate, Qty, HSNCode, Total, DiscountPercentage, DiscountAmount,
	 TaxableAmount, CGSTPercentage, CGSTAmount, SGSTPercentage, SGSTAmount, IGSTPercentage, IGSTAmount, NetAmount)
	 values(@PurchaseID,@ProductID,@IsExpire,@ExpireDate,@Rate,@Qty,@HSNCode,@Total,@DiscountPercentage,@DiscountAmount,@TaxableAmount,@CGSTPercentage,@CGSTAmount
			,@SGSTPercentage,@SGSTAmount,@IGSTPercentage,@IGSTAmount,@NetAmount)
END

GO
/****** Object:  StoredProcedure [dbo].[InsertIntoPurchaseMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertIntoPurchaseMaster]
@PurchaseDate date,
@SupplierID int,
@InvoiceNo numeric(18,0)
AS
BEGIN
	Insert into PurchaseMaster(PurchaseDate,SupplierID,InvoiceNo) values(@PurchaseDate,@SupplierID,@InvoiceNo)
	select @@IDENTITY PurchaseID
END

GO
/****** Object:  StoredProcedure [dbo].[InsertIntoPurchaseReturnDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertIntoPurchaseReturnDetails]
@PurchaseReturnID int,
@ProductID int,
@IsExpire bit, 
@ExpireDate date,
@Rate decimal(18,2),
@Qty decimal(18,2),
@HSNCode numeric(18,0),
@Total decimal(18,2),
@DiscountPercentage decimal(18,2),
@DiscountAmount decimal(18,2),
@TaxableAmount decimal(18,2),
@CGSTPercentage decimal(18,2),
@CGSTAmount decimal(18,2),
@SGSTPercentage decimal(18,2),
@SGSTAmount decimal(18,2),
@IGSTPercentage decimal(18,2),
@IGSTAmount decimal(18,2),
@NetAmount decimal(18,2)
AS
BEGIN
	Insert into PurchaseReturnDetail(PurchaseReturnID, ProductID, IsExpire, [ExpireDate], Rate, Qty, HSNCode, Total, DiscountPercentage, DiscountAmount,
	 TaxableAmount, CGSTPercentage, CGSTAmount, SGSTPercentage, SGSTAmount, IGSTPercentage, IGSTAmount, NetAmount)
	 values(@PurchaseReturnID,@ProductID,@IsExpire,@ExpireDate,@Rate,@Qty,@HSNCode,@Total,@DiscountPercentage,@DiscountAmount,@TaxableAmount,@CGSTPercentage,@CGSTAmount
			,@SGSTPercentage,@SGSTAmount,@IGSTPercentage,@IGSTAmount,@NetAmount)
END

GO
/****** Object:  StoredProcedure [dbo].[InsertIntoSalesDetail]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>


-- =============================================
CREATE PROCEDURE [dbo].[InsertIntoSalesDetail]
@SalesID int,
@ProductID int,
@Rate decimal(18,2),
@Qty decimal(18,2),
@HSNCode numeric(18,0),
@Total decimal(18,2),
@DiscountPercentage decimal(18,2),
@DiscountAmount decimal(18,2),
@TaxableAmount decimal(18,2),
@CGSTPercentage decimal(18,2),
@CGSTAmount decimal(18,2),
@SGSTPercentage decimal(18,2),
@SGSTAmount decimal(18,2),
@IGSTPercentage decimal(18,2),
@IGSTAmount decimal(18,2),
@NetAmount decimal(18,2)
AS
BEGIN
	Insert into SalesDetail(SalesID, ProductID, Rate, Qty, HSNCode, Total, DiscountPercentage, DiscountAmount,
	 TaxableAmount, CGSTPercentage, CGSTAmount, SGSTPercentage, SGSTAmount, IGSTPercentage, IGSTAmount, NetAmount)
	 values(@SalesID,@ProductID,@Rate,@Qty,@HSNCode,@Total,@DiscountPercentage,@DiscountAmount,@TaxableAmount,@CGSTPercentage,@CGSTAmount
			,@SGSTPercentage,@SGSTAmount,@IGSTPercentage,@IGSTAmount,@NetAmount)
END


GO
/****** Object:  StoredProcedure [dbo].[InsertIntoSalesMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertIntoSalesMaster]
@SalesDate date,
@InvoiceNo numeric(18,0)
AS
BEGIN
	Insert into SalesMaster(SalesDate,InvoiceNo) values(@SalesDate,@InvoiceNo)
	select @@IDENTITY SalesID
END

GO
/****** Object:  StoredProcedure [dbo].[InsertIntoSalesReturnDetail]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertIntoSalesReturnDetail]
@SalesReturnID int,
@ProductID int,
@Rate decimal(18,2),
@Qty decimal(18,2),
@HSNCode numeric(18,0),
@Total decimal(18,2),
@DiscountPercentage decimal(18,2),
@DiscountAmount decimal(18,2),
@TaxableAmount decimal(18,2),
@CGSTPercentage decimal(18,2),
@CGSTAmount decimal(18,2),
@SGSTPercentage decimal(18,2),
@SGSTAmount decimal(18,2),
@IGSTPercentage decimal(18,2),
@IGSTAmount decimal(18,2),
@NetAmount decimal(18,2)
AS
BEGIN
	Insert into SalesReturnDetail(SalesReturnID, ProductID, Rate, Qty, HSNCode, Total, DiscountPercentage, DiscountAmount,
	 TaxableAmount, CGSTPercentage, CGSTAmount, SGSTPercentage, SGSTAmount, IGSTPercentage, IGSTAmount, NetAmount)
	 values(@SalesReturnID,@ProductID,@Rate,@Qty,@HSNCode,@Total,@DiscountPercentage,@DiscountAmount,@TaxableAmount,@CGSTPercentage,@CGSTAmount
			,@SGSTPercentage,@SGSTAmount,@IGSTPercentage,@IGSTAmount,@NetAmount)
END

GO
/****** Object:  StoredProcedure [dbo].[InsertIntoSalesReturnMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertIntoSalesReturnMaster]
@SalesReturnDate date,
@InvoiceNo numeric(18,0)
AS
BEGIN
	Insert into SalesReturnMaster(SalesReturnDate,InvoiceNo) values(@SalesReturnDate,@InvoiceNo)
	select @@IDENTITY SalesReturnID
END

GO
/****** Object:  StoredProcedure [dbo].[InsertIntoSupplierMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertIntoSupplierMaster]
@SUPPLIERNAME varchar(50),
@ADDRESS varchar(500),
@EMAILID varchar(50),
@MOBILENO numeric(18,0),
@CONTACTPERSON varchar(50),
@REMARK varchar(500)
AS
BEGIN
	INSERT INTO SupplierMaster (SUPPLIERNAME, [ADDRESS], EMAILID, MOBILENO, CONTACTPERSON, REMARK) VALUES(@SUPPLIERNAME, @ADDRESS, @EMAILID, @MOBILENO, @CONTACTPERSON, @REMARK)
END

GO
/****** Object:  StoredProcedure [dbo].[InsertSubCategoryDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertSubCategoryDetails]
@CATEGORYID int,
@SUBCATEGORYNAME varchar(50)
AS
BEGIN
	INSERT INTO SubCategoryMaster (CATEGORYID, SUBCATEGORYNAME) VALUES(@CATEGORYID,@SUBCATEGORYNAME)
END

GO
/****** Object:  StoredProcedure [dbo].[InsterIntoPurchaseReturnMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsterIntoPurchaseReturnMaster]
@PurchaseDate date,
@SupplierID int,
@InvoiceNo numeric(18,0)


AS
BEGIN
	Insert into PurchaseReturnMaster(PurchaseDate,SupplierID,InvoiceNo) values(@PurchaseDate,@SupplierID,@InvoiceNo)
	select @@IDENTITY PurchaseReturnID
END

GO
/****** Object:  StoredProcedure [dbo].[ListCategoryDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[ListCategoryDetails]

AS
BEGIN
	SELECT 0 AS CATEGORYID,'--Select Category--' AS CATEGORYNAME UNION
	SELECT CATEGORYID, CATEGORYNAME FROM CategoryMaster
END

GO
/****** Object:  StoredProcedure [dbo].[ListFinancialYear]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListFinancialYear]

AS
BEGIN
	select 0 as YEARID ,'--Select Year--' As FINANCIALYEAR union
	select YEARID,FINANCIALYEAR from FinancialYearMaster
END

GO
/****** Object:  StoredProcedure [dbo].[ListProductMasterDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ListProductMasterDetails]
	
AS
BEGIN
	select 0 as PRODUCTID, '--Select Product--' as PRODUCTNAME union
	select PRODUCTID, PRODUCTNAME from ProductMaster
END

GO
/****** Object:  StoredProcedure [dbo].[ListSubCategoryDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListSubCategoryDetails]
@CATEGORYID int
AS
BEGIN
	select 0 as SUBCATEGORYID,'--SELECT--' As SUBCATEGORYNAME 
	UNION
	select SUBCATEGORYID,SUBCATEGORYNAME from SubCategoryMaster where CATEGORYID = @CATEGORYID
END

GO
/****** Object:  StoredProcedure [dbo].[ListSupplierDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ListSupplierDetails]

AS
BEGIN
	select 0 as SUPPLIERID , '--Select Supplier--' as SUPPLIERNAME   union
	select SUPPLIERID, SUPPLIERNAME  from SupplierMaster
END

GO
/****** Object:  StoredProcedure [dbo].[MacthingUserDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- MacthingUserDetails 'Souvik','123456'
-- =============================================
CREATE PROCEDURE [dbo].[MacthingUserDetails]
@USERNAME VARCHAR(50),
@PASSWORD VARCHAR(50)


AS
BEGIN
if exists (select * from FinancialYearMaster where ISCURRENT = 'true')

begin
select USERNAME,PASSWORD from LoginDetails where USERNAME = @USERNAME AND PASSWORD = @PASSWORD 
end
	
END

GO
/****** Object:  StoredProcedure [dbo].[ResetProductDetail]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ResetProductDetail]
@PRODUCTID INT
AS
BEGIN
	DELETE FROM ProductDetails WHERE PRODUCTID = PRODUCTID
END

GO
/****** Object:  StoredProcedure [dbo].[ResetPurchaseDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ResetPurchaseDetails]
@PurchaseMasterID int	
AS
BEGIN
	delete from PurchaseDetail where PurchaseID = @PurchaseMasterID
END

GO
/****** Object:  StoredProcedure [dbo].[ResetPurchaseMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ResetPurchaseMaster]
@PurchaseMasterID int
AS
BEGIN
	delete from PurchaseMaster where PurchaseID = @PurchaseMasterID
END

GO
/****** Object:  StoredProcedure [dbo].[ResetPurchaseReturnDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[ResetPurchaseReturnDetails]
@PurchaseReturnMasterID int	
AS
BEGIN
	delete from PurchaseReturnDetail where PurchaseReturnID = @PurchaseReturnMasterID
END

GO
/****** Object:  StoredProcedure [dbo].[ResetPurchaseReturnMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ResetPurchaseReturnMaster]
@PurchaseReturnMasterID int
AS
BEGIN
	delete from PurchaseReturnMaster where PurchaseReturnID = @PurchaseReturnMasterID
END

GO
/****** Object:  StoredProcedure [dbo].[ResetSalesDetail]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ResetSalesDetail]
@SalesMasterID int	
AS
BEGIN
	delete from SalesDetail where SalesID = @SalesMasterID
END


GO
/****** Object:  StoredProcedure [dbo].[ResetSalesMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ResetSalesMaster]
@SalesMasterID int
AS
BEGIN
	delete from SalesMaster where SalesID = @SalesMasterID	
END
GO
/****** Object:  StoredProcedure [dbo].[ResetSalesReturnDetail]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ResetSalesReturnDetail]
@SalesReturnMasterID int	
AS
BEGIN
	delete from SalesReturnDetail where SalesReturnID = @SalesReturnMasterID
END


GO
/****** Object:  StoredProcedure [dbo].[ResetSalesReturnMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ResetSalesReturnMaster]
@SalesReturnMasterID int
AS
BEGIN
	delete from SalesReturnMaster where SalesReturnID = @SalesReturnMasterID	
END
GO
/****** Object:  StoredProcedure [dbo].[RPTCategoryList]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RPTCategoryList]

AS
BEGIN
	Select CATEGORYID,CATEGORYNAME from CategoryMaster
END

GO
/****** Object:  StoredProcedure [dbo].[RPTGetProductBySubCategory]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>


-- =============================================
CREATE PROCEDURE [dbo].[RPTGetProductBySubCategory]
@SubCategoryID int,
@CategoryID int
AS
BEGIN
	select PRODUCTDETAILID,cm.CATEGORYNAME,scm.SUBCATEGORYNAME ,pm.PRODUCTNAME, QTY, UNIT, PURCHASERATE, SALESRATE, CGSTPERCENTAGE, CGSTAMOUNT, SGSTPERCENTAGE, SGSTAMOUNT,
	 IGSTPERCENTAGE, IGSTAMOUNT, BASICRATE, MRP
	  from ProductDetails pd
	  inner join ProductMaster pm on pd.PRODUCTID = pm.PRODUCTID
	  inner join SubCategoryMaster scm on pm.SUBCATEGORYID = scm.SUBCATEGORYID
	  inner join CategoryMaster cm on scm.CATEGORYID = cm.CATEGORYID
	  where pm.SUBCATEGORYID =(case when @SubCategoryID = 0 then
									pm.SUBCATEGORYID else @SubCategoryID end)
	  and scm.CATEGORYID = (case when @CategoryID = 0 then
									scm.CATEGORYID else @CategoryID end)




END

GO
/****** Object:  StoredProcedure [dbo].[RPTGetPurchaseDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RPTGetPurchaseDetails]

AS
BEGIN
	select pm.PRODUCTNAME,IsExpire,CONVERT(VARCHAR,ExpireDate,103) AS ExpireDateDMY,Rate,Qty,PurchasedetailID,HSNCode, Total, DiscountPercentage, DiscountAmount, purd.TaxableAmount, CGSTPercentage,
	 purd.CGSTAmount, SGSTPercentage, purd.SGSTAmount, IGSTPercentage, purd.IGSTAmount, purd.NetAmount,
	 PurchaseDate, SupplierID, InvoiceNo, TotalGrossAmount, TotalDiscountAmount, purm.TaxableAmount as TotalTaxableAMT, purm.CGSTAmount as TotalCGSTAMT, purm.SGSTAmount as TotalSGSTAMT, purm.IGSTAmount as TotalIGSTAMT, TotalAmount as TotalNetAMT,
	  TradeDiscountAmount, CashDiscountAmount, FreighCharges, LabourCharges, purm.NetAmount as PMNetAmount, PaymentMode, Remark
	  from PurchaseDetail as purd inner join ProductMaster as pm 
	 on purd.ProductID = pm.PRODUCTID 
	 inner join PurchaseMaster as purm on purm.PurchaseID = purd.PurchaseID 


END

GO
/****** Object:  StoredProcedure [dbo].[RPTGetPurchaseReturnDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RPTGetPurchaseReturnDetails]


AS
BEGIN
	select  pm.PRODUCTNAME,IsExpire, ExpireDate, Rate, Qty, HSNCode, Total, DiscountPercentage, DiscountAmount, 
	TaxableAmount, CGSTPercentage, prd.CGSTAmount, SGSTPercentage, prd.SGSTAmount, IGSTPercentage, prd.IGSTAmount, prd.NetAmount,
	Sup.SUPPLIERNAME, InvoiceNo, TotalGrossAmount, TotalDiscountAmount, prm.CGSTAmount as TotalCGSTAMT, prm.SGSTAmount as TotalSGSTAMT, prm.IGSTAmount as TotalIGSTAMT, TotalAmount as TotalNetAMT, TradeDiscountAmount, 
	CashDiscountAmount, FreighCharges, LabourCharges, prm.NetAmount, PaymentMode
	 from PurchaseReturnDetail as prd
	inner join ProductMaster as pm on pm.PRODUCTID = prd.ProductID
	inner join PurchaseReturnMaster as prm on prm.PurchaseReturnID = prd.PurchaseReturnID 
	inner join SupplierMaster as sup on sup.SUPPLIERID = prm.SupplierID
	
END

GO
/****** Object:  StoredProcedure [dbo].[RPTGetSaleDetail]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>


-- =============================================
CREATE PROCEDURE [dbo].[RPTGetSaleDetail]

AS
BEGIN
	select pm.PRODUCTNAME, Rate, Qty, HSNCode, Total, DiscountPercentage, DiscountAmount, sd.TaxableAmount, CGSTPercentage, sd.CGSTAmount, SGSTPercentage,
	 sd.SGSTAmount, IGSTPercentage, sd.IGSTAmount, sd.NetAmount,
	 sm.SalesID, SalesDate, InvoiceNo, TotalGrossAmount, TotalDiscountAmount, sm.TaxableAmount as TotalTaxableAMT, sm.CGSTAmount as TotalCGSTAMT, sm.SGSTAmount as TotalSGSAMT, sm.IGSTAmount as TotalIGSTAMT, sm.NetAmount as SMNetAMT, 
	 MobileNo, CustomerName, Address, PaymentMode
	 from SalesDetail as sd
	 inner join ProductMaster as pm on sd.ProductID = pm.PRODUCTID
	 inner join SalesMaster as sm on sd.SalesID = sm.SalesID

	 
END

GO
/****** Object:  StoredProcedure [dbo].[RPTGetSaleReturnDetail]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RPTGetSaleReturnDetail]

AS
BEGIN
	select pm.PRODUCTNAME, Rate, Qty, HSNCode, Total, DiscountPercentage, DiscountAmount, srd.TaxableAmount, CGSTPercentage, srd.CGSTAmount, SGSTPercentage,
	 srd.SGSTAmount, IGSTPercentage, srd.IGSTAmount, srd.NetAmount,
	 srm.SalesReturnID, SalesReturnDate, InvoiceNo, TotalGrossAmount, TotalDiscountAmount, srm.TaxableAmount as TotalTaxableAMT, srm.CGSTAmount as TotalCGSTAMT, srm.SGSTAmount as TotalSGSAMT,
	  srm.IGSTAmount as TotalIGSTAMT, srm.NetAmount as SMNetAMT, 
	 MobileNo, CustomerName, Address, PaymentMode
	 from SalesReturnDetail as srd
	 inner join ProductMaster as pm on srd.ProductID = pm.PRODUCTID
	 inner join SalesReturnMaster as srm on srd.SalesReturnID = srm.SalesReturnID

	 
END

GO
/****** Object:  StoredProcedure [dbo].[RPTGetSubCategoryList]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RPTGetSubCategoryList]

AS
BEGIN
	select SUBCATEGORYID,cm.CATEGORYNAME,SUBCATEGORYNAME from SubCategoryMaster as scm inner join CategoryMaster as cm on scm.CATEGORYID = cm.CATEGORYID
END

GO
/****** Object:  StoredProcedure [dbo].[RPTProductDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RPTProductDetails]

AS
BEGIN
	select PRODUCTDETAILID,pm.PRODUCTNAME,sc.SUBCATEGORYNAME,QTY,UNIT,PURCHASERATE,SALESRATE,CGSTPERCENTAGE,CGSTAMOUNT
	,SGSTPERCENTAGE,SGSTAMOUNT,IGSTPERCENTAGE,IGSTAMOUNT,BASICRATE,MRP 
	 from ProductDetails as pd
	inner join ProductMaster as pm 
	on pd.PRODUCTID = pm.PRODUCTID
	 inner join SubCategoryMaster as sc
	  on pm.SUBCATEGORYID = sc.SUBCATEGORYID
END

GO
/****** Object:  StoredProcedure [dbo].[RPTPurchaseReportByParameter]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RPTPurchaseReportByParameter]
@SupplierID int,
@InvoiceNo numeric(18,0),
@StartDate date,
@EndDate date
AS
BEGIN
	select PurchasedetailID, purd.PurchaseID,pm.PRODUCTNAME ,purd.ProductID, IsExpire, [ExpireDate], Rate, Qty, HSNCode, Total, DiscountPercentage, DiscountAmount,
	purd.TaxableAmount, CGSTPercentage, purd.CGSTAmount, SGSTPercentage, purd.SGSTAmount, IGSTPercentage, purd.IGSTAmount, purd.NetAmount,

	PurchaseDate, sup.SUPPLIERNAME, InvoiceNo, TotalGrossAmount, TotalDiscountAmount, purm.TaxableAmount as TotalTaxableAMT, purm.CGSTAmount TotalCGSTAMT, purm.SGSTAmount as TotalSGSTAMT, 
	purm.IGSTAmount as TotalIGSTAMT, TotalAmount as TotalNetAMT,TradeDiscountAmount, CashDiscountAmount, FreighCharges, LabourCharges, purm.NetAmount, PaymentMode
	from PurchaseDetail purd
	inner join ProductMaster pm on purd.ProductID = pm.PRODUCTID 
	inner join PurchaseMaster purm on purd.PurchaseID = purm.PurchaseID
	inner join SupplierMaster sup on sup.SUPPLIERID = purm.SupplierID
	where purm.SupplierID =(case when @SupplierID = 0 then
								purm.SupplierID else @SupplierID end) and 
		  InvoiceNo = (case when @InvoiceNo = 0 then
								InvoiceNo else @InvoiceNo end)
								 and
	PurchaseDate between @StartDate and @EndDate

END

GO
/****** Object:  StoredProcedure [dbo].[RPTPurchaseReturnReportByParameter]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[RPTPurchaseReturnReportByParameter]
@SupplierID int,
@InvoiceNo numeric(18,0),
@StartDate date,
@EndDate date
AS
BEGIN
	select PurchaseReturnDetailID, purd.PurchaseReturnID,pm.PRODUCTNAME ,purd.ProductID, IsExpire, [ExpireDate], Rate, Qty, HSNCode, Total, DiscountPercentage, DiscountAmount,
	purd.TaxableAmount, CGSTPercentage, purd.CGSTAmount, SGSTPercentage, purd.SGSTAmount, IGSTPercentage, purd.IGSTAmount, purd.NetAmount,

	PurchaseDate, sup.SUPPLIERNAME, InvoiceNo, TotalGrossAmount, TotalDiscountAmount, purm.TaxableAmount as TotalTaxableAMT, purm.CGSTAmount TotalCGSTAMT, purm.SGSTAmount as TotalSGSTAMT, 
	purm.IGSTAmount as TotalIGSTAMT, TotalAmount as TotalNetAMT,TradeDiscountAmount, CashDiscountAmount, FreighCharges, LabourCharges, purm.NetAmount, PaymentMode
	from PurchaseReturnDetail purd
	inner join ProductMaster pm on purd.ProductID = pm.PRODUCTID 
	inner join PurchaseReturnMaster purm on purd.PurchaseReturnID = purm.PurchaseReturnID
	inner join SupplierMaster sup on sup.SUPPLIERID = purm.SupplierID
	where purm.SupplierID =(case when @SupplierID = 0 then
								purm.SupplierID else @SupplierID end) and 
		  InvoiceNo = (case when @InvoiceNo = 0 then
								InvoiceNo else @InvoiceNo end)
								 and
	PurchaseDate between @StartDate and @EndDate

END

GO
/****** Object:  StoredProcedure [dbo].[RPTSalesReportByParameter]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RPTSalesReportByParameter]

@InvoiceNo numeric(18,0),
@StartDate date,
@EndDate date
AS
BEGIN
	select SalesDetailID, sd.SalesID,pm.PRODUCTNAME ,sd.ProductID, Rate, Qty, HSNCode, Total, DiscountPercentage, DiscountAmount,
	sd.TaxableAmount, CGSTPercentage, sd.CGSTAmount, SGSTPercentage, sd.SGSTAmount, IGSTPercentage, sd.IGSTAmount, sd.NetAmount,

	SalesDate, InvoiceNo, TotalGrossAmount, TotalDiscountAmount, sm.TaxableAmount as TotalTaxableAMT, sm.CGSTAmount TotalCGSTAMT, sm.SGSTAmount as TotalSGSTAMT, 
	sm.IGSTAmount as TotalIGSTAMT, TotalAmount, sm.NetAmount as TotalNetAMT,[MobileNo],[CustomerName],[Address], PaymentMode
	from SalesDetail sd
	inner join ProductMaster pm on sd.ProductID = pm.PRODUCTID 
	inner join SalesMaster sm on sd.SalesID = sm.SalesID
		where  sm.InvoiceNo = (case when @InvoiceNo = 0 then
								InvoiceNo else @InvoiceNo end)
								 and
	SalesDate between @StartDate and @EndDate

END
GO
/****** Object:  StoredProcedure [dbo].[RPTSalesReturnReportByParameter]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[RPTSalesReturnReportByParameter]

@InvoiceNo numeric(18,0),
@StartDate date,
@EndDate date
AS
BEGIN
	select SalesReturnDetailID, sd.SalesReturnID,pm.PRODUCTNAME ,sd.ProductID, Rate, Qty, HSNCode, Total, DiscountPercentage, DiscountAmount,
	sd.TaxableAmount, CGSTPercentage, sd.CGSTAmount, SGSTPercentage, sd.SGSTAmount, IGSTPercentage, sd.IGSTAmount, sd.NetAmount,

	SalesReturnDate, InvoiceNo, TotalGrossAmount, TotalDiscountAmount, sm.TaxableAmount as TotalTaxableAMT, sm.CGSTAmount TotalCGSTAMT, sm.SGSTAmount as TotalSGSTAMT, 
	sm.IGSTAmount as TotalIGSTAMT, TotalAmount, sm.NetAmount as TotalNetAMT,[MobileNo],[CustomerName],[Address], PaymentMode
	from SalesReturnDetail sd
	inner join ProductMaster pm on sd.ProductID = pm.PRODUCTID 
	inner join SalesReturnMaster sm on sd.SalesReturnID = sm.SalesReturnID
		where  sm.InvoiceNo = (case when @InvoiceNo = 0 then
								InvoiceNo else @InvoiceNo end)
								 and
	SalesReturnDate between @StartDate and @EndDate

END
GO
/****** Object:  StoredProcedure [dbo].[RPTSubCategoryByParameter]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RPTSubCategoryByParameter]
@CategoryID int
AS
BEGIN
	select SUBCATEGORYID,scm.CATEGORYID,cm.CATEGORYNAME,SUBCATEGORYNAME from SubCategoryMaster scm
	inner join CategoryMaster cm on scm.CATEGORYID = cm.CATEGORYID
	where scm.CATEGORYID = (case when @CategoryID = 0 then
									scm.CATEGORYID
									else @CategoryID end)
	
	

END

GO
/****** Object:  StoredProcedure [dbo].[RPTSubcategpryByCategory]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- RPTSubcategpryByCategory 2
-- =============================================
CREATE PROCEDURE [dbo].[RPTSubcategpryByCategory]
@CATEGORYID INT
AS
BEGIN
	SELECT 
		SUBCATEGORYID,
		SM.CATEGORYID,
		CATEGORYNAME,
		SUBCATEGORYNAME
	FROM SubCategoryMaster SM
	INNER JOIN CategoryMaster Cm ON CM.CATEGORYID=SM.CATEGORYID

	WHERE
		--SM.CATEGORYID=@CATEGORYID
		SM.CATEGORYID=(CASE WHEN @CATEGORYID=0 THEN SM.CATEGORYID ELSE @CATEGORYID END)
END

GO
/****** Object:  StoredProcedure [dbo].[RPTSupplierMasterList]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RPTSupplierMasterList]

AS
BEGIN
	Select SUPPLIERID,SUPPLIERNAME,ADDRESS,EMAILID,MOBILENO,CONTACTPERSON from SupplierMaster
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateCategoryDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateCategoryDetails]
@CATEGORYID int,
@CATEGORYNAME varchar(50)
AS
BEGIN
	UPDATE CategoryMaster SET  CATEGORYNAME = @CATEGORYNAME WHERE CATEGORYID = @CATEGORYID
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateProductDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateProductDetails]
@PRODUCTDETAILID INT,
@PRODUCTID int,
@QTY decimal(18,2),
@UNIT varchar(50),
@PURCHASERATE decimal(18,2), 
@SALESRATE decimal(18,2), 
@CGSTPERCENTAGE decimal(18,2), 
@CGSTAMOUNT decimal(18,2), 
@SGSTPERCENTAGE decimal(18,2), 
@SGSTAMOUNT decimal(18,2), 
@IGSTPERCENTAGE decimal(18,2), 
@IGSTAMOUNT decimal(18,2), 
@BASICRATE decimal(18,2), 
@MRP decimal(18,2)
AS
BEGIN
	UPDATE ProductDetails SET PRODUCTID = @PRODUCTID, QTY = @QTY, UNIT = @UNIT, PURCHASERATE = @PURCHASERATE, SALESRATE = @SALESRATE, CGSTPERCENTAGE = @CGSTPERCENTAGE,
	 CGSTAMOUNT = @CGSTAMOUNT, SGSTPERCENTAGE = @SGSTPERCENTAGE, SGSTAMOUNT = @SGSTAMOUNT, IGSTPERCENTAGE = @IGSTPERCENTAGE, IGSTAMOUNT = @IGSTAMOUNT, BASICRATE = @BASICRATE, MRP = @MRP WHERE PRODUCTDETAILID =  @PRODUCTDETAILID
END

GO
/****** Object:  StoredProcedure [dbo].[UpdatePurchaseDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdatePurchaseDetails]
@PurchasedetailID int,
@PurchaseID int,
@ProductID int,
@IsExpire bit,
@ExpireDate date,
@Rate decimal(18,2),
@Qty decimal(18,2),
@HSNCode numeric(18,0),
@Total decimal(18,2),
@DiscountPercentage decimal(18,2),
@DiscountAmount decimal(18,2),
@TaxableAmount decimal(18,2),
@CGSTPercentage decimal(18,2),
@CGSTAmount decimal(18,2),
@SGSTPercentage decimal(18,2),
@SGSTAmount decimal(18,2),
@IGSTPercentage decimal(18,2),
@IGSTAmount decimal(18,2),
@NetAmount decimal(18,2)
AS
BEGIN
	update PurchaseDetail set PurchaseID = @PurchaseID , ProductID = @ProductID , IsExpire = @IsExpire, [ExpireDate] = @ExpireDate, Rate = @Rate, Qty = @Qty, HSNCode = @HSNCode,
	 Total = @Total, DiscountPercentage = @DiscountPercentage, DiscountAmount = @DiscountAmount, TaxableAmount = @TaxableAmount, CGSTPercentage = @CGSTPercentage, CGSTAmount = @CGSTAmount,
	  SGSTPercentage = @SGSTPercentage, SGSTAmount = @SGSTAmount, IGSTPercentage = @IGSTPercentage, IGSTAmount = @IGSTAmount, NetAmount = @NetAmount where PurchasedetailID = @PurchasedetailID
END

GO
/****** Object:  StoredProcedure [dbo].[UpdatePurchaseMasterTable]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdatePurchaseMasterTable]
@PurchaseID int,
@TotalGrossAmount decimal(18,2),
@TotalDiscountAmount decimal(18,2),
@TotalTaxableAmount decimal(18, 2),
@CGSTAmount decimal(18,2),
@SGSTAmount decimal(18,2),
@IGSTAmount decimal(18,2),
@TotalNetAmount decimal(18,2),
@TradeDiscountAmount decimal(18,2),
@CashDiscountAmount decimal(18,2),
@FreighCharges decimal(18,2),
@LabourCharges decimal(18,2),
@NetAmount decimal(18,2),
@PaymentMode varchar(50),
@Remark varchar(50)

AS
BEGIN
	Update PurchaseMaster set TotalGrossAmount = @TotalGrossAmount ,TotalDiscountAmount = @TotalDiscountAmount,TaxableAmount = @TotalTaxableAmount,  CGSTAmount = @CGSTAmount , SGSTAmount = @SGSTAmount , IGSTAmount = @IGSTAmount 
	, TotalAmount = @TotalNetAmount , TradeDiscountAmount = @TradeDiscountAmount , CashDiscountAmount = @CashDiscountAmount, FreighCharges = @FreighCharges, LabourCharges = @LabourCharges,
	NetAmount = @NetAmount, PaymentMode = @PaymentMode, Remark = @Remark where PurchaseID = @PurchaseID
END

GO
/****** Object:  StoredProcedure [dbo].[UpdatePurchaseReturnDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdatePurchaseReturnDetails]
@PurchaseReturnDetailID int,
@PurchaseReturnID int,
@ProductID int,
@IsExpire bit,
@ExpireDate date,
@Rate decimal(18,2),
@Qty decimal(18,2),
@HSNCode numeric(18,0),
@Total decimal(18,2),
@DiscountPercentage decimal(18,2),
@DiscountAmount decimal(18,2),
@TaxableAmount decimal(18,2),
@CGSTPercentage decimal(18,2),
@CGSTAmount decimal(18,2),
@SGSTPercentage decimal(18,2),
@SGSTAmount decimal(18,2),
@IGSTPercentage decimal(18,2),
@IGSTAmount decimal(18,2),
@NetAmount decimal(18,2)
AS
BEGIN
	update PurchaseReturnDetail set PurchaseReturnID = @PurchaseReturnID , ProductID = @ProductID , IsExpire = @IsExpire, [ExpireDate] = @ExpireDate, Rate = @Rate, Qty = @Qty, HSNCode = @HSNCode,
	 Total = @Total, DiscountPercentage = @DiscountPercentage, DiscountAmount = @DiscountAmount, TaxableAmount = @TaxableAmount, CGSTPercentage = @CGSTPercentage, CGSTAmount = @CGSTAmount,
	  SGSTPercentage = @SGSTPercentage, SGSTAmount = @SGSTAmount, IGSTPercentage = @IGSTPercentage, IGSTAmount = @IGSTAmount, NetAmount = @NetAmount where PurchaseReturnDetailID = @PurchaseReturnDetailID
END

GO
/****** Object:  StoredProcedure [dbo].[UpdatePurchaseReturnMasterTable]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[UpdatePurchaseReturnMasterTable]
@PurchaseReturnID int,
@TotalGrossAmount decimal(18,2),
@TotalDiscountAmount decimal(18,2),
@CGSTAmount decimal(18,2),
@SGSTAmount decimal(18,2),
@IGSTAmount decimal(18,2),
@TotalNetAmount decimal(18,2),
@TradeDiscountAmount decimal(18,2),
@CashDiscountAmount decimal(18,2),
@FreighCharges decimal(18,2),
@LabourCharges decimal(18,2),
@NetAmount decimal(18,2),
@PaymentMode varchar(50),
@Remark varchar(50)

AS
BEGIN
	Update PurchaseReturnMaster set TotalGrossAmount = @TotalGrossAmount ,TotalDiscountAmount = @TotalDiscountAmount, CGSTAmount = @CGSTAmount , SGSTAmount = @SGSTAmount , IGSTAmount = @IGSTAmount 
	, TotalAmount = @TotalNetAmount , TradeDiscountAmount = @TradeDiscountAmount , CashDiscountAmount = @CashDiscountAmount, FreighCharges = @FreighCharges, LabourCharges = @LabourCharges,
	NetAmount = @NetAmount, PaymentMode = @PaymentMode, Remark = @Remark where PurchaseReturnID = @PurchaseReturnID
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateSalesDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateSalesDetails]
@SalesDetailID int,
@SalesID int,
@ProductID int,
@Rate decimal(18,2),
@Qty decimal(18,2),
@HSNCode numeric(18,0),
@Total decimal(18,2),
@DiscountPercentage decimal(18,2),
@DiscountAmount decimal(18,2),
@TaxableAmount decimal(18,2),
@CGSTPercentage decimal(18,2),
@CGSTAmount decimal(18,2),
@SGSTPercentage decimal(18,2),
@SGSTAmount decimal(18,2),
@IGSTPercentage decimal(18,2),
@IGSTAmount decimal(18,2),
@NetAmount decimal(18,2)
AS
BEGIN
	update SalesDetail set SalesID = @SalesID , ProductID = @ProductID , Rate = @Rate, Qty = @Qty, HSNCode = @HSNCode,
	 Total = @Total, DiscountPercentage = @DiscountPercentage, DiscountAmount = @DiscountAmount, TaxableAmount = @TaxableAmount, CGSTPercentage = @CGSTPercentage, CGSTAmount = @CGSTAmount,
	  SGSTPercentage = @SGSTPercentage, SGSTAmount = @SGSTAmount, IGSTPercentage = @IGSTPercentage, IGSTAmount = @IGSTAmount, NetAmount = @NetAmount where SalesDetailID = @SalesDetailID
END


GO
/****** Object:  StoredProcedure [dbo].[UpdateSalesMasterTable]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateSalesMasterTable]
@SalesID int,
@TotalGrossAmount decimal(18,2),
@TotalDiscountAmount decimal(18,2),
@TotalTaxableAmount decimal(18, 2),
@CGSTAmount decimal(18,2),
@SGSTAmount decimal(18,2),
@IGSTAmount decimal(18,2),
@TotalNetAmount decimal(18,2),
@MobileNo numeric(18,0),
@CustomerName varchar(50),
@Address varchar(500), 
@PaymentMode varchar(50),
@Remark varchar(50)

AS
BEGIN
	Update SalesMaster set TotalGrossAmount = @TotalGrossAmount ,TotalDiscountAmount = @TotalDiscountAmount,TaxableAmount = @TotalTaxableAmount, 
	 CGSTAmount = @CGSTAmount , SGSTAmount = @SGSTAmount , IGSTAmount = @IGSTAmount ,NetAmount = @TotalNetAmount,MobileNo = @MobileNo,CustomerName = @CustomerName,
	  [Address] = @Address , PaymentMode = @PaymentMode, Remark = @Remark where SalesID = @SalesID
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateSalesReturnDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateSalesReturnDetails]
@SalesReturnDetailID int,
@SalesReturnID int,
@ProductID int,
@Rate decimal(18,2),
@Qty decimal(18,2),
@HSNCode numeric(18,0),
@Total decimal(18,2),
@DiscountPercentage decimal(18,2),
@DiscountAmount decimal(18,2),
@TaxableAmount decimal(18,2),
@CGSTPercentage decimal(18,2),
@CGSTAmount decimal(18,2),
@SGSTPercentage decimal(18,2),
@SGSTAmount decimal(18,2),
@IGSTPercentage decimal(18,2),
@IGSTAmount decimal(18,2),
@NetAmount decimal(18,2)
AS
BEGIN
	update SalesReturnDetail set SalesReturnID = @SalesReturnID , ProductID = @ProductID , Rate = @Rate, Qty = @Qty, HSNCode = @HSNCode,
	 Total = @Total, DiscountPercentage = @DiscountPercentage, DiscountAmount = @DiscountAmount, TaxableAmount = @TaxableAmount, CGSTPercentage = @CGSTPercentage, CGSTAmount = @CGSTAmount,
	  SGSTPercentage = @SGSTPercentage, SGSTAmount = @SGSTAmount, IGSTPercentage = @IGSTPercentage, IGSTAmount = @IGSTAmount, NetAmount = @NetAmount where SalesReturnDetailID = @SalesReturnDetailID
END


GO
/****** Object:  StoredProcedure [dbo].[UpdateSalesReturnMasterTable]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateSalesReturnMasterTable]
@SalesReturnID int,
@TotalGrossAmount decimal(18,2),
@TotalDiscountAmount decimal(18,2),
@TotalTaxableAmount decimal(18, 2),
@CGSTAmount decimal(18,2),
@SGSTAmount decimal(18,2),
@IGSTAmount decimal(18,2),
@TotalNetAmount decimal(18,2),
@MobileNo numeric(18,0),
@CustomerName varchar(50),
@Address varchar(500), 
@PaymentMode varchar(50),
@Remark varchar(50)

AS
BEGIN
	Update SalesReturnMaster set TotalGrossAmount = @TotalGrossAmount ,TotalDiscountAmount = @TotalDiscountAmount,TaxableAmount = @TotalTaxableAmount, 
	 CGSTAmount = @CGSTAmount , SGSTAmount = @SGSTAmount , IGSTAmount = @IGSTAmount ,NetAmount = @TotalNetAmount,MobileNo = @MobileNo,CustomerName = @CustomerName,
	  [Address] = @Address , PaymentMode = @PaymentMode, Remark = @Remark where SalesReturnID = @SalesReturnID
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateSubCategoryDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[UpdateSubCategoryDetails]
@SUBCATEGORYID int,
@CATEGORYID int,
@SUBCATEGORYNAME varchar(50)
AS
BEGIN
	UPDATE SubCategoryMaster SET  CATEGORYID = @CATEGORYID , SUBCATEGORYNAME = @SUBCATEGORYNAME WHERE  SUBCATEGORYID = @SUBCATEGORYID
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateSupplierMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateSupplierMaster]
@SUPPLIERID int,
@SUPPLIERNAME varchar(50),
@ADDRESS varchar(500),
@EMAILID varchar(50),
@MOBILENO numeric(18,0),
@CONTACTPERSON varchar(50),
@REMARK varchar(500)
AS
BEGIN
	UPDATE SupplierMaster SET SUPPLIERNAME = @SUPPLIERNAME, [ADDRESS] = @ADDRESS, EMAILID = @EMAILID, MOBILENO = @MOBILENO, CONTACTPERSON = @CONTACTPERSON, REMARK = @REMARK WHERE SUPPLIERID = @SUPPLIERID
END

GO
/****** Object:  Table [dbo].[CategoryMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CategoryMaster](
	[CATEGORYID] [int] IDENTITY(1,1) NOT NULL,
	[CATEGORYNAME] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FinancialYearMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FinancialYearMaster](
	[YEARID] [int] IDENTITY(1,1) NOT NULL,
	[STARTDATE] [date] NULL,
	[ENDDATE] [date] NULL,
	[FINANCIALYEAR] [varchar](10) NULL,
	[ISCURRENT] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoginDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoginDetails](
	[LOGINID] [int] IDENTITY(1,1) NOT NULL,
	[USERNAME] [varchar](50) NULL,
	[PASSWORD] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductDetails]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductDetails](
	[PRODUCTDETAILID] [int] IDENTITY(1,1) NOT NULL,
	[PRODUCTID] [int] NOT NULL,
	[QTY] [decimal](18, 2) NOT NULL,
	[UNIT] [varchar](50) NULL,
	[PURCHASERATE] [decimal](18, 2) NOT NULL,
	[SALESRATE] [decimal](18, 2) NOT NULL,
	[CGSTPERCENTAGE] [decimal](18, 2) NULL,
	[CGSTAMOUNT] [decimal](18, 2) NULL,
	[SGSTPERCENTAGE] [decimal](18, 2) NULL,
	[SGSTAMOUNT] [decimal](18, 2) NULL,
	[IGSTPERCENTAGE] [decimal](18, 2) NULL,
	[IGSTAMOUNT] [decimal](18, 2) NULL,
	[BASICRATE] [decimal](18, 2) NULL,
	[MRP] [decimal](18, 2) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductMaster](
	[PRODUCTID] [int] IDENTITY(1,1) NOT NULL,
	[PRODUCTNAME] [varchar](50) NULL,
	[SUBCATEGORYID] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PurchaseDetail]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseDetail](
	[PurchasedetailID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[IsExpire] [bit] NOT NULL,
	[ExpireDate] [date] NULL,
	[Rate] [decimal](18, 2) NULL,
	[Qty] [decimal](18, 2) NULL,
	[HSNCode] [numeric](18, 0) NULL,
	[Total] [decimal](18, 2) NULL,
	[DiscountPercentage] [decimal](18, 2) NULL,
	[DiscountAmount] [decimal](18, 2) NULL,
	[TaxableAmount] [decimal](18, 2) NULL,
	[CGSTPercentage] [decimal](18, 2) NULL,
	[CGSTAmount] [decimal](18, 2) NULL,
	[SGSTPercentage] [decimal](18, 2) NULL,
	[SGSTAmount] [decimal](18, 2) NULL,
	[IGSTPercentage] [decimal](18, 2) NULL,
	[IGSTAmount] [decimal](18, 2) NULL,
	[NetAmount] [decimal](18, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PurchaseMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PurchaseMaster](
	[PurchaseID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseDate] [date] NULL,
	[SupplierID] [int] NOT NULL,
	[InvoiceNo] [numeric](18, 0) NULL,
	[TotalGrossAmount] [decimal](18, 2) NULL,
	[TotalDiscountAmount] [decimal](18, 2) NULL,
	[TaxableAmount] [decimal](18, 2) NULL,
	[CGSTAmount] [decimal](18, 2) NULL,
	[SGSTAmount] [decimal](18, 2) NULL,
	[IGSTAmount] [decimal](18, 2) NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[TradeDiscountAmount] [decimal](18, 2) NULL,
	[CashDiscountAmount] [decimal](18, 2) NULL,
	[FreighCharges] [decimal](18, 2) NULL,
	[LabourCharges] [decimal](18, 2) NULL,
	[NetAmount] [decimal](18, 2) NULL,
	[PaymentMode] [varchar](50) NULL,
	[Remark] [varchar](500) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PurchaseReturnDetail]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseReturnDetail](
	[PurchaseReturnDetailID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseReturnID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[IsExpire] [bit] NULL,
	[ExpireDate] [date] NULL,
	[Rate] [decimal](18, 2) NULL,
	[Qty] [decimal](18, 2) NULL,
	[HSNCode] [numeric](18, 0) NULL,
	[Total] [decimal](18, 2) NULL,
	[DiscountPercentage] [decimal](18, 2) NULL,
	[DiscountAmount] [decimal](18, 2) NULL,
	[TaxableAmount] [decimal](18, 2) NULL,
	[CGSTPercentage] [decimal](18, 2) NULL,
	[CGSTAmount] [decimal](18, 2) NULL,
	[SGSTPercentage] [decimal](18, 2) NULL,
	[SGSTAmount] [decimal](18, 2) NULL,
	[IGSTPercentage] [decimal](18, 2) NULL,
	[IGSTAmount] [decimal](18, 2) NULL,
	[NetAmount] [decimal](18, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PurchaseReturnMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PurchaseReturnMaster](
	[PurchaseReturnID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseDate] [date] NULL,
	[SupplierID] [int] NOT NULL,
	[InvoiceNo] [numeric](18, 0) NULL,
	[TotalGrossAmount] [decimal](18, 2) NULL,
	[TotalDiscountAmount] [decimal](18, 2) NULL,
	[TaxableAmount] [decimal](18, 2) NULL,
	[CGSTAmount] [decimal](18, 2) NULL,
	[SGSTAmount] [decimal](18, 2) NULL,
	[IGSTAmount] [decimal](18, 2) NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[TradeDiscountAmount] [decimal](18, 2) NULL,
	[CashDiscountAmount] [decimal](18, 2) NULL,
	[FreighCharges] [decimal](18, 2) NULL,
	[LabourCharges] [decimal](18, 2) NULL,
	[NetAmount] [decimal](18, 2) NULL,
	[PaymentMode] [varchar](50) NULL,
	[Remark] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesDetail]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesDetail](
	[SalesDetailID] [int] IDENTITY(1,1) NOT NULL,
	[SalesID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Rate] [decimal](18, 2) NULL,
	[Qty] [decimal](18, 2) NULL,
	[HSNCode] [numeric](18, 0) NULL,
	[Total] [decimal](18, 2) NULL,
	[DiscountPercentage] [decimal](18, 2) NULL,
	[DiscountAmount] [decimal](18, 2) NULL,
	[TaxableAmount] [decimal](18, 2) NULL,
	[CGSTPercentage] [decimal](18, 2) NULL,
	[CGSTAmount] [decimal](18, 2) NULL,
	[SGSTPercentage] [decimal](18, 2) NULL,
	[SGSTAmount] [decimal](18, 2) NULL,
	[IGSTPercentage] [decimal](18, 2) NULL,
	[IGSTAmount] [decimal](18, 2) NULL,
	[NetAmount] [decimal](18, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SalesMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesMaster](
	[SalesID] [int] IDENTITY(1,1) NOT NULL,
	[SalesDate] [date] NULL,
	[InvoiceNo] [numeric](18, 0) NOT NULL,
	[TotalGrossAmount] [decimal](18, 2) NULL,
	[TotalDiscountAmount] [decimal](18, 2) NULL,
	[TaxableAmount] [decimal](18, 2) NULL,
	[CGSTAmount] [decimal](18, 2) NULL,
	[SGSTAmount] [decimal](18, 2) NULL,
	[IGSTAmount] [decimal](18, 2) NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[NetAmount] [decimal](18, 2) NULL,
	[MobileNo] [numeric](18, 0) NULL,
	[CustomerName] [varchar](50) NULL,
	[Address] [varchar](500) NULL,
	[PaymentMode] [varchar](50) NULL,
	[Remark] [varchar](500) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesReturnDetail]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesReturnDetail](
	[SalesReturnDetailID] [int] IDENTITY(1,1) NOT NULL,
	[SalesReturnID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Rate] [decimal](18, 2) NULL,
	[Qty] [decimal](18, 2) NULL,
	[HSNCode] [numeric](18, 0) NULL,
	[Total] [decimal](18, 2) NULL,
	[DiscountPercentage] [decimal](18, 2) NULL,
	[DiscountAmount] [decimal](18, 2) NULL,
	[TaxableAmount] [decimal](18, 2) NULL,
	[CGSTPercentage] [decimal](18, 2) NULL,
	[CGSTAmount] [decimal](18, 2) NULL,
	[SGSTPercentage] [decimal](18, 2) NULL,
	[SGSTAmount] [decimal](18, 2) NULL,
	[IGSTPercentage] [decimal](18, 2) NULL,
	[IGSTAmount] [decimal](18, 2) NULL,
	[NetAmount] [decimal](18, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SalesReturnMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesReturnMaster](
	[SalesReturnID] [int] IDENTITY(1,1) NOT NULL,
	[SalesReturnDate] [date] NULL,
	[InvoiceNo] [numeric](18, 0) NULL,
	[TotalGrossAmount] [decimal](18, 2) NULL,
	[TotalDiscountAmount] [decimal](18, 2) NULL,
	[TaxableAmount] [decimal](18, 2) NULL,
	[CGSTAmount] [decimal](18, 2) NULL,
	[SGSTAmount] [decimal](18, 2) NULL,
	[IGSTAmount] [decimal](18, 2) NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[NetAmount] [decimal](18, 2) NULL,
	[MobileNo] [numeric](18, 0) NULL,
	[CustomerName] [varchar](50) NULL,
	[Address] [varchar](500) NULL,
	[PaymentMode] [varchar](50) NULL,
	[Remark] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SubCategoryMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SubCategoryMaster](
	[SUBCATEGORYID] [int] IDENTITY(1,1) NOT NULL,
	[SUBCATEGORYNAME] [varchar](50) NULL,
	[CATEGORYID] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SupplierMaster]    Script Date: 05-24-2023 17:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SupplierMaster](
	[SUPPLIERID] [int] IDENTITY(1,1) NOT NULL,
	[SUPPLIERNAME] [varchar](50) NULL,
	[ADDRESS] [varchar](500) NULL,
	[EMAILID] [varchar](50) NULL,
	[MOBILENO] [numeric](18, 0) NULL,
	[CONTACTPERSON] [varchar](50) NULL,
	[REMARK] [varchar](500) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CategoryMaster] ON 

GO
INSERT [dbo].[CategoryMaster] ([CATEGORYID], [CATEGORYNAME]) VALUES (1, N'Software')
GO
INSERT [dbo].[CategoryMaster] ([CATEGORYID], [CATEGORYNAME]) VALUES (2, N'Hardware')
GO
INSERT [dbo].[CategoryMaster] ([CATEGORYID], [CATEGORYNAME]) VALUES (4, N'Network')
GO
INSERT [dbo].[CategoryMaster] ([CATEGORYID], [CATEGORYNAME]) VALUES (5, N'Database')
GO
INSERT [dbo].[CategoryMaster] ([CATEGORYID], [CATEGORYNAME]) VALUES (7, N'Jewellery')
GO
INSERT [dbo].[CategoryMaster] ([CATEGORYID], [CATEGORYNAME]) VALUES (8, N'sfhfh')
GO
SET IDENTITY_INSERT [dbo].[CategoryMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[FinancialYearMaster] ON 

GO
INSERT [dbo].[FinancialYearMaster] ([YEARID], [STARTDATE], [ENDDATE], [FINANCIALYEAR], [ISCURRENT]) VALUES (4, CAST(0x00440B00 AS Date), CAST(0x31450B00 AS Date), N'2022-2023', 1)
GO
SET IDENTITY_INSERT [dbo].[FinancialYearMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[LoginDetails] ON 

GO
INSERT [dbo].[LoginDetails] ([LOGINID], [USERNAME], [PASSWORD]) VALUES (1, N'Souvik', N'123456')
GO
SET IDENTITY_INSERT [dbo].[LoginDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductDetails] ON 

GO
INSERT [dbo].[ProductDetails] ([PRODUCTDETAILID], [PRODUCTID], [QTY], [UNIT], [PURCHASERATE], [SALESRATE], [CGSTPERCENTAGE], [CGSTAMOUNT], [SGSTPERCENTAGE], [SGSTAMOUNT], [IGSTPERCENTAGE], [IGSTAMOUNT], [BASICRATE], [MRP]) VALUES (1, 2, CAST(5.00 AS Decimal(18, 2)), N'--Select Unit --', CAST(55000.00 AS Decimal(18, 2)), CAST(65000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(1300.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(1300.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(327600.00 AS Decimal(18, 2)), CAST(67000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[ProductDetails] ([PRODUCTDETAILID], [PRODUCTID], [QTY], [UNIT], [PURCHASERATE], [SALESRATE], [CGSTPERCENTAGE], [CGSTAMOUNT], [SGSTPERCENTAGE], [SGSTAMOUNT], [IGSTPERCENTAGE], [IGSTAMOUNT], [BASICRATE], [MRP]) VALUES (2, 2, CAST(15.00 AS Decimal(18, 2)), N'--Select Unit --', CAST(56000.00 AS Decimal(18, 2)), CAST(60000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(902400.00 AS Decimal(18, 2)), CAST(65000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[ProductDetails] ([PRODUCTDETAILID], [PRODUCTID], [QTY], [UNIT], [PURCHASERATE], [SALESRATE], [CGSTPERCENTAGE], [CGSTAMOUNT], [SGSTPERCENTAGE], [SGSTAMOUNT], [IGSTPERCENTAGE], [IGSTAMOUNT], [BASICRATE], [MRP]) VALUES (3, 3, CAST(15.00 AS Decimal(18, 2)), N'--Select Unit --', CAST(6161.00 AS Decimal(18, 2)), CAST(63000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(1260.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(1260.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(947520.00 AS Decimal(18, 2)), CAST(68000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[ProductDetails] ([PRODUCTDETAILID], [PRODUCTID], [QTY], [UNIT], [PURCHASERATE], [SALESRATE], [CGSTPERCENTAGE], [CGSTAMOUNT], [SGSTPERCENTAGE], [SGSTAMOUNT], [IGSTPERCENTAGE], [IGSTAMOUNT], [BASICRATE], [MRP]) VALUES (4, 5, CAST(15.00 AS Decimal(18, 2)), N'--Select Unit --', CAST(65500.00 AS Decimal(18, 2)), CAST(68200.00 AS Decimal(18, 2)), CAST(0.18 AS Decimal(18, 2)), CAST(122.76 AS Decimal(18, 2)), CAST(0.50 AS Decimal(18, 2)), CAST(341.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(1023463.76 AS Decimal(18, 2)), CAST(70500.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[ProductDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductMaster] ON 

GO
INSERT [dbo].[ProductMaster] ([PRODUCTID], [PRODUCTNAME], [SUBCATEGORYID]) VALUES (1, N'HP Laptop', 9)
GO
INSERT [dbo].[ProductMaster] ([PRODUCTID], [PRODUCTNAME], [SUBCATEGORYID]) VALUES (2, N'HP Laptop', 8)
GO
INSERT [dbo].[ProductMaster] ([PRODUCTID], [PRODUCTNAME], [SUBCATEGORYID]) VALUES (3, N'Dell Laptop', 9)
GO
INSERT [dbo].[ProductMaster] ([PRODUCTID], [PRODUCTNAME], [SUBCATEGORYID]) VALUES (5, N'Acer Predator', 7)
GO
SET IDENTITY_INSERT [dbo].[ProductMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[PurchaseDetail] ON 

GO
INSERT [dbo].[PurchaseDetail] ([PurchasedetailID], [PurchaseID], [ProductID], [IsExpire], [ExpireDate], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (1, 1, 2, 0, CAST(0x19440B00 AS Date), CAST(65000.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(1616 AS Numeric(18, 0)), CAST(325000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(6500.00 AS Decimal(18, 2)), CAST(318500.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(6370.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(6370.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(331240.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[PurchaseDetail] ([PurchasedetailID], [PurchaseID], [ProductID], [IsExpire], [ExpireDate], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (2, 2, 1, 0, CAST(0x19440B00 AS Date), CAST(5600.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(56161 AS Numeric(18, 0)), CAST(28000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(560.00 AS Decimal(18, 2)), CAST(27440.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(548.80 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(548.80 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(28537.60 AS Decimal(18, 2)))
GO
INSERT [dbo].[PurchaseDetail] ([PurchasedetailID], [PurchaseID], [ProductID], [IsExpire], [ExpireDate], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (3, 2, 3, 0, CAST(0x19440B00 AS Date), CAST(6200.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), CAST(1615 AS Numeric(18, 0)), CAST(93000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(1860.00 AS Decimal(18, 2)), CAST(91140.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(1822.80 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(1822.80 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(94785.60 AS Decimal(18, 2)))
GO
INSERT [dbo].[PurchaseDetail] ([PurchasedetailID], [PurchaseID], [ProductID], [IsExpire], [ExpireDate], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (4, 3, 1, 0, CAST(0x19440B00 AS Date), CAST(65000.00 AS Decimal(18, 2)), CAST(6.00 AS Decimal(18, 2)), CAST(5161 AS Numeric(18, 0)), CAST(390000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(7800.00 AS Decimal(18, 2)), CAST(382200.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(7644.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(7644.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(397488.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[PurchaseDetail] ([PurchasedetailID], [PurchaseID], [ProductID], [IsExpire], [ExpireDate], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (5, 4, 1, 0, CAST(0x1E440B00 AS Date), CAST(56000.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(566 AS Numeric(18, 0)), CAST(280000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(5600.00 AS Decimal(18, 2)), CAST(274400.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(5488.00 AS Decimal(18, 2)), CAST(279888.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[PurchaseDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[PurchaseMaster] ON 

GO
INSERT [dbo].[PurchaseMaster] ([PurchaseID], [PurchaseDate], [SupplierID], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [TradeDiscountAmount], [CashDiscountAmount], [FreighCharges], [LabourCharges], [NetAmount], [PaymentMode], [Remark]) VALUES (1, CAST(0x02440B00 AS Date), 2, CAST(1616 AS Numeric(18, 0)), CAST(325000.00 AS Decimal(18, 2)), CAST(6500.00 AS Decimal(18, 2)), CAST(318500.00 AS Decimal(18, 2)), CAST(6370.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(331240.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(523.00 AS Decimal(18, 2)), CAST(523.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'NEFT', N'Nothing to Write')
GO
INSERT [dbo].[PurchaseMaster] ([PurchaseID], [PurchaseDate], [SupplierID], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [TradeDiscountAmount], [CashDiscountAmount], [FreighCharges], [LabourCharges], [NetAmount], [PaymentMode], [Remark]) VALUES (2, CAST(0x02440B00 AS Date), 2, CAST(5161 AS Numeric(18, 0)), CAST(121000.00 AS Decimal(18, 2)), CAST(2420.00 AS Decimal(18, 2)), CAST(118580.00 AS Decimal(18, 2)), CAST(2371.60 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(123323.20 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(561.00 AS Decimal(18, 2)), CAST(235.00 AS Decimal(18, 2)), CAST(123.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'NEFT', N'saih hihai i')
GO
INSERT [dbo].[PurchaseMaster] ([PurchaseID], [PurchaseDate], [SupplierID], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [TradeDiscountAmount], [CashDiscountAmount], [FreighCharges], [LabourCharges], [NetAmount], [PaymentMode], [Remark]) VALUES (3, CAST(0x03440B00 AS Date), 2, CAST(516 AS Numeric(18, 0)), CAST(390000.00 AS Decimal(18, 2)), CAST(7800.00 AS Decimal(18, 2)), CAST(382200.00 AS Decimal(18, 2)), CAST(7644.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(397488.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(18, 2)), CAST(223.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'NEFT', N'c sdb ksbsss')
GO
INSERT [dbo].[PurchaseMaster] ([PurchaseID], [PurchaseDate], [SupplierID], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [TradeDiscountAmount], [CashDiscountAmount], [FreighCharges], [LabourCharges], [NetAmount], [PaymentMode], [Remark]) VALUES (4, CAST(0x02440B00 AS Date), 2, CAST(562 AS Numeric(18, 0)), CAST(280000.00 AS Decimal(18, 2)), CAST(5600.00 AS Decimal(18, 2)), CAST(274400.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(279888.00 AS Decimal(18, 2)), CAST(562.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'RTGS', N'vsv')
GO
INSERT [dbo].[PurchaseMaster] ([PurchaseID], [PurchaseDate], [SupplierID], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [TradeDiscountAmount], [CashDiscountAmount], [FreighCharges], [LabourCharges], [NetAmount], [PaymentMode], [Remark]) VALUES (5, CAST(0x21440B00 AS Date), 2, CAST(131 AS Numeric(18, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[PurchaseMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[PurchaseReturnDetail] ON 

GO
INSERT [dbo].[PurchaseReturnDetail] ([PurchaseReturnDetailID], [PurchaseReturnID], [ProductID], [IsExpire], [ExpireDate], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (1, 1, 1, 0, CAST(0x1F440B00 AS Date), CAST(6892.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(485 AS Numeric(18, 0)), CAST(34460.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(689.20 AS Decimal(18, 2)), CAST(33770.80 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(675.42 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(675.42 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(35121.63 AS Decimal(18, 2)))
GO
INSERT [dbo].[PurchaseReturnDetail] ([PurchaseReturnDetailID], [PurchaseReturnID], [ProductID], [IsExpire], [ExpireDate], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (2, 1, 3, 0, CAST(0x1F440B00 AS Date), CAST(85000.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(555 AS Numeric(18, 0)), CAST(425000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(8500.00 AS Decimal(18, 2)), CAST(416500.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(8330.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(8330.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(433160.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[PurchaseReturnDetail] ([PurchaseReturnDetailID], [PurchaseReturnID], [ProductID], [IsExpire], [ExpireDate], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (3, 3, 1, 0, CAST(0x21440B00 AS Date), CAST(61.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(616 AS Numeric(18, 0)), CAST(122.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2.44 AS Decimal(18, 2)), CAST(119.56 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2.39 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2.39 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(124.34 AS Decimal(18, 2)))
GO
INSERT [dbo].[PurchaseReturnDetail] ([PurchaseReturnDetailID], [PurchaseReturnID], [ProductID], [IsExpire], [ExpireDate], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (4, 6, 1, 0, CAST(0x21440B00 AS Date), CAST(56000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(562 AS Numeric(18, 0)), CAST(112000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2240.00 AS Decimal(18, 2)), CAST(109760.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2195.20 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2195.20 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(114150.40 AS Decimal(18, 2)))
GO
INSERT [dbo].[PurchaseReturnDetail] ([PurchaseReturnDetailID], [PurchaseReturnID], [ProductID], [IsExpire], [ExpireDate], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (5, 7, 1, 0, CAST(0x21440B00 AS Date), CAST(56000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2 AS Numeric(18, 0)), CAST(112000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2240.00 AS Decimal(18, 2)), CAST(109760.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2195.20 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2195.20 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(114150.40 AS Decimal(18, 2)))
GO
INSERT [dbo].[PurchaseReturnDetail] ([PurchaseReturnDetailID], [PurchaseReturnID], [ProductID], [IsExpire], [ExpireDate], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (6, 8, 1, 0, CAST(0x21440B00 AS Date), CAST(266.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(265 AS Numeric(18, 0)), CAST(532.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(10.64 AS Decimal(18, 2)), CAST(521.36 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(10.43 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(10.43 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(542.21 AS Decimal(18, 2)))
GO
INSERT [dbo].[PurchaseReturnDetail] ([PurchaseReturnDetailID], [PurchaseReturnID], [ProductID], [IsExpire], [ExpireDate], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (7, 9, 1, 0, CAST(0x21440B00 AS Date), CAST(56.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(222 AS Numeric(18, 0)), CAST(112.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2.24 AS Decimal(18, 2)), CAST(109.76 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2.20 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2.20 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(114.15 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[PurchaseReturnDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[PurchaseReturnMaster] ON 

GO
INSERT [dbo].[PurchaseReturnMaster] ([PurchaseReturnID], [PurchaseDate], [SupplierID], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [TradeDiscountAmount], [CashDiscountAmount], [FreighCharges], [LabourCharges], [NetAmount], [PaymentMode], [Remark]) VALUES (1, CAST(0x03440B00 AS Date), 3, CAST(665 AS Numeric(18, 0)), CAST(459460.00 AS Decimal(18, 2)), CAST(9189.20 AS Decimal(18, 2)), NULL, CAST(9005.42 AS Decimal(18, 2)), CAST(9005.42 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(468281.63 AS Decimal(18, 2)), CAST(125.00 AS Decimal(18, 2)), CAST(126.00 AS Decimal(18, 2)), CAST(120.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'NEFT', N'Nothing')
GO
INSERT [dbo].[PurchaseReturnMaster] ([PurchaseReturnID], [PurchaseDate], [SupplierID], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [TradeDiscountAmount], [CashDiscountAmount], [FreighCharges], [LabourCharges], [NetAmount], [PaymentMode], [Remark]) VALUES (2, CAST(0x27440B00 AS Date), 2, CAST(646 AS Numeric(18, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[PurchaseReturnMaster] ([PurchaseReturnID], [PurchaseDate], [SupplierID], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [TradeDiscountAmount], [CashDiscountAmount], [FreighCharges], [LabourCharges], [NetAmount], [PaymentMode], [Remark]) VALUES (3, CAST(0x20440B00 AS Date), 2, CAST(64 AS Numeric(18, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[PurchaseReturnMaster] ([PurchaseReturnID], [PurchaseDate], [SupplierID], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [TradeDiscountAmount], [CashDiscountAmount], [FreighCharges], [LabourCharges], [NetAmount], [PaymentMode], [Remark]) VALUES (4, CAST(0x20440B00 AS Date), 2, CAST(5165 AS Numeric(18, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[PurchaseReturnMaster] ([PurchaseReturnID], [PurchaseDate], [SupplierID], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [TradeDiscountAmount], [CashDiscountAmount], [FreighCharges], [LabourCharges], [NetAmount], [PaymentMode], [Remark]) VALUES (6, CAST(0x20440B00 AS Date), 2, CAST(1161 AS Numeric(18, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[PurchaseReturnMaster] ([PurchaseReturnID], [PurchaseDate], [SupplierID], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [TradeDiscountAmount], [CashDiscountAmount], [FreighCharges], [LabourCharges], [NetAmount], [PaymentMode], [Remark]) VALUES (7, CAST(0x20440B00 AS Date), 2, CAST(515 AS Numeric(18, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[PurchaseReturnMaster] ([PurchaseReturnID], [PurchaseDate], [SupplierID], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [TradeDiscountAmount], [CashDiscountAmount], [FreighCharges], [LabourCharges], [NetAmount], [PaymentMode], [Remark]) VALUES (8, CAST(0x20440B00 AS Date), 2, CAST(151 AS Numeric(18, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[PurchaseReturnMaster] ([PurchaseReturnID], [PurchaseDate], [SupplierID], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [TradeDiscountAmount], [CashDiscountAmount], [FreighCharges], [LabourCharges], [NetAmount], [PaymentMode], [Remark]) VALUES (9, CAST(0x20440B00 AS Date), 2, CAST(561616 AS Numeric(18, 0)), CAST(112.00 AS Decimal(18, 2)), CAST(2.24 AS Decimal(18, 2)), NULL, CAST(2.20 AS Decimal(18, 2)), CAST(2.20 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(114.15 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(114.15 AS Decimal(18, 2)), N'-- Select Mode --', N'')
GO
SET IDENTITY_INSERT [dbo].[PurchaseReturnMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[SalesDetail] ON 

GO
INSERT [dbo].[SalesDetail] ([SalesDetailID], [SalesID], [ProductID], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (1, 1, 3, CAST(63000.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(552 AS Numeric(18, 0)), CAST(315000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(6300.00 AS Decimal(18, 2)), CAST(308700.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(6174.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(6174.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(321048.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SalesDetail] ([SalesDetailID], [SalesID], [ProductID], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (2, 1, 2, CAST(65000.00 AS Decimal(18, 2)), CAST(6.00 AS Decimal(18, 2)), CAST(2 AS Numeric(18, 0)), CAST(390000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(7800.00 AS Decimal(18, 2)), CAST(382200.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(7644.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(7644.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(397488.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SalesDetail] ([SalesDetailID], [SalesID], [ProductID], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (3, 2, 2, CAST(65000.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(845 AS Numeric(18, 0)), CAST(325000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(6500.00 AS Decimal(18, 2)), CAST(318500.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(6370.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(6370.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(331240.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SalesDetail] ([SalesDetailID], [SalesID], [ProductID], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (4, 2, 3, CAST(63000.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(462 AS Numeric(18, 0)), CAST(315000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(6300.00 AS Decimal(18, 2)), CAST(308700.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(6174.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(6174.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(321048.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SalesDetail] ([SalesDetailID], [SalesID], [ProductID], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (5, 3, 2, CAST(65000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(55 AS Numeric(18, 0)), CAST(130000.00 AS Decimal(18, 2)), CAST(2.50 AS Decimal(18, 2)), CAST(3250.00 AS Decimal(18, 2)), CAST(126750.00 AS Decimal(18, 2)), CAST(2.50 AS Decimal(18, 2)), CAST(3168.75 AS Decimal(18, 2)), CAST(2.50 AS Decimal(18, 2)), CAST(3168.75 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(133087.50 AS Decimal(18, 2)))
GO
INSERT [dbo].[SalesDetail] ([SalesDetailID], [SalesID], [ProductID], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (6, 4, 2, CAST(65000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2632 AS Numeric(18, 0)), CAST(130000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2600.00 AS Decimal(18, 2)), CAST(127400.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2548.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2548.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(132496.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SalesDetail] ([SalesDetailID], [SalesID], [ProductID], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (7, 5, 1, CAST(41616.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(535 AS Numeric(18, 0)), CAST(83232.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(1664.64 AS Decimal(18, 2)), CAST(81567.36 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(1631.35 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(1631.35 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(84830.05 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[SalesDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[SalesMaster] ON 

GO
INSERT [dbo].[SalesMaster] ([SalesID], [SalesDate], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [NetAmount], [MobileNo], [CustomerName], [Address], [PaymentMode], [Remark]) VALUES (1, CAST(0x0B440B00 AS Date), CAST(534 AS Numeric(18, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[SalesMaster] ([SalesID], [SalesDate], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [NetAmount], [MobileNo], [CustomerName], [Address], [PaymentMode], [Remark]) VALUES (2, CAST(0x03440B00 AS Date), CAST(5862 AS Numeric(18, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[SalesMaster] ([SalesID], [SalesDate], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [NetAmount], [MobileNo], [CustomerName], [Address], [PaymentMode], [Remark]) VALUES (3, CAST(0x02440B00 AS Date), CAST(556 AS Numeric(18, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[SalesMaster] ([SalesID], [SalesDate], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [NetAmount], [MobileNo], [CustomerName], [Address], [PaymentMode], [Remark]) VALUES (4, CAST(0x03440B00 AS Date), CAST(456 AS Numeric(18, 0)), CAST(130000.00 AS Decimal(18, 2)), CAST(2600.00 AS Decimal(18, 2)), CAST(127400.00 AS Decimal(18, 2)), CAST(2548.00 AS Decimal(18, 2)), CAST(2548.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, CAST(132496.00 AS Decimal(18, 2)), CAST(64648555 AS Numeric(18, 0)), N'Souvik Bhattacharya', N'Surat', N'Cash', N'Nothing')
GO
INSERT [dbo].[SalesMaster] ([SalesID], [SalesDate], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [NetAmount], [MobileNo], [CustomerName], [Address], [PaymentMode], [Remark]) VALUES (5, CAST(0x20440B00 AS Date), CAST(5441 AS Numeric(18, 0)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[SalesMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[SalesReturnDetail] ON 

GO
INSERT [dbo].[SalesReturnDetail] ([SalesReturnDetailID], [SalesReturnID], [ProductID], [Rate], [Qty], [HSNCode], [Total], [DiscountPercentage], [DiscountAmount], [TaxableAmount], [CGSTPercentage], [CGSTAmount], [SGSTPercentage], [SGSTAmount], [IGSTPercentage], [IGSTAmount], [NetAmount]) VALUES (1, 1, 3, CAST(63000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(516 AS Numeric(18, 0)), CAST(126000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2520.00 AS Decimal(18, 2)), CAST(123480.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2469.60 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(2469.60 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(128419.20 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[SalesReturnDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[SalesReturnMaster] ON 

GO
INSERT [dbo].[SalesReturnMaster] ([SalesReturnID], [SalesReturnDate], [InvoiceNo], [TotalGrossAmount], [TotalDiscountAmount], [TaxableAmount], [CGSTAmount], [SGSTAmount], [IGSTAmount], [TotalAmount], [NetAmount], [MobileNo], [CustomerName], [Address], [PaymentMode], [Remark]) VALUES (1, CAST(0x02440B00 AS Date), CAST(5161 AS Numeric(18, 0)), CAST(126000.00 AS Decimal(18, 2)), CAST(2520.00 AS Decimal(18, 2)), CAST(123480.00 AS Decimal(18, 2)), CAST(2469.60 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, CAST(128419.20 AS Decimal(18, 2)), CAST(0 AS Numeric(18, 0)), N'0', N'0', N'Cash', N'Nothing')
GO
SET IDENTITY_INSERT [dbo].[SalesReturnMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[SubCategoryMaster] ON 

GO
INSERT [dbo].[SubCategoryMaster] ([SUBCATEGORYID], [SUBCATEGORYNAME], [CATEGORYID]) VALUES (1, N'Windows 11 Pro', 1)
GO
INSERT [dbo].[SubCategoryMaster] ([SUBCATEGORYID], [SUBCATEGORYNAME], [CATEGORYID]) VALUES (2, N'Windows 11 Home', 1)
GO
INSERT [dbo].[SubCategoryMaster] ([SUBCATEGORYID], [SUBCATEGORYNAME], [CATEGORYID]) VALUES (3, N'Ethernet Cable', 4)
GO
INSERT [dbo].[SubCategoryMaster] ([SUBCATEGORYID], [SUBCATEGORYNAME], [CATEGORYID]) VALUES (4, N'Sql Server', 5)
GO
INSERT [dbo].[SubCategoryMaster] ([SUBCATEGORYID], [SUBCATEGORYNAME], [CATEGORYID]) VALUES (5, N'MongoDb', 5)
GO
INSERT [dbo].[SubCategoryMaster] ([SUBCATEGORYID], [SUBCATEGORYNAME], [CATEGORYID]) VALUES (6, N'1TB SSD', 2)
GO
INSERT [dbo].[SubCategoryMaster] ([SUBCATEGORYID], [SUBCATEGORYNAME], [CATEGORYID]) VALUES (7, N'2TB SSD', 2)
GO
INSERT [dbo].[SubCategoryMaster] ([SUBCATEGORYID], [SUBCATEGORYNAME], [CATEGORYID]) VALUES (8, N'5TB SSD', 2)
GO
INSERT [dbo].[SubCategoryMaster] ([SUBCATEGORYID], [SUBCATEGORYNAME], [CATEGORYID]) VALUES (9, N'5TB HHD', 2)
GO
INSERT [dbo].[SubCategoryMaster] ([SUBCATEGORYID], [SUBCATEGORYNAME], [CATEGORYID]) VALUES (10, N'1TB HHD', 2)
GO
INSERT [dbo].[SubCategoryMaster] ([SUBCATEGORYID], [SUBCATEGORYNAME], [CATEGORYID]) VALUES (11, N'Abelton', 1)
GO
INSERT [dbo].[SubCategoryMaster] ([SUBCATEGORYID], [SUBCATEGORYNAME], [CATEGORYID]) VALUES (12, N'Switch', 4)
GO
INSERT [dbo].[SubCategoryMaster] ([SUBCATEGORYID], [SUBCATEGORYNAME], [CATEGORYID]) VALUES (13, N'Router', 4)
GO
INSERT [dbo].[SubCategoryMaster] ([SUBCATEGORYID], [SUBCATEGORYNAME], [CATEGORYID]) VALUES (14, N'sabydifybs', 2)
GO
SET IDENTITY_INSERT [dbo].[SubCategoryMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[SupplierMaster] ON 

GO
INSERT [dbo].[SupplierMaster] ([SUPPLIERID], [SUPPLIERNAME], [ADDRESS], [EMAILID], [MOBILENO], [CONTACTPERSON], [REMARK]) VALUES (2, N'Cisco ', N'ATRHTSH', N'Cisco@gmail.com', CAST(85376 AS Numeric(18, 0)), N'Souvik', N'AEHRAH')
GO
INSERT [dbo].[SupplierMaster] ([SUPPLIERID], [SUPPLIERNAME], [ADDRESS], [EMAILID], [MOBILENO], [CONTACTPERSON], [REMARK]) VALUES (3, N'Amazon Ltd', N'wgegerg', N'AmazonSupport@gmail.com', CAST(453434345 AS Numeric(18, 0)), N'Neel', N'egeerrevre')
GO
SET IDENTITY_INSERT [dbo].[SupplierMaster] OFF
GO
USE [master]
GO
ALTER DATABASE [FinancialProject] SET  READ_WRITE 
GO
