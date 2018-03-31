<%@ Control Language="C#" AutoEventWireup="true" CodeFile="datalist.ascx.cs" Inherits="datalist" %>

<style type="text/css">
    .style1
    {
        width: 134px;
    }
    .style2
    {
        width: 149px;
    }
    .style3
    {
        width: 149px;
        height: 125px;
    }
</style>
 <br /><br />
&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="显示页数"></asp:Label>
:<asp:TextBox ID="txtnumber" runat="server" BorderColor="#99FF66" 
    BorderWidth="1px" Height="20px" Width="158px"></asp:TextBox>
<asp:Button ID="btnsearch" runat="server" Height="21px" 
    onclick="btnsearch_Click" Text="查看" Width="60px" />
    <br /><br />

<asp:DataList ID="dataBooks" runat="server" DataKeyField="Id" RepeatColumns="5" 
    RepeatDirection="Horizontal" Width="688px" 
    onselectedindexchanged="dataBooks_SelectedIndexChanged">
   <HeaderTemplate >
            &nbsp;
            
            <asp:Label ID="lblmessage" runat="server" Text="主编推荐" Font-Bold="True" 
            Font-Names="黑体" Font-Overline="False" Font-Size="X-Large" Font-Strikeout="False" 
            Font-Underline="False" ForeColor="#33CCFF"></asp:Label>
            <br /><br />
    </HeaderTemplate>
    <ItemTemplate>
        <table class="style1">
            <tr>
                <td class="style3">
                    <asp:Image ID="imgpicture" runat="server" 
                        ImageUrl='<%# Eval("ISBN","~/Image/{0}.jpg") %>' Height="125px" 
                        Width="100px" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                      <a href='bookshow.aspx?id=<%#Eval("id") %>'><asp:Label ID="lbltitle" runat="server" Text='<%# Eval("Title") %>'></asp:Label></a>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    人气指数：<asp:Label ID="lblclick" runat="server" Text='<%# Eval("Clicks") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                   &nbsp;&nbsp; &yen<asp:Label ID="lblmoney" runat="server" Text='<%# Eval("UnitPrice") %>'></asp:Label>
                </td>
            </tr>
        </table>
    </ItemTemplate>
</asp:DataList>


