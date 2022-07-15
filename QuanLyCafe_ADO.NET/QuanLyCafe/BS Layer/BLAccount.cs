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
    class BLAccount
    {
        DBMain db = null;
        public BLAccount()
        {
            db = new DBMain();
        }
        public bool KiemTra(string User, string Pass)
        {
            DataSet ds = db.ExecuteQueryDataSet("select * from Account where userName = '" + User + "' and password = '" + Pass +"'", CommandType.Text);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row["userName"].ToString() == User && row["password"].ToString() == Pass)
                    return true;
            }
            return false;
        }
        public DataSet LayAccount()
        {
            return db.ExecuteQueryDataSet("select * from Account", CommandType.Text);
        }

        public bool ThemAccount(string user, string display, string pass, string type, ref string err)
        {
            string sqlString = "Insert Into Account Values('" + user + "',N'" + display + "',N'" + pass + "', " + type + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool XoaAccount(string user, ref string err)
        {
            string sqlString = "Delete From Account Where userName = '" + user + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool SuaAccount(string user, string display, string pass, string type, ref string err)
        {
            string sqlString = "Update Account Set displayName ='" + display + "', password = '" + pass + "', accountType = '" + type + "'  Where userName = '" + user + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public List<string> LayInfoAcc(string user)
        {
            DataSet ds = db.ExecuteQueryDataSet("select * from Account where userName = '" + user + "'", CommandType.Text);

            List<string> lst = new List<string>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lst.Add(row["userName"].ToString());
                lst.Add(row["displayName"].ToString());
                lst.Add(row["password"].ToString());
                lst.Add(row["accountType"].ToString());
            }

            return lst;
        }
    }
}
