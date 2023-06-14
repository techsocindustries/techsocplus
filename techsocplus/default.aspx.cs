using System;
using System.IO;
using System.Web.Security;

namespace MyNamespace
{
    public partial class MainClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                litUsername.Text = "User logged in: " + User.Identity.Name;
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("login.aspx");
        }

        protected void Upload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string folderPath = Server.MapPath("content/");
                string filePath = folderPath + Path.GetFileName(FileUpload1.FileName);
                if (!File.Exists(filePath))
                {
                    FileUpload1.SaveAs(filePath);
                    lblMessage.Text = "<br><br><font color='lightgreen'>" + Path.GetFileName(FileUpload1.FileName) +
                        "</font> has been uploaded!<br>" + "<font size='1'>" + FileUpload1.PostedFile.ContentLength.ToString("#,##0") +
                        " bytes (" + FileUpload1.PostedFile.ContentType + ")</font>";
                }
                else
                {
                    lblMessage.Text = "<br><br><font color='salmon'>" + FileUpload1.FileName + " already exists!</font>";
                }
            }
            else
            {
                lblMessage.Text = "<br><br><font color='salmon'>You forgot to select a file!</font>";
            }
        }
    }
}