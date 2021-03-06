﻿
#region Imports...
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Nettiers.AdventureWorks.Web.UI;
#endregion

public partial class NullFkeyParentEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "NullFkeyParentEdit.aspx?{0}", NullFkeyParentDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "NullFkeyParentEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "NullFkeyParent.aspx");
		FormUtil.SetDefaultMode(FormView1, "NullFkeyParentId");
	}
	protected void GridViewNullFkeyChild1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("NullFkeyChildId={0}", GridViewNullFkeyChild1.SelectedDataKey.Values[0]);
		Response.Redirect("NullFkeyChildEdit.aspx?" + urlParams, true);		
	}	
}


