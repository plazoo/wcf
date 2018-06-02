using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.domain;
namespace Repository
{
    public class LogRespository:ILogRespository
    {
        public int SetLog(string description, int? user)
        {
            using (var db = new ApplicationDbContextSGO())
                return db.usp_INS_TBL_LOG(description, user);
        }
    }
}
