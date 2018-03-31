/**
 * MyServiceLocator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package com.example.www;

public class MyServiceLocator extends org.apache.axis.client.Service implements com.example.www.MyService {

    public MyServiceLocator() {
    }


    public MyServiceLocator(org.apache.axis.EngineConfiguration config) {
        super(config);
    }

    public MyServiceLocator(java.lang.String wsdlLoc, javax.xml.namespace.QName sName) throws javax.xml.rpc.ServiceException {
        super(wsdlLoc, sName);
    }

    // Use to get a proxy class for MyServiceHttpPort
    private java.lang.String MyServiceHttpPort_address = "http://localhost:8080/javaweb_t15_0101_WebServiceXFireServer/services/MyService";

    public java.lang.String getMyServiceHttpPortAddress() {
        return MyServiceHttpPort_address;
    }

    // The WSDD service name defaults to the port name.
    private java.lang.String MyServiceHttpPortWSDDServiceName = "MyServiceHttpPort";

    public java.lang.String getMyServiceHttpPortWSDDServiceName() {
        return MyServiceHttpPortWSDDServiceName;
    }

    public void setMyServiceHttpPortWSDDServiceName(java.lang.String name) {
        MyServiceHttpPortWSDDServiceName = name;
    }

    public com.example.www.MyServicePortType getMyServiceHttpPort() throws javax.xml.rpc.ServiceException {
       java.net.URL endpoint;
        try {
            endpoint = new java.net.URL(MyServiceHttpPort_address);
        }
        catch (java.net.MalformedURLException e) {
            throw new javax.xml.rpc.ServiceException(e);
        }
        return getMyServiceHttpPort(endpoint);
    }

    public com.example.www.MyServicePortType getMyServiceHttpPort(java.net.URL portAddress) throws javax.xml.rpc.ServiceException {
        try {
            com.example.www.MyServiceHttpBindingStub _stub = new com.example.www.MyServiceHttpBindingStub(portAddress, this);
            _stub.setPortName(getMyServiceHttpPortWSDDServiceName());
            return _stub;
        }
        catch (org.apache.axis.AxisFault e) {
            return null;
        }
    }

    public void setMyServiceHttpPortEndpointAddress(java.lang.String address) {
        MyServiceHttpPort_address = address;
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        try {
            if (com.example.www.MyServicePortType.class.isAssignableFrom(serviceEndpointInterface)) {
                com.example.www.MyServiceHttpBindingStub _stub = new com.example.www.MyServiceHttpBindingStub(new java.net.URL(MyServiceHttpPort_address), this);
                _stub.setPortName(getMyServiceHttpPortWSDDServiceName());
                return _stub;
            }
        }
        catch (java.lang.Throwable t) {
            throw new javax.xml.rpc.ServiceException(t);
        }
        throw new javax.xml.rpc.ServiceException("There is no stub implementation for the interface:  " + (serviceEndpointInterface == null ? "null" : serviceEndpointInterface.getName()));
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(javax.xml.namespace.QName portName, Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        if (portName == null) {
            return getPort(serviceEndpointInterface);
        }
        java.lang.String inputPortName = portName.getLocalPart();
        if ("MyServiceHttpPort".equals(inputPortName)) {
            return getMyServiceHttpPort();
        }
        else  {
            java.rmi.Remote _stub = getPort(serviceEndpointInterface);
            ((org.apache.axis.client.Stub) _stub).setPortName(portName);
            return _stub;
        }
    }

    public javax.xml.namespace.QName getServiceName() {
        return new javax.xml.namespace.QName("www.example.com", "MyService");
    }

    private java.util.HashSet ports = null;

    public java.util.Iterator getPorts() {
        if (ports == null) {
            ports = new java.util.HashSet();
            ports.add(new javax.xml.namespace.QName("www.example.com", "MyServiceHttpPort"));
        }
        return ports.iterator();
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(java.lang.String portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        
if ("MyServiceHttpPort".equals(portName)) {
            setMyServiceHttpPortEndpointAddress(address);
        }
        else 
{ // Unknown Port Name
            throw new javax.xml.rpc.ServiceException(" Cannot set Endpoint Address for Unknown Port" + portName);
        }
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(javax.xml.namespace.QName portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        setEndpointAddress(portName.getLocalPart(), address);
    }

}
