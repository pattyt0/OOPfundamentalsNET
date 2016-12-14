using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace step1_EH
{
    public partial class step1_eh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtCalculate_Click(object sender, EventArgs e)
        {
            Decimal miles = Decimal.Parse(txtGalons.Text);
            Decimal galons = Decimal.Parse(txtMiles.Text);
            Decimal efficiancy = miles / galons;

            txtEfficiency.Text = string.Format("{0:n}", efficiancy);
        }

        protected void txtEfficiency_TextChanged(object sender, EventArgs e)
        {

        }
    }
}