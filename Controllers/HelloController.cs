using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace web {
    public class HelloController : Controller{
        [HttpGetAtribute]
        public string index() {
            return "Browser loaded";
        }
    }
}