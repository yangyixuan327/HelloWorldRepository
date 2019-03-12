<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeworkStringOffset.aspx.cs" Inherits="HelloWorld.homeworkStringOffset" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            请输入字符串<asp:TextBox ID="txtString" runat="server"></asp:TextBox>
            <br />
            右移位数<asp:TextBox ID="txtMove" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="输出" />
        </div>
    </form>
</body>
</html>
