using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyCafe.BD_Layer;

namespace QuanLyCafe.BS_Layer
{
    class BLBillInfo
    {
        DBMain db = null;
        public BLBillInfo()
        {
            db = new DBMain();
        }
        public DataSet LayBillInfo(string Id)
        {
            return db.ExecuteQueryDataSet("select BillInfo.id, BillInfo.idBill, Food.name, BillInfo.count from Food inner join BillInfo on Food.id = BillInfo.idFood where BillInfo.idBill = '" + Id + "'", CommandType.Text);
        }

        public bool ThemBillInfo(string id, string idBill, string Food, int count, ref string err)
        {
            DataSet ds = db.ExecuteQueryDataSet("select * from Food where name  = N'" + Food + "'", CommandType.Text);
            string idFood = null;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                idFood = row["id"].ToString();
            }
            string sqlString = "Insert Into BillInfo Values('" + id + "',N'" + idBill + "',N'" + idFood + "', " + count + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool XoaBillInfo(string id, ref string err)
        {
        string sqlString = "Delete From BillInfo Where id = '" + id + "'";
        return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool SuaBillInfo(string id, string idBill, string Food, int count, ref string err)
        {
            DataSet ds = db.ExecuteQueryDataSet("select * from Food where name  = N'" + Food + "'", CommandType.Text);
            string idFood = null;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                idFood = row["id"].ToString();
            }
            string sqlString = "Update BillInfo Set  idFood = '" + idFood + "', count = " + count + "  Where id = '" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public double TotalPay(string id)
        {
            double tong = 0;
            DataSet ds = db.ExecuteQueryDataSet("select SUM(BillInfo.count*Food.price) as total from Food inner join BillInfo on BillInfo.idFood = Food.id where BillInfo.idBill  = N'" + id + "'", CommandType.Text);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                try
                {
                    tong = (double)row["total"];
                }
                catch
                {
                    return tong = 0;
                }
                
            }
            return tong;
        }
    }
}
