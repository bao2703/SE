using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
	public static class NhanVienDAO
	{
		/// <summary>
		/// Get Nhân viên
		/// </summary>
		/// <param name="idNhanVien">Mã nhân viên</param>
		/// <returns></returns>
		public static NhanVien Get(string idNhanVien)
		{
			using (var data = new QLKhachSanDataContext(Connection.ConnectionString))
			{
				var query = (from table in data.Nhan_Viens
							 where table.Ma_Nhan_Vien == idNhanVien
							 select table).SingleOrDefault();
				if (query == null)
				{
					return new NhanVien();
				}
				return new NhanVien(query.Ma_Nhan_Vien, query.Ten_Nhan_Vien, query.Mat_Khau);
			}
		}

		/// <summary>
		/// Kiểm tra thông tin đăng nhập của Nhân viên
		/// </summary>
		/// <param name="nhanVien"></param>
		/// <returns></returns>
		public static bool IsValid(NhanVien nhanVien)
		{
			using (var data = new QLKhachSanDataContext(Connection.ConnectionString))
			{
				var query = (from table in data.
							 where (table.Ma_Nhan_Vien == nhanVien.Id) && (table.Mat_Khau == nhanVien.MatKhau)
							 select table).SingleOrDefault();
				if (query == null)
				{
					return false;
				}
				return true;
			}
		}
	}
}
