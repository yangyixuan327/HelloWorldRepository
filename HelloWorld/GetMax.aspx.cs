using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class GetMax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            double num1 = double.Parse(TextBox1.Text);
            double num2 = double.Parse(TextBox2.Text);
            double num3 = double.Parse(TextBox3.Text);
            if (num1 >= num2 && num1 >= num3) { Response.Write("最大值是" + num1); };

            if (num2 >= num1 && num2 >= num3) { Response.Write("最大值是" + num2); };

            if (num3 >= num1 && num3 >= num2) { Response.Write("最大值是" + num3); };
        }
    }
}