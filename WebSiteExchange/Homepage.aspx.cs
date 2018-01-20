﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Homepage : System.Web.UI.Page
{

    GetBtcLivePriceReference.GetBtcLivePriceClient getbtcliveprice = new GetBtcLivePriceReference.GetBtcLivePriceClient();
    protected void Page_Load(object sender, EventArgs e)
    {

       
        string data = getbtcliveprice.DoWork();
        bitcoin_value.Text = data;

    }

    protected void login_home_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

    

    protected void register_home_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }


}