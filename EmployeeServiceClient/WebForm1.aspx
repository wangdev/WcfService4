<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EmployeeServiceClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <label>ID:</label>
                </td>
                <td>
                    <label>Name:</label>
                </td>
                <td>
                    <label>Gender:</label>
                </td>
                <td>
                    <label>DateOfBirth</label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tbxId" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="tbxName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="tbxGender" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="tbxDateOfBirth" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnGetEmployee" runat="server" Text="Get" OnClick="btnGetEmployee_Click" />
                </td>
                <td>
                    <asp:Button ID="btnSaveEmployee" runat="server" Text="Save" OnClick="btnSaveEmployee_Click" />
                </td>
            </tr>
            <tr>
                <asp:Label ID="lblStatus" runat="server"></asp:Label>
            </tr>
        </table> 
    </div>
    </form>
</body>
</html>
