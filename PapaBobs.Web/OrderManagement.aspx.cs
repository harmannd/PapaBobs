﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobs.Web {
    public partial class OrderManagement : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            refreshGridView();
        }

        protected void gridViewOrders_RowCommand(object sender, GridViewCommandEventArgs e) {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = gridViewOrders.Rows[index];
            var value = row.Cells[1].Text.ToString();
            var orderId = Guid.Parse(value);

            Domain.OrderManager.CompleteOrder(orderId);

            refreshGridView();
        }

        private void refreshGridView() {
            var orders = Domain.OrderManager.GetOrders();
            gridViewOrders.DataSource = orders.ToList();
            gridViewOrders.DataBind();
        }
    }
}