using System.Collections.Generic;
using Nancy;

namespace HelloNancy
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get("/", args =>
            {
                ViewBag.greeting = "Yo wat up";
                ViewBag.show = true;
                List<string> listOfUsers = new List<string>
                    { "Preeya", "Cassidy", "Randy", "Cindy", "Michael", "James" };
                return View["Hello.sshtml", listOfUsers];
            });

            Post("/formsubmitted", args =>
            {
                string User = Request.Form["name"];
                Session["User"] = User;
                return Response.AsRedirect("/");
            });
        }
    }
}
