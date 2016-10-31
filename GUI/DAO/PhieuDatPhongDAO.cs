using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DTO;

namespace DAO
{
	public static class PhieuDatPhongDAO
	{
		/// <summary>
		/// Thêm phiếu đặt phòng
		/// </summary>
		/// <param name="phieuDatPhong"></param>
		/// <returns></returns>
		public static bool Add(PhieuDatPhong phieuDatPhong)
		{
			using (var transaction = new TransactionScope())
			{
				using (var data = new QLKhachSanDataContext(Connection.ConnectionString))
				{
					try
					{
						PHIEU_DAT_PHONG temp = new PHIEU_DAT_PHONG();
						temp.ID_DAT_PHONG = phieuDatPhong.Id;
						temp.ID_KHACH_HANG = phieuDatPhong.KhachHang.Id;
						temp.ID_NHAN_VIEN = phieuDatPhong.NhanVien.Id;
						temp.NGAY_DAT = phieuDatPhong.NgayDat;
						temp.TONG_SO_KHACH = phieuDatPhong.SoLuongKhach;
						temp.TONG_SO_PHONG = phieuDatPhong.SoLuongPhong;
						data.PHIEU_DAT_PHONGs.InsertOnSubmit(temp);
						data.SubmitChanges();
						ChiTietDatPhongDAO.Add(phieuDatPhong);
						transaction.Complete();
					}
					catch (Exception)
					{
						return false;
					}
				}
				return true;
			}
		}

		public static string GetLastId()
		{
			using (var data = new QLKhachSanDataContext(Connection.ConnectionString))
			{
				var query = (from table in data.PHIEU_DAT_PHONGs
							 orderby table.ID_DAT_PHONG descending
							 select table).FirstOrDefault();
				if (query == null)
				{
					return "";
				}
				return query.ID_DAT_PHONG;
			}
		}
	}
}
