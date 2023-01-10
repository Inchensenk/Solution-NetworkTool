using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_NetworkTool
{
    /// <summary>
    /// статус того что происходит на сервере
    /// </summary>
    public enum RequestStatus
    {
        Success,
        Failed,
        Forbidden,
        Error
    }
}
