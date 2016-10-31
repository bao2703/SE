using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
	public class KhachHangDAO
	{
		/// <summary>
		/// Get Khách hàng
		/// </summary>
		/// <param name="idKhachHang">Mã khách hàng</param>
		/// <returns></returns>
		public static KhachHang Get(string idKhachHang)
		{
			using (var data = new QLKhachSanDataContext(Connection.ConnectionString))
			{
				var query = (from table in data.KHACH_HANGs
							 where table.ID_KHACH_HANG == idKhachHang
							 select table).SingleOrDefault();
				if (query == null)
				{
					return new KhachHang();
				}
				return new KhachHang(query.ID_KHACH_HANG, query.TEN, query.DIA_CHI, query.SDT, query.FAX, query.TELEX);
			}
		}

		/// <summary>
		/// Get danh sách khách hàng
		/// </summary>
		/// <returns></returns>
		public static List<KhachHang> GetAll()
		{
			List<KhachHang> result = new List<KhachHang>();
			using (var data = new QLKhachSanDataContext(Connection.ConnectionString))
			{
				var query = from table in data.KHACH_HANGs
							 orderby table.ID_KHACH_HANG
							 select table;

				foreach (var item in query)
				{
					result.Add(new KhachHang(item.ID_KHACH_HANG, item.TEN, item.DIA_CHI, item.SDT, item.FAX, item.TELEX));
				}
				return result;
			}
		}

		/// <summary>
		/// Thêm khách hàng
		/// </summary>
		/// <param name="khachHang"></param>
		/// <returns></returns>
		public static bool Add(KhachHang khachHang)
		{
			using (var data = new QLKhachSanDataContext(Connection.ConnectionString))
			{
				try
				{
					KHACH_HANG temp = new KHACH_HANG();
					temp.ID_KHACH_HANG = khachHang.Id;
					//temp.ID_PHONG = ; must change this later
					temp.TEN = khachHang.Ten;
					temp.DIA_CHI = khachHang.DiaChi;
					temp.SDT = khachHang.SoDienThoai;
					temp.FAX = khachHang.Fax;
					temp.TELEX = khachHang.Telex;

					data.KHACH_HANGs.InsertOnSubmit(temp);
					data.SubmitChanges();
				}
				catch (Exception)
				{
					return false;
				}
				return true;
			}
		}

		public static string GetLastId()
		{
			using (var data = new QLKhachSanDataContext(Connection.ConnectionString))
			{
				var query = (from table in data.KHACH_HANGs
							 orderby table.ID_KHACH_HANG descending
							 select table).FirstOrDefault();
				if (query == null)
				{
					return "";
				}
				return query.ID_KHACH_HANG;
			}
		}
	}
}
