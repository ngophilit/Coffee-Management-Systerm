using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCafe.BS_Layer
{
    class BLAccount
    {
        public bool KiemTra(string User, string Pass)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();

            if (qlcfEntity.Accounts.Where(u => u.userName == User &&
             u.password == Pass).Count() > 0)
            {
                return true;
            }
            else
                return false;
        }
        public DataTable LayAccount()
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            var acc = from u in qlcfEntity.Accounts
                      select u;

            DataTable dt = new DataTable();
            dt.Columns.Add("UserName");
            dt.Columns.Add("DisplayName");
            dt.Columns.Add("Password");
            dt.Columns.Add("AccountType");

            foreach (var x in acc)
            {
                dt.Rows.Add(x.userName, x.displayName, x.password, x.accountType);
            }

            return dt;
        }

        public bool ThemAccount(string user, string display, string pass, string type, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            Account acc = new Account();
            acc.userName = user;
            acc.displayName = display;
            acc.password = pass;
            acc.accountType = type;

            qlcfEntity.Accounts.Add(acc);
            qlcfEntity.SaveChanges();

            return true;
        }

        public bool XoaAccount(string user, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            Account acc = new Account();
            acc.userName = user;

            qlcfEntity.Accounts.Attach(acc);
            qlcfEntity.Accounts.Remove(acc);
            qlcfEntity.SaveChanges();

            return true;
        }

        public bool SuaAccount(string user, string display, string pass, string type, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            var accQuery = (from acc in qlcfEntity.Accounts
                            where acc.userName == user
                            select acc).SingleOrDefault();
            if (accQuery != null)
            {
                accQuery.displayName = display;
                accQuery.password = pass;
                accQuery.accountType = type;

                qlcfEntity.SaveChanges();
            }
            return true;
        }
        public List<string> LayInfoAcc(string user)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            var acc = from u in qlcfEntity.Accounts
                      where u.userName == user
                      select u;

            List<string> lst = new List<string>();

            foreach (var x in acc)
            {
                lst.Add(x.userName);
                lst.Add(x.displayName);
                lst.Add(x.password);
                lst.Add(x.accountType);
            }

            return lst;
        }
    }
}
