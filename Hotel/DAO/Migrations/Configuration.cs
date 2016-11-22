namespace DAO.Migrations
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;
	using DTO.Domain;
	using System.Collections.Generic;

	public class Configuration : DbMigrationsConfiguration<HotelContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true;
		}

		protected override void Seed(HotelContext context)
		{
			#region Add Employees
			var employee = new Employee { EmployeeId = "1", Name = "Neptune", Password = "1" };
			context.Employees.AddOrUpdate(p => p.Name, employee);
			#endregion

			#region Add RoomTypes
			var roomTypes = new List<RoomType>();
			roomTypes.Add(new RoomType() { TypeId = "0", TypeName = TypeOfRoom.A });
			roomTypes.Add(new RoomType() { TypeId = "1", TypeName = TypeOfRoom.B });
			roomTypes.Add(new RoomType() { TypeId = "2", TypeName = TypeOfRoom.C });
			roomTypes.Add(new RoomType() { TypeId = "3", TypeName = TypeOfRoom.D });
			roomTypes.ForEach(t => context.RoomTypes.AddOrUpdate(p=>p.TypeName, t));
			#endregion

			#region Add Rooms
			var rooms = new List<Room>();
			var typeId = roomTypes[0].TypeId;
			for (int i = 1; i <= 120; i++)
			{
				if (i > 30 && i <= 60)
				{
					typeId = roomTypes[1].TypeId;
				}
				else if (i > 60 && i <= 90)
				{
					typeId = roomTypes[2].TypeId;
				}
				else if (i > 90)
				{
					typeId = roomTypes[3].TypeId;
				}
				rooms.Add(new Room() { RoomId = i.ToString(), TypeId = typeId });
			}
			rooms.ForEach(r => context.Rooms.AddOrUpdate(r));
			#endregion

			#region Add Customers
			var customer1 = new Customer() { CustomerId = "C0001", Name = "yaxu", Address = "20 phut", Phone = "gank", Fax = "tem", Telex = "GG" };
			var customer2 = new Customer() { CustomerId = "C0002", Name = "Neptune", Address = "20 phut", Phone = "gank", Fax = "tem", Telex = "GG" };
			context.Customers.AddOrUpdate(p => p.Name, customer1, customer2);
			#endregion

			#region Add Bookings
			var bookings = new List<Booking>();
			bookings.Add(new Booking() { BookingId = "B0001", CustomerId = customer1.CustomerId, EmployeeId = employee.EmployeeId, CreatedDate = DateTime.Now });
			bookings.Add(new Booking() { BookingId = "B0002", CustomerId = customer2.CustomerId, EmployeeId = employee.EmployeeId, CreatedDate = DateTime.Now });
			bookings.ForEach(b => context.Bookings.AddOrUpdate(b));
			#endregion

			#region Add BookingDetails
			var bookingDetails = new List<BookingDetail>();
			bookingDetails.Add(new BookingDetail
			{
				BookingId = bookings[0].BookingId,
				RoomId = rooms[0].RoomId,
				BookingStart = new DateTime(2016, 11, 20),
				BookingEnd = new DateTime(2016, 11, 30),
				NumOfCustomer = 2,
			});
			bookingDetails.Add(new BookingDetail
			{
				BookingId = bookings[0].BookingId,
				RoomId = rooms[1].RoomId,
				BookingStart = new DateTime(2016, 11, 20),
				BookingEnd = new DateTime(2016, 11, 30),
				NumOfCustomer = 2,
			});
			bookingDetails.Add(new BookingDetail
			{
				BookingId = bookings[0].BookingId,
				RoomId = rooms[3].RoomId,
				BookingStart = new DateTime(2016, 11, 20),
				BookingEnd = new DateTime(2016, 11, 30),
				NumOfCustomer = 2,
			});

			bookingDetails.Add(new BookingDetail
			{
				BookingId = bookings[1].BookingId,
				RoomId = rooms[4].RoomId,
				BookingStart = new DateTime(2016, 11, 20),
				BookingEnd = new DateTime(2016, 11, 30),
				NumOfCustomer = 3,
			});
			bookingDetails.Add(new BookingDetail
			{
				BookingId = bookings[1].BookingId,
				RoomId = rooms[5].RoomId,
				BookingStart = new DateTime(2016, 11, 20),
				BookingEnd = new DateTime(2016, 11, 30),
				NumOfCustomer = 2,
			});
			bookingDetails.ForEach(b => context.BookingDetails.AddOrUpdate(b));
			#endregion
		}
	}
}
