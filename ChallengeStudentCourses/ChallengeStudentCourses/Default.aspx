<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeStudentCourses.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Assignment1" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Assignment2" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Assignment3" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
