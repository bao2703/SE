using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
	public static class KhachHangBUS
	{
		/// <summary>
		/// Get Khách hàng
		/// </summary>
		/// <param name="idKhachHang">Mã khách hàng</param>
		/// <returns></returns>
		public static KhachHang Get(string idKhachHang)
		{
			return KhachHangDAO.Get(idKhachHang);
		}

		/// <summary>
		/// Get danh sách khách hàng
		/// </summary>
		/// <returns></returns>
		public static List<KhachHang> GetAll()
		{
			return KhachHangDAO.GetAll();
		}

		/// <summary>
		/// Thêm khách hàng
		/// </summary>
		/// <param name="khachHang"></param>
		/// <returns></returns>
		public static bool Add(KhachHang khachHang)
		{
			return KhachHangDAO.Add(khachHang);
		}

		public static string NextId()
		{
			return Module.NextId(KhachHangDAO.GetLastId(), KhachHang.PrefixId);
		}
	}
}
