using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CanadaPharmacyManagementSystem.DAL
{
    class DataAccessLayer
    {
        SqlConnection con;
        SqlCommand cmd;

        public DataAccessLayer()
        {
            if (Properties.Settings.Default.Mode == "Server")
            {
                con = new SqlConnection("Server=" + Properties.Settings.Default.serverName + ";" +
                                    "DataBase=" + Properties.Settings.Default.dataBaseName + ";" +
                                    "Integrated Security=False;" +
                                    "User ID=" + Properties.Settings.Default.ID + ";" +
                                    "Password=" + Properties.Settings.Default.psw + ";");
            }
            else
            {
                con = new SqlConnection("Server=" + Properties.Settings.Default.serverName + ";" +
                                        "DataBase=" + Properties.Settings.Default.dataBaseName + ";" +
                                        "Integrated Security=true");
            }
            
        }

        public void Open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public DataTable SelectData(string storedProcedure,SqlParameter[] param)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = storedProcedure;
            cmd.Connection = con;

            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void ExecuteCommand(string storedProcedure, SqlParameter[] param)
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = storedProcedure;

            if (param != null)
            {
                for(int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }

            Open();
            cmd.ExecuteNonQuery();
            close();
        }

    }
}
