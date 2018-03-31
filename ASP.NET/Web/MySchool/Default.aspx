<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gvNews" runat="server" DataSourceID="odsNews" 
            AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Title" HeaderText="新闻标题" SortExpression="Title" />
                <asp:ImageField DataImageUrlField="PictureUrl" 
                    DataImageUrlFormatString="~/userfiles/{0}" HeaderText="缩略图">
                    <ControlStyle Width="120px" />
                </asp:ImageField>
                <asp:BoundField DataField="PublishDate" DataFormatString="{0:yyyy-MM-dd}" 
                    HeaderText="PublishDate" SortExpression="PublishDate" />
                <asp:BoundField DataField="Contents" HeaderText="Contents" 
                    SortExpression="Contents" />
            </Columns>
        </asp:GridView>
    
    </div>
    <asp:ObjectDataSource ID="odsNews" runat="server" 
        SelectMethod="GetAllNews" TypeName="MySchool.BLL.NewsManager">
    </asp:ObjectDataSource>
    </form>
</body>
</html>
