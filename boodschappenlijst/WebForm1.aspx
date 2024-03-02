﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="boodschappenlijst.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
               <h1>boodschappenlijst</h1>
            <p>product: </p>
            <asp:TextBox ID="TbProduct" runat="server"></asp:TextBox><br /><br />
            <p>aantal: </p>
            <asp:TextBox ID="TbAantal" runat="server"></asp:TextBox><br /><br />
            <p>extra: </p>
            <asp:TextBox ID="TbExtra" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="btnAdd" runat="server" Text="Toevoegen" OnClick="btnAdd_Click" /><br /><br />
            <asp:ListBox ID="lbOutput" Rows="10"  runat="server"></asp:ListBox>
        </div>
    </form>
</body>
</html>