using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL
{
    public class DAL_Khoa
        {
            private static DAL_Khoa instance;

            public static DAL_Khoa Instance
            {

                get { if (instance == null) instance = new DAL_Khoa(); return instance; }
                private set => instance
                =
                value;
            }

            private DAL_Khoa() { }
            public bool Them(string makhoa, string tenkhoa)
            {
                string sql = "INSERT INTO Khoa (MaKhoa,TenKhoa) VALUES (@Id, @MaKhoa, @TenKhoa)";
                return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { makhoa,tenkhoa });
            }

            public bool Sua(string makhoa, string tenkhoa, int id)
            {
                string sql = "UPDATE Khoa SET MaKhoa = @MaKhoa, TenKhoa = @TenKhoa,WHERE Id = @id";
                return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { makhoa, tenkhoa, id });
            }
      
            
            public bool Xoa(int id)
            {
                string sql = "DELETE FROM Khoa WHERE Id = @id";
                return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { id });
            }

            public DataTable DanhSach()
            {
                return KetNoi.Instance.ExcuteQuery("SELECT * FROM Khoa");
            }

        }
}
