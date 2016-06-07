<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login or Register</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Login or Register</h1>
        <hr/>
        <table>
            <tr>
                <td>Username</td>
                <td>
                    <asp:TextBox ID="userTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
               <td>
                   <asp:Button ID="LoginButton" runat="server" Text="Log In" OnClick="LoginButton_Click" />
               </td> 
                <td>
                    <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
        <asp:LinkButton ID="RegisterLink" runat="server" PostBackUrl="Register.aspx">Register Venue</asp:LinkButton>
    </div>
    </form>
</body>
</html>
