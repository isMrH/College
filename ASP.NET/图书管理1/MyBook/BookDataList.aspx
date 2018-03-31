<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookDataList.aspx.cs" Inherits="BookDataList" %>

<%@ Register src="datalist.ascx" tagname="datalist" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="Server">
    <uc1:datalist ID="datalist1" runat="server" />
</asp:Content>

