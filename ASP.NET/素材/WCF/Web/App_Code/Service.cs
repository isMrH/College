using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MyShop.Model;
using MyShop.BLL;
using System.Data;
using System.Data.SqlClient;

// 注意: 如果更改此处的类名“Service”，也必须更新 Web.config 和关联的 .svc 文件中对“Service”的引用。
public class Service : IService
{
    //public string GetData(int value)
    //{
    //    return string.Format("You entered: {0}", value);
    //}

    //public CompositeType GetDataUsingDataContract(CompositeType composite)
    //{
    //    if (composite.BoolValue)
    //    {
    //        composite.StringValue += "Suffix";
    //    }
    //    return composite;
    //}
    GoodsInfoManager gm = new GoodsInfoManager();
    //查所有
    public List<GoodsInfo> GetAllInfo()
    {
       
        return gm.GetAllInfo();
    }
    //查重
    public int IsHasInfo(string name)
    {
        return gm.IsHasInfo(name);
    }
    //插入
    public int AddInfo(GoodsInfo gs)
    {
        return gm.AddGoods(gs);
    }
    //查找
    public List<GoodsInfo> SelectByName(string name)
    {
        return gm.SelectByName(name);

    }
}
