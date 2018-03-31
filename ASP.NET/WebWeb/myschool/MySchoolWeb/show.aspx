<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="show.aspx.cs" Inherits="Default2" validateRequest="false"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<form runat="server">
<asp:DetailsView ID="DetailsView1" runat="server" Height="16px" Width="212px" 
    AutoGenerateRows="False" DataSourceID="ObjectDataSource1" 
    DataKeyNames="NewsId" onitemupdating="DetailsView1_ItemUpdating1">
    <Fields>
        <asp:BoundField DataField="NewsId" HeaderText="NewsId" 
            SortExpression="NewsId" ReadOnly="True" />
        <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
        <asp:ImageField DataImageUrlField="PictureUrl" 
            DataImageUrlFormatString="~/userFiles/{0}" HeaderText="图片" ReadOnly="True">
            <ControlStyle Height="150px" Width="150px" />
        </asp:ImageField>
        <asp:BoundField DataField="PublishDate" HeaderText="PublishDate" 
            SortExpression="PublishDate" DataFormatString="{0:yyyy-MM-dd}" 
            ReadOnly="True" />
        <asp:BoundField DataField="PublisherName" HeaderText="PublisherName" 
            SortExpression="PublisherName" ReadOnly="True" />
        <asp:BoundField DataField="Clicks" HeaderText="Clicks" 
            SortExpression="Clicks" />
        <asp:TemplateField HeaderText="State" SortExpression="State">
            <EditItemTemplate>
                <asp:CheckBox ID="chkState" runat="server" 
                    oncheckedchanged="CheckBox1_CheckedChanged" 
                    Checked='<%# GetNewsState(Eval("State")) %>' />
            </EditItemTemplate>
            <InsertItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("State") %>'></asp:TextBox>
            </InsertItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# GetState(Eval("State")) %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Contents" SortExpression="Contents">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Height="52px" 
                    Text='<%# Bind("Contents") %>' TextMode="MultiLine" Width="197px"></asp:TextBox>
            </EditItemTemplate>
            <InsertItemTemplate>
                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Contents") %>'></asp:TextBox>
            </InsertItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Contents") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="IsTop" SortExpression="IsTop">
            <EditItemTemplate>
                <asp:CheckBox ID="chkTop" runat="server" 
                    Checked='<%# GetNewsTop(Eval("IsTop")) %>' />
            </EditItemTemplate>
            <InsertItemTemplate>
                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("IsTop") %>'></asp:TextBox>
            </InsertItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# GetTop(Eval("IsTop")) %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" />
    </Fields>
</asp:DetailsView>
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
    SelectMethod="GetNewsByNewsId" TypeName="MySchool.BLL.NewsManager" 
    UpdateMethod="Update">
    <UpdateParameters>
        <asp:Parameter Name="newsid" Type="Int32" />
        <asp:Parameter Name="Title" Type="String" />
        <asp:Parameter Name="Contents" Type="String" />
        <asp:Parameter Name="Clicks" Type="Int32" />
        <asp:Parameter Name="State" Type="Int32" />
        <asp:Parameter Name="IsTop" Type="Int32" />
    </UpdateParameters>
    <SelectParameters>
        <asp:QueryStringParameter Name="newsId" QueryStringField="id" Type="Int32" 
            DefaultValue="19" />
    </SelectParameters>
</asp:ObjectDataSource>
<br />
<asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="返回首页" />
</form>
</asp:Content>

