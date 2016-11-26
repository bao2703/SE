namespace BUS
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using DAO;

	public static class Utilities
	{
		public static bool IsValidStartAndEndDate(DateTime start, DateTime end)
		{
			return start.CompareTo(end) == -1;
		}

		/// <summary>
		/// Tìm mã kế tiếp
		/// </summary>
		/// <param name="lastId">Mã cuối cùng</param>
		/// <param name="prefixId">Tiền tố mã</param>
		/// <returns></returns>
		public static string NextId(string lastId, string prefixId)
		{
			if (lastId == string.Empty)
			{
				return prefixId + "0001";  // fix width default
			}
			int nextId = int.Parse(lastId.Remove(0, prefixId.Length)) + 1;
			int lengthNumerID = lastId.Length - prefixId.Length;
			string zeroNumber = string.Empty;
			for (int i = 1; i <= lengthNumerID; i++)
			{
				if (nextId < Math.Pow(10, i))
				{
					for (int j = 1; j <= lengthNumerID - i; i++)
					{
						zeroNumber += "0";
					}
					return prefixId + zeroNumber + nextId.ToString();
				}
			}
			return prefixId + nextId;
		}
	}
}
