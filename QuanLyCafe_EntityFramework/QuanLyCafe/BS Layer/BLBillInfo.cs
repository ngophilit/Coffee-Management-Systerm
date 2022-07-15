using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCafe.BS_Layer
{
    class BLBillInfo
    {
        public DataTable LayBillInfo(string Id)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            var BillInfo = from u in qlcfEntity.BillInfoes
                           join f in qlcfEntity.Foods on u.idFood equals f.id
                           where u.idBill == Id
                           select new { id = u.id, idBill = u.idBill, idFood = f.name, count = u.count };

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Mã hóa đơn");
            dt.Columns.Add("Món ăn");
            dt.Columns.Add("Số lượng");

            foreach (var x in BillInfo)
            {
                dt.Rows.Add(x.id, x.idBill, x.idFood, x.count);
            }

            return dt;
        }

        public bool ThemBillInfo(string id, string idBill, string idFood, int count, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();

            var f = from u in qlcfEntity.Foods
                    where u.name == idFood
                    select u;

            BillInfo acc = new BillInfo();
            acc.id = id;
            acc.idBill = idBill;
            acc.count = count;

            foreach (var x in f)
            {
                acc.idFood = x.id;
            }

            qlcfEntity.BillInfoes.Add(acc);
            qlcfEntity.SaveChanges();

            return true;
        }

        public bool XoaBillInfo(string id, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            BillInfo acc = new BillInfo();
            acc.id = id;

            qlcfEntity.BillInfoes.Attach(acc);
            qlcfEntity.BillInfoes.Remove(acc);
            qlcfEntity.SaveChanges();

            return true;
        }

        public bool SuaBillInfo(string id, string idBill, string Food, int count, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            var accQuery = (from acc in qlcfEntity.BillInfoes
                            where acc.id == id
                            select acc).SingleOrDefault();

            
            if (accQuery != null)
            {
                accQuery.idBill = idBill;
                accQuery.idFood = Food;
                accQuery.count = count;
                var f = from u in qlcfEntity.Foods
                        where u.name == Food
                        select u;


                foreach (var x in f)
                {
                    accQuery.idFood = x.id;
                }
                qlcfEntity.SaveChanges();
            }
            return true;
        }
        public double TotalPay(string id)
        {
            double tong = 0;
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            var tkB = from b in qlcfEntity.BillInfoes
                      join f in qlcfEntity.Foods on b.idFood equals f.id
                      select new { BillId = b.idBill, TotalPrice = b.count * f.price };
            var tk = (from x in tkB
                     group x by x.BillId into g
                     select new { Id = g.Key, TotalPrice = g.Sum(x => x.TotalPrice) }).Distinct();

            foreach (var x in tk)
            {
                if (x.Id == id)
                    tong = x.TotalPrice;
            }
            return tong;
        }
    }
}
