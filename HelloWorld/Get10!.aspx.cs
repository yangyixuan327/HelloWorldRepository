using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class _10_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double i;
            double s;
            
            //35头，94脚
            for (i = 1; i <= 35; i = i + 1)
            {
                for (s = 1; s <= 35; s = s + 1)
                {
                    if (i + s == 35 && i * 2 + s * 4 == 94)
                        Response.Write("鸡" + i + "只，兔" + s + "只");
                }
            }
        }
    }
}

