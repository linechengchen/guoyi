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
    protected  string Category="";
    protected List<T_Category> listcategory = new List<T_Category>();
    protected List<T_ejiCategory> listeji = new List<T_ejiCategory>();
    protected List<T_Goods> listgoods = new List<T_Goods>();
    protected T_ejiCategory eji = new T_ejiCategory();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //listcategory = BLLTable<T_Category>.Select();
        //Category = Request["Category"];
        //eji.Pid = Category;
        //listeji = BLLTable<T_ejiCategory>.Select(new T_ejiCategory(),eji);
        //int a = 1;
        
    }
}