using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace OnlineDiary
{
    public partial class ManageRoles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CreateRoleButton_Click(object sender, EventArgs e)
        {
            //string newRoleName = RoleName.Text.Trim();
            //if (!Roles.RoleExists(newRoleName))
            //    Roles.CreateRole(newRoleName);
            //RoleName.Text = string.Empty;
            //ManageRoles Role = new ManageRoles();
            //RoleStore<Role store
        }
    }
}