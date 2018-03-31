using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyShop.Model;
using System.Data;
using System.Data.SqlClient;

namespace MyShop.DAL
{
    public class GoodsInfoService
    {
        //得到所有商品信息
        public List<GoodsInfo> GetAllInfo()
        {
            string strsql = "select * from GoodsInfo";
            return GetInfoBySql(strsql);
        }
        //查看是否重名
        public int IsHasInfo(string name)
        {
            string strsql = "select count(*) from GoodsInfo where GoodsName=@name";
            SqlParameter[] paras = new SqlParameter[] { 
               new SqlParameter("@name",name),
            };
            return Convert.ToInt32( DBHelper.GetScalar(strsql,paras));
        }
        //插入信息
        public int AddGoods(GoodsInfo gs)
        {
            string strsql = "insert into GoodsInfo values(@GoodsName,@GoodsPrice,@GoodsCount,@Compnay)";
            SqlParameter[] paras = new SqlParameter[] { 
               new SqlParameter("@GoodsName",gs.GoodsName),
               new SqlParameter("@GoodsPrice",gs.GoodsPrice),
               new SqlParameter("@GoodsCount",gs.GoodsCount),
               new SqlParameter("@Compnay",gs.Company),
            };
            return DBHelper.ExecuteCommand(strsql,paras);
        }
        //根据商品名称进行查询
        public List<GoodsInfo> SelectByName(string name)
        {
            string strsql = "select * from GoodsInfo where GoodsName='"+name+"'";
            return GetInfoBySql(strsql);
        }
        //定义私有方法获取信息
        private static List<GoodsInfo> GetInfoBySql(string strsql)
        {
            List<GoodsInfo> list = new List<GoodsInfo>();
            DataTable dt = DBHelper.GetTable(strsql);
            foreach (DataRow row in dt.Rows)
            {
                GoodsInfo goods = new GoodsInfo();
                goods.Id = Convert.ToInt32(row["Id"]);
                goods.GoodsName = row["GoodsName"].ToString();
                goods.GoodsCount = Convert.ToInt32(row["GoodsCount"]);
                goods.GoodsPrice = Convert.ToDouble(row["GoodsPrice"]);
                goods.Company = row["Company"].ToString();
                list.Add(goods);
            }

            return list;
        }
    }
}
