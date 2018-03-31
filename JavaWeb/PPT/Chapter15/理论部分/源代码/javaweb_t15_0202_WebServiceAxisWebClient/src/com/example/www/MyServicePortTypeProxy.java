package com.example.www;

public class MyServicePortTypeProxy implements com.example.www.MyServicePortType {
  private String _endpoint = null;
  private com.example.www.MyServicePortType myServicePortType = null;
  
  public MyServicePortTypeProxy() {
    _initMyServicePortTypeProxy();
  }
  
  public MyServicePortTypeProxy(String endpoint) {
    _endpoint = endpoint;
    _initMyServicePortTypeProxy();
  }
  
  private void _initMyServicePortTypeProxy() {
    try {
      myServicePortType = (new com.example.www.MyServiceLocator()).getMyServiceHttpPort();
      if (myServicePortType != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)myServicePortType)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)myServicePortType)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (myServicePortType != null)
      ((javax.xml.rpc.Stub)myServicePortType)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public com.example.www.MyServicePortType getMyServicePortType() {
    if (myServicePortType == null)
      _initMyServicePortTypeProxy();
    return myServicePortType;
  }
  
  public int add(int in0, int in1) throws java.rmi.RemoteException{
    if (myServicePortType == null)
      _initMyServicePortTypeProxy();
    return myServicePortType.add(in0, in1);
  }
  
  public java.lang.String sayHello(java.lang.String in0) throws java.rmi.RemoteException{
    if (myServicePortType == null)
      _initMyServicePortTypeProxy();
    return myServicePortType.sayHello(in0);
  }
  
  
}