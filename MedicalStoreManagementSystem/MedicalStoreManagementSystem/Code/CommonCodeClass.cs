using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagementSystem.Code
{
    public class CommonCodeClass
    {
        public static string GetCategoryName(string CategoryID)
        {
            string sql = string.Format(@"SELECT categoryName FROM Categories WHERE categoryID = '{0}'", CategoryID);
            return DataAccessLayer.Retreiving(sql).Rows[0][0].ToString();
        }

        public static string GetCategoryID(string CategoryName)
        {
            string sql = string.Format(@"SELECT categoryID FROM Categories WHERE categoryName = '{0}'", CategoryName);
            return DataAccessLayer.Retreiving(sql).Rows[0][0].ToString();
        }

        public static DataTable GetAllCategory()
        {
            string sql = string.Format(@"SELECT categoryName FROM Categories");
            return DataAccessLayer.Retreiving(sql);
        }

        public static DataTable GetProductCurrentDetail(string productName, string Type)
        {
            DataTable dt = new DataTable();
            string productID = "";
            if(Type == "M")
            {
                productID = DataAccessLayer.Retreiving(string.Format(@"SELECT medID FROM Medicines WHERE med_Name = '{0}'", productName)).Rows[0][0].ToString();
                string query = string.Format(@"SELECT batch_no, quantity, salePrice FROM Stock WHERE batch_no = (SELECT batch_no FROM Purchase_Details WHERE med_ID = '{0}')", productID);
                dt = DataAccessLayer.Retreiving(query);
            }
            if (Type == "G")
            {
                productID = DataAccessLayer.Retreiving(string.Format(@"SELECT gen_ID FROM General WHERE gen_Name = '{0}'", productName)).Rows[0][0].ToString();
                string query = string.Format(@"SELECT batch_no, quantity, salePrice FROM Stock WHERE batch_no = (SELECT batch_no FROM Purchase_Details WHERE gen_ID = '{0}')", productID);
                dt = DataAccessLayer.Retreiving(query);
            }

            return dt;
            
        }
    }
}
