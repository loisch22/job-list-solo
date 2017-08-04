using Microsoft.AspNetCore.Mvc;
using Job.Models;
using System.Collections.Generic;

namespace Job.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/added-work")]
    public ActionResult AddedWork()
    {
      string yourName = Request.Form["your-name"];
      string companyName = Request.Form["company"];
      string jobTitle = Request.Form["job-title"];
      string startDate = Request.Form["start"].ToString();
      string endDate = Request.Form["end"].ToString();
      string jobDescription = Request.Form["description"];
      Jobs newJob = new Jobs(yourName, companyName, jobTitle, startDate, endDate, jobDescription);
      return View(newJob);
    }

    [HttpGet("/showAllWork")]
    public ActionResult ShowAll()
    {

      List<Jobs> jobsShow = Jobs.GetAllJobs();
      return View(jobsShow);
    }
  }
}
