﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderManagement.aspx.cs" Inherits="PapaBobs.Web.OrderManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gridViewOrders" runat="server" OnRowCommand="gridViewOrders_RowCommand">
            <Columns>
                <asp:ButtonField Text="Complete"></asp:ButtonField>
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
