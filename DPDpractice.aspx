<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DPDpractice.aspx.cs" Inherits="WebApplication1.DPDpractice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="City name:"></asp:Label>
            &nbsp;
            &nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Height="27px" Width="216px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="margin-left: 30px">
            </asp:DropDownList>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Area"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" Height="22px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" style="margin-left: 112px" Width="215px">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="street"></asp:Label>
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" Height="22px" style="margin-left: 107px" Width="215px">
            </asp:DropDownList>
        </p>
    </form>
</body>
</html>
