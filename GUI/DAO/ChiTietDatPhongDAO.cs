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
		public static bool Add(PhieuDatPhong phieuDatPhong)
		{
			using (var data = new QLKhachSanDataContext(Connection.ConnectionString))
			{
				try
				{
					List<CT_DAT_PHONG> listChiTietDatPhong = new List<CT_DAT_PHONG>();
					CT_DAT_PHONG temp;
					foreach (var item in phieuDatPhong.ChiTietDatPhong)
					{
						temp = new CT_DAT_PHONG();
						temp.ID_DAT_PHONG = phieuDatPhong.Id;
						temp.ID_PHONG = item.Phong.Id;
						temp.SO_KHACH = item.SoLuongKhach;
						temp.NGAY_DEN = item.NgayDen;
						temp.NGAY_DI = item.NgayDi;
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
