<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddShow.aspx.cs" Inherits="AddShow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Add A Show!</h1>
        <hr />
    <table>
        <tr>
            <td>Show Name</td>
            <td>
                <asp:TextBox ID="ShowNameTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
               
            </td>
        </tr>
        
        <tr>
            <td>ShowDate</td>
            <td>
                <asp:TextBox ID="ShowDateTextBox" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>ShowTicketInfo</td>
            <td>
                <asp:TextBox ID="ShowTicketInfoTextBox" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
        <tr>
            <td>Artist Key</td>
            <td>
                <asp:TextBox ID="ArtistKeyTextBox" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>ShowDetail Artist Start Time</td>
            <td>
                <asp:TextBox ID="ShowDetailArtistStartTimeTextBox" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>Show Detail Additional</td>
            <td>
                <asp:TextBox ID="ShowDetailAdditionalTextBox" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
            </td>
            <td>
                <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
