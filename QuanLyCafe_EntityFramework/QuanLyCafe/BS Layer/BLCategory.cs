using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCafe.BS_Layer
{
    class BLCategory
    {
        public DataTable LayCategory()
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            var cf = from u in qlcfEntity.FoodCategories
                      select u;

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("CategoryFoodName");

            foreach (var x in cf)
            {
                dt.Rows.Add(x.id, x.name);
            }

            return dt;
        }

        public bool ThemCategory(string id, string category, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            FoodCategory cf = new FoodCategory();
            cf.id = id;
            cf.name = category;

            qlcfEntity.FoodCategories.Add(cf);
            qlcfEntity.SaveChanges();

            return true;
        }

        public bool XoaCategory(string id, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            FoodCategory cf = new FoodCategory();
            cf.id = id;

            qlcfEntity.FoodCategories.Attach(cf);
            qlcfEntity.FoodCategories.Remove(cf);
            qlcfEntity.SaveChanges();

            return true;
        }

        public bool SuaCategory(string id, string category, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            var cfQuery = (from cf in qlcfEntity.FoodCategories
                            where cf.id == id
                            select cf).SingleOrDefault();
            if (cfQuery != null)
            {
                cfQuery.name = category;

                qlcfEntity.SaveChanges();
            }
            return true;
        }
    }
}
