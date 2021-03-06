namespace DAO
{
	using System;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity;
	using System.Linq;
	using DAO.Domain;

	public partial class HotelContext : DbContext
	{
		public HotelContext() : base(Connection.ConnectionString)
		{
		}

		public virtual DbSet<BookingDetail> BookingDetails { get; set; }

		public virtual DbSet<Booking> Bookings { get; set; }

		public virtual DbSet<CheckInDetail> CheckInDetails { get; set; }

		public virtual DbSet<CheckIn> CheckIns { get; set; }

		public virtual DbSet<Customer> Customers { get; set; }

		public virtual DbSet<Employee> Employees { get; set; }

		public virtual DbSet<Invoice> Invoices { get; set; }

		public virtual DbSet<Report> Reports { get; set; }

		public virtual DbSet<Room> Rooms { get; set; }

		public virtual DbSet<RoomType> RoomTypes { get; set; }

		public virtual DbSet<ServiceDetail> ServiceDetails { get; set; }

		public virtual DbSet<Service> Services { get; set; }

		public virtual DbSet<TypePriceDetail> TypePriceDetails { get; set; }

		public virtual DbSet<TypePrice> TypePrices { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Booking>()
				.HasMany(e => e.BookingDetails)
				.WithRequired(e => e.Booking)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<CheckInDetail>()
				.Property(e => e.RoomPrice)
				.HasPrecision(18, 0);

			modelBuilder.Entity<CheckIn>()
				.HasMany(e => e.CheckInDetails)
				.WithRequired(e => e.CheckIn)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<CheckIn>()
				.HasMany(e => e.Invoices)
				.WithRequired(e => e.CheckIn)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<CheckIn>()
				.HasMany(e => e.ServiceDetails)
				.WithRequired(e => e.CheckIn)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Customer>()
				.HasMany(e => e.Bookings)
				.WithRequired(e => e.Customer)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Customer>()
				.HasMany(e => e.CheckIns)
				.WithRequired(e => e.Customer)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Employee>()
				.HasMany(e => e.Bookings)
				.WithRequired(e => e.Employee)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Employee>()
				.HasMany(e => e.CheckIns)
				.WithRequired(e => e.Employee)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Employee>()
				.HasMany(e => e.Invoices)
				.WithRequired(e => e.Employee)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.TotalPrice)
				.HasPrecision(18, 0);

			modelBuilder.Entity<Room>()
				.HasMany(e => e.BookingDetails)
				.WithRequired(e => e.Room)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Room>()
				.HasMany(e => e.CheckInDetails)
				.WithRequired(e => e.Room)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<RoomType>()
				.HasMany(e => e.TypePriceDetails)
				.WithRequired(e => e.RoomType)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<ServiceDetail>()
				.Property(e => e.ServicePrice)
				.HasPrecision(18, 0);

			modelBuilder.Entity<Service>()
				.Property(e => e.Price)
				.HasPrecision(18, 0);

			modelBuilder.Entity<Service>()
				.HasMany(e => e.ServiceDetails)
				.WithRequired(e => e.Service)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<TypePrice>()
				.Property(e => e.Price)
				.HasPrecision(18, 0);

			modelBuilder.Entity<TypePrice>()
				.HasMany(e => e.TypePriceDetails)
				.WithRequired(e => e.TypePrice)
				.WillCascadeOnDelete(false);
		}
	}
}
