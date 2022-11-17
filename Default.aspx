<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        /*code: 48-57 Numbers*/
        function restrictAlphabets(e) {
            var x = e.which || e.keycode;
            if ((x >= 48 && x <= 57))
                return true;
            else
                return false;
        }
        

        function setValue(node) {
            var txtBoxValue = document.getElementById("txtNumber").value;
            if (txtBoxValue > 1000) {
                alert("Please Enter number between 1 to 1000");
                document.getElementById("txtNumber").value = "";
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtNumber" AutoPostBack="true" OnTextChanged="txtNumber_TextChanged"   onkeypress='return restrictAlphabets(event)' onchange = "setValue(this);" TextMode="Number" MaxLength="4"  min="1" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
runat="server" ErrorMessage="Enter only positive integer values."
ControlToValidate="txtNumber" ValidationExpression="^[1-9][0-9]*$"
CssClass="required" Display="Dynamic" />
            <asp:GridView ID="GridView1" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound"   EmptyDataText="! Sorry No data found"
                AutoGenerateColumns="true" PageSize="20" AllowPaging="True" runat="server"></asp:GridView>

        </div>
    </form>
</body>
</html>
