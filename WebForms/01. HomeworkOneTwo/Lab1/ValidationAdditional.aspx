<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationAdditional.aspx.cs" Inherits="Lab1.ValidationAdditional" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="ButtonNewCounterParty" PostBackUrl="~/ValidationAdditional.aspx" Text="нов контрагент" Enabled="false" runat="server" />
            <asp:Panel ID="Panel1" GroupingText="Контрагент" runat="server">
                <asp:Table ID="Table1" runat="server">

                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelNumber" runat="server" Text="Номер:"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell></asp:TableCell>
                        <asp:TableCell>
                            <asp:Label ID="LabelCounterParty" AssociatedControlID="CounterParty" runat="server" Text="Вид контрагент:"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:DropDownList 
                                OnSelectedIndexChanged="CounterParty_SelectedIndexChanged" AutoPostBack="true"
                                ID="CounterParty" Width="140px" runat="server">
                                <asp:ListItem Value="0" Selected="True"> не е определен</asp:ListItem>
                                <asp:ListItem Value="1"> Доставчик</asp:ListItem>
                                <asp:ListItem Value="2"> Оценител</asp:ListItem>
                                <asp:ListItem Value="3"> Потребител</asp:ListItem>
                                <asp:ListItem Value="4"> Агент</asp:ListItem>
                                <asp:ListItem Value="5"> Клиент</asp:ListItem>
                                <asp:ListItem Value="6"> Партньор</asp:ListItem>
                            </asp:DropDownList>
                        </asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelName" runat="server" AssociatedControlID="TextBoxName" Text="Име:*"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator
                                ValidationGroup="validation_group_1"
                                ControlToValidate="TextBoxName" ErrorMessage="Полето е задължително!" runat="server" />
                        </asp:TableCell><asp:TableCell>
                            <asp:Label ID="Label1" runat="server" AssociatedControlID="DropDownListType" Text="Тип:*"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:DropDownList ID="DropDownListType" 
                                OnSelectedIndexChanged="DropDownListType_SelectedIndexChanged" 
                                runat="server">
                                <asp:ListItem Value="0" Selected="True">агент</asp:ListItem>
                                <asp:ListItem Value="1">банка</asp:ListItem>
                                <asp:ListItem Value="2">предприятие</asp:ListItem>
                                <asp:ListItem Value="3">физическо лице</asp:ListItem>
                            </asp:DropDownList>

                            <asp:RequiredFieldValidator
                                ValidationGroup="validation_group_1"
                                ControlToValidate="DropDownListType" ErrorMessage="Полето е задължително!" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelEGN" runat="server" AssociatedControlID="TextBoxEGN"
                                Text="ЕГН/Булстат:*"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxEGN" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator
                                ValidationGroup="validation_group_1"
                                ControlToValidate="TextBoxEGN" ErrorMessage="Полето е задължително!" runat="server" />
                            <asp:RegularExpressionValidator
                                ValidationGroup="validation_group_1"
                                runat="server" ControlToValidate="TextBoxEGN"
                                ValidationExpression="(\d{13})|(\d{10})" ErrorMessage="Моля въведете валидно ЕГН или Булстат" />
                        </asp:TableCell><asp:TableCell>
                            <asp:Label ID="LabelDDS" runat="server" AssociatedControlID="TextBoxDDS"
                                Text="Рег.№ по ДДС:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxDDS" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelIndividualEntity" runat="server" AssociatedControlID="DropDownListIndividualEntity" Text="Физическо/ Юридическо лице:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:DropDownList ID="DropDownListIndividualEntity" runat="server">
                                <asp:ListItem Value=""></asp:ListItem>
                                <asp:ListItem Value="FL">ФЛ</asp:ListItem>
                                <asp:ListItem Value="CO">СО</asp:ListItem>
                                <asp:ListItem Value="ET">ЕТ</asp:ListItem>
                                <asp:ListItem Value="OOD">ООД</asp:ListItem>
                                <asp:ListItem Value="AD">АД</asp:ListItem>
                                <asp:ListItem Value="EOOD">ЕООД</asp:ListItem>
                                <asp:ListItem Value="KD">КД</asp:ListItem>
                            </asp:DropDownList>
                        </asp:TableCell><asp:TableCell>
                            <asp:Label ID="LabelManagementAddress" runat="server" AssociatedControlID="TextBoxManagementAddress"
                                Text="Адрес на управление:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxManagementAddress" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>

                <asp:Button CausesValidation="true" OnClick="ButtonPostback_Click" ID="ButtonPostback" Text="Postback" runat="server"  />

            </asp:Panel>
            <asp:Panel ID="PanelContacts" GroupingText="Контакти" runat="server">
                <asp:Table ID="Table2" runat="server">
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelAddress" AssociatedControlID="TextBoxAddress" runat="server" Text="Адрес:*"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxAddress" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator
                                ValidationGroup="validation_group_1"
                                ControlToValidate="TextBoxAddress" ErrorMessage="Полето е задължително!" runat="server" />
                        </asp:TableCell><asp:TableCell>
                            <asp:Label ID="LabelEmail" AssociatedControlID="TextBoxEmail" runat="server"
                                Text="Ел. поща:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator
                                ValidationGroup="validation_group_1"
                                runat="server" ControlToValidate="TextBoxEmail"
                                ValidationExpression=".*@.{2,}\..{2,}" ErrorMessage="Моля въведете валидна Ел. поща" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelCity" runat="server" AssociatedControlID="TextBoxCity" Text="Населено място:*"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxCity" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator
                                ValidationGroup="validation_group_1"
                                ControlToValidate="TextBoxCity" ErrorMessage="Полето е задължително!" runat="server" />
                        </asp:TableCell><asp:TableCell>
                            <asp:Label ID="LabelOfficeAddress" runat="server" AssociatedControlID="TextBoxOfficeAddress" Text="Адрес офис:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxOfficeAddress" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelTelephone" runat="server" AssociatedControlID="TextBoxTelephone" Text="Телефон:*"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxTelephone" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator
                                ValidationGroup="validation_group_1"
                                runat="server" ControlToValidate="TextBoxTelephone"
                                ValidationExpression="\d{10}" ErrorMessage="Моля въведете валиден 10-цифрен Телефон" />
                            <asp:RequiredFieldValidator
                                ValidationGroup="validation_group_1"
                                ControlToValidate="TextBoxTelephone" ErrorMessage="Полето е задължително!" runat="server" />
                        </asp:TableCell><asp:TableCell>
                            <asp:Label ID="LabelHomeNumber" runat="server" AssociatedControlID="TextBoxHomeNumber" Text="Стационарен телефон:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxHomeNumber" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator
                                ValidationGroup="validation_group_1"
                                runat="server" ControlToValidate="TextBoxHomeNumber"
                                ValidationExpression="\d{6,10}" ErrorMessage="Моля въведете валиден Телефон между 6 и 10 цифри" />
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </asp:Panel>

            <asp:Panel ID="Panel7" GroupingText="Банка" runat="server">
                <asp:Table ID="Table8" runat="server">
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="Label2" AssociatedControlID="TextBoxRegistrationDate" runat="server" Text="Дата на регистрация:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxRegistrationDate" runat="server" Enabled="false" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Calendar OnSelectionChanged="Calendar1_SelectionChanged" ID="Calendar1" runat="server"></asp:Calendar>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </asp:Panel>


            <asp:CheckBox runat="server" Text="Банка" ID="CheckBoxBank" AutoPostBack="true" 
                Checked="true"
                OnCheckedChanged="CheckBoxBank_CheckedChanged" />

            <asp:Panel ID="Panel2" GroupingText="Банка" runat="server">
                <asp:Table ID="Table3" runat="server">
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelBIC1" AssociatedControlID="TextBoxBIC1" runat="server" Text="BIC:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxBIC1" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator
                                ValidationGroup="validation_group_1"
                                runat="server" ControlToValidate="TextBoxBIC1"
                                ValidationExpression="^[0-9a-zA-Z]{8}$"
                                ErrorMessage="Моля въведете валиден BIC" />
                        </asp:TableCell><asp:TableCell>
                            <asp:Label ID="LabelBankName1" AssociatedControlID="TextBoxBankName1" runat="server"
                                Text="Име:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxBankName1" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelIBAN1" runat="server" AssociatedControlID="TextBoxIBAN1" Text="IBAN:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxIBAN1" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator
                                ValidationGroup="validation_group_1"
                                runat="server" ControlToValidate="TextBoxIBAN1"
                                ValidationExpression="[a-zA-Z]{2}[0-9]{2}[a-zA-Z0-9]{4}[0-9]{7}([a-zA-Z0-9]?){0,16}"
                                ErrorMessage="Моля въведете валиден IBAN" />
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </asp:Panel>

                        <asp:CheckBox runat="server" Text="Банка 2" ID="CheckBoxBank2" AutoPostBack="true" 
                Checked="true"
                OnCheckedChanged="CheckBoxBank2_CheckedChanged" />

            <asp:Panel ID="Panel3" GroupingText="Банка 2" runat="server">
                <asp:Table ID="Table4" runat="server">
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelBIC2" AssociatedControlID="TextBoxBIC2" runat="server" Text="BIC:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxBIC2" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator
                                ValidationGroup="validation_group_1"
                                runat="server" ControlToValidate="TextBoxBIC2"
                                ValidationExpression="^[0-9a-zA-Z]{8}$"
                                ErrorMessage="Моля въведете валиден BIC" />
                        </asp:TableCell><asp:TableCell>
                            <asp:Label ID="LabelBankName2" AssociatedControlID="TextBoxBankName2" runat="server"
                                Text="Име:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxBankName2" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelIBAN2" runat="server" AssociatedControlID="TextBoxIBAN2" Text="IBAN:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxIBAN2" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator
                                ValidationGroup="validation_group_1"
                                runat="server" ControlToValidate="TextBoxIBAN2"
                                ValidationExpression="[a-zA-Z]{2}[0-9]{2}[a-zA-Z0-9]{4}[0-9]{7}([a-zA-Z0-9]?){0,16}"
                                ErrorMessage="Моля въведете валиден IBAN" />
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </asp:Panel>
            <asp:Panel ID="Panel4" GroupingText="Представител на контрагента" runat="server">
                <asp:Table ID="Table5" runat="server">
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelCounterPartyRepresentative" AssociatedControlID="TextBoxCounterPartyRepresentative" runat="server"
                                Text="Име:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxCounterPartyRepresentative" runat="server"></asp:TextBox>
                        </asp:TableCell><asp:TableCell>
                            <asp:Label ID="LabelEGNIDN" AssociatedControlID="TextBoxEGNIDN" runat="server"
                                Text="ЕГН/ЛНЧ:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxEGNIDN" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelIndividualContact" runat="server" AssociatedControlID="TextBoxIndividualContact" Text="Лице за контакти:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxIndividualContact" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </asp:Panel>
            <asp:Panel ID="Panel5" GroupingText="Сертификат/Лиценз за Недвижими имоти" runat="server">
                <asp:Table ID="Table6" runat="server">
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelLicenceNumber1" AssociatedControlID="TextBoxLicenceNumber1" runat="server"
                                Text="Номер:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxLicenceNumber1" runat="server"></asp:TextBox>
                        </asp:TableCell><asp:TableCell>
                            <asp:Label ID="LabelIssueDate"
                                AssociatedControlID="TextBoxIssueDate1" runat="server"
                                Text="Дата на издаване:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxIssueDate1" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelPublisher1" runat="server" AssociatedControlID="TextBoxPublisher1" Text="Издател:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxPublisher1" runat="server"></asp:TextBox>
                        </asp:TableCell><asp:TableCell>
                            <asp:Label ID="LabelValidity1" runat="server" AssociatedControlID="TextBoxValidity1" Text="Валидност:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxValidity1" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelRange1" runat="server" AssociatedControlID="TextBoxRange1" Text="Обхват:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxRange1" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </asp:Panel>
            <asp:Panel ID="Panel6"
                GroupingText="Сертификат/Лиценз за оценка на Нематериални ДА" runat="server">
                <asp:Table ID="Table7" runat="server">
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelLicenceNumber2" AssociatedControlID="TextBoxLicenceNumber2" runat="server"
                                Text="Номер:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxLicenceNumber2" runat="server"></asp:TextBox>
                        </asp:TableCell><asp:TableCell>
                            <asp:Label ID="LabelIssueDate2"
                                AssociatedControlID="TextBoxIssueDate2" runat="server"
                                Text="Дата на издаване:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxIssueDate2" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelPublisher2" runat="server" AssociatedControlID="TextBoxPublisher2" Text="Издател:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxPublisher2" runat="server"></asp:TextBox>
                        </asp:TableCell><asp:TableCell>
                            <asp:Label ID="LabelValidity2" runat="server" AssociatedControlID="TextBoxValidity2" Text="Валидност:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxValidity2" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="LabelRange2" runat="server" AssociatedControlID="TextBoxRange2" Text="Обхват:"></asp:Label>
                        </asp:TableCell><asp:TableCell>
                            <asp:TextBox ID="TextBoxRange2" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </asp:Panel>
            <asp:Button CausesValidation="true" Text="Регистрация" ValidationGroup="validation_group_1" runat="server" OnClick="Unnamed2_Click" />
            <asp:Label ID="LabelSuccess" Text="Регистрацията е успешна!" Visible="false" runat="server" />
        </div>
    </form>
</body>
</html>
