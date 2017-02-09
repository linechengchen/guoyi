using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class easy : System.Web.UI.Page
{  
    protected List<T_Category> listcategory = new List<T_Category>();
   
    protected void Page_Load(object sender, EventArgs e)
    {


        listcategory = BLLTable<T_Category>.Select();
    }
}