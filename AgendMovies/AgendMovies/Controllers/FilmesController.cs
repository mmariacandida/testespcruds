﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendMovies.Controllers
{
    public class FilmesController : Controller
    {
        // GET: Filmes
        public ActionResult Filmes()
        {
            return View();
        }
    }
}