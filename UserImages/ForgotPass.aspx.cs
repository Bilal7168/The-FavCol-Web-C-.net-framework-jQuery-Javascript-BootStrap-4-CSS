﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Web.UI.WebControls;

namespace UserImages
{
    public partial class ForgotPass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void username_TextChanged(object sender, EventArgs e)
        {

        }
        protected void Send_Click(object sender, EventArgs e)
        {
            if (username.Text != "")
            {
                DAL x = new DAL();
                x.mailSend(username.Text);
                Response.Redirect(url: "ValidateKey.aspx");
            }
        }
    }
}