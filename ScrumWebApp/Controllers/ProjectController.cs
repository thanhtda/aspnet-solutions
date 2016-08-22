﻿using Scrum.Application;
using Scrum.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScrumWebApp.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            this._projectService = projectService;
        }

        // GET: Project
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateProject()
        {
            System.Threading.Thread.Sleep(3000);
            return PartialView("_CreateProject");
        }

        [HttpPost]
        public ActionResult CreateProject(CreateProjectCommand createProjectCommand)
        {
            this._projectService.CreateProject(createProjectCommand);
            return View();
        }
    }
}