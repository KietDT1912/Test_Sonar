using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDTO;
using System.Data;
using System.Data.SqlClient;
namespace DBUtil
{
    public class StudentDAO
    {
        DBUtil db;
        SqlDataAdapter da;
        SqlCommand cmd;

        public StudentDAO()
        {
            db = new DBUtil();
        }
        
        public DataTable getAll()
        {
            string sql = "select * from Svien";   // Lay toan bo sinh vien 
            SqlConnection con = db.GetConnection();  // Tao ket noi toi SQL

            da = new SqlDataAdapter(sql, con);

            con.Open(); // Mo ket noi

            // Do du lieu tu SqlDataAdapter vao DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close(); // Dong ket noi
            return dt;
        }

        public DataTable getAllMaKH()
        {
            string sql = "SELECT [MAKHOA] ,[TENKHOA] FROM [dbo].[KHOA]";   // Lay toan bo ma khoa
            SqlConnection con = db.GetConnection();  // Tao ket noi toi SQL

            da = new SqlDataAdapter(sql, con);

            con.Open(); // Mo ket noi

            // Do du lieu tu SqlDataAdapter vao DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close(); // Dong ket noi
            return dt;
        }

        public bool deleteSV(ref Student sv)
        {
            string sql = "DELETE FROM [dbo].[SVIEN] WHERE MASV = @MASV";
            SqlConnection con = db.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MASV", SqlDbType.Int).Value = sv.MaSV;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool AddNew(ref Student sv)
        {
            string sql = "INSERT INTO [dbo].[SVIEN] ([TEN],[MASV],[NAM],[MAKH]) VALUES(@TEN, @MASV, @NAM, @MAKH)";
            SqlConnection con = db.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TEN", SqlDbType.VarChar).Value = sv.Name;
                cmd.Parameters.Add("@MASV", SqlDbType.Int).Value = sv.MaSV;
                cmd.Parameters.Add("@NAM", SqlDbType.Int).Value = sv.Nam;
                cmd.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = sv.MaKH;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Update(ref Student sv)
        {
            string sql = "UPDATE [dbo].[SVIEN] SET [TEN] = @TEN,[MASV] = @MASV, [NAM] = @NAM, [MAKH] = @MAKH WHERE MASV = @MASV";
            SqlConnection con = db.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TEN", SqlDbType.VarChar).Value = sv.Name;
                cmd.Parameters.Add("@MASV", SqlDbType.Int).Value = sv.MaSV;
                cmd.Parameters.Add("@NAM", SqlDbType.Int).Value = sv.Nam;
                cmd.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = sv.MaKH;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
