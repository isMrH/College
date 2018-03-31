<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:BoundField DataField="NewsId" HeaderText="NewsId" 
                    SortExpression="NewsId" />
                <asp:BoundField DataField="TypeId" HeaderText="TypeId" 
                    SortExpression="TypeId" />
                <asp:ImageField DataImageUrlField="PictureUrl" 
                    DataImageUrlFormatString="~/userFiles/{0}" HeaderText="Image">
                    <ControlStyle Height="100px" Width="130px" />
                </asp:ImageField>
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="PublishDate" HeaderText="PublishDate" 
                    SortExpression="PublishDate" />
                <asp:BoundField DataField="PublisherName" HeaderText="PublisherName" 
                    SortExpression="PublisherName" />
                <asp:BoundField DataField="Clicks" HeaderText="Clicks" 
                    SortExpression="Clicks" />
                <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                <asp:BoundField DataField="Contents" HeaderText="Contents" 
                    SortExpression="Contents" />
                <asp:BoundField DataField="IsTop" HeaderText="IsTop" SortExpression="IsTop" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="GetAllNews" TypeName="MySchool.BLL.NewsManager">
        </asp:ObjectDataSource>
    
    </div>
    </form>
</body>
</html>
