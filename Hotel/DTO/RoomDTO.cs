namespace DTO
{
	using System;
	using System.Collections.Generic;

	public class RoomDTO
	{
		public RoomDTO()
		{
		}

		public string RoomId { get; set; }

		public string TypeId { get; set; }

		public RoomTypeDTO RoomType { get; set; }
	}
}
