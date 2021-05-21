using System;
using System.Data;

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
            if (Type == "M")
            {
                productID = DataAccessLayer.Retreiving(string.Format(@"SELECT medID FROM Medicines WHERE med_Name = '{0}'", productName)).Rows[0][0].ToString();
                string query = string.Format(@"SELECT batch_no, quantity FROM Stock WHERE batch_no = (SELECT batch_no FROM Purchase_Details WHERE med_ID = '{0}')", productID);
                dt = DataAccessLayer.Retreiving(query);
            }
            if (Type == "G")
            {
                productID = DataAccessLayer.Retreiving(string.Format(@"SELECT gen_ID FROM General WHERE gen_Name = '{0}'", productName)).Rows[0][0].ToString();
                string query = string.Format(@"SELECT batch_no, quantity FROM Stock WHERE batch_no = (SELECT batch_no FROM Purchase_Details WHERE gen_ID = '{0}')", productID);
                dt = DataAccessLayer.Retreiving(query);
            }

            return dt;
        }

        public static void GetBatchNo(string productName, string Type, out bool AutoIncrementStatus, out string PBatch_no)
        {
            DataTable dt = new DataTable();
            DataTable BatchNo = new DataTable();
            AutoIncrementStatus = false;
            int batch_no;
            string batchNo = "";
            string productID = "";
            if (Type == "M")
            {
                productID = DataAccessLayer.Retreiving(string.Format(@"SELECT medID FROM Medicines WHERE med_Name = '{0}'", productName)).Rows[0][0].ToString();
                string query = string.Format(@"SELECT batch_no FROM Purchase_Details WHERE med_ID = '{0}' group by batch_no", productID);
                dt = DataAccessLayer.Retreiving(query);
                if (dt.Rows.Count == 0)
                {
                    BatchNo = DataAccessLayer.Retreiving("SELECT MAX(batch_no) FROM Purchase_Details");
                    if (BatchNo.Rows.Count == 0)
                    {
                        batchNo = "1";
                        AutoIncrementStatus = true;
                    }
                    else
                    {
                        int.TryParse(BatchNo.Rows[0][0].ToString(), out batch_no);
                        batchNo = Convert.ToString(batch_no + 1);
                        AutoIncrementStatus = true;
                    }
                }
                else
                {
                    batchNo = dt.Rows[0][0].ToString();
                    AutoIncrementStatus = false;
                }
            }
            if (Type == "G")
            {
                productID = DataAccessLayer.Retreiving(string.Format(@"SELECT gen_ID FROM General WHERE gen_Name = '{0}'", productName)).Rows[0][0].ToString();
                string query = string.Format(@"SELECT batch_no FROM Purchase_Details WHERE gen_ID = '{0}' group by batch_no", productID);
                dt = DataAccessLayer.Retreiving(query);
                if (dt.Rows.Count == 0)
                {
                    BatchNo = DataAccessLayer.Retreiving("SELECT MAX(batch_no) FROM Purchase_Details");
                    if (BatchNo.Rows.Count == 0)
                    {
                        batchNo = "1";
                        AutoIncrementStatus = true;
                    }
                    else
                    {
                        int.TryParse(BatchNo.Rows[0][0].ToString(), out batch_no);
                        batchNo = Convert.ToString(batch_no + 1);
                        AutoIncrementStatus = true;
                    }
                }
                else
                {
                    batchNo = dt.Rows[0][0].ToString();
                    AutoIncrementStatus = false;
                }
            }

            PBatch_no = batchNo;
        }
    }
}