using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    public String title = "";
    public String title1 = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        title = "这是网页标题";
        title1 = "这是正文标题";
    }
}