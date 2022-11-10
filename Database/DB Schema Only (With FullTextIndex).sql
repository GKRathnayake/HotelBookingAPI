USE [Hotel]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Rooms]') AND type in (N'U'))
ALTER TABLE [dbo].[Rooms] DROP CONSTRAINT IF EXISTS [FK_Rooms_RoomTypes_RoomTypeId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Rooms]') AND type in (N'U'))
ALTER TABLE [dbo].[Rooms] DROP CONSTRAINT IF EXISTS [FK_Rooms_Hotels_HotelId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Reviews]') AND type in (N'U'))
ALTER TABLE [dbo].[Reviews] DROP CONSTRAINT IF EXISTS [FK_Reviews_Hotels_HotelId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Hotels]') AND type in (N'U'))
ALTER TABLE [dbo].[Hotels] DROP CONSTRAINT IF EXISTS [FK_Hotels_Countries_CountryId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Hotels]') AND type in (N'U'))
ALTER TABLE [dbo].[Hotels] DROP CONSTRAINT IF EXISTS [FK_Hotels_Cities_CityId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FacilityHotel]') AND type in (N'U'))
ALTER TABLE [dbo].[FacilityHotel] DROP CONSTRAINT IF EXISTS [FK_FacilityHotel_Hotels_HotelsHotelId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FacilityHotel]') AND type in (N'U'))
ALTER TABLE [dbo].[FacilityHotel] DROP CONSTRAINT IF EXISTS [FK_FacilityHotel_Facilities_FacilitiesFacilityId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cities]') AND type in (N'U'))
ALTER TABLE [dbo].[Cities] DROP CONSTRAINT IF EXISTS [FK_Cities_Countries_CountryId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bookings]') AND type in (N'U'))
ALTER TABLE [dbo].[Bookings] DROP CONSTRAINT IF EXISTS [FK_Bookings_Rooms_RoomId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bookings]') AND type in (N'U'))
ALTER TABLE [dbo].[Bookings] DROP CONSTRAINT IF EXISTS [FK_Bookings_BookingStatuses_BookingStatusId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bookings]') AND type in (N'U'))
ALTER TABLE [dbo].[Bookings] DROP CONSTRAINT IF EXISTS [DF__Bookings__RoomId__06CD04F7]
GO
/****** Object:  FullTextIndex     Script Date: 11/10/2022 8:34:36 PM ******/
IF  EXISTS (SELECT * FROM sys.fulltext_indexes fti WHERE fti.object_id = OBJECT_ID(N'[dbo].[Hotels]'))
DROP FULLTEXT INDEX ON [dbo].[Hotels]
GO
/****** Object:  Index [IX_Rooms_RoomTypeId]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP INDEX IF EXISTS [IX_Rooms_RoomTypeId] ON [dbo].[Rooms]
GO
/****** Object:  Index [IX_Rooms_HotelId]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP INDEX IF EXISTS [IX_Rooms_HotelId] ON [dbo].[Rooms]
GO
/****** Object:  Index [IX_Reviews_HotelId]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP INDEX IF EXISTS [IX_Reviews_HotelId] ON [dbo].[Reviews]
GO
/****** Object:  Index [UI_HotelId]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP INDEX IF EXISTS [UI_HotelId] ON [dbo].[Hotels]
GO
/****** Object:  Index [IX_Hotels_CountryId]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP INDEX IF EXISTS [IX_Hotels_CountryId] ON [dbo].[Hotels]
GO
/****** Object:  Index [IX_Hotels_CityId]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP INDEX IF EXISTS [IX_Hotels_CityId] ON [dbo].[Hotels]
GO
/****** Object:  Index [IX_FacilityHotel_HotelsHotelId]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP INDEX IF EXISTS [IX_FacilityHotel_HotelsHotelId] ON [dbo].[FacilityHotel]
GO
/****** Object:  Index [IX_Cities_CountryId]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP INDEX IF EXISTS [IX_Cities_CountryId] ON [dbo].[Cities]
GO
/****** Object:  Index [IX_Bookings_RoomId]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP INDEX IF EXISTS [IX_Bookings_RoomId] ON [dbo].[Bookings]
GO
/****** Object:  Index [IX_Bookings_BookingStatusId]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP INDEX IF EXISTS [IX_Bookings_BookingStatusId] ON [dbo].[Bookings]
GO
/****** Object:  Table [dbo].[RoomTypes]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP TABLE IF EXISTS [dbo].[RoomTypes]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP TABLE IF EXISTS [dbo].[Rooms]
GO
/****** Object:  Table [dbo].[Reviews]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP TABLE IF EXISTS [dbo].[Reviews]
GO
/****** Object:  Table [dbo].[Hotels]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP TABLE IF EXISTS [dbo].[Hotels]
GO
/****** Object:  Table [dbo].[FacilityHotel]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP TABLE IF EXISTS [dbo].[FacilityHotel]
GO
/****** Object:  Table [dbo].[Facilities]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP TABLE IF EXISTS [dbo].[Facilities]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP TABLE IF EXISTS [dbo].[Countries]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP TABLE IF EXISTS [dbo].[Cities]
GO
/****** Object:  Table [dbo].[BookingStatuses]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP TABLE IF EXISTS [dbo].[BookingStatuses]
GO
/****** Object:  Table [dbo].[Bookings]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP TABLE IF EXISTS [dbo].[Bookings]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/10/2022 8:34:36 PM ******/
DROP TABLE IF EXISTS [dbo].[__EFMigrationsHistory]
GO
/****** Object:  FullTextCatalog [FullTextCatalog]    Script Date: 11/10/2022 8:34:36 PM ******/
GO
IF  EXISTS (SELECT * FROM sysfulltextcatalogs ftc WHERE ftc.name = N'FullTextCatalog')
DROP FULLTEXT CATALOG [FullTextCatalog]
GO
/****** Object:  FullTextCatalog [ft]    Script Date: 11/10/2022 8:34:36 PM ******/
GO
IF  EXISTS (SELECT * FROM sysfulltextcatalogs ftc WHERE ftc.name = N'ft')
DROP FULLTEXT CATALOG [ft]
GO
/****** Object:  FullTextCatalog [ft]    Script Date: 11/10/2022 8:34:36 PM ******/
CREATE FULLTEXT CATALOG [ft] WITH ACCENT_SENSITIVITY = ON
AS DEFAULT
GO
/****** Object:  FullTextCatalog [FullTextCatalog]    Script Date: 11/10/2022 8:34:36 PM ******/
CREATE FULLTEXT CATALOG [FullTextCatalog] WITH ACCENT_SENSITIVITY = ON
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/10/2022 8:34:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bookings]    Script Date: 11/10/2022 8:34:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bookings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoomId] [int] NOT NULL,
	[CheckinDate] [datetime2](7) NOT NULL,
	[CheckoutDate] [datetime2](7) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[AdditionalInstructions] [nvarchar](1000) NOT NULL,
	[BookingStatusId] [int] NOT NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Bookings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookingStatuses]    Script Date: 11/10/2022 8:34:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingStatuses](
	[BookingStatusId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](150) NOT NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_BookingStatuses] PRIMARY KEY CLUSTERED 
(
	[BookingStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 11/10/2022 8:34:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[CityId] [int] IDENTITY(1,1) NOT NULL,
	[CountryId] [int] NOT NULL,
	[CityName] [nvarchar](400) NOT NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 11/10/2022 8:34:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryId] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](500) NOT NULL,
	[Code] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facilities]    Script Date: 11/10/2022 8:34:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facilities](
	[FacilityId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Facilities] PRIMARY KEY CLUSTERED 
(
	[FacilityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacilityHotel]    Script Date: 11/10/2022 8:34:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacilityHotel](
	[FacilitiesFacilityId] [int] NOT NULL,
	[HotelsHotelId] [int] NOT NULL,
 CONSTRAINT [PK_FacilityHotel] PRIMARY KEY CLUSTERED 
(
	[FacilitiesFacilityId] ASC,
	[HotelsHotelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hotels]    Script Date: 11/10/2022 8:34:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotels](
	[HotelId] [int] IDENTITY(1,1) NOT NULL,
	[HotelName] [nvarchar](250) NOT NULL,
	[Description] [nvarchar](1000) NOT NULL,
	[Longitude] [decimal](18, 4) NOT NULL,
	[Latitude] [decimal](18, 4) NOT NULL,
	[CountryId] [int] NOT NULL,
	[CityId] [int] NOT NULL,
	[Address] [nvarchar](400) NOT NULL,
	[OverallRating] [decimal](18, 4) NOT NULL,
	[LowestRoomPrice] [decimal](18, 4) NOT NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Hotels] PRIMARY KEY CLUSTERED 
(
	[HotelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reviews]    Script Date: 11/10/2022 8:34:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reviews](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HotelId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[Rating] [decimal](18, 4) NOT NULL,
	[Comment] [nvarchar](1500) NOT NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Reviews] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 11/10/2022 8:34:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[RoomId] [int] IDENTITY(1,1) NOT NULL,
	[RoomNumber] [nvarchar](10) NOT NULL,
	[HotelId] [int] NOT NULL,
	[RoomTypeId] [int] NOT NULL,
	[Price] [decimal](18, 4) NOT NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[RoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomTypes]    Script Date: 11/10/2022 8:34:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomTypes](
	[RoomTypeId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](150) NOT NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_RoomTypes] PRIMARY KEY CLUSTERED 
(
	[RoomTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_Bookings_BookingStatusId]    Script Date: 11/10/2022 8:34:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Bookings_BookingStatusId] ON [dbo].[Bookings]
(
	[BookingStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Bookings_RoomId]    Script Date: 11/10/2022 8:34:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Bookings_RoomId] ON [dbo].[Bookings]
(
	[RoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Cities_CountryId]    Script Date: 11/10/2022 8:34:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Cities_CountryId] ON [dbo].[Cities]
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FacilityHotel_HotelsHotelId]    Script Date: 11/10/2022 8:34:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_FacilityHotel_HotelsHotelId] ON [dbo].[FacilityHotel]
(
	[HotelsHotelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Hotels_CityId]    Script Date: 11/10/2022 8:34:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Hotels_CityId] ON [dbo].[Hotels]
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Hotels_CountryId]    Script Date: 11/10/2022 8:34:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Hotels_CountryId] ON [dbo].[Hotels]
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UI_HotelId]    Script Date: 11/10/2022 8:34:36 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UI_HotelId] ON [dbo].[Hotels]
(
	[HotelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reviews_HotelId]    Script Date: 11/10/2022 8:34:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Reviews_HotelId] ON [dbo].[Reviews]
(
	[HotelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Rooms_HotelId]    Script Date: 11/10/2022 8:34:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Rooms_HotelId] ON [dbo].[Rooms]
(
	[HotelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Rooms_RoomTypeId]    Script Date: 11/10/2022 8:34:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Rooms_RoomTypeId] ON [dbo].[Rooms]
(
	[RoomTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  FullTextIndex     Script Date: 11/10/2022 8:34:36 PM ******/
CREATE FULLTEXT INDEX ON [dbo].[Hotels](
[Address] LANGUAGE 'English', 
[Description] LANGUAGE 'English', 
[HotelName] LANGUAGE 'English')
KEY INDEX [UI_HotelId]ON ([ft], FILEGROUP [PRIMARY])
WITH (CHANGE_TRACKING = AUTO, STOPLIST = SYSTEM)

GO
ALTER TABLE [dbo].[Bookings] ADD  DEFAULT ((0)) FOR [RoomId]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [FK_Bookings_BookingStatuses_BookingStatusId] FOREIGN KEY([BookingStatusId])
REFERENCES [dbo].[BookingStatuses] ([BookingStatusId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [FK_Bookings_BookingStatuses_BookingStatusId]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [FK_Bookings_Rooms_RoomId] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Rooms] ([RoomId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [FK_Bookings_Rooms_RoomId]
GO
ALTER TABLE [dbo].[Cities]  WITH CHECK ADD  CONSTRAINT [FK_Cities_Countries_CountryId] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countries] ([CountryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cities] CHECK CONSTRAINT [FK_Cities_Countries_CountryId]
GO
ALTER TABLE [dbo].[FacilityHotel]  WITH CHECK ADD  CONSTRAINT [FK_FacilityHotel_Facilities_FacilitiesFacilityId] FOREIGN KEY([FacilitiesFacilityId])
REFERENCES [dbo].[Facilities] ([FacilityId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FacilityHotel] CHECK CONSTRAINT [FK_FacilityHotel_Facilities_FacilitiesFacilityId]
GO
ALTER TABLE [dbo].[FacilityHotel]  WITH CHECK ADD  CONSTRAINT [FK_FacilityHotel_Hotels_HotelsHotelId] FOREIGN KEY([HotelsHotelId])
REFERENCES [dbo].[Hotels] ([HotelId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FacilityHotel] CHECK CONSTRAINT [FK_FacilityHotel_Hotels_HotelsHotelId]
GO
ALTER TABLE [dbo].[Hotels]  WITH CHECK ADD  CONSTRAINT [FK_Hotels_Cities_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([CityId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Hotels] CHECK CONSTRAINT [FK_Hotels_Cities_CityId]
GO
ALTER TABLE [dbo].[Hotels]  WITH CHECK ADD  CONSTRAINT [FK_Hotels_Countries_CountryId] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countries] ([CountryId])
GO
ALTER TABLE [dbo].[Hotels] CHECK CONSTRAINT [FK_Hotels_Countries_CountryId]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_Hotels_HotelId] FOREIGN KEY([HotelId])
REFERENCES [dbo].[Hotels] ([HotelId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_Hotels_HotelId]
GO
ALTER TABLE [dbo].[Rooms]  WITH CHECK ADD  CONSTRAINT [FK_Rooms_Hotels_HotelId] FOREIGN KEY([HotelId])
REFERENCES [dbo].[Hotels] ([HotelId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Rooms] CHECK CONSTRAINT [FK_Rooms_Hotels_HotelId]
GO
ALTER TABLE [dbo].[Rooms]  WITH CHECK ADD  CONSTRAINT [FK_Rooms_RoomTypes_RoomTypeId] FOREIGN KEY([RoomTypeId])
REFERENCES [dbo].[RoomTypes] ([RoomTypeId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Rooms] CHECK CONSTRAINT [FK_Rooms_RoomTypes_RoomTypeId]
GO
