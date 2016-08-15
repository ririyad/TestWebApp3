using System;
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
            TextBox1.Text = "I have just changed the message! now I have to pull and edit again";
            // I want to change this line
        }
    }
}
