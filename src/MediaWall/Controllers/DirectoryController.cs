using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediaWall.DAL;
using MediaWall.DAL.Interfaces;
using MediaWall.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MediaWall.Controllers
{
    public class DirectoryController : Controller
    {
        private DirectoryContext db;

        public DirectoryController(DirectoryContext context)
        {
            db = context;
        }
        
        public IActionResult GetDirectory(string WhatDirectory = "All")
        {            
            var data = db.Set<GetDirectoryHeadersResult>().FromSql("Web.GetDirectoryHeaders @SearchTerm = {0}, @WhatDirectory = {1}", null, WhatDirectory);            
            return View(data.ToList());
        }
    }
}
