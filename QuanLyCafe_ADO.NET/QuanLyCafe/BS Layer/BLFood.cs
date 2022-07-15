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
    class BLFood
    {
        DBMain db = null;
        public BLFood()
        {
            db = new DBMain();
        }
        public DataSet LayFood()
        {
            return db.ExecuteQueryDataSet("select * from Food", CommandType.Text);
        }

        public bool ThemFood(string id, string name, string idCategory, int price, ref string err)
        {
            string sqlString = "Insert Into Food Values('" + id + "',N'" + name + "',N'" + idCategory + "', " + price + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool XoaFood(string idFood, ref string err)
        {
            string sqlString = "Delete From Food Where id = '" + idFood + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool SuaFood(string id, string name, string idCategory, int price, ref string err)
        {
            string sqlString = "Update Food Set name ='" + name + "', idCategory = '" + idCategory + "', price = " + price + "  Where id = '" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemFood(string tk)
        {
            return db.ExecuteQueryDataSet("select * from Food Where name LIKE N'%" + tk + "%'", CommandType.Text);
        }
    }
}
