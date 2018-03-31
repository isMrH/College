using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mobile.DAL;
using Mobile.Model;

namespace Mobile.BLL
{
    public class InfoManagers
    {
            public static int InsertInfo(Info info)
            {
                return InfoService.InsertInfo(info);
            }
    }
}
