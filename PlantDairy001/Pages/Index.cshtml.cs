﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PlantDairy001.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            int yearStarted = 2006;
            string name = "My Plant Dairy";
            ViewData["Name"] = name;
        }
    }
}
