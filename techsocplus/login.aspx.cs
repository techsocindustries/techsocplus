using System;
using System.Web.Security;
using System.Security.Cryptography;
using System.Text;

namespace MyNamespace
{
    public partial class LoginClass : System.Web.UI.Page
    {
        const string salt = "8ebea7c19dc3f29a7df8";
        const string hash = "70f9dfe08e9da3b885ff4ad1443686a99923fadb";

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (username.ToLower() == "techsoc" && ConvertToSHA1(salt + password) == hash)
            {
                FormsAuthentication.RedirectFromLoginPage(username, false);
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Incorrect login :(";
            }
        }

        string ConvertToSHA1(string inputString)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(inputString);
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] hashBytes = sha1.ComputeHash(inputBytes);
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    stringBuilder.Append(b.ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }
    }
}