namespace DTO
{
	using System;
	using System.Collections.Generic;

	public enum TypeOfRoom
	{
		A,
		B,
		C,
		D
	}

	public class RoomTypeDTO
	{
		public RoomTypeDTO()
		{
		}

		public string TypeId { get; set; }

		public TypeOfRoom TypeName { get; set; }
	}
}
