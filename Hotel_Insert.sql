USE [HotelManagement]
GO

INSERT INTO [dbo].[Employees]
           ([EmployeeId]
           ,[Name]
           ,[Password])
     VALUES
           (1, 'Neptune', 1)
GO

INSERT INTO [dbo].[RoomTypes]
           ([TypeId]
           ,[Name])
     VALUES
           (1, 'A'), (2, 'B'), (3, 'C'), (4, 'D'),
GO

INSERT INTO [dbo].[Rooms]
           ([RoomId]
           ,[TypeId])
     VALUES
          (1, 1), (2, 1), (3, 1), (4, 1), (5, 1), (6, 1), (7, 1), (8, 1), (9, 1), (10, 1),
		  (11, 1), (12, 1), (13, 1), (14, 1), (15, 1), (16, 1), (17, 1), (18, 1), (19, 1), (20, 1),
		  (21, 1), (22, 1), (23, 1), (24, 1), (25, 1), (26, 1), (27, 1), (28, 1), (29, 1), (30, 1),

		  (31, 2), (32, 2), (33, 2), (34, 2), (35, 2), (36, 2), (37, 2), (38, 2), (39, 2), (40, 2),
		  (41, 2), (42, 2), (43, 2), (44, 2), (45, 2), (46, 2), (47, 2), (48, 2), (49, 2), (50, 2),
		  (51, 2), (52, 2), (53, 2), (54, 2), (55, 2), (56, 2), (57, 2), (58, 2), (59, 2), (60, 2),

		  (61, 3), (62, 3), (63, 3), (64, 3), (65, 3), (66, 3), (67, 3), (68, 3), (69, 3), (70, 3),
		  (71, 3), (72, 3), (73, 3), (74, 3), (75, 3), (76, 3), (77, 3), (78, 3), (79, 3), (80, 3),
		  (81, 3), (82, 3), (83, 3), (84, 3), (85, 3), (86, 3), (87, 3), (88, 3), (89, 3), (90, 3),

		  (91, 4), (92, 4), (93, 4), (94, 4), (95, 4), (96, 4), (97, 4), (98, 4), (99, 4), (100, 4),
		  (101, 4), (102, 4), (103, 4), (104, 4), (105, 4), (106, 4), (107, 4), (108, 4), (109, 4), (110, 4),
		  (111, 4), (112, 4), (113, 4), (114, 4), (115, 4), (116, 4), (117, 4), (118, 4), (119, 4), (120, 4)
GO

INSERT INTO [dbo].[Bookings]
           ([BookingId]
           ,[CustomerId]
           ,[EmployeeId]
           ,[CreatedDate])
     VALUES
           ('B0001', 'C0001', 1, '2016/11/19'),
           ('B0002', 'C0001', 1, '2016/11/18')
GO

INSERT INTO [dbo].[BookingDetails]
           ([BookingId]
           ,[RoomId]
           ,[BookingStart]
           ,[BookingEnd]
           ,[NumOfCustomer])
     VALUES
           ('B0001', 1, '2016/11/19', '2016/11/20', 2),
           ('B0001', 2, '2016/11/10', '2016/11/25', 2),
           ('B0002', 3, '2016/11/20', '2016/11/25', 2),
           ('B0002', 4, '2016/11/25', '2016/11/30', 2)
GO