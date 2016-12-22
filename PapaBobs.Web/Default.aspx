<%@ Page Language="C#" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaBobs.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Papa Bob's Pizza</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">

        <div class="page-header">
            <h1>Papa Bob's Pizza</h1>
            <p class="lead">Pizza to Code By</p>
        </div>

        <div class="form-group">
            <label>Size: </label>
            <asp:dropdownlist id="dropDownSize" class="form-control" runat="server" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="recalculateTotalCost" >
                <asp:ListItem text="Select A Size" value=""></asp:ListItem>
                <asp:ListItem text ="Small (12 inch - $12)" value="Small"></asp:ListItem>
                <asp:ListItem text ="Medium (14 inch - $14)" value="Medium"></asp:ListItem>
                <asp:ListItem text ="Large (16 inch - $16)" value="Large"></asp:ListItem>
            </asp:dropdownlist>            
        </div>

        <div class="form-group">
            <label>Crust: </label>
            <asp:dropdownlist id="dropDownCrust" class="form-control" runat="server" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="recalculateTotalCost">
                <asp:ListItem text="Select A Crust" value=""></asp:ListItem>
                <asp:ListItem text="Regular" value="Regular"></asp:ListItem>
                <asp:ListItem text="Thin" value="Thin"></asp:ListItem>
                <asp:ListItem text="Thick (+ $2)" value="Thick"></asp:ListItem>
            </asp:dropdownlist>
        </div>

        <div class ="checkbox"><label><asp:checkbox id="checkBoxSausage" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"></asp:checkbox> Sausage</label></div>
        <div class ="checkbox"><label><asp:checkbox id="checkBoxPepperoni" runat="server" AutoPostBack="true"  OnCheckedChanged="recalculateTotalCost"></asp:checkbox> Pepperoni</label></div>
        <div class ="checkbox"><label><asp:checkbox id="checkBoxOnions" runat="server" AutoPostBack="true"  OnCheckedChanged="recalculateTotalCost"></asp:checkbox> Onions</label></div>
        <div class ="checkbox"><label><asp:checkbox id="checkBoxGreenPeppers" runat="server" AutoPostBack="true"  OnCheckedChanged="recalculateTotalCost"></asp:checkbox> Green Peppers</label></div> 

        <h3>Deliver To:</h3>

        <div class="form-group">
            <label>Name:</label>
            <asp:textbox id="textBoxName" class="form-control" runat="server" AutoPostBack="true"></asp:textbox>
        </div>

        <div class="form-group">
            <label>Address:</label>
            <asp:textbox id="textBoxAddress" class="form-control" runat="server" AutoPostBack="true"></asp:textbox>
        </div>

        <div class="form-group">
            <label>Zip:</label>
            <asp:textbox id="textBoxZip" class="form-control" runat="server" AutoPostBack="true"></asp:textbox>
        </div>

        <div class="form-group">
            <label>Phone:</label>
            <asp:textbox id="textBoxPhone" class="form-control" runat="server" AutoPostBack="true"></asp:textbox>
        </div>

        <h3>Payment:</h3>

        <div class="radio"><label><asp:radiobutton id="radioCash" checked="true" value="Cash" GroupName="PaymentGroup" runat="server" AutoPostBack="true"></asp:radiobutton> Cash</label></div>
        <div class="radio"><label><asp:radiobutton id="radioCredit" value="Credit" GroupName="PaymentGroup" runat="server" AutoPostBack="true"></asp:radiobutton> Credit</label></div>
        
        <asp:label id="labelValidation" class="bg-danger" runat="server" visible="false"></asp:label>
        
        <h3>Total Cost: <asp:label id="labelTotal" text="" runat="server" ></asp:label></h3>

        <p>&nbsp</p>
        
        <asp:button id="buttonOrder" class="btn btn-primary" runat="server" text="Order" OnClick="buttonOrder_Click" />

        </div>
    </div>
    </form>

    

    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
</body>    
</html>
