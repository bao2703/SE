using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
	public static class ChiTietDatPhongDAO
	{
		/// <summary>
		/// Thêm danh sách Chi tiết đặt phòng
		/// </summary>
		/// <param name="chiTietDatPhong"></param>
		/// <returns></returns>
		public static bool Add(List<ChiTietDatPhong> chiTietDatPhong)
		{
			using (var data = new QLKhachSanDataContext(Connection.ConnectionString))
			{
				try
				{
					List<CT_DAT_PHONG> listChiTietDatPhong = new List<CT_DAT_PHONG>();
					CT_DAT_PHONG temp;
					foreach (var item in chiTietDatPhong)
					{
						temp = new CT_DAT_PHONG();
						temp.ID_DAT_PHONG = item.IdPhieuDatPhong;
						temp.ID_PHONG = item.IdPhong;
						temp.SO_KHACH = item.SoLuongKhach;
						listChiTietDatPhong.Add(temp);
					}
					data.CT_DAT_PHONGs.InsertAllOnSubmit(listChiTietDatPhong);
					data.SubmitChanges();
				}
				catch (Exception)
				{
					return false;
				}
			}
			return true;
		}
	}
}
