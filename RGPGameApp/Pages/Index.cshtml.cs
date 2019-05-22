﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RGPGameApp.Classes;

namespace RGPGameApp.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            StatLine fLine = new StatLine();
            ViewData["statLine1"] = fLine.ToString();
            //ViewData["statLine2"] = new StatLine();
        }
    }
}
