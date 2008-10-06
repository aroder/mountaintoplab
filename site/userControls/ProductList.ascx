<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductList.ascx.cs"
    Inherits="lab.userControls.ProductList" %>
<style type="text/css">
    #ProductList table td
    {
        padding: 5px;
    }
    #ProductList .ProductTitle
    {
        font-size: larger;
    }
    #ProductList .ProductListPrice
    {
        text-align: right;
    }
    #ProductList .ProductDescription
    {
    }
    #ProductList th
    {
        text-align: left;
    }
</style>
<div id="ProductList">
    <asp:Repeater ID="ProductListRepeater" runat="server">
        <HeaderTemplate>
            <table width="100%" border="1">
                <tr>
                    <th>
                        Name
                    </th>
                    <th>
                        Turnaround
                    </th>
                    <th>
                        Price
                    </th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td class="ProductTitle">
                    <%# Eval("Name") %>
                </td>
                <td class="ProductTurnaround">
                    <%# GetTurnaroundText(int.Parse(Eval("TurnaroundDays").ToString())) %>
                </td>
                <td class="ProductListPrice">
                    <%# Eval("ListPrice", "{0:c}") %>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</div>
