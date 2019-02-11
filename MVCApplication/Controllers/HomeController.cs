using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using MVCApplication.ViewModels;

namespace MVCApplication.Controllers
{

    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            IndexViewModel indexViewModel = new IndexViewModel();

            return View(indexViewModel);
        }

        public IActionResult Error()
        {

            return View();
        }

        public IActionResult Result()
        {
            ResultViewModel resultViewModel = new ResultViewModel();

            resultViewModel.Error = "To test a new number, please return to the 'Input' page.";

            return View(resultViewModel);
        }

        [HttpPost]
        public IActionResult Result(ResultViewModel resultViewModel)

        {
            if (ModelState.IsValid)
             

            {

                resultViewModel.Answer = true;
                resultViewModel.State = true;

                if ((resultViewModel.Numin <= 1) || (resultViewModel.Numin == 2) || (resultViewModel.Numin % 2 == 0))
                {

                    resultViewModel.Answer = false;

                }

                var boundary = (int)Math.Floor(Math.Sqrt(resultViewModel.Numin));

                for (int i = 3; i <= boundary; i += 2)
                    if (resultViewModel.Numin % i == 0)
                    {
                        resultViewModel.Answer = false;
                    }

        
             return View(resultViewModel);
            }


            return Redirect("/Home/Error");

        }

    }

}

