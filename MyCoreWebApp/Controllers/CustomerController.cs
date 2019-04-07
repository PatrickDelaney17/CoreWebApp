using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyCoreWebApp.Models.DataModels;
using Bogus;
using MyCoreWebApp.Models;
using System.Diagnostics;

namespace MyCoreWebApp.Controllers
{
    public class CustomerController : Controller
    {

        public IActionResult Index()
        {

            var model = new List<CustomerDataModel>();
            //create a list of people using bogus assign the person to our customers class
            for (int i = 0; i <= 15; i++)
            {
                //new person created each loop
                var person = new Person();
                model.Add(new CustomerDataModel { customerId = i, customerFirstName = person.FirstName, customerLastName = person.LastName, customerUserName = person.UserName, Email = person.Email });

            }
            //Create random content for filling the page
            ViewData["Message"] = new Faker().Lorem.Paragraph().ToString();

            //return model back to the view
            return View("Index", model);
        }

        public ActionResult Details(int id)
        {
            //check the id got passed in
            if (id >= 0)
            {
                //new person created 
                var person = new Person();

                return View("Details", new CustomerDataModel { customerId = id, customerAvatar = person.Avatar, customerFirstName = person.FirstName, customerLastName = person.LastName, customerUserName = person.UserName, Email = person.Email });
            }
            else
            {
                return Error();
            }

        }
        public ActionResult Error()
        {
            return View("Error", new ErrorViewModel { Message = "Sorry the customer you're looking for could not be found.", RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
