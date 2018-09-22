using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AutoAddicts.Models;
using AutoAddicts.Logic;


namespace AutoAddicts
{
    public partial class CheckOut : System.Web.UI.Page
    {
        string[] arrdiscount = { "AutoAddicts12345", "AutoAddicts98654", "AutoAddicts87654", "AutoAddicts23467", "AutoAddicts54321" };
        string sDiscount = "";
        double discount = 0;
        double delivery = 0;
        double vat = 0;
        double dTotal = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            dTotal = dTotal - vat;
            lblPrice.Text = dTotal.ToString();
            lblVAT.Text = vat.ToString();
            lblDelivery.Text = delivery.ToString();
            lblDiscount.Text = discount.ToString();

            double finalTotal = dTotal + vat + delivery - discount;
            lblTotal.Text = finalTotal.ToString();
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {            
            string Total = Session["TotalPrice"].ToString();
            string sTotal = Total.Substring(1);
            double dTotal = double.Parse(sTotal);
            vat = dTotal * 0.14;

            switch (cmbDelivery.SelectedIndex)
            {
                case 1:
                    {
                        delivery = 50.00;
                        break;
                    }
                case 2:
                    {
                        delivery = 25.00;
                        break;
                    }
                case 3:
                    {
                        delivery = 0.00;
                        break;
                    }
                default:
                    {
                        delivery = 0.00;
                        break;
                    }
            }

            dTotal = dTotal - vat;
            lblPrice.Text = dTotal.ToString();
            lblVAT.Text = vat.ToString();
            lblDelivery.Text = delivery.ToString();
            lblDiscount.Text =discount.ToString();

            double finalTotal = dTotal + vat + delivery - discount;
            lblTotal.Text = finalTotal.ToString();

            btnBuy.Visible = true;
        }

        protected void btnDiscount_Click(object sender, EventArgs e)
        {
            sDiscount = txtDiscount.Text;

            for (int k = 0; k < arrdiscount.Length; k++)
            {
                if (sDiscount == arrdiscount[k])
                {
                    discount = dTotal * 0.2;
                }
            }
        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {

        }

    }
}