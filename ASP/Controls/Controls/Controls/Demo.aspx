<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="Controls.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <title> My first C# Form </title>
</head>
<body>
    <div class="container-fluid p-5 bg-primary text-white text-center">
      <h1>My first C# Form</h1>
      <p>Using Bootstrap 5 & Jquery</p> 
    </div>

    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" Text=""></asp:TextBox>
        </div>
        <p />
        <div>
            <asp:ListBox ID="lstLocation" runat="server">
                <asp:ListItem>item1</asp:ListItem>
                <asp:ListItem>item2</asp:ListItem>
                <asp:ListItem>item3</asp:ListItem>
                <asp:ListItem>item4</asp:ListItem>
            </asp:ListBox>
        </div>
        <p />
        <div>
            <asp:RadioButton id="red" Text="Red" Checked="True" GroupName="colors" runat="server"/>
            <br />
            <asp:RadioButton id="green" Text="Green" GroupName="colors" runat="server"/>
            <br />
            <asp:RadioButton id="blue" Text="Blue" GroupName="colors" runat="server"/>
            
        </div>
        <p />
        <div>
            <asp:CheckBox id="CheckBox1" runat="server"  />check01
            <asp:CheckBox id="CheckBox2" runat="server"  />check02
            <asp:CheckBox id="CheckBox3" runat="server"  />check03
        </div>
        <p />
        <div>
            <button type="button" class="btn btn-primary" id="jsSubmit">jsSubmit</button>
            <asp:Button CssClass="btn btn-primary" id="serverSubmit" Text="serverSubmit" runat="server" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>

<script type="text/javascript">
    $(document).ready(function () {

        $("#jsSubmit").click(function () {
            console.log("btn click");
        });

    });

</script>
