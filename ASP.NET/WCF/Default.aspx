<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" Debug="true"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
      *{ margin:0px auto; padding:0px;}
      .father{ width:600px; height:400px; padding-top:10px}
      #content{ margin-top:10px;}
      #title{text-align:center;}
      #style{ text-align:right;width:100px;height:30px;}
      #btnExit{ margin-left:20px;}
      table{border:solid 1px #c1c1c1; width:304px;
        }
      table tr{border:solid 1px #c1c1c1;}
      
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="father">
        <div id=title>添加商品</div>
        <div id="content">
        <table border="0" cellpadding="1" cellspacing="1">
            <tr>
               <td id="style">商品名称：</td>
               <td>
                   <asp:TextBox ID="txtName" runat="server" Width="132px" BorderColor="Black" 
                       BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                       ControlToValidate="txtName" Display="Dynamic" ErrorMessage="*" 
                       ValidationGroup="yanzheng"></asp:RequiredFieldValidator>
                   </td>
            </tr>
            <tr>
               <td id="style">数量：</td>
               <td>
                   <asp:TextBox ID="txtCount" runat="server" BorderColor="Black" 
                       BorderStyle="Solid" BorderWidth="1px" Width="132px"></asp:TextBox>
                   <asp:CompareValidator ID="CompareValidator1" runat="server" 
                       ControlToValidate="txtCount" Display="Dynamic" ErrorMessage="*" 
                       Operator="DataTypeCheck" Type="Integer" ValidationGroup="yanzheng"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
               <td id="style">单价：</td>
               <td>
                   <asp:TextBox ID="txtPrice" runat="server" BorderColor="Black" 
                       BorderStyle="Solid" BorderWidth="1px" Width="132px"></asp:TextBox>
                   <asp:CompareValidator ID="CompareValidator2" runat="server" 
                       ControlToValidate="txtPrice" Display="Dynamic" ErrorMessage="*" 
                       Operator="DataTypeCheck" Type="Double" ValidationGroup="yanzheng"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
               <td id="style">供应商：</td>
               <td>
                   <asp:TextBox ID="txtCompany" runat="server" BorderColor="Black" 
                       BorderStyle="Solid" BorderWidth="1px" Width="132px"></asp:TextBox>
                </td>
            </tr>
            <tr>
               <td colspan="2" align="center">
                   <asp:Button ID="btnAdd" runat="server" Text="添加" onclick="btnAdd_Click" 
                       ValidationGroup="yanzheng" />
                   <asp:Button ID="btnExit" runat="server" Text="退出" onclick="btnExit_Click" />
               </td>
               
            </tr>
        </table>
        </div>
    </div>
    </form>
</body>
</html>
