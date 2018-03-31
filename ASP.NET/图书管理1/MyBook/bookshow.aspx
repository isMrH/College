<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="bookshow.aspx.cs" Inherits="bookshow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="Server">
    <table style="width: 104%; height: 338px">
    <tr>
        <td rowspan="6" style="width: 138px">
            <asp:Image ID="imgpicture" runat="server" Height="150px" Width="100px" />
        </td>
        <td colspan="2" style="height: 34px" >
            <asp:Label ID="lblmessage" runat="server" BorderStyle="None" Font-Bold="True" 
                Font-Size="Medium" ForeColor="Red" Text="搜索结果"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2" style="height: 17px">
            <asp:Label ID="lbltitle" runat="server" Font-Bold="True" Font-Size="Medium" 
                ForeColor="#0066CC" Text="lbltitle"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="height: 26px; width: 232px">
            作者：<asp:Label ID="lblauthor" runat="server" Text="lblauthor"></asp:Label>
        </td>
        <td style="height: 26px">
            丛书名：<asp:Label ID="lblname" runat="server" Text="lblname"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 232px; height: 29px">
            出版社：<asp:Label ID="lblpusher" runat="server" Text="lblpusher"></asp:Label>
        </td>
        <td style="height: 29px">
            IBSN：<asp:Label ID="lblISBN" runat="server" Text="lblISBN"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="height: 18px; width: 232px">
            出版时间：<asp:Label ID="lblpusherdata" runat="server" Text="lblpusherdata"></asp:Label>
        </td>
        <td style="height: 18px">
            字数：<asp:Label ID="lblcount" runat="server" Text="lblcount"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 232px; height: 24px">
        </td>
        <td style="height: 24px">
            定价：<asp:Label ID="lblmoney" runat="server" Text="lblmoney"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="3" style="height: 146px">
            内容：<asp:Label ID="lblcontent" runat="server" Text="lblcontent"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="3" align="right">
            <asp:ImageButton ID="ImageButton1" runat="server" 
                ImageUrl="~/Images/sale.gif" onclick="ImageButton1_Click" /></td>    
    </tr>
     <tr>
        <td colspan="3" align="center">
           
            <asp:Button ID="btnback" runat="server" Text="返回列表" onclick="btnback_Click" />
           
        </td>
    </tr>
</table>
</asp:Content>

