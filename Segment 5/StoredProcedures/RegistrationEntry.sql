USE [StudentDB]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[RegistrationEntry]
(
@Name varchar (50),
@DOB varchar (50),
@GradePointAvg float,
@Active varchar(50)

)
as
begin
Insert into Registration (Name,DOB,GradePointAvg,Active) values (@Name,@DOB,@GradePointAvg,@Active)
End
GO


