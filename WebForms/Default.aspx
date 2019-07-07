<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="inputLabel" runat="server" Text="Enter your current age:" />
            <asp:TextBox ID="ageTextbox" runat="server" />
            <br />
            <asp:Button ID="submitButton" runat="server" Text="Get age in 10 years!" OnClick="submitButton_Click" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
