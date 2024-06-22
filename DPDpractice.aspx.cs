using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DPDpractice : System.Web.UI.Page
    {
        DataAccessLayer obj;
        protected void Page_Load(object sender, EventArgs e)
            
        {
            if (!Page.IsPostBack)
            {

                obj = new DataAccessLayer();
                obj.FillDD(DropDownList1, @"select cityid,cityname from city");
            }
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

                obj = new DataAccessLayer();
                obj.FillDD(DropDownList2, @"select areaid,areaname from area where cityid=" + Convert.ToInt32(DropDownList1.SelectedValue));
            
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                obj = new DataAccessLayer();
                obj.FillDD(DropDownList3, @"select streetid, streetname from street where areaid=" + Convert.ToInt32(DropDownList2.SelectedValue));
            

        }
    }
}