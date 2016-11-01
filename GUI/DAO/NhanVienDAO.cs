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
				var query = (from table in data.NHAN_VIENs
							 where table.ID_NHAN_VIEN == idNhanVien
							 select table).SingleOrDefault();
				if (query == null)
				{
					return null;
				}
				return new NhanVien(query.ID_NHAN_VIEN, query.TEN_NV, query.MAT_KHAU);
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
				var query = (from table in data.NHAN_VIENs
							 where (table.ID_NHAN_VIEN == nhanVien.Id) && (table.MAT_KHAU == nhanVien.MatKhau)
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
