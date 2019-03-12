using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class homeworkStringOffset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string String = txtString.Text;
            string sub_S = "";
            int location = 0;
            int Location = 0;
            int a=0;
            int A=0;
            int m = int.Parse(txtMove.Text);

            for (int i=0; i<=String.Length-1 ; i++)
            {
                sub_S = String.Substring(i, 1);
                location = alphabet.IndexOf(sub_S);
                Location = Alphabet.IndexOf(sub_S);
                a = int.Parse(location.ToString());
                A = int.Parse(Location.ToString());
                int b = a + m;
                int B = A + m;

                if (a==-1 && A==-1)
                {
                    Response.Write(sub_S);
                }

                else if(a!=-1)
                {
                    while(b>=26)
                    {
                        b = b - 26;
                    }
                    Response.Write(alphabet.Substring(b, 1));
                }

                else if(A!=-1)
                {
                    while(B>=26)
                    {
                        B = B - 26;
                    }
                    Response.Write(Alphabet.Substring(B, 1));
                }
            }
        }
    }
}