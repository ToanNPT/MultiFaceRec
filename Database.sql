USE [attt]
GO
/****** Object:  Table [dbo].[users]    Script Date: 12/8/2021 10:50:21 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[users]') AND type in (N'U'))
DROP TABLE [dbo].[users]
GO
/****** Object:  Table [dbo].[users]    Script Date: 12/8/2021 10:50:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [nvarchar](20) NULL,
	[lastname] [nvarchar](20) NULL,
	[image] [varchar](30) NULL,
	[username] [nvarchar](10) NULL,
	[password] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [firstname], [lastname], [image], [username], [password]) VALUES (1, N'toan', N'nguyen phuc than', NULL, N'toannpt', N'08102001')
INSERT [dbo].[users] ([id], [firstname], [lastname], [image], [username], [password]) VALUES (2, N'Vy', N'Tran Huu Khanh Vy', NULL, N'vytran', N'vytran')
INSERT [dbo].[users] ([id], [firstname], [lastname], [image], [username], [password]) VALUES (13, N'toan', N'nguyen phuc thanh', N'null ', N'toan0810', N'toan0810')
SET IDENTITY_INSERT [dbo].[users] OFF
GO
