using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
namespace Service
{
    public class LogService:ILogService
    {
        private readonly ILogRespository iLogRespository;
        public LogService()
        {
            iLogRespository = new LogRespository();
        }
        public int SetLog(string description, int? user)
        {
            return iLogRespository.SetLog(description,user);
        }
    }
}
