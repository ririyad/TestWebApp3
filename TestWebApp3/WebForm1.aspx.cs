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
<<<<<<< HEAD
            TextBox1.Text = "Hello, testing again!";
            // Just a test.
=======
            TextBox1.Text = "Again try to merge pull request";
            // I want to change this line
            // also changed
            
>>>>>>> 6ac476d28d0e3d2289079b6af67c88f7f1b0856a
        }
    }
}
