using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum TypeOfRoom
{
	A,
	B,
	C,
	D
}

namespace DTO
{
	public class RoomTypeDTO
	{
		public RoomTypeDTO()
		{
		}

		public string TypeId { get; set; }

		public TypeOfRoom TypeName { get; set; }
	}
}
