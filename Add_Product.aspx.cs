using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Add_Product : System.Web.UI.Page
{
    static string s = "server=DESKTOP-0S42GH7\\SQLEXPRESS;database=test;integrated security=true";
    SqlConnection con = new SqlConnection(s);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindcid();
            data();
        }
    }
    void bindcid()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select category_id from add_catagory", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DropDownList1.DataSource = ds;
        DropDownList1.DataBind();
    }
    void data()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from add_product", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into add_product values(" + DropDownList1.Text + ",'" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "' )", con);
        cmd.ExecuteNonQuery();
        con.Close();
        Label1.Text = "Add Prouct Success ";
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        data();
        
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from add_catagory where category_id=" + DropDownList1.Text + "  ", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            TextBox1.Text = dr[1].ToString();
        }
        dr.Close();
        con.Close();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void GridView1_PageIndexChanged(object sender, EventArgs e)
    {
       
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        data();
    }
}