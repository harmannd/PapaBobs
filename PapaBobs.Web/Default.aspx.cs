using PapaBobs.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobs.Web {
    public partial class Default : System.Web.UI.Page {
        private OrderManager orderManager = new OrderManager();

        protected void Page_Load(object sender, EventArgs e) {
            if (!Page.IsPostBack) {                
                populateDropDowns();
            }
            if (isValidPizza()) {
                updateTotal();
            }
        }

        protected void buttonOrder_Click(object sender, EventArgs e) {
            //catch exceptions if delivery info isn't inputed, textboxs and payment 
            
        }

        private void populateDropDowns() {         
            dropDownSize.DataSource = orderManager.populateSizeDropdown();
            dropDownSize.DataBind();
            

            dropDownCrust.DataSource = orderManager.populateCrustDropdown();
            dropDownCrust.DataBind();
        }

        private bool isValidPizza() {
            return orderManager.ValidateSizeInput(dropDownSize.SelectedValue)
                && orderManager.ValidateCrustInput(dropDownCrust.SelectedValue);
        }

        private void updateTotal() {

        }
    }
}