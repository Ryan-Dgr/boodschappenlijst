<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="boodschappenlijst.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <%-- toont de validators niet meer, omdat hij meteen refresht na drukken op de knop --%>


            <h1>boodschappenlijst</h1>
            <p>product: </p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorProduct" runat="server" 
            ControlToValidate="TbProduct" ErrorMessage="Product is verplicht" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidatorProduct" runat="server"
            ControlToValidate="TbProduct"
            ErrorMessage="Product mag maximaal 100 tekens bevatten"
            ValidationExpression="^[\s\S]{0,100}$" />
            <br />
            <asp:TextBox ID="TbProduct" runat="server"></asp:TextBox>
            <br /><br />

            <p>aantal: </p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TbAantal" ErrorMessage="Aantal is verplicht" />
            <asp:RangeValidator ID="RangeValidatorAantal" runat="server"
            ControlToValidate="TbAantal" ErrorMessage="Aantal moet tussen 1 en 250 liggen" 
            MinimumValue="1" MaximumValue="250" Type="Integer" /> 
            <br />
            <asp:TextBox ID="TbAantal" runat="server"></asp:TextBox>
            <br /><br />

            <p>extra: </p>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
            ControlToValidate="TbExtra"
            ErrorMessage="Het veld 'Extra' mag maximaal 250 tekens bevatten"
            ValidationExpression="^[\s\S]{0,100}$" />
            <br />
            <asp:TextBox ID="TbExtra" runat="server"></asp:TextBox>

            <br /><br />
            <asp:Button ID="btnAdd" runat="server" Text="Toevoegen" OnClick="btnAdd_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" /><br /><br />

            <asp:ListBox ID="lbOutput" runat="server" Rows="10" AutoPostBack="true" EnableViewState="true"></asp:ListBox>

            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
