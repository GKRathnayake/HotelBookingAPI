USE [Hotel]
GO

INSERT INTO [dbo].[Facilities]
([Description])
VALUES
('Breakfast');

INSERT INTO [dbo].[Facilities]
([Description])
VALUES
('Wifi');

INSERT INTO [dbo].[Facilities]
([Description])
VALUES
('Parking');

INSERT INTO [dbo].[Facilities]
([Description])
VALUES
('Spa');

INSERT INTO [dbo].[Facilities]
([Description])
VALUES
('Pool');

INSERT INTO [dbo].[RoomTypes]([Description],[UpdatedDate],[CreatedDate])
VALUES ('Single Room' ,NULL ,GETDATE());

INSERT INTO [dbo].[RoomTypes]([Description],[UpdatedDate],[CreatedDate])
VALUES ('Double Room' ,NULL ,GETDATE());

INSERT INTO [dbo].[RoomTypes]([Description],[UpdatedDate],[CreatedDate])
VALUES ('Studio Room' ,NULL ,GETDATE());

INSERT INTO [dbo].[RoomTypes]([Description],[UpdatedDate],[CreatedDate])
VALUES ('Deluxe Room' ,NULL ,GETDATE());

INSERT INTO [dbo].[RoomTypes]([Description],[UpdatedDate],[CreatedDate])
VALUES ('Room With a View' ,NULL ,GETDATE());

INSERT INTO [dbo].[RoomTypes]([Description],[UpdatedDate],[CreatedDate])
VALUES ('Suite' ,NULL ,GETDATE());

INSERT INTO [dbo].[RoomTypes]([Description],[UpdatedDate],[CreatedDate])
VALUES ('Presidential Suite' ,NULL ,GETDATE());

GO


INSERT INTO [dbo].[Countries]([Name],[Code])
VALUES('United Arab Emirates', 'AE');

INSERT INTO [dbo].[Countries]([Name],[Code])
VALUES('Sri Lanka', 'LK');
GO

GO

INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Dubai',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Abu Dhabi',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Sharjah',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Al Ain',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Ajman',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Ras Al Khaimah',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Fujairah',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Umm al-Quwain',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Dibba Al-Fujairah',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Khor Fakkan',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Kalba',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Jebel Ali',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Madinat Zayed',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Ruwais',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Liwa Oasis',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Dhaid',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Ghayathi',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Ar-Rams',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Dibba Al-Hisn',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Hatta',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Al Madam',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(1,'Al Jazirah Al Hamra',NULL,GETDATE());

GO
GO

INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Colombo',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Moratuwa',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Kandy',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Negombo',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Batticaloa',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Sri Jayewardenepura Kotte',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Kilinochchi',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Galle',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Trincomalee',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Jaffna',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Matara',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Anuradhapura',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Ratnapura',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Puttalam',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Badulla',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Mullaittivu',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Matale',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Mannar',NULL,GETDATE());
INSERT INTO [dbo].[Cities]([CountryId],[Name],[UpdatedDate],[CreatedDate]) VALUES(2,'Kurunegala',NULL,GETDATE());
GO

INSERT INTO [dbo].[BookingStatuses]([Description],[UpdatedDate],[CreatedDate])
VALUES('In Progress',NULL,GETDATE());

INSERT INTO [dbo].[BookingStatuses]([Description],[UpdatedDate],[CreatedDate])
VALUES('Payment Pending',NULL,GETDATE());

INSERT INTO [dbo].[BookingStatuses]([Description],[UpdatedDate],[CreatedDate])
VALUES('Payment Confirmation Pending',NULL,GETDATE());

INSERT INTO [dbo].[BookingStatuses]([Description],[UpdatedDate],[CreatedDate])
VALUES('Payment Confirmed',NULL,GETDATE());

INSERT INTO [dbo].[BookingStatuses]([Description],[UpdatedDate],[CreatedDate])
VALUES('Cancelled',NULL,GETDATE());

GO

GO

INSERT INTO [dbo].[Hotels]([HotelName],[Description],[Longitude],[Latitude],[CountryId],[CityId],[Address],[OverallRating],[LowestRoomPrice],[UpdatedDate],[CreatedDate])
VALUES
('Atlantis The Palm'
,'An iconic entertainment destination comprised of two world-class resorts that bring you extraordinary experiences. Discover a world of amazement across stays, dining, entertainment, attractions and wellness.'
,25.13222867
,55.1138368
,1
,1
,'Crescent Road, The Palm'
,3
,25.9
,NULL
,GETDATE());

INSERT INTO [dbo].[Hotels]([HotelName],[Description],[Longitude],[Latitude],[CountryId],[CityId],[Address],[OverallRating],[LowestRoomPrice],[UpdatedDate],[CreatedDate])
VALUES
('Burj Al Arab'
,'Burj Al Arab, Dubai’s most iconic hotel and a global icon of Arabian luxury. Explore the jewel of Jumeirah and enjoy its private beach, world-class dining, and exceptional service.'
,25.14220931
,55.18508664
,1
,1
,'Jumeirah St - Dubai, PO Box 74147'
,4
,40
,NULL
,GETDATE());


INSERT INTO [dbo].[Hotels]([HotelName],[Description],[Longitude],[Latitude],[CountryId],[CityId],[Address],[OverallRating],[LowestRoomPrice],[UpdatedDate],[CreatedDate])
VALUES
('Amaya Hills'
,'Drawing regal splendour and monarchical charms from an era of the kings and queens of this ancient kingdom, Amaya Hills Kandy sets the benchmark for stunning hotels in Kandy with breathtaking, verdant views of the surrounding mountains and the city. Experience a unique, royal treatment high up in the mountains at Amaya Hills.'
,7.261613059261975
,80.61904584009554
,2
,25
,'Herrassagala, 20000'
,4
,30
,NULL
,GETDATE());

INSERT INTO [dbo].[Hotels]([HotelName],[Description],[Longitude],[Latitude],[CountryId],[CityId],[Address],[OverallRating],[LowestRoomPrice],[UpdatedDate],[CreatedDate])
VALUES
('Cinnamon Lakeside'
,'Cinnamon Lakeside is located along the banks of Beira Lake in Colombo, 10 minutes’ drive from Crescat Boulevard shopping mall. It features 9 dining options and a full-service health club.'
,6.931501463013912
,79.84909991934313
,2
,23
,'115, Sir Chittampalam A Gardiner Mawatha, 00200'
,4
,35
,NULL
,GETDATE());
GO


GO

INSERT INTO [dbo].[FacilityHotel]([FacilitiesFacilityId],[HotelsHotelId])
VALUES(1,1);

INSERT INTO [dbo].[FacilityHotel]([FacilitiesFacilityId],[HotelsHotelId])
VALUES(2,1);

INSERT INTO [dbo].[FacilityHotel]([FacilitiesFacilityId],[HotelsHotelId])
VALUES(3,1);
GO

GO

INSERT INTO [dbo].[Reviews]
([HotelId]
,[UserId]
,[Rating]
,[Comment]
,[UpdatedDate]
,[CreatedDate])
VALUES(1,2,3,'Lorem ipsum dolor sit amet.',NULL,GETDATE())

INSERT INTO [dbo].[Reviews]
([HotelId]
,[UserId]
,[Rating]
,[Comment]
,[UpdatedDate]
,[CreatedDate])
VALUES(2,3,4,'Donec non erat ac turpis.',NULL,GETDATE())

INSERT INTO [dbo].[Reviews]
([HotelId]
,[UserId]
,[Rating]
,[Comment]
,[UpdatedDate]
,[CreatedDate])
VALUES(1,2,5,'Suspendisse luctus mauris ac nibh.',NULL,GETDATE())

INSERT INTO [dbo].[Reviews]
([HotelId]
,[UserId]
,[Rating]
,[Comment]
,[UpdatedDate]
,[CreatedDate])
VALUES(2,2,4,'Donec a sapien bibendum velit.',NULL,GETDATE())

INSERT INTO [dbo].[Reviews]
([HotelId]
,[UserId]
,[Rating]
,[Comment]
,[UpdatedDate]
,[CreatedDate])
VALUES(1,2,3,'Nullam tempor tempor velit sit.',NULL,GETDATE())
GO

GO

INSERT INTO [dbo].[Rooms]
([RoomNumber]
,[HotelId]
,[RoomTypeId]
,[Price]
,[UpdatedDate]
,[CreatedDate])
VALUES('101',1,1,23,NULL,GETDATE());

INSERT INTO [dbo].[Rooms]
([RoomNumber]
,[HotelId]
,[RoomTypeId]
,[Price]
,[UpdatedDate]
,[CreatedDate])
VALUES('102',1,1,23,NULL,GETDATE());

INSERT INTO [dbo].[Rooms]
([RoomNumber]
,[HotelId]
,[RoomTypeId]
,[Price]
,[UpdatedDate]
,[CreatedDate])
VALUES('103',1,1,23,NULL,GETDATE());

INSERT INTO [dbo].[Rooms]
([RoomNumber]
,[HotelId]
,[RoomTypeId]
,[Price]
,[UpdatedDate]
,[CreatedDate])
VALUES('104',1,1,23,NULL,GETDATE());

--=====================

INSERT INTO [dbo].[Rooms]
([RoomNumber]
,[HotelId]
,[RoomTypeId]
,[Price]
,[UpdatedDate]
,[CreatedDate])
VALUES('204',1,2,23,NULL,GETDATE());

INSERT INTO [dbo].[Rooms]
([RoomNumber]
,[HotelId]
,[RoomTypeId]
,[Price]
,[UpdatedDate]
,[CreatedDate])
VALUES('205',1,2,23,NULL,GETDATE());

INSERT INTO [dbo].[Rooms]
([RoomNumber]
,[HotelId]
,[RoomTypeId]
,[Price]
,[UpdatedDate]
,[CreatedDate])
VALUES('206',1,2,23,NULL,GETDATE());

INSERT INTO [dbo].[Rooms]
([RoomNumber]
,[HotelId]
,[RoomTypeId]
,[Price]
,[UpdatedDate]
,[CreatedDate])
VALUES('207',1,2,23,NULL,GETDATE());

--====================================================================

INSERT INTO [dbo].[Rooms]
([RoomNumber]
,[HotelId]
,[RoomTypeId]
,[Price]
,[UpdatedDate]
,[CreatedDate])
VALUES('101',2,1,23,NULL,GETDATE());

INSERT INTO [dbo].[Rooms]
([RoomNumber]
,[HotelId]
,[RoomTypeId]
,[Price]
,[UpdatedDate]
,[CreatedDate])
VALUES('102',2,1,23,NULL,GETDATE());

INSERT INTO [dbo].[Rooms]
([RoomNumber]
,[HotelId]
,[RoomTypeId]
,[Price]
,[UpdatedDate]
,[CreatedDate])
VALUES('103',2,1,23,NULL,GETDATE());

INSERT INTO [dbo].[Rooms]
([RoomNumber]
,[HotelId]
,[RoomTypeId]
,[Price]
,[UpdatedDate]
,[CreatedDate])
VALUES('104',2,1,23,NULL,GETDATE());

--=====================

INSERT INTO [dbo].[Rooms]
([RoomNumber]
,[HotelId]
,[RoomTypeId]
,[Price]
,[UpdatedDate]
,[CreatedDate])
VALUES('204',2,4,23,NULL,GETDATE());

INSERT INTO [dbo].[Rooms]
([RoomNumber]
,[HotelId]
,[RoomTypeId]
,[Price]
,[UpdatedDate]
,[CreatedDate])
VALUES('205',2,2,23,NULL,GETDATE());

INSERT INTO [dbo].[Rooms]
([RoomNumber]
,[HotelId]
,[RoomTypeId]
,[Price]
,[UpdatedDate]
,[CreatedDate])
VALUES('206',2,2,23,NULL,GETDATE());

INSERT INTO [dbo].[Rooms]
([RoomNumber]
,[HotelId]
,[RoomTypeId]
,[Price]
,[UpdatedDate]
,[CreatedDate])
VALUES('207',2,2,23,NULL,GETDATE());
GO

GO

INSERT INTO [dbo].[Bookings]
([RoomId]
,[CheckinDate]
,[CheckoutDate]
,[CustomerId]
,[AdditionalInstructions]
,[BookingStatusId]
,[UpdatedDate]
,[CreatedDate])
VALUES
(1
,'1-Nov-2022'
,'2-Nov-2022'
,1
,'N/A'
,2
,NULL
,GETDATE());

INSERT INTO [dbo].[Bookings]
([RoomId]
,[CheckinDate]
,[CheckoutDate]
,[CustomerId]
,[AdditionalInstructions]
,[BookingStatusId]
,[UpdatedDate]
,[CreatedDate])
VALUES
(15
,'10-Nov-2022'
,'20-Nov-2022'
,1
,'N/A'
,2
,NULL
,GETDATE());

INSERT INTO [dbo].[Bookings]
([RoomId]
,[CheckinDate]
,[CheckoutDate]
,[CustomerId]
,[AdditionalInstructions]
,[BookingStatusId]
,[UpdatedDate]
,[CreatedDate])
VALUES
(2
,'30-Oct-2022'
,'3-Oct-2022'
,1
,'N/A'
,2
,NULL
,GETDATE());

INSERT INTO [dbo].[Bookings]
([RoomId]
,[CheckinDate]
,[CheckoutDate]
,[CustomerId]
,[AdditionalInstructions]
,[BookingStatusId]
,[UpdatedDate]
,[CreatedDate])
VALUES
(16
,'10-Nov-2022'
,'20-Nov-2022'
,1
,'N/A'
,2
,NULL
,GETDATE());
GO





