using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class homeworkPrintChar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnPrintTriangle_Click(object sender, EventArgs e)
        {
            int line = int.Parse(txtLines.Text);
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string sub_a = "";

            if (line > 26)
            {
                Response.Write("无法输出三角形");
            }
            else
            {
                for (int i = 1; i <= line; i = i + 1)
                {
                    sub_a = alphabet.Substring(i - 1, 1);
                    for (int j = 0; j <line-i; j = j + 1)
                    {
                        Response.Write("&nbsp;&nbsp;");
                    }

                    for (int l = 0; l < 2*i-1; l = l + 1)
                    {

                        Response.Write(sub_a );
                        
                    }
                    Response.Write("</br>");


                }

            }
        }
    }
}