USE [StudentDB]
GO

/****** Object:  Table [dbo].[Registration]    Script Date: 7/5/2015 9:16:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Registration](
	[StudentId] [int] IDENTITY(1000,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[DOB] [varchar](50) NULL,
	[GradePointAvg] [float] NULL,
	[Active] [nvarchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


