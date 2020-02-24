using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoWeb.Models;
using DemoWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DemoWeb.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pie, ICategoryRepository category)
        {
            _pieRepository = pie;
            _categoryRepository = category;
        }

        public ViewResult List()
        {
            PiesListViewModel model = new PiesListViewModel();
            model.Pies = _pieRepository.AllPies;

            model.CurrentCategory = "Cheese Cakes";
            return View(model); 
        }
    }
}