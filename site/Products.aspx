<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="lab.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <h1>Price Sheet</h1>
    <controls:ProductList id="ProductList" runat="server" />
</asp:Content>
