using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCafe.BS_Layer
{
    class BLTable
    {
        public DataTable LayTable()
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            var tb = from u in qlcfEntity.TableFoods
                      select u;

            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("TableName");
            dt.Columns.Add("Status");

            foreach (var x in tb)
            {
                dt.Rows.Add(x.id, x.name, x.status);
            }

            return dt;
        }

        public bool ThemTable(string id, string tablename, string status, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            TableFood tb = new TableFood();
            tb.id = id;
            tb.name = tablename;
            tb.status = status;

            qlcfEntity.TableFoods.Add(tb);
            qlcfEntity.SaveChanges();

            return true;
        }

        public bool XoaTable(string id, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            TableFood tb = new TableFood();
            tb.id = id;

            qlcfEntity.TableFoods.Attach(tb);
            qlcfEntity.TableFoods.Remove(tb);
            qlcfEntity.SaveChanges();

            return true;
        }

        public bool SuaTable(string id, string tablename, string status, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            var tbQuery = (from tb in qlcfEntity.TableFoods
                            where tb.id == id
                            select tb).SingleOrDefault();
            if (tbQuery != null)
            {
                tbQuery.name = tablename;
                tbQuery.status = status;

                qlcfEntity.SaveChanges();
            }
            return true;
        }
    }
}
