﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HiddenFields
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = TextBox1.Text;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = HiddenField1.Value;
        }
    }
}