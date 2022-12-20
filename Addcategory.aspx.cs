using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Addcategory : System.Web.UI.Page
{
    static string s = "server=DESKTOP-0S42GH7\\SQLEXPRESS;database=test;integrated security=true";
    SqlConnection con = new SqlConnection(s);
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into add_catagory values(" + TextBox1.Text + ",'" + TextBox2.Text + "')", con);
        cmd.ExecuteNonQuery();
        con.Close();
        Label1.Text = "Add Catagory Success ";
        TextBox1.Text = "";
        TextBox2.Text = "";
    }
}