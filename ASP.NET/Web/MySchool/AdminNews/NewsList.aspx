<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="NewsList.aspx.cs" Inherits="AdminNews_NewsList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
   <script language ="javascript" type ="text/javascript" >

       //以＂全选＂前面的复选框对象做参数
       function GetAllCheckBox(CheckAll) {
           //获得所有的input对象的列表，并遍历该列表
           var items = document.getElementsByTagName("input");
           for (i = 0; i < items.length; i++) {
               //判断遍历input对象中的列表中的对象是否为checkbox类型
               if (items[i].type == "checkbox") {
                   items[i].checked = CheckAll.checked;
               }
           }
       }
    </script>
    <form id="form1" runat="server">
    
        <br />
        <div style="margin-left: 50px; margin-top: 10px;">
        <asp:ObjectDataSource ID="SchoolDataSource" runat="server" 
            SelectMethod="GetAllNews" TypeName="MySchool.BLL.NewsManager">
        </asp:ObjectDataSource>
        <asp:GridView ID="gvNews" runat="server" AutoGenerateColumns="False" 
                DataSourceID="SchoolDataSource" AllowPaging="True" PageSize="5" Width="723px" 
                Height="219px" DataKeyNames="NewsId" onrowdatabound="gvNews_RowDataBound">
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        <input id="Checkbox1" type="checkbox"   onclick ="GetAllCheckBox(this)" />
                        全选
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="chkAll" runat="server" />
                    </ItemTemplate>
                    <ItemStyle Width="60px" />
                </asp:TemplateField>
                <asp:BoundField DataField="Title" HeaderText="标题" 
                    SortExpression="Title" />
                <asp:TemplateField HeaderText="类别" SortExpression="Type">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Type.Title") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Type.Title") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle Width="50px" />
                </asp:TemplateField>
                <asp:BoundField DataField="PublishDate" HeaderText="发布日期" 
                    SortExpression="PublishDate" DataFormatString="{0:yyyy-MM-dd}" >
                <ItemStyle Width="80px" />
                </asp:BoundField>
                <asp:ImageField DataImageUrlField="PictureUrl" 
                    DataImageUrlFormatString="~/userFiles/{0}" HeaderText="新闻图片">
                    <ControlStyle Height="50px" Width="50px" />                   
                </asp:ImageField>
                <asp:TemplateField HeaderText="内容" SortExpression="Contents">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Contents") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" 
                            Text='<%# GetContents(Eval("Contents")) %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:HyperLinkField DataNavigateUrlFields="NewsId" 
                    DataNavigateUrlFormatString="NewsDetails.aspx?newsid={0}" HeaderText="查看详细" 
                    Text="详细" />
            </Columns>
        </asp:GridView>
        修改新闻类别：<asp:DropDownList ID="ddlCategory" runat="server" 
                DataSourceID="TypeDataSource" DataTextField="Title" DataValueField="TypeId">
            </asp:DropDownList>
            <asp:Button ID="btnModify" runat="server" Text="修改" onclick="btnModify_Click" />
            <asp:ObjectDataSource ID="TypeDataSource" runat="server" 
                SelectMethod="GetAllNewsTypes" TypeName="MySchool.BLL.NewsTypeManager">
            </asp:ObjectDataSource>
    </div>
    </form>
</asp:Content>

