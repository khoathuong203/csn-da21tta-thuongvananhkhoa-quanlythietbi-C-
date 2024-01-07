using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSN_QLTB
{
    internal class thuoc
    {
        thaotac db = new thaotac();
        public void addthuoc(string idtb, string idphong)
        {
            string sql = string.Format("Insert into THUOC Values(N'{0}',N'{1}')", idtb, idphong);

            Console.WriteLine(sql);
            db.excuteNonQuery(sql);
        }
    }
}
