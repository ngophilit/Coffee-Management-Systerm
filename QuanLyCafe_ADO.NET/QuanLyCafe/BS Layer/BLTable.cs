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
    class BLTable
    {
        DBMain db = null;
        public BLTable ()
        {
            db = new DBMain();
        }
        public DataSet LayTable()
        {
            return db.ExecuteQueryDataSet("select * from TableFood", CommandType.Text);
        }

        public bool ThemTable(string id, string tablename, string status, ref string err)
        {
            string sqlString = "Insert Into TableFood Values('" + id + "',N'" + tablename + "',N'" + status + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool XoaTable(string id, ref string err)
        {
            string sqlString = "Delete From TableFood Where id = '" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool SuaTable(string id, string tablename, string status, ref string err)
        {
            string sqlString = "Update TableFood Set name ='" + tablename + "', status = '" + status +"'  Where id = '" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
