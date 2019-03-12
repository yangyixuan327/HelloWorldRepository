<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeworkPrintChar.aspx.cs" Inherits="HelloWorld.homeworkPrintChar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            请输入行数<asp:TextBox ID="txtLines" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnPrintTriangle" runat="server" OnClick="btnPrintTriangle_Click" Text="输出图形" />
        </div>
    </form>
</body>
</html>
