using PapaBobs.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobs.Web {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            
        }

        protected void buttonOrder_Click(object sender, EventArgs e) {
            try {
                var order = buildOrder();
                OrderManager.CreateOrder(order);
                Response.Redirect("Success.aspx", false);
            } 
            catch (Exception ex) {
                labelValidation.Text = ex.Message;
                labelValidation.Visible = true;
                return;
            }
        }

        private DTO.Order buildOrder() {
            var order = new DTO.Order();

            order.Size = determineSize();
            order.Crust = determineCrust();
            order.Sausage = checkBoxSausage.Checked;
            order.Pepperoni = checkBoxPepperoni.Checked;
            order.Onions = checkBoxOnions.Checked;
            order.GreenPeppers = checkBoxGreenPeppers.Checked;
            order.Name = textBoxName.Text.Trim();
            order.Address = textBoxAddress.Text.Trim();
            order.Zip = textBoxZip.Text.Trim();
            order.Phone = textBoxPhone.Text.Trim();
            order.PaymentType = determinePayment();

            return order;
        }

        private DTO.Enums.Sizes determineSize() {
            DTO.Enums.Sizes size;
            if (!Enum.TryParse(dropDownSize.SelectedValue, out size)) {
                throw new Exception("Size not selected.");
            }
            return size;
        }

        private DTO.Enums.Crusts determineCrust() {
            DTO.Enums.Crusts crust;
            if (!Enum.TryParse(dropDownCrust.SelectedValue, out crust)) {
                throw new Exception("Crust not selected.");
            }
            return crust;
        }

        private DTO.Enums.Payments determinePayment() {
            if (radioCash.Checked) {
                return DTO.Enums.Payments.Cash;
            }
            else {
                return DTO.Enums.Payments.Credit;
            }
        }

        protected void recalculateTotalCost(object sender, EventArgs e) {
            if (dropDownSize.SelectedValue == String.Empty) return;
            if (dropDownCrust.SelectedValue == String.Empty) return;

            var order = buildOrder();

            try {
                labelTotal.Text = Domain.PizzaPriceManager.CalculateCost(order).ToString("C");
            } 
            catch (Exception) {
                //error swallowed
            } 
        }
    }
}