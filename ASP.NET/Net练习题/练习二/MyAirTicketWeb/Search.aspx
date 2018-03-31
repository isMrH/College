<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        *
        {
            margin: 0px;
            padding: 0px;
            font-size: 12px;
        }
        #Wapper
        {
            width: 600px;
            margin: 50px auto;
        }
        .col
        {
            margin-top: 5px;
        }
        #gvTicket
        {
            text-align: center;
        }
    </style>
</head>
<body>
    <div id="Wapper">
        <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <div class="col">
                        <asp:Label ID="Label1" runat="server" Text="请选择出发地："></asp:Label>
                        <asp:DropDownList ID="ddlProvince" runat="server" OnSelectedIndexChanged="ddlProvince_SelectedIndexChanged"
                            AutoPostBack="True">
                        </asp:DropDownList>
                        <asp:Label ID="Label2" runat="server" Text="（省）"></asp:Label>
                        <asp:DropDownList ID="ddlCity" runat="server" AppendDataBoundItems="True">
                        </asp:DropDownList>
                        <asp:Label ID="Label3" runat="server" Text="（市）"></asp:Label>
                    </div>
                    <div class="col">
                        <asp:Label ID="Label4" runat="server" Text="请选择到达地："></asp:Label>
                        <asp:DropDownList ID="ddlProvince1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvince1_SelectedIndexChanged">
                        </asp:DropDownList>
                        <asp:Label ID="Label5" runat="server" Text="（省）"></asp:Label>
                        <asp:DropDownList ID="ddlCity1" runat="server" AppendDataBoundItems="True">
                        </asp:DropDownList>
                        <asp:Label ID="Label6" runat="server" Text="（市）"></asp:Label>
                    </div>
                    <div class="col">
                        <asp:Label ID="Label7" runat="server" Text="请选择日期："></asp:Label>
                        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="请选择日期：" />
                        <asp:Button ID="btnSelect" runat="server" OnClick="btnSelect_Click" Text="查询" />
                    </div>
                    &nbsp;<asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"
                        Visible="False" DayNameFormat="Shortest" Width="154px"></asp:Calendar>
                    <asp:GridView ID="gvTicket" runat="server" AutoGenerateColumns="False" CellPadding="4"
                        GridLines="None" Width="596px">
                        <Columns>
                            <asp:BoundField DataField="FlightOrder" HeaderText="航班" />
                            <asp:BoundField DataField="FromCity" HeaderText="出发地" />
                            <asp:BoundField DataField="ToCity" HeaderText="目的地" />
                            <asp:BoundField DataField="Price" HeaderText="票价(元)" />
                            <asp:BoundField DataField="LeaveDate" HeaderText="日期" />
                            <asp:BoundField DataField="RoomType" HeaderText="舱类型" />
                        </Columns>
                    </asp:GridView>
                    <br />
                    <hr />
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
        </div>
        </form>
    </div>
</body>
</html>
