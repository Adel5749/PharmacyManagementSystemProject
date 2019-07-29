using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CanadaPharmacyManagementSystem.DAL;

namespace CanadaPharmacyManagementSystem.BL
{
    class Category:DataAccessLayer
    {
        public DataTable CategoryVerifyName(string categoryName)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CategoryName", SqlDbType.NVarChar, 50);
            param[0].Value = categoryName;

            DataTable dt = SelectData("CategoryVerifyName", param);
            return dt;
        }

        public void CategoryAdd(string categoryName)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CategoryName", SqlDbType.NVarChar, 50);
            param[0].Value = categoryName;

            ExecuteCommand("CategoryAdd", param);
        }

        public DataTable CategoryGetAll()
        {
            DataTable dt = SelectData("CategoryGetAll", null);
            return dt;
        }

        public DataTable CategorySearch(string search)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Search", SqlDbType.NVarChar, 50);
            param[0].Value = search;

            DataTable dt = SelectData("CategorySearch", param);
            return dt;
        }

        public void CategoryUpdate(int categoryID,string categoryName)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@CategoryID", SqlDbType.Int);
            param[0].Value = categoryID;

            param[1] = new SqlParameter("@CategoryName", SqlDbType.NVarChar, 50);
            param[1].Value = categoryName;

            ExecuteCommand("CategoryUpdate", param);

        }

        public void CategoryDelete(int categoryID)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CategoryID", SqlDbType.Int);
            param[0].Value = categoryID;

            ExecuteCommand("CategoryDelete", param);

        }
    }
}
