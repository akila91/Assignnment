USE [StudentDB]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SelectProcedure1]
AS
BEGIN
    Select StudentId AS [Student ID],Name AS [Name], DOB AS [DoB], GradePointAvg As [GradePointAvg], Active As [Active] From Registration
END
GO


