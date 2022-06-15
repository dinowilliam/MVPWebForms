<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MVPWebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Calcule the Area of a Circle</h1>                
        <h2>Fill the Radius(r) value:</h2>                 
        <p>
            <asp:TextBox ID="txtRadius" runat="server"></asp:TextBox>
            <br>
            <asp:RequiredFieldValidator ID="txtRadiusRequiredFieldValidator" runat="server" ErrorMessage="Radius cannot be blank" ControlToValidate="txtRadius" ForeColor="Red"></asp:RequiredFieldValidator>             
            <asp:CompareValidator ID="txtRadiusCompareValidator" runat="server" ErrorMessage="Field need be numeric" Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtRadius" ForeColor="Red"></asp:CompareValidator>
        </p>                 
        <h2>Result:</h2>
        <p><asp:Label ID="lblArea" runat="server" ForeColor="red"></asp:Label></p>                 
        <p><asp:Button ID="btnResult" runat="server" CssClass="btn btn-primary btn-lg" Text="Área Value" OnClick="btnResult_Click"/></p>                
    </div>

</asp:Content>
