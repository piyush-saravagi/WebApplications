using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submitButton_Click(object sender, EventArgs e)
    {
        string currAgeString = ageTextbox.Text;
        int currAge = Int32.Parse(currAgeString);
        resultLabel.Text = "Your age in 10 years is: " + (currAge + 10);
    }
}