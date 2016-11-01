using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
	public class PhongBUS
	{
		/// <summary>
		/// Get phòng
		/// </summary>
		/// <param name="idPhong"></param>
		/// <returns></returns>
		public static Phong Get(string idPhong)
		{
			return PhongDAO.Get(idPhong);
		}

		/// <summary>
		/// Get tất cả phòng theo loại
		/// </summary>
		/// <returns></returns>
		public static List<Phong> GetLoai(string loaiPhong)
		{
			return PhongDAO.GetLoai(loaiPhong);
		}

		public static List<Phong> GetAllPhongTrong(DateTime ngayBatDau, DateTime ngayKetThuc)
		{
			if (ngayBatDau.CompareTo(ngayKetThuc) == 1)
			{
				throw new InvalidTimeZoneException();
			}
			return PhongDAO.GetAllPhongTrong(ngayBatDau, ngayKetThuc);
		}

		/// <summary>
		/// Get tất cả phòng
		/// </summary>
		/// <returns></returns>
		public static List<Phong> GetAll()
		{
			return PhongDAO.GetAll();
		}

		
	}
}
