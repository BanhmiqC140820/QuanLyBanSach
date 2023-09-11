using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyBanSach.Models;

namespace QuanLyBanSach.Controllers
{
    public class CusServiceController : Controller
    {
        // GET: CusService
        private Model1 db = new Model1();
        private CustomerService customerService = new CustomerService();
        public ActionResult Index()
        {
            customerService.DanhSachSach= db.saches.Include(s => s.loai).ToList();
            customerService.DanhSachLoai = db.loais.ToList();
            return View(customerService);
        }

        // GET: CusService/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CusService/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CusService/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CusService/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CusService/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CusService/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CusService/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
