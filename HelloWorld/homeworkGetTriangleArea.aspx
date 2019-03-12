<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeworkGetTriangleArea.aspx.cs" Inherits="HelloWorld.homeworkGetTriangleArea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            请输入第一条边<asp:TextBox ID="txtLine1" runat="server"></asp:TextBox>
            <br />
            请输入第二条边<asp:TextBox ID="txtLine2" runat="server"></asp:TextBox>
            <br />
            请输入第三条边<asp:TextBox ID="txtLine3" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnGetArea" runat="server" Text="求三角形面积" OnClick="btnGetArea_Click1" />
        </div>
    </form>
</body>
</html>
