using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
	public static class NhanVienBUS
	{
		/// <summary>
		/// Get Nhân viên
		/// </summary>
		/// <param name="idHocVien">Mã nhân viên</param>
		/// <returns></returns>
		public static NhanVien Get(string idNhanVien)
		{
			return NhanVienDAO.Get(idNhanVien);
		}

		/// <summary>
		/// Kiểm tra thông tin đăng nhập của Nhân viên
		/// </summary>
		/// <param name="nhanVien"></param>
		/// <returns></returns>
		public static bool IsValid(NhanVien nhanVien)
		{
			return NhanVienDAO.IsValid(nhanVien);
		}
	}
}
