<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="NewsDetails.aspx.cs" Inherits="AdminNews_NewsDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="margin-left: 50px; margin-top: 10px;">
        <fieldset style="width: 90%">
            <legend style="width: 90%">新闻详细</legend>
            <table>
                <tr>
                    <td width="80px">
                        标题:
                    </td>
                    <td>
                        <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        类别:
                    </td>
                    <td>
                        <asp:Label ID="lblType" runat="server" Text=""></asp:Label>      
                    </td>
                </tr>
                <tr>
                    <td>
                        发布者:
                    </td>
                    <td>
                        <asp:Label ID="lblPubliserName" runat="server" Text=""></asp:Label>      
                    </td>
                </tr>
                <tr>
                    <td>
                        发布日期:
                    </td>
                    <td>
                         <asp:Label ID="lblPublisherDate" runat="server" Text=""></asp:Label>      
                    </td>
                </tr>
                <tr>
                    <td>
                        新闻图片:
                    </td>
                    <td>
                        <asp:Image ID="imgNews" runat="server" Width ="80px" Height ="80px" /> 
                    </td>
                </tr>
                <tr>
                    <td>
                        点击量:
                    </td>
                    <td>
                        <asp:Label ID="lblClicks" runat="server" Text=""></asp:Label>      
                    </td>
                </tr>
                <tr>
                    <td>
                        状态:
                    </td>
                    <td>
                         <asp:Label ID="lblState" runat="server" Text=""></asp:Label>      
                    </td>
                </tr>
                <tr>
                    <td>
                        是否置顶:
                    </td>
                    <td>
                        <asp:Label ID="lblTop" runat="server" Text=""></asp:Label>      
                    </td>
                </tr>                         
                
                <tr>
                    <td>
                        内容:
                    </td>
                    <td>
                        <asp:Label ID="lblContents" runat="server" Text=""></asp:Label>      
                    </td>
                </tr>
            </table>
        </fieldset>
        <p>          
           
            <asp:HyperLink ID="hlList" runat="server" NavigateUrl ="~/AdminNews/NewsList.aspx">返回新闻列表</asp:HyperLink> 
        </p>
    </div>
</asp:Content>

