using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSN_QLTB
{
    internal class o
    {
        thaotac db = new thaotac();
        public void addp(string idphong, string idgv)
        {
            string sql = string.Format("Insert into O Values(N'{0}',N'{1}')", idphong, idgv);

            Console.WriteLine(sql);
            db.excuteNonQuery(sql);
        }
    }
}
