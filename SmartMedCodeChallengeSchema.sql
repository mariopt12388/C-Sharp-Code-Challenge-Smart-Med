USE [medications]
GO
/****** Object:  Schema [medications]    Script Date: 22/04/2022 23:24:38 ******/
CREATE SCHEMA [medications]
GO
/****** Object:  Table [medications].[medication]    Script Date: 22/04/2022 23:24:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [medications].[medication](
	[name] [varchar](255) NOT NULL,
	[quantity] [int] NOT NULL,
	[creation_date] [datetime] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [medication_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
