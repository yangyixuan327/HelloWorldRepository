using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class homeworkGetTriangleArea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetArea_Click1(object sender, EventArgs e)
        {
            double line1 = double.Parse(txtLine1.Text);
            double line2 = double.Parse(txtLine2.Text);
            double line3 = double.Parse(txtLine3.Text);
            double p = (line1 + line2 + line3) / 2;
            double s = Math.Sqrt(p * (p - line1) * (p - line2) * (p - line3));

            if (line1 + line2 > line3 && line1 + line3 > line2 && line2 + line3 > line1)
            {
                if (line1 == line2 && line2 == line3)
                    Response.Write("您输入的三条边组成了一个等边锐角三角形，它的面积是" + s);
                else if (line1 == line2 || line1 == line3 || line2 == line3)
                {
                    if (line1 * line1 + line2 * line2 == line3 * line3 || line1 * line1 + line3 * line3 == line2 * line2 || line3 * line3 + line2 * line2 == line1 * line1)
                        Response.Write("您输入的三条边组成了一个等腰直角三角形，它的面积是" + s);
                    else if (line1 * line1 + line2 * line2 > line3 * line3 && line1 * line1 + line3 * line3 > line2 * line2 && line3 * line3 + line2 * line2 > line1 * line1)
                        Response.Write("您输入的三条边组成了一个等腰锐角三角形，它的面积是" + s);
                    else
                        Response.Write("您输入的三条边组成了一个等腰钝角三角形，它的面积是" + s);
                }
                else
                {
                    if (line1 * line1 + line2 * line2 == line3 * line3 || line1 * line1 + line3 * line3 == line2 * line2 || line3 * line3 + line2 * line2 == line1 * line1)
                        Response.Write("您输入的三条边组成了一个一般直角三角形，它的面积是" + s);
                    else if (line1 * line1 + line2 * line2 > line3 * line3 && line1 * line1 + line3 * line3 > line2 * line2 && line3 * line3 + line2 * line2 > line1 * line1)
                        Response.Write("您输入的三条边组成了一个一般锐角三角形，它的面积是" + s);
                    else
                        Response.Write("您输入的三条边组成了一个一般钝角三角形，它的面积是" + s);
                }
            }
            else
            {
                Response.Write("您输入的三条边不能构成一个三角形");
            }
        }
    }
}