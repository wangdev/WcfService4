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
                    <asp:RequiredFieldValidator ErrorMessage="Id is Required" ControlToValidate="tbxId" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="tbxName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ErrorMessage="Name is Required" ControlToValidate="tbxName" runat="server" />
                    <asp:RangeValidator ErrorMessage="Name Length must be 3 - 20" ControlToValidate="tbxName" runat="server" MaximumValue="3" MinimumValue="50" />
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
                <asp:Label ID="lblStatus" runat="server"></asp:Label>
            </table> 
    </div>
    </form>
</body>
</html>
