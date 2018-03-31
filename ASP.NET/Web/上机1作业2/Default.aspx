<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="BookCode" 
        DataSourceID="SqlDataSource1" 
      
        Width="439px">
        <Columns>
            <asp:BoundField DataField="BookCode" HeaderText="编号" ReadOnly="True" 
                SortExpression="BookCode" />
            <asp:BoundField DataField="BookName" HeaderText="书名" 
                SortExpression="BookName" />
            <asp:BoundField DataField="UnitPrice" HeaderText="单价" 
                SortExpression="UnitPrice" />
        </Columns>
    </asp:GridView>
    <div>
    
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:BooksManagerConnectionString2 %>" 
        DeleteCommand="DELETE FROM [Books] WHERE [BookCode] = @BookCode" 
        InsertCommand="INSERT INTO [Books] ([UnitPrice], [BookCode], [BookName]) VALUES (@UnitPrice, @BookCode, @BookName)" 
        SelectCommand="SELECT [UnitPrice], [BookCode], [BookName] FROM [Books]" 
        UpdateCommand="UPDATE [Books] SET [UnitPrice] = @UnitPrice, [BookName] = @BookName WHERE [BookCode] = @BookCode">
        <DeleteParameters>
            <asp:Parameter Name="BookCode" Type="String" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="UnitPrice" Type="Decimal" />
            <asp:Parameter Name="BookName" Type="String" />
            <asp:Parameter Name="BookCode" Type="String" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="UnitPrice" Type="Decimal" />
            <asp:Parameter Name="BookCode" Type="String" />
            <asp:Parameter Name="BookName" Type="String" />
        </InsertParameters>
    </asp:SqlDataSource>
    </form>
</body>
</html>
