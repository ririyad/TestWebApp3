﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWebApp3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public object MessageBox { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void clickMeButton_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "Hello, testing again!";
            // Just a test.
        }

        protected void clickMeByRiyadTextBox_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "Now I will be shown if you click second button.";
        }
    }
}