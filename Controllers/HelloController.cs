using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
namespace web {
    public class HelloController : Controller{

        public static void Register(HttpConfiguration config) {
        
        }
        public string index() {
            return "Browser loaded";
        }
    }
}