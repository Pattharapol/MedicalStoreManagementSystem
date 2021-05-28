using System;
using System.Data;

namespace MedicalStoreManagementSystem.Code
{
    public static class CommonCodeClass
    {
        public static string GetThaiDateTime(string datetime)
        {
            // แปลงให้เป็นค่าปกติ เพราะเครื่องใช้ format English ไม่ได้ มีบางโปรแกรม ไม่รองรับ format อื่น ต้องไทยเท่านั้น
            // ข้อมูลจากฐานจะเป็น xx-xx-2564 พอเอาขึ้นมาแสดง จะเป็น xx-xx-3107 มันจะบวกไปอีก 543 เลยต้องลบกันก่อนแสดง
            string year = Convert.ToDateTime(datetime).ToString("dd-MM-yyyy").Substring(6);
            int year1 = Convert.ToInt32(year) - 543;
            string year2 = Convert.ToDateTime(datetime).ToString("dd-MM-") + year1;
            return year2;
        }

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
                string query = string.Format(@"SELECT batch_no, quantity FROM Stock WHERE batch_no = (SELECT batch_no FROM Purchase_Details WHERE med_ID = '{0}' group by batch_no)", productID);
                dt = DataAccessLayer.Retreiving(query);
            }
            if (Type == "G")
            {
                productID = DataAccessLayer.Retreiving(string.Format(@"SELECT gen_ID FROM General WHERE gen_Name = '{0}'", productName)).Rows[0][0].ToString();
                string query = string.Format(@"SELECT batch_no, quantity FROM Stock WHERE batch_no = (SELECT batch_no FROM Purchase_Details WHERE gen_ID = '{0}' group by batch_no)", productID);
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

        public static string GetGeneralID(string generalName)
        {
            string query = string.Format(@"SELECT gen_ID FROM General WHERE gen_Name = '{0}'", generalName);
            return DataAccessLayer.Retreiving(query).Rows[0][0].ToString();
        }

        public static string GetGeneralName(string generalID)
        {
            string query = string.Format(@"SELECT gen_Name FROM General WHERE gen_ID = '{0}'", generalID);
            return DataAccessLayer.Retreiving(query).Rows[0][0].ToString();
        }

        public static string GetMedicineID(string medicineName)
        {
            string query = string.Format(@"SELECT medID FROM Medicines WHERE med_Name = '{0}'", medicineName);
            return DataAccessLayer.Retreiving(query).Rows[0][0].ToString();
        }

        public static string GetMedicineName(string medicineID)
        {
            string query = string.Format(@"SELECT med_Name FROM Medicines WHERE medID = '{0}'", medicineID);
            return DataAccessLayer.Retreiving(query).Rows[0][0].ToString();
        }

        public static void StockManagement(string batchNo, string quantity, string salePrice, string Description)
        {
            DataTable dt = new DataTable();
            string query = "";
            dt = DataAccessLayer.Retreiving(string.Format(@"SELECT * FROM Stock WHERE batch_No = '{0}'", batchNo));
            if (dt.Rows.Count == 0)
            {
                query = string.Format(@"INSERT INTO Stock(batch_No, quantity, salePrice, description) VALUES ('{0}','{1}','{2}','{3}')", batchNo, quantity, salePrice, Description);
            }
            else
            {
                query = string.Format(@"UPDATE Stock SET quantity = quantity + '{0}', salePrice = '{1}', description = '{2}' WHERE batch_No = '{3}'", quantity, salePrice, Description, batchNo);
            }
            DataAccessLayer.Execute(query);
        }
    }
}