using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
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
