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
    class ScientificName:DataAccessLayer
    {
        public DataTable ScientificNameVerifyName(int scientificID,string scientificName)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ScientificID", SqlDbType.Int);
            param[0].Value = scientificID;

            param[1] = new SqlParameter("@ScientificName", SqlDbType.NVarChar, 50);
            param[1].Value = scientificName;

            DataTable dt = SelectData("ScientificNameVerifyName", param);
            return dt;
        } 

        public DataTable ScientificNameSearch(string srch)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Search", SqlDbType.NVarChar, 50);
            param[0].Value = srch;

            DataTable dt = SelectData("ScientificNameSearch", param);
            return dt;
        }

        public void ScientificNameAdd(string scientificName)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ScientificName", SqlDbType.NVarChar, 50);
            param[0].Value = scientificName;

            ExecuteCommand("ScientificNameAdd", param);
        }

        public void ScientificNameUpdate(int scientificID,string scientificName)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ScientificID", SqlDbType.Int);
            param[0].Value = scientificID;

            param[1] = new SqlParameter("@ScientificName", SqlDbType.NVarChar, 50);
            param[1].Value = scientificName;

            ExecuteCommand("ScientificNameUpdate", param);
        }

        public void ScientificNameDelete(int scientificID)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ScientificID", SqlDbType.Int);
            param[0].Value = scientificID;

            ExecuteCommand("ScientificNameDelete", param);
        }
    }
}
