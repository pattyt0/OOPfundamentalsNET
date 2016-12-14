using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace step2_EH
{
    public partial class step2_EH : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal miles = Decimal.Parse(txtMiles.Text);
                decimal galons = Decimal.Parse(txtGalons.Text);
                decimal efficiency = miles / galons;

                txtEfficiency.Text = string.Format("{0:n}", efficiency);
                    
            }
            catch (FormatException fe)
            {
                string msg = String.Format("Message: {0} <br> Stack Trace : <br> {1}", fe.Message, fe.StackTrace);
                lblMessage.Text = fe.GetType().ToString() + "<br>" + msg;
                
            }
            catch (DivideByZeroException dbze)
            {
                string msg = String.Format("Message: {0} <br> Stack Trace : <br> {1}", dbze.Message, dbze.StackTrace);
                lblMessage.Text = dbze.GetType().ToString() + "<br>" + msg;
                
            }
            catch (Exception ex)
            {
                string msg = String.Format("Message: {0} <br> Stack Trace : <br> {1}", ex.Message, ex.StackTrace);
                lblMessage.Text = ex.GetType().ToString() + "<br>" + msg;
                
            }
        }
    }
}