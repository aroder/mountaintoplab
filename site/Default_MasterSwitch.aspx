<%@ Page Title="" Language="C#" AutoEventWireup="True" Inherits="_Default_MasterSwitch" Codebehind="Default_MasterSwitch.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headContent" Runat="Server">
</asp:Content>

<asp:Content ID="topContent" ContentPlaceHolderID="topContent" runat="server">
        <div style="position: absolute; right: 30px; top: 40px; padding: 10px; border: 2px solid black; background-color: White; color: Black;">
        Choose Layout: <asp:DropDownList ID="MasterSwitch" runat="server" AutoPostBack="true">
            <asp:ListItem Value="1">One</asp:ListItem>
            <asp:ListItem Value="2">Two</asp:ListItem>
            <asp:ListItem value="3">Three</asp:ListItem>
            <asp:ListItem Value="4">Four</asp:ListItem>
            <asp:ListItem Value="5">Five</asp:ListItem>
            <asp:ListItem Value="6">Six</asp:ListItem>
            <asp:ListItem Value="7">Seven</asp:ListItem>
            <asp:ListItem Value="8">Eight</asp:ListItem>
            <asp:ListItem Value="9">Nine</asp:ListItem>
            <asp:ListItem Value="10">Ten</asp:ListItem>
            <asp:ListItem Value="11">Eleven</asp:ListItem>
            <asp:ListItem Value="12">Twelve</asp:ListItem>
        </asp:DropDownList>
        </div>
</asp:Content>

<%--<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server"></asp:Content>
--%>
