using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
	public static class PhieuDatPhongBUS
	{
		/// <summary>
		/// Thêm phiếu đặt phòng
		/// </summary>
		/// <param name="phieuDatPhong"></param>
		/// <returns></returns>
		public static bool Add(PhieuDatPhong phieuDatPhong)
		{
			return PhieuDatPhongDAO.Add(phieuDatPhong);
		}

		public static string NextId()
		{
			return Module.NextId(PhieuDatPhongDAO.GetLastId(), PhieuDatPhong.PrefixId);
		}
	}
}
