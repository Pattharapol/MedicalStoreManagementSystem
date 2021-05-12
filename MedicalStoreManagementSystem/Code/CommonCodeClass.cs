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
    }
}
