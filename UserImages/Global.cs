﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace UserImages
{
    public class GlobalVar
    {
        public static string user = "";
        public static string ForgotPassUser = "";
        public static bool allowUse = true;
        public static bool FirstChatOpen = true;
        public static string SearchString = "";
        public static void makeSearchString(string color, string word)
        {
            SearchString = color + "" + word;
        }

    }
}