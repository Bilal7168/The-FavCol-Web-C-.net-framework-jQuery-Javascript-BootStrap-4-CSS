﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserImages
{
    public partial class Chat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void message_Click(object sender, EventArgs e)
        {
            Response.Redirect("Chat.aspx");
        }

        protected void Images_Click(object sender, EventArgs e)
        {
            Response.Redirect("Images.aspx");
        }
    }
}