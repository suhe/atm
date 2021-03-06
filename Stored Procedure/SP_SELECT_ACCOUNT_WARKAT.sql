USE [ATM]
GO
/****** Object:  StoredProcedure [dbo].[Sp_Select_Warkat]    Script Date: 04/09/2015 14:34:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter PROCEDURE [dbo].[Sp_Select_By_Account_Warkat]
@DateFrom nvarchar(50),
@DateTo nvarchar(50),
@AccountFromID int,
@AccountToID int
AS 
    SELECT Account.AccountNo,Account.AccountName,Bank.Name As BankName,WarkatNo,DueDate,Nominal
    FROM [dbo].[Warkat]
    LEFT JOIN [dbo].[Bank] on [dbo].[Bank].BankID = [dbo].[Warkat].bankID
    LEFT JOIN [dbo].[Account] on [dbo].[Account].AccountID = [dbo].[Warkat].AccountID
    WHERE DueDate between convert(datetime,@DateFrom,101) and convert(datetime,@DateTo,101)
    AND (Account.AccountID >= @AccountFromID  AND Account.AccountID <= @AccountToID)