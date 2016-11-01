using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
	public class PhongDAO
	{
		/// <summary>
		/// Get phòng
		/// </summary>
		/// <param name="idPhong"></param>
		/// <returns></returns>
		public static Phong Get(string idPhong)
		{
			using (var data = new QLKhachSanDataContext(Connection.ConnectionString))
			{
				var query = (from table in data.PHONGs
							 where table.ID_PHONG == idPhong
							 select table).SingleOrDefault();
				if (query == null)
				{
					return null;
				}
				return new Phong(query.ID_PHONG, query.LOAI_PHONG);
			}
		}

		/// <summary>
		/// Get tất cả phòng theo loại
		/// </summary>
		/// <returns></returns>
		public static List<Phong> GetLoai(string loaiPhong)
		{
			List<Phong> result = new List<Phong>();
			using (var data = new QLKhachSanDataContext(Connection.ConnectionString))
			{
				var query = from table in data.PHONGs
							where table.LOAI_PHONG == loaiPhong
							select table;
				foreach (var item in query)
				{
					result.Add(new Phong(item.ID_PHONG, item.LOAI_PHONG));
				}
			}
			return result;
		}

		/// <summary>
		/// Get tất cả phòng
		/// </summary>
		/// <returns></returns>
		public static List<Phong> GetAll()
		{
			List<Phong> result = new List<Phong>();
			using (var data = new QLKhachSanDataContext(Connection.ConnectionString))
			{
				var query = from table in data.PHONGs
							orderby table.ID_PHONG
							select table;
				foreach (var item in query)
				{
					result.Add(new Phong(item.ID_PHONG, item.LOAI_PHONG));
				}
			}
			return result;
		}

		/// <summary>
		/// Get danh sách phòng trống
		/// </summary>
		/// <returns></returns>
		public static List<Phong> GetAllPhongTrong(DateTime ngayBatDau, DateTime ngayKetThuc)
		{
			string s = "";
			List<Phong> result = new List<Phong>();
			using (var data = new QLKhachSanDataContext(Connection.ConnectionString))
			{
				var query = from tablePhong				in data.PHONGs
							from tableDatPhong			in data.PHIEU_DAT_PHONGs
							from tableChiTietDatPhong	in data.CT_DAT_PHONGs
							where tableDatPhong.ID_DAT_PHONG == tableChiTietDatPhong.ID_DAT_PHONG
							where !((tableDatPhong.NGAY_DI.CompareTo(ngayBatDau)) < 1 || (tableDatPhong.NGAY_DEN.CompareTo(ngayKetThuc) > -1))
							where (tablePhong.ID_PHONG == tableChiTietDatPhong.ID_PHONG) && (tableChiTietDatPhong.ID_DAT_PHONG == tableDatPhong.ID_DAT_PHONG)
							select tablePhong;

				foreach (var item in query)
				{
					result.Add(new Phong(item.ID_PHONG, item.LOAI_PHONG));
				}
			}
			return result;
		}
	}
}
