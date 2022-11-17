using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private static string day = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack==true)
        {

        }

    }

    protected void txtNumber_TextChanged(object sender, EventArgs e)
    {
        int num =Convert.ToInt16(txtNumber.Text);
        if (num < 1000)
        {

            loadGrid();


        }
        else
        {
            txtNumber.Text = "";
            GridView1.DataSource = null;
            GridView1.DataBind();
        }
    }

    protected async void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.Cells[0].Text == "fizz")
            {
                e.Row.Cells[0].ForeColor = System.Drawing.Color.Blue;
                if(day=="T")
                e.Row.Cells[0].Text = day + e.Row.Cells[0].Text.ToString().Substring(1, e.Row.Cells[0].Text.ToString().Length - 1);
                
            }
            else if (e.Row.Cells[0].Text == "buzz")
            {
                e.Row.Cells[0].ForeColor = System.Drawing.Color.Green;
                if (day == "T")
                    e.Row.Cells[0].Text = day + e.Row.Cells[0].Text.ToString().Substring(1, e.Row.Cells[0].Text.ToString().Length - 1);
                
            }
        }
        
    }
    private void loadGrid()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("COL1", typeof(String));
         day = DateTime.Now.ToString("ddd");
        day = char.ToUpper(day[0]).ToString();
        for (int i = 1; i <= Convert.ToInt16(txtNumber.Text); i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                dt.Rows.Add("fizz buzz");
            }
            else if (i % 3 == 0)
            {
              
                dt.Rows.Add("fizz");
            }
            else if (i % 5 == 0)
            {
                dt.Rows.Add("buzz");
            }
            else
                dt.Rows.Add(Convert.ToInt16(i));
        }
       
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;

        loadGrid();
    }
}