<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="step1_eh.aspx.cs" Inherits="step1_EH.step1_eh" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Miles&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtMiles" runat="server"></asp:TextBox>
        <br />
        Galons&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtGalons" runat="server"></asp:TextBox>
        <br />
        Efficiency&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEfficiency" runat="server" OnTextChanged="txtEfficiency_TextChanged"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="txtCalculate" runat="server" OnClick="txtCalculate_Click" Text="Calculate" />
    
    </div>
    </form>
</body>
</html>
