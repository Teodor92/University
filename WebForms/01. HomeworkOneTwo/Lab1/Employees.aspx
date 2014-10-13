<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="Lab1.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" GroupingText="Add" runat="server">
            <asp:Table ID="Table1" runat="server">

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LabelEmployeeID" runat="server" AssociatedControlID="TextBoxEmployeeID" Text="Employee ID:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBoxEmployeeID" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator 
                            ValidationGroup="validation_group_1" 
                            ControlToValidate="TextBoxEmployeeID" ErrorMessage="Полето е задължително!" runat="server" />
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LabelFirstName" runat="server" AssociatedControlID="TextBoxFirstName" Text="First Name:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator 
                            ValidationGroup="validation_group_1"
                            ControlToValidate="TextBoxFirstName" ErrorMessage="Полето е задължително!" runat="server" />
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LabelLastName" runat="server" AssociatedControlID="TextBoxLastName" Text="Last Name:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator 
                            ValidationGroup="validation_group_1"
                            ControlToValidate="TextBoxLastName" ErrorMessage="Полето е задължително!" runat="server" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LabelPosition" runat="server" AssociatedControlID="TextBoxPosition" Text="Position:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBoxPosition" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LabelEGN" runat="server" AssociatedControlID="TextBoxEGN" Text="EGN:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBoxEGN" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator 
                            ControlToValidate="TextBoxEGN" ErrorMessage="ЕГН-то не е валидно! Пример: 1234567890" 
                             ValidationExpression="\d{10}" ValidationGroup="validation_group_1" runat="server" />
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LabelAddress" runat="server" AssociatedControlID="TextBoxAddress" Text="Address:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox TextMode="MultiLine" Rows="3" ID="TextBoxAddress" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="LabelTelephone" runat="server" AssociatedControlID="TextBoxTelephone" Text="Telephone:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBoxTelephone" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator 
                            ControlToValidate="TextBoxTelephone" ErrorMessage="Телефонът не е валиден! Пример: 1234567890" 
                            ValidationExpression="\d{10}" ValidationGroup="validation_group_1" runat="server" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <asp:Button CausesValidation="true" Text="Save" ValidationGroup="validation_group_1" runat="server" />
            <asp:Button Text="Cancel" runat="server" />

            <asp:AdRotator KeywordFilter="banner" AdvertisementFile="~/Ads.xml" runat="server" />
        </asp:Panel>
    </form>
</body>
</html>
