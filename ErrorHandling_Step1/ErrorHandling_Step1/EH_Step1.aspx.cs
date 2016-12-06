using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ErrorHandling_Step1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(Object sender, System.EventArgs args) {
            decimal decMiles = Convert.ToDecimal(TxtMiles.Text);
            decimal decGallons = Convert.ToDecimal(TxtGallons.Text);
            decimal decEfficiency = decMiles / decGallons;

            TxtEfficiency.Text = String.Format("{0:n}", decEfficiency);

        }
    }
}