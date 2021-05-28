using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagementSystem.Code
{
    public class DatabaseInitializer : DataAccessLayer
    {
        public static void RegisterAdmin()
        {
            DataTable dt = new DataTable();
            dt = Retreiving("SELECT * FROM Users WHERE userType = 'Admin' AND contactNo = '065-0735610' ");
            if(dt.Rows.Count > 0)
            {
                return;
            }
            string sql = string.Format(@"INSERT INTO Users(userType, userName, password, contactNo, description) VALUES ('Admin', 'Admin', 'Admin', '065-0735610', 'AdministratorTIKK')");
            Execute(sql);
        }
    }
}
