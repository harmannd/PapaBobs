﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobs.Web {
    public partial class OrderManagement : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            var orders = Domain.OrderManager.GetOrders();
            gridViewOrders.DataSource = orders.ToList();
            gridViewOrders.DataBind();
        }
    }
}