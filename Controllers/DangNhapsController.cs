using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyBanSach.Models;

namespace QuanLyBanSach.Controllers
{
    public class DangNhapsController : Controller
    {
        private Model1 db = new Model1();

        // GET: DangNhaps
        public ActionResult Index()
        {
            return View(db.DangNhaps.ToList());
        }
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(DangNhap user)
        {
            if (IsValidUser(user))
            {
                return RedirectToAction("Index", "Saches");
            }

            ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng.");
            return View(user);
        }
        public ActionResult LogoutView()
        {
            Session.Abandon();
            return RedirectToAction("Logout");
        }
        public ActionResult Logout()
        {
            return View();
        }
        private bool IsValidUser(DangNhap user)
        {
            var dbuser = db.DangNhaps.FirstOrDefault(u => u.TenDangNhap == user.TenDangNhap);
            if (dbuser != null)
            {
                if(dbuser.MatKhau== user.MatKhau)
                {
                    Session["user"] = dbuser;
                    return true;
                }
            }
            return false;
        }
        // GET: DangNhaps/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DangNhap dangNhap = db.DangNhaps.Find(id);
            if (dangNhap == null)
            {
                return HttpNotFound();
            }
            return View(dangNhap);
        }

        // GET: DangNhaps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DangNhaps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TenDangNhap,MatKhau,Quyen")] DangNhap dangNhap)
        {
            if (ModelState.IsValid)
            {
                db.DangNhaps.Add(dangNhap);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dangNhap);
        }

        // GET: DangNhaps/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DangNhap dangNhap = db.DangNhaps.Find(id);
            if (dangNhap == null)
            {
                return HttpNotFound();
            }
            return View(dangNhap);
        }

        // POST: DangNhaps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TenDangNhap,MatKhau,Quyen")] DangNhap dangNhap)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dangNhap).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dangNhap);
        }

        // GET: DangNhaps/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DangNhap dangNhap = db.DangNhaps.Find(id);
            if (dangNhap == null)
            {
                return HttpNotFound();
            }
            return View(dangNhap);
        }

        // POST: DangNhaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DangNhap dangNhap = db.DangNhaps.Find(id);
            db.DangNhaps.Remove(dangNhap);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
