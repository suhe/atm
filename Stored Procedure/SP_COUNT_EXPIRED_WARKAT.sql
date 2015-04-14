USE [ATM]
GO
/****** Object:  StoredProcedure [dbo].[Sp_Select_By_Account_Warkat]    Script Date: 04/14/2015 09:54:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Count_By_Expired_Warkat]
AS 
    SELECT COUNT(*) as Total
    FROM [dbo].[Warkat]
    WHERE DueDate<=CONVERT(VARCHAR(10),GETDATE(),101);