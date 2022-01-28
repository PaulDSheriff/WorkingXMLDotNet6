/****** Object:  Table [dbo].[Product]    Script Date: 11/19/2021 7:15:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ProductNumber] [nvarchar](25) NOT NULL,
	[Color] [nvarchar](15) NULL,
	[StandardCost] [money] NOT NULL,
	[ListPrice] [money] NOT NULL,
	[Size] [nvarchar](5) NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Product_ProductID] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Product] ON 
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (706, N'HL Road Frame - Red, 58', N'FR-R92R-58', N'Red', 1059.3100, 1500.0000, N'58', CAST(N'2019-09-11T15:57:34.527' AS DateTime))
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (707, N'Sport-100 Helmet, Red', N'HL-U509-R', N'Red', 13.0800, 34.9900, NULL, CAST(N'2021-03-11T10:01:36.000' AS DateTime))
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (708, N'Sport-100 Helmet, Black', N'HL-U509', N'Black', 13.0863, 34.9900, NULL, CAST(N'2021-03-11T10:01:36.000' AS DateTime))
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (709, N'Mountain Bike Socks, M', N'SO-B909-M', N'White', 3.3963, 9.5000, N'M', CAST(N'2021-03-11T10:01:36.000' AS DateTime))
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (710, N'Mountain Bike Socks, L', N'SO-B909-L', N'White', 3.3963, 9.5000, N'L', CAST(N'2021-03-11T10:01:36.000' AS DateTime))
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (711, N'Sport-100 Helmet, Blue', N'HL-U509-B', N'Blue', 13.0863, 34.9900, NULL, CAST(N'2021-03-11T10:01:36.000' AS DateTime))
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (712, N'AWC Logo Cap', N'CA-1098', N'Multi', 6.9200, 8.9900, NULL, CAST(N'2019-10-08T10:33:09.270' AS DateTime))
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (713, N'Long-Sleeve Logo Jersey, S', N'LJ-0192-S', N'Multi', 38.4923, 49.9900, N'S', CAST(N'2021-03-11T10:01:36.000' AS DateTime))
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (714, N'Long-Sleeve Logo Jersey, M', N'LJ-0192-M', N'Multi', 38.4923, 49.9900, N'M', CAST(N'2021-03-11T10:01:36.000' AS DateTime))
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (715, N'Long-Sleeve Logo Jersey, L', N'LJ-0192-L', N'Multi', 38.4923, 49.9900, N'L', CAST(N'2021-03-11T10:01:36.000' AS DateTime))
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (716, N'Long-Sleeve Logo Jersey, XL', N'LJ-0192-X', N'Multi', 38.4923, 49.9900, N'XL', CAST(N'2021-03-11T10:01:36.000' AS DateTime))
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (717, N'HL Road Frame - Red, 62', N'FR-R92R-62', N'Red', 868.6342, 1431.5000, N'62', CAST(N'2021-03-11T10:01:36.000' AS DateTime))
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (718, N'HL Road Frame - Red, 44', N'FR-R92R-44', N'Red', 868.6342, 1431.5000, N'44', CAST(N'2021-03-11T10:01:36.000' AS DateTime))
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (719, N'HL Road Frame - Red, 48', N'FR-R92R-48', N'Red', 868.6342, 1431.5000, N'48', CAST(N'2021-03-11T10:01:36.000' AS DateTime))
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (720, N'HL Road Frame - Red, 52', N'FR-R92R-52', N'Red', 868.6300, 1431.5000, N'52', CAST(N'2020-07-06T10:01:36.000' AS DateTime))
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (721, N'HL Road Frame - Red, 56', N'FR-R92R-56', N'Red', 868.6342, 1431.5000, N'56', CAST(N'2021-03-11T10:01:36.000' AS DateTime))
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (722, N'LL Road Frame - Black, 58', N'FR-R38B-58', N'Black', 204.6251, 337.2200, N'58', CAST(N'2021-03-11T10:01:36.000' AS DateTime))
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (723, N'LL Road Frame - Black, 60', N'FR-R38B-60', N'Black', 204.6251, 337.2200, N'60', CAST(N'2021-06-21T10:01:36.000' AS DateTime))
GO
INSERT [dbo].[Product] ([ProductID], [Name], [ProductNumber], [Color], [StandardCost], [ListPrice], [Size], [ModifiedDate]) VALUES (724, N'LL Road Frame - Black, 62', N'FR-R38B-62', N'Black', 204.6251, 337.2200, N'62', CAST(N'2021-04-01T10:01:36.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
