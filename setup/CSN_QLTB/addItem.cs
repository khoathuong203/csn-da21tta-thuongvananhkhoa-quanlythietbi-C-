using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSN_QLTB
{
    internal class addItem
    {
        thaotac db = new thaotac();

        public void addGV(string id, string ten)
        {
            string sql = string.Format("Insert into GIANGVIEN Values(N'{0}',N'{1}')", id,ten);

            Console.WriteLine(sql);
            db.excuteNonQuery(sql);
        }
        public void addPhong(string id, string ten, int sl)
        {
            string sql = string.Format("Insert into PHONG Values(N'{0}',N'{1}','{2}')", id, ten,sl);

            Console.WriteLine(sql);
            db.excuteNonQuery(sql);
        }
        public void addTB(string id, string ten, string nsx)
        {
            string sql = string.Format("Insert into THIETBI Values(N'{0}',N'{1}','{2}')", id, ten,nsx);

            Console.WriteLine(sql);
            db.excuteNonQuery(sql);
        }
        public void addthuoc(string idtb,string idp)
        {
            string sql = string.Format("Insert into THUOC Values(N'{0}',N'{1}')", idtb, idp);

            Console.WriteLine(sql);
            db.excuteNonQuery(sql);
        }
        public void addo(string idp,string idgv)
        {
            string sql = string.Format("Insert into O Values(N'{0}',N'{1}')", idp, idgv);

            Console.WriteLine(sql);
            db.excuteNonQuery(sql);
        }
        public void addsd(string tb, string gv, string p)
        {
            string sql = string.Format("Insert into SUDUNG Values(N'{0}',N'{1}',N'{2}','NULL')", tb,gv,p);

            Console.WriteLine(sql);
            db.excuteNonQuery(sql);
        }
        public void addts(string idts,string idtb,string tents, string gt)
        {
            string sql = string.Format("Insert into THUOC Values(N'{0}',N'{1}',N'{2}',N'{3}')", idts, idtb);

            Console.WriteLine(sql);
            db.excuteNonQuery(sql);
        }
    }
}
