using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediaWall.DAL;
using MediaWall.DAL.Interfaces;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MediaWall.Controllers
{
    public class AlumniController : Controller
    {
        private AlumniContext db;

        public AlumniController(AlumniContext context)
        {
            db = context;
        }
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            /* Html 
             * <div class="grid-item" data-datesort="1/1/1907">
                    <figure>
                        <a href="~/images/Wall/1907Wall.jpg" title="Class of 1907"><img class="thumbnail-vertical" src="~/images/Thumbnails/1907Thumb.jpg" /> </a>
                        <figcaption>Class of 1907</figcaption>
                    </figure>
                </div>

                 <div class="grid-item" data-datesort="picture.DisplayYear">
                    <figure>
                        <a href="picture.ImageLocation" title="picture.Caption"><img class="thumbnail-vertical" src="picture.ThumbnailLocation" /> </a>
                        <figcaption>picture.Caption</figcaption>
                    </figure>
                </div>


                */
            return View(db.Pictures.ToList());            
        }
    }
}
