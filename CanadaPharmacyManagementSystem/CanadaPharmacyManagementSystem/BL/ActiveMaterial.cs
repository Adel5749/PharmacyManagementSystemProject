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
    class ActiveMaterial:DataAccessLayer
    {
        public DataTable ActiveMaterialVerifyName(int activeMaterialID,string activeMaterialName)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ActiveMaterialID", SqlDbType.Int);
            param[0].Value = activeMaterialID;

            param[1] = new SqlParameter("@ActiveMaterialName", SqlDbType.NVarChar, 50);
            param[1].Value = activeMaterialName;

            DataTable dt = SelectData("ActiveMaterialVerifyName", param);
            return dt;
        }

        public void ActiveMaterialAdd(string activeMaterialName,string activeMaterialDesc)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ActiveMaterialName", SqlDbType.NVarChar, 50);
            param[0].Value = activeMaterialName;

            param[1] = new SqlParameter("@ActiveMaterialDesc", SqlDbType.NVarChar);
            param[1].Value = activeMaterialDesc;

            ExecuteCommand("ActiveMaterialAdd", param);
        }

        public DataTable ActiveMaterialSearch(string search)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Search", SqlDbType.NVarChar, 50);
            param[0].Value = search;

            DataTable dt = SelectData("ActiveMaterialSearch", param);
            return dt;
        }

        public void ActiveMaterialUpdate(int activeMaterialID,string activeMaterialName,string activeMaterialDesc)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@ActiveMaterialID", SqlDbType.Int);
            param[0].Value = activeMaterialID;

            param[1] = new SqlParameter("@ActiveMaterialName", SqlDbType.NVarChar, 50);
            param[1].Value = activeMaterialName;

            param[2] = new SqlParameter("@ActiveMaterialDesc", SqlDbType.NVarChar);
            param[2].Value = activeMaterialDesc;

            ExecuteCommand("ActiveMaterialUpdate", param);
        }

        public void ActiveMaterialDelete(int activeMaterialID)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ActiveMaterialID", SqlDbType.Int);
            param[0].Value = activeMaterialID;

            ExecuteCommand("ActiveMaterialDelete", param);
        }
    }
}
