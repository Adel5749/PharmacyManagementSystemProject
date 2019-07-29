using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanadaPharmacyManagementSystem.DAL;
using System.Data;
using System.Data.SqlClient;

namespace CanadaPharmacyManagementSystem.BL
{
    class User:DataAccessLayer
    {
        public DataTable UserLogin(string userName,string userPassword)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[0].Value = userName;

            param[1] = new SqlParameter("@UserPassword", SqlDbType.VarChar, 50);
            param[1].Value = userPassword;

            DataTable dt= SelectData("UserLogin", param);
            return dt;
        }
    }
}
