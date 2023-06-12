using IntelligenceTestModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligenceTestDAL
{
    public class RegistrationDAL
    {
        public static int SaveUser(RegistrationModel rm)
        {
            SqlConnection con = DBhelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_SaveUser", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", rm.Name);
            cmd.Parameters.AddWithValue("@Address", rm.Address);
            cmd.Parameters.AddWithValue("@Email", rm.Email);
            cmd.Parameters.AddWithValue("@Contact", rm.Contact);
            cmd.Parameters.AddWithValue("@Username", rm.Username);
            cmd.Parameters.AddWithValue("@Password", rm.Password);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
