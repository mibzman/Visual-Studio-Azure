using System;
using System.Web;
using System.Web.UI;

namespace testweb
{

    public partial class Default : System.Web.UI.Page
    {
        public void button1Clicked(object sender, EventArgs args)
        {
            button1.Text = "This is a test!!!";
        }
    }
}
