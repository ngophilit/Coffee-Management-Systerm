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
    class BLBill
    {
        DBMain db = null;
        public BLBill()
        {
            db = new DBMain();
        }
        public DataSet ThongKeBill(DateTime DateFrom, DateTime DateTo, ref string err)
        {
            return db.ExecuteQueryDataSet("select BillInfo.IdBill,TableFood.name,Bill.dateCheckOut, SUM(BillInfo.count*Food.price) as total from BillInfo inner join Food on BillInfo.idFood = Food.id inner join Bill on BillInfo.idBill = Bill.id inner join TableFood on TableFood.id = Bill.idTable where Bill.dateCheckOut >= '" + DateFrom + "' and Bill.dateCheckOut <= '" + DateTo + "' Group by BillInfo.idBill, TableFood.name,Bill.dateCheckOut", CommandType.Text);
        }
        public DataSet LayBill()
        {
            return db.ExecuteQueryDataSet("select * from Bill", CommandType.Text);
        }

        public bool ThemBill(string id, DateTime DateIn, DateTime DateOut, string idTable, ref string err)
        {
            string sqlString = "Insert Into Bill Values('" + id + "','" + DateIn + "','" + DateOut + "', N'" + idTable + "','0')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err); 
        }

        public bool XoaBill(string id, ref string err)
        {
            string sqlString = "Delete From Bill Where id = '" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool SuaBill(string id, DateTime DateIn, DateTime DateOut, string idTable,string status, ref string err)
        {
            string st = null;
            if(status == "Đã thanh toán")
            {
                st = "1";
            }    
            else
            {
                st = "0";
            }
            string sqlString = "Update Bill Set dateCheckIn ='" + DateIn + "', dateCheckOut = '" + DateOut + "', idTable = N'" + idTable + "', status = N'" + st + "'  Where id = '" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        public bool PayBill(string id, ref string err)
        {
            string sqlString = "Update Bill Set  status = '1'  Where id = '" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
