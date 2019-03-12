<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetMax.aspx.cs" Inherits="HelloWorld.GetMax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            请输入第一个数<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            请输入第二个数<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            请输入第三个数<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="输出最大值" OnClick="Button1_Click1" />
            <br />
        </div>
    </form>
</body>
</html>
