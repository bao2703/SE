using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DTO.BindingModel
{
	public class RoomBindingModel
	{
		public RoomBindingModel()
		{ 
		}

        public string RoomId { get; set; }

		public TypeOfRoom TypeName { get; set; }
	}
}
