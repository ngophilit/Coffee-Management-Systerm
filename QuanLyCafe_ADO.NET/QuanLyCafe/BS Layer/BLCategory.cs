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
    class BLCategory
    {
        DBMain db = null;
        public BLCategory()
        {
            db = new DBMain();
        }
        public DataSet LayCategory()
        {
            return db.ExecuteQueryDataSet("select * from FoodCategory", CommandType.Text);
        }

        public bool ThemCategory(string id, string category, ref string err)
        {
            string sqlString = "Insert Into FoodCategory Values('" + id + "',N'" + category + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool XoaCategory(string id, ref string err)
        {
            string sqlString = "Delete From FoodCategory Where id = '" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool SuaCategory(string id, string category, ref string err)
        {
            string sqlString = "Update FoodCategory Set name ='" + category + "'  Where id = '" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
