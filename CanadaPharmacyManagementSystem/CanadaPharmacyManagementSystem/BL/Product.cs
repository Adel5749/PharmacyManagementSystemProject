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
    class Product:DataAccessLayer
    {
        public DataTable ProductVerifyName(int productID,string productName)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ProductID", SqlDbType.BigInt);
            param[0].Value = productID;

            param[1] = new SqlParameter("@ProductName", SqlDbType.NVarChar, 50);
            param[1].Value = productName;

            DataTable dt = SelectData("ProductVerifyName", param);
            return dt;
        }

        public void ProductAdd(string productName,string productDescription,byte[] productImage,string buyPrice,string sellPrice,
                               int catID, int am_ID,int sn_ID   ,string barcode)
        {
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@ProductName", SqlDbType.NVarChar, 50);
            param[0].Value = productName;

            param[1] = new SqlParameter("@ProductDescription", SqlDbType.NVarChar);
            param[1].Value = productDescription;

            param[2] = new SqlParameter("@ProductImage", SqlDbType.Image);
            param[2].Value = productImage;

            param[3] = new SqlParameter("@BuyPrice", SqlDbType.VarChar,50);
            param[3].Value = buyPrice;

            param[4] = new SqlParameter("@SellPrice", SqlDbType.VarChar, 50);
            param[4].Value = sellPrice;

            param[5] = new SqlParameter("@CatID", SqlDbType.Int);
            param[5].Value = catID;

            param[6] = new SqlParameter("@AM_ID", SqlDbType.Int);
            param[6].Value = am_ID;

            param[7] = new SqlParameter("@Sn_ID", SqlDbType.Int);
            param[7].Value = sn_ID;

            param[8] = new SqlParameter("@Barcode", SqlDbType.VarChar, 50);
            param[8].Value = barcode;

            ExecuteCommand("ProductAdd", param);

        }

        public DataTable ProductSearch(string search)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Search", SqlDbType.NVarChar, 50);
            param[0].Value = search;

            DataTable dt = SelectData("ProductSearch", param);
            return dt;
        }

    }
}
