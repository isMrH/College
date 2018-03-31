using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyShop.DAL;
using MyShop.Model;

namespace MyShop.BLL
{
    public class GoodsInfoManager
    {
        GoodsInfoService gis = new GoodsInfoService();
         //得到所有商品信息
        public List<GoodsInfo> GetAllInfo()
        {
            return gis.GetAllInfo();
        }
        //查看是否重名
        public int IsHasInfo(string name)
        {
            return gis.IsHasInfo(name);
        }
        //插入信息
        public int AddGoods(GoodsInfo gs)
        {
            return gis.AddGoods(gs);
        }
        //跟据商品名称进行查询
        public List<GoodsInfo> SelectByName(string name)
        {
            return gis.SelectByName(name);
        }
    }
}
