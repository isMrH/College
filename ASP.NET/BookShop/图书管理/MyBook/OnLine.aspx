<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OnLine.aspx.cs" Inherits="OnLine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="10pt" 
        ForeColor="#009933" Text="在线列表"></asp:Label>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
        <div class="content">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                Width="258px">
                <EmptyDataRowStyle BorderStyle="Solid" />
                <Columns>
                    <asp:BoundField DataField="LoginId" HeaderText="用户名">
                    <ControlStyle 
                        ForeColor="#009933" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Address" HeaderText="地址">
                    <ControlStyle 
                        ForeColor="#009933" />
                    </asp:BoundField>
                </Columns>
            </asp:GridView>
            <asp:Timer ID="Timer1" runat="server" Interval="1000" ontick="Timer1_Tick">
            </asp:Timer>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
</asp:Content>
