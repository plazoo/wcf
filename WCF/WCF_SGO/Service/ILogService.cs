using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.domain;
namespace Service
{
    public interface ILogService
    {
        int SetLog(string description,int?user);
    }
}
