using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using Web.Dao;

namespace Web.Controllers
{
    public class QuestionController : Controller
    {
        private QuestionDao question = new QuestionDao();


        [Route("")]
        public ViewResult List() 
        {
            var data = question.getAll;
            return View(data); 
        }

        [Route("/Result")]
        public ViewResult Result(int res,string email)
        {
            
            var data = question.getAll;
            ViewBag.res = res;
            return View(data);
        }

        
    }
}

