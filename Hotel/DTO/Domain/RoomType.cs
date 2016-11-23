namespace DTO.Domain
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.Spatial;

	public enum TypeOfRoom
	{
		A,
		B,
		C,
		D
	}

	public partial class RoomType
	{
		public RoomType()
		{
			Rooms = new HashSet<Room>();
			TypePriceDetails = new HashSet<TypePriceDetail>();
		}

		[Key]
		[StringLength(10)]
		public string TypeId { get; set; }

		public TypeOfRoom TypeName { get; set; }

		public virtual ICollection<Room> Rooms { get; set; }

		public virtual ICollection<TypePriceDetail> TypePriceDetails { get; set; }
	}
}
