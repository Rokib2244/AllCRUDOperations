using Autofac;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SocialNetworkWebApp2.Areas.Admin.Models;
using SocialNetworkWebApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetworkWebApp2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MemberController : Controller
    {
        private readonly ILogger<MemberController> _logger;
        private readonly ILifetimeScope _scope;
        public MemberController(ILogger<MemberController> logger, ILifetimeScope scope)
        {
            _logger = logger;
            _scope = scope;
        }
        // GET: MemberController
        public IActionResult ShowAllMember()
        {
            var model = new MemberListModel();
            model.LoadMemberData();
            return View(model);
            //return View();
        }
        //public JsonResult GetAllMembers()
        //{
        //    var dataTablesModel = new DataTablesAjaxRequestModel(Request);
        //    var model = new MemberListModel();
        //    var data = model.GetAllMembers(dataTablesModel);
        //    return Json(data);
        //}

        // GET: MemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            var model = new CreateMemberModel();
            return View(model);
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateMemberModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.CreateMember();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Sorry..Failed to Create Member");
                    _logger.LogError(ex, "Failed to Create Member");
                }
            }
            return View();
        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = new EditMemberModel();
            model.LoadModelData(id);
            return View(model);
        }

        // POST: MemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditMemberModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    model.Update();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Sorry..Failed to Update Member");
                    _logger.LogError(ex, "Failed to Update Member");
                }
            }
            
            return View();
        }

        // GET: MemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
