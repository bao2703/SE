namespace BUS
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using System.Windows.Forms;
	using DAO;
	using DAO.Domain;
	using DTO;

	public static class CustomerBUS
	{
		/// <summary>
		/// Tìm mã khách hàng tiếp theo
		/// </summary>
		/// <returns></returns>
		public static string NextId()
		{
			using (var context = new HotelContext())
			{
				var query = context.Customers.OrderByDescending(c => c.CustomerId).FirstOrDefault();
				var prefixId = CustomerDTO.PrefixId;
				if (query == null)
				{
					return Utilities.NextId(string.Empty, prefixId);
				}
				return Utilities.NextId(query.CustomerId, prefixId);
			}
		}
	}
}
