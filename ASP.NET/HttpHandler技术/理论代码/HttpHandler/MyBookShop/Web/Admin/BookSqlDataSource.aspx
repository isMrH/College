<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookSqlDataSource.aspx.cs" Inherits="Admin_BookSqlDataSource" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;&nbsp;
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues"
            ConnectionString="<%$ ConnectionStrings:MyBookShopConnectionString %>" DeleteCommand="DELETE FROM [Books] WHERE [Id] = @original_Id AND [Title] = @original_Title AND [Author] = @original_Author AND [PublishDate] = @original_PublishDate AND [ISBN] = @original_ISBN AND [WordsCount] = @original_WordsCount"
            InsertCommand="INSERT INTO [Books] ([Title], [Author], [PublishDate], [ISBN], [WordsCount]) VALUES (@Title, @Author, @PublishDate, @ISBN, @WordsCount)"
            OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [Id], [Title], [Author], [PublishDate], [ISBN], [WordsCount] FROM [Books]"
            UpdateCommand="UPDATE [Books] SET [Title] = @Title, [Author] = @Author, [PublishDate] = @PublishDate, [ISBN] = @ISBN, [WordsCount] = @WordsCount WHERE [Id] = @original_Id AND [Title] = @original_Title AND [Author] = @original_Author AND [PublishDate] = @original_PublishDate AND [ISBN] = @original_ISBN AND [WordsCount] = @original_WordsCount">
            <DeleteParameters>
                <asp:Parameter Name="original_Id" Type="Int32" />
                <asp:Parameter Name="original_Title" Type="String" />
                <asp:Parameter Name="original_Author" Type="String" />
                <asp:Parameter Name="original_PublishDate" Type="DateTime" />
                <asp:Parameter Name="original_ISBN" Type="String" />
                <asp:Parameter Name="original_WordsCount" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="Author" Type="String" />
                <asp:Parameter Name="PublishDate" Type="DateTime" />
                <asp:Parameter Name="ISBN" Type="String" />
                <asp:Parameter Name="WordsCount" Type="Int32" />
                <asp:Parameter Name="original_Id" Type="Int32" />
                <asp:Parameter Name="original_Title" Type="String" />
                <asp:Parameter Name="original_Author" Type="String" />
                <asp:Parameter Name="original_PublishDate" Type="DateTime" />
                <asp:Parameter Name="original_ISBN" Type="String" />
                <asp:Parameter Name="original_WordsCount" Type="Int32" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="Author" Type="String" />
                <asp:Parameter Name="PublishDate" Type="DateTime" />
                <asp:Parameter Name="ISBN" Type="String" />
                <asp:Parameter Name="WordsCount" Type="Int32" />
            </InsertParameters>
        </asp:SqlDataSource>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
            AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource1"
            ForeColor="#333333" GridLines="None">
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True"
                    SortExpression="Id" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
                <asp:BoundField DataField="PublishDate" HeaderText="PublishDate" SortExpression="PublishDate" />
                <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
                <asp:BoundField DataField="WordsCount" HeaderText="WordsCount" SortExpression="WordsCount" />
            </Columns>
            <RowStyle BackColor="#E3EAEB" />
            <EditRowStyle BackColor="#7C6F57" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    </form>
</body>
</html>
