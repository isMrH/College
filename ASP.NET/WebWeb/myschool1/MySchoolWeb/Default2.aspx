﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <form id="form1" runat="server">
    <asp:GridView ID="gvNews" runat="server" AutoGenerateColumns="False" 
        DataSourceID="objNews" AllowPaging="True" DataKeyNames="Newsid" 
        onselectedindexchanged="gvNews_SelectedIndexChanged" PageSize="5" 
        onrowcommand="gvNews_RowCommand" Width="662px" 
        onrowdatabound="gvNews_RowDataBound" onrowdeleting="gvNews_RowDeleting">
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <input ID="chkall" type="checkbox" onclick="checkall(this)" />全选
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="chk" runat="server" />
                </ItemTemplate>
                <HeaderStyle Wrap="False" />
            </asp:TemplateField>
            <asp:BoundField DataField="NewsId" HeaderText="新闻编号" 
                SortExpression="NewsId" >
            <ControlStyle Width="50px" />
            <HeaderStyle Width="50px" Wrap="False" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="新闻类型" SortExpression="Type">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Type") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("Type.title") %>'></asp:Label>
                </ItemTemplate>
                <ControlStyle Width="50px" />
                <HeaderStyle Width="50px" Wrap="False" />
            </asp:TemplateField>
            <asp:BoundField DataField="Title" HeaderText="新闻标题" SortExpression="Title" >
            <ControlStyle Width="150px" />
            <HeaderStyle Wrap="False" />
            </asp:BoundField>
            <asp:ImageField DataImageUrlField="PictureUrl" 
                DataImageUrlFormatString="~/userFiles/{0}" HeaderText="新闻图片">
                <ControlStyle Width="100px" />
            </asp:ImageField>
            <asp:BoundField DataField="PublishDate" DataFormatString="{0:yyyy-MM-dd}" 
                HeaderText="发布日期" SortExpression="PublishDate" >
            <HeaderStyle Wrap="False" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="内容" SortExpression="Contents">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Contents") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Cut(Eval("Contents")) %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="详细信息">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" 
                        CommandArgument='<%# Eval("newsid") %>' CommandName="details">查看详情</asp:LinkButton>
                </ItemTemplate>
                <ControlStyle Width="50px" />
                <HeaderStyle Wrap="False" />
            </asp:TemplateField>
            <asp:CommandField HeaderText="删除" ShowDeleteButton="True">
            <ControlStyle Width="30px" />
            </asp:CommandField>
            <asp:TemplateField HeaderText="模板删除">
                <ItemTemplate>
                    <asp:LinkButton ID="ldelet" runat="server" 
                        CommandArgument='<%# Eval("newsid") %>' CommandName="ndelet">删除</asp:LinkButton>
                </ItemTemplate>
                <ControlStyle Width="30px" />
                <HeaderStyle Wrap="False" />
            </asp:TemplateField>
        </Columns>
        <EmptyDataTemplate>
            没有符合条件的新闻
        </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource ID="objNews" runat="server" 
        SelectMethod="GetAllNews" TypeName="MySchool.BLL.NewsManager" 
        DeleteMethod="DeleteNewsId">
        <DeleteParameters>
            <asp:Parameter Name="newsId" Type="Int32" />
        </DeleteParameters>
    </asp:ObjectDataSource>
    <asp:DropDownList ID="ddlSelect" runat="server" 
        DataSourceID="ObjectDataSource1" DataTextField="Title" DataValueField="TypeId">
    </asp:DropDownList>
    <asp:Button ID="btnSelect" runat="server" Text="查找" />
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="objNewsType" 
        DataTextField="Title" DataValueField="TypeId">
    </asp:DropDownList>
    <asp:Button ID="btnModify" runat="server" onclick="btnModify_Click" 
        Text="修改类别" />
    <asp:ObjectDataSource ID="objNewsType" runat="server" 
        SelectMethod="GetAllNewsTypes" TypeName="MySchool.BLL.NewsTypeManager">
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="GetAllNewsTypes" TypeName="MySchool.BLL.NewsTypeManager">
    </asp:ObjectDataSource>
    </form>
</asp:Content>

