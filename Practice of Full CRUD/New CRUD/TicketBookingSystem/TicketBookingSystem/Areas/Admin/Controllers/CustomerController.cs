using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketBookingSystem.Areas.Admin.Models;

namespace TicketBookingSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomerController : Controller
    {

        // GET: CustomerController
        public ActionResult GetAllCustomers()
        {
            var model = new CustomerListModel();
            model.LoadAllCustomers();
            return View(model);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            var model = new CreateCustomerModel();
            return View(model);
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateCustomerModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.CreateCustomer();
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError("", "Sorry..Failed to Create new Customer");
                }
            }
            return View();

        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = new EditCustomerModel();
            model.LoadCustomerData(id);
            return View(model);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditCustomerModel model)
        {
            try
            {
                model.UpdateCustomer();
            }
            catch
            {
                ModelState.AddModelError("", "Sorry..Failed to Edit Customer");
               
            }
            return View();
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = new DeleteCustomerModel();
            model.LoadCustomerData(id);
           
            return View(model);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(DeleteCustomerModel model)
        {
            try
            {
                model.DeleteCustomer();
            }
            catch
            {
                
            }
            return View();
        }
    }
}
