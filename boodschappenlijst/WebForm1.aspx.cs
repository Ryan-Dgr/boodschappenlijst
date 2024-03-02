using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using domain_boodschappen.Business;

namespace boodschappenlijst
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        domain_boodschappen.Business.controller controller = new controller();
        protected void Page_Load(object sender, EventArgs e)
        {
            lbOutput.DataSource = controller.getBoodschappen();
            lbOutput.DataBind();

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string product;
                int aantal;
                string extra;

                product = TbProduct.Text;
                aantal = Convert.ToInt32(TbAantal.Text);
                extra = TbExtra.Text;

                controller.addBoodschap(product, aantal, extra);

            }

        }


    }
}