using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyCoreWebApp.Models.DataModels;
using Bogus;

namespace MyCoreWebApp.Controllers
{
    public class CustomerController : Controller
    {

        public IActionResult Index()
        {

            var model = new List<CustomerDataModel>();
            //create a list of people using bogus assign the person to our customers class
            for (int i = 0; i <= 4; i++)
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
    }
}
