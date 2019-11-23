using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreManagement.Service;
using StoreManagement.Entity;
using System.Threading.Tasks;

namespace StoreManagement.Controllers
{
    public class DressController : Controller
    {
        private IService<Dress> _dressService;
        public DressController(IService<Dress> dressService)
        {
            this._dressService = dressService;
        }

        // GET: Dress
        public async Task<ActionResult> Index()
        {
            var listDress = await _dressService.GetAllAsync();
            return View(listDress);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}