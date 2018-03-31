using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// 注意: 如果更改此处的接口名称 "IPPSWCFService"，也必须更新 Web.config 中对 "IPPSWCFService" 的引用。
[ServiceContract]
public interface IPPSWCFService
{
	[OperationContract]
	void DoWork();
}
