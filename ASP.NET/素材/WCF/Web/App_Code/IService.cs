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

// 注意: 如果更改此处的接口名称“IService”，也必须更新 Web.config 中对“IService”的引用。
[ServiceContract]
public interface IService
{
    //[OperationContract]
    //string GetData(int value);

    //[OperationContract]
    //CompositeType GetDataUsingDataContract(CompositeType composite);

    [OperationContract]
    //定义查找所有的方法
    List<GoodsInfo> GetAllInfo();

    [OperationContract]
    //定义查重的方法
    int IsHasInfo(string name);

    [OperationContract]
    //定义插入的方法
    int AddInfo(GoodsInfo gs);

    [OperationContract]
    //查找
    List<GoodsInfo> SelectByName(string name);
}

// 使用下面示例中说明的数据约定将复合类型添加到服务操作。
[DataContract]
public class CompositeType
{
	bool boolValue = true;
	string stringValue = "Hello ";

	[DataMember]
	public bool BoolValue
	{
		get { return boolValue; }
		set { boolValue = value; }
	}

	[DataMember]
	public string StringValue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}
}
