using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCafe.BS_Layer
{
    class BLBill
    {
        public DataTable ThongKeBill(DateTime DateFrom, DateTime DateTo, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            var tkB = from b in qlcfEntity.Bills
                      join tf in qlcfEntity.TableFoods on b.idTable equals tf.id
                      join bi in qlcfEntity.BillInfoes on b.id equals bi.idBill
                      join f in qlcfEntity.Foods on bi.idFood equals f.id 
                      where b.dateCheckOut >= DateFrom && b.dateCheckOut <= DateTo
                      select new {BillId = b.id, TableName = tf.name, DateOut = b.dateCheckOut, TotalPrice = bi.count*f.price};
            var tk = from x in tkB
                     group x by x.BillId into g
                     select new { Id = g.Key ,TotalPrice = g.Sum(x => x.TotalPrice)};

            var tkFinal = (from x in tkB
                          join y in tk on x.BillId equals y.Id
                          orderby x.BillId
                          select new { Id = x.BillId, Tablename = x.TableName, DateCheckOut = x.DateOut, TotalPrice = y.TotalPrice }).Distinct();

            DataTable dt = new DataTable();
            dt.Columns.Add("Bill Id");
            dt.Columns.Add("Table Name");
            dt.Columns.Add("Date Check Out");
            dt.Columns.Add("Total Price");

            foreach (var x in tkFinal)
            {
                dt.Rows.Add(x.Id, x.Tablename, x.DateCheckOut.ToShortDateString(), x.TotalPrice);
            }

            return dt;
        }
        public DataTable LayBill()
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            var bill = from u in qlcfEntity.Bills
                      select u;

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("DateCheckIn");
            dt.Columns.Add("DateCheckOut");
            dt.Columns.Add("idTable");
            dt.Columns.Add("Status");

            foreach (var x in bill)
            {
                dt.Rows.Add(x.id, x.dateCheckIn.ToShortDateString(), x.dateCheckOut.ToShortDateString(), x.idTable,x.status);
            }

            return dt;
        }

        public bool ThemBill(string id, DateTime DateIn, DateTime DateOut, string idTable, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            Bill acc = new Bill();
            acc.id = id;
            acc.dateCheckIn = DateIn;
            acc.dateCheckOut = DateOut;
            acc.idTable = idTable;
            acc.status = "0";

            qlcfEntity.Bills.Add(acc);
            qlcfEntity.SaveChanges();

            return true;
        }

        public bool XoaBill(string id, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            Bill acc = new Bill();
            acc.id = id;

            qlcfEntity.Bills.Attach(acc);
            qlcfEntity.Bills.Remove(acc);
            qlcfEntity.SaveChanges();

            return true;
        }

        public bool SuaBill(string id, DateTime DateIn, DateTime DateOut, string idTable,string status, ref string err)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            var accQuery = (from acc in qlcfEntity.Bills
                            where acc.id == id
                            select acc).SingleOrDefault();
            if (accQuery != null)
            {
                accQuery.dateCheckIn = DateIn;
                accQuery.dateCheckOut = DateOut;
                accQuery.idTable = idTable;
                if(status == "Đã thanh toán")
                {
                    accQuery.status = "1";
                }    
                else
                {
                    accQuery.status = "0";
                }    

                qlcfEntity.SaveChanges();
            }
            return true;
        }
        public bool PayBill(string id)
        {
            QuanLyQuanCafeEntities qlcfEntity = new QuanLyQuanCafeEntities();
            var accQuery = (from acc in qlcfEntity.Bills
                            where acc.id == id
                            select acc).SingleOrDefault();
            if (accQuery != null)
            {
                accQuery.status = "1";

                qlcfEntity.SaveChanges();
            }
            return true;
        }
    }
}
