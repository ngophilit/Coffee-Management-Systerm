using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCafe.BS_Layer
{
    class BLFood
    {
        public DataTable LayFood()
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            var f = from u in qlcfEntity.Foods
                    orderby u.idCategory
                    select u;

            DataTable dt = new DataTable();
            dt.Columns.Add("foodId");
            dt.Columns.Add("foodName");
            dt.Columns.Add("categoryId");
            dt.Columns.Add("price");

            foreach (var x in f)
            {
                dt.Rows.Add(x.id, x.name, x.idCategory, x.price);
            }

            return dt;
        }

        public bool ThemFood(string id, string name, string idCategory, int price, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            Food f = new Food();
            f.id = id;
            f.name = name;
            f.idCategory = idCategory;
            f.price = price;

            qlcfEntity.Foods.Add(f);
            qlcfEntity.SaveChanges();

            return true;
        }

        public bool XoaFood(string idFood, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            Food f = new Food();
            f.id = idFood;

            qlcfEntity.Foods.Attach(f);
            qlcfEntity.Foods.Remove(f);
            qlcfEntity.SaveChanges();

            return true;
        }

        public bool SuaFood(string id, string name, string idCategory, int price, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            var fQuery = (from f in qlcfEntity.Foods
                            where f.id == id
                            select f).SingleOrDefault();
            if (fQuery != null)
            {
                fQuery.name = name;
                fQuery.idCategory = idCategory;
                fQuery.price = price;

                qlcfEntity.SaveChanges();
            }
            return true;
        }
        public DataTable TimKiemFood(string tk)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            var query = qlcfEntity.Foods.Where(c => c.name.Contains(tk));

            DataTable dt = new DataTable();
            dt.Columns.Add("foodId");
            dt.Columns.Add("foodName");
            dt.Columns.Add("categoryId");
            dt.Columns.Add("price");

            foreach (var x in query)
            {
                dt.Rows.Add(x.id, x.name, x.idCategory, x.price);
            }

            return dt;
        }
    }
}
