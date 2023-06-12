﻿using IntelligenceTestDAL;
using System.Data.SqlClient;

namespace BlazorServerAuthenticationAndAuthorization.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users;
        
        public UserAccountService()
        {
            SqlConnection con = DBhelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetUsernameAndPass", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            _users = new List<UserAccount>();
            while (dr.Read())
            {
                UserAccount _user = new UserAccount();
                _user.UserName = dr["UserName"].ToString();
                _user.Password = dr["Password"].ToString();
                _user.Role = "User";
                _users.Add(_user);
            }
            con.Close();
        }

        public UserAccount? GetByUserName(string userName)
        {
            return _users.FirstOrDefault(x => x.UserName == userName);
        }
    }
}
