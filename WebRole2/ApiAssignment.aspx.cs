﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebRole2
{
    public partial class ApiAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<string> Plot = new List<string>()
            {
              {""},

               {"Full"},
               {"Short"}

            };
                List<string> YearList = new List<string>()
            {
                  {""},
                {"1998"},
                {"1999"},
                {"2000"},
                {"2001"},
                {"2002"},
                {"2003"},
                {"2004"},
                {"2005"},
                {"2006"},
                {"2007"},
                {"2008"},
                {"2009"},
                {"2010"},
                {"2011"},
                {"2012"},
                {"2013"},
                 {"2014"},
                {"2015"},
                {"2016"},


            };


                List<string> MovieDetails = new List<string>()
                {
                    { "All"},
                { "Title"},       
                { "Year"},
                { "Rated"},
                {"Released" },
                {  "Genre" },
                };
                lstbx1.DataSource = Plot;
                lstbx1.DataBind();
                lstbx2.DataSource = YearList;
                lstbx2.DataBind();
                DropDownList1.DataSource = MovieDetails;
                DropDownList1.DataBind();

            }




        }
    }
}