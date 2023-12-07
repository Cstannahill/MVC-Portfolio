using Microsoft.AspNetCore.Mvc;
using MVC_Portfolio.Models;
using static System.Net.Mime.MediaTypeNames;

namespace MVC_Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            List<ProjectsModel> projects = new List<ProjectsModel>
            {
                new ProjectsModel { Title = "Analytics Component", SubTitle = "SQL, .NET, ReactJS", Description = "Returning various analytics from SQL stored procedures through .NET utilzing REST APIs to display on view made in ReactJS.", ImageSrc = "resources/Analytic.gif", Link = "https://github.com/Cstannahill/Analytics" },
                new ProjectsModel { Title = "Menu/Ordering", SubTitle = "SQL, .NET, ReactJS", Description = "Menu component for ordering and modifying an order item, designed mobile first. Returns available menus for an organization given the time of day/year, inserts orders into cart, as well as adding modification information to DB.", ImageSrc = "resources/Menu.gif", Link = "https://github.com/Cstannahill/Menu" },
                new ProjectsModel { Title = "Events Component", SubTitle = "SQL, .NET, ReactJS, GoogleMaps API", Description = "Returning events from SQL stored procedure through .NET REST APIs to as well as utilizing google maps API and geolocation to display upcoming events in ReactJS. Allows you to add, edit, or delete events.", ImageSrc = "resources/Events.gif", Link = "https://github.com/Cstannahill/Events" },
                new ProjectsModel { Title = "Friends Component", SubTitle = "SQL, .NET, ReactJS", Description = "A simple component to allow you to add a friend and display a paginated view of them. Joins with a skills table to add skills to person. Allows you to add, edit, or delete friends.", ImageSrc = "resources/Friends.gif", Link = "https://github.com/Cstannahill/Friends" },
                new ProjectsModel { Title = "Jobs Component", SubTitle = "SQL, .NET, ReactJS", Description = "A simple component to allow you to add a job with skill requirements and display a paginated view. Shows more detailed information on view more modal. Allows you to add, edit, or delete jobs.", ImageSrc = "resources/Jobs.gif", Link = "https://github.com/Cstannahill/Jobs" },
                new ProjectsModel { Title = "Companies Component", SubTitle = "SQL, .NET, ReactJS", Description = "A simple component to allow you to add a company and display a paginated view. Joined with jobs to show the associated jobs that are shown from that company. Allows you to add, edit, or delete companies.", ImageSrc = "resources/TechCo.gif", Link = "https://github.com/Cstannahill/Companies" },
            };
            return View(projects);
        }
    }
}
