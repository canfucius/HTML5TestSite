USE [TestInput]
GO

/****** Object:  Table [dbo].[mainpage]    Script Date: 4/19/2014 9:15:36 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[mainpage](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[linedesc] [varchar](64) NULL,
	[datemade] [smalldatetime] NULL,
	[options1] [varchar](32) NULL,
	[options2] [varchar](32) NULL,
 CONSTRAINT [PK_mainpage] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


