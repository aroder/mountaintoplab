<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="lab.userControls.Menu" %>

<script type="text/javascript">
    $(document).ready(function() {
        $("#nav a").each(function() {
            //current contains a jquery object representing the anchor element
            var current = $(this).filter(function() {
                return this.href.toLowerCase() == location.href.toLowerCase();
            });

            // current.length will be true if the anchor's href tag matches the current url
            if (current.length) {
                current.addClass("active");
                // expand the parents (and the current node) of the node that contains the url of the current page

            }
        });
    });
</script>

<ul id="nav">
    <li><img src="../images/mountain_clipart.gif" height="70" width="100" style="margin-left: -10px; position: absolute; top: 8px; left: 10px;" /><a></a></li><!-- -->
    <li>
        <asp:HyperLink ID="HomeLink" runat="server" NavigateUrl="~/Default.aspx" Text="Home" /></li>
    <li>
        <asp:HyperLink ID="ProductsLink" runat="server" NavigateUrl="~/Products.aspx" Text="Products" /></li>
    <li>
    <asp:HyperLink ID="ServicesLink" runat="server" NavigateUrl="~/Services.aspx" Text="Services" /></li>
    <li><asp:HyperLink ID="TurnaroundLink" runat="server" NavigateUrl="~/Turnaround.aspx" Text="Turnaround" /></li>
        <li><a href="#">We're Better</a></li>
        
    <li><a class="last"></a></li><!-- -->
</ul>
