<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab1._Default" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:Panel ID="Panel1" runat="server">
        <asp:Table runat="server">

            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="LabelOrderID" AssociatedControlID="OrderID" runat="server" Text="Order ID"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="OrderID" runat="server"></asp:TextBox>
                </asp:TableCell>

            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="LabelOrderNumber" AssociatedControlID="OrderNumber" runat="server" Text="Order Number"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="OrderNumber" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>


            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="LabelInvoiceNumber" AssociatedControlID="InvoiceNumber" runat="server" Text="Invoice Number"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="InvoiceNumber" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="LabelEmployeeID" AssociatedControlID="EmployeeID" runat="server" Text="Employee ID"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="EmployeeID" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="LabelCustomerID" AssociatedControlID="CustomerID" runat="server" Text="CustomerID"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="CustomerID" runat="server"></asp:TextBox>
                </asp:TableCell>

            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="LabelDate" AssociatedControlID="Date" runat="server" Text="Date:"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Calendar ID="Date" runat="server"></asp:Calendar>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Button ID="Button1" runat="server" Text="Next" OnClick="Button1_Click" />
    </asp:Panel>

    <asp:Panel ID="Panel2" runat="server" Visible="False">
        <h3>Details</h3>
        <asp:Table runat="server">

            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="LabelProductID" AssociatedControlID="ProductID" runat="server" Text="Product ID"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="ProductID" runat="server"></asp:TextBox>
                </asp:TableCell>

            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="LabelQuantity" AssociatedControlID="Quantity" runat="server" Text="Quantity"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="Quantity" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>


            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="LabelUnitPrice" AssociatedControlID="UnitPrice" runat="server" Text="Unit Price"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="UnitPrice" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Button ID="Button3" runat="server" Text="Previous" OnClick="Button3_Click" />
        <asp:Button ID="Button2" runat="server" Text="Go to total" OnClick="Button2_Click" />
    </asp:Panel>

        <asp:Panel ID="Panel3" runat="server" Visible="false">
        <h3>Calculation</h3>
        <asp:Table runat="server">

            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="LabelTotalAmount" AssociatedControlID="TotalAmount" runat="server" Text="Total Amount"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="TotalAmount" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Button ID="Button4" runat="server" Text="Previous" OnClick="Button4_Click" />
    </asp:Panel>

</asp:Content>
