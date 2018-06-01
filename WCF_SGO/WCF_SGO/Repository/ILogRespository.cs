using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.domain;
namespace Repository
{
    public interface ILogRespository
    {
        int SetLog(string description,int?user);
    }
}
