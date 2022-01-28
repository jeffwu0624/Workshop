using System.IO;
using System.Web;

namespace WebApplication1.Util
{
    public class UserDataCreator
    {  
        public string GetUserName(HttpContext context)
        {
            if (context.User.Identity.IsAuthenticated)
            {
                // asus\jeff2_wu
                return Path.GetFileName(context.User.Identity.Name);
            }

            return "";
        } 
    }
}