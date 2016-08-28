<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ChallengeSimpleCalculator._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Calculator</title>
    <link href="https://fonts.googleapis.com/css?family=Oswald" rel="stylesheet"/>
    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Simple calculator</h1><br />
        <br />
        First Value:&nbsp;
        <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Second Value:&nbsp;
        <asp:TextBox ID="secondTextBox" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="plusButton" runat="server" OnClick="plusButton_Click" Text="+" />
&nbsp;
        <asp:Button ID="minusButton" runat="server" OnClick="minusButton_Click" Text="-" />
&nbsp;
        <asp:Button ID="multButton" runat="server" Text="*" OnClick="multButton_Click" />
&nbsp;
        <asp:Button ID="divisionButton" runat="server" Text="/" OnClick="divisionButton_Click" />
        <br />
        <br />
        Result:&nbsp;
        <asp:Label ID="resultLabel" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
