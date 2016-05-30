<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ShowDropDownList" runat="server"></asp:DropDownList><br/>
        <asp:DropDownList ID="VenueDropDownList" runat="server"> </asp:DropDownList>
        <asp:GridView ID="ShowGridView2" runat="server"></asp:GridView>
        <asp:Button ID="VenueShowButton" runat="server" Text="GetShows" OnClick="VenueButton_Click" />
        <br />
        <asp:DropDownList ID="ArtistDropDownList" runat="server"></asp:DropDownList>
        <asp:GridView ID="ShowGridView" runat="server"></asp:GridView>
        <asp:Button ID="ShowButton" runat="server" Text="Get Shows" OnClick="ShowButton_Click" />
    </div>
    </form>
</body>
</html>
