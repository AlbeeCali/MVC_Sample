using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using MySampleProject.Models;

namespace MySampleProject.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        DocsDBEntities _db;

        public HomeController()
        {
            _db = new DocsDBEntities();
        }

        public ActionResult Index()
        {
            ViewBag.InsertErrors = "false";
            ViewBag.DocumentId = 1;
            ViewData.Model = _db.Documents.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Document model)
        {
            ViewBag.InsertErrors = "false";
            if (ModelState.IsValid)
            {
                model.LastChangeDate = DateTime.Now;
                model.LastChangedBy = "mspTest";
                _db.AddToDocuments(model);
                _db.SaveChanges();
            }
            else
            {
                ViewBag.InsertErrors = "true";
                List<Document> docs = _db.Documents.ToList();
                ViewData.Model = docs;
                return View();

            }
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        [HttpPost]
        public string UpdateData(string DocumentId, string Title, string Description,
            string PubDate, string Author)
        {
            string msg = "";
            try
            {
                if (string.IsNullOrEmpty(Title))
                {
                    ModelState.AddModelError("Title", "Title is required");
                }
                if (string.IsNullOrEmpty(Description))
                {
                    ModelState.AddModelError("Description", "Description is required");
                }
                if (string.IsNullOrEmpty(Author))
                {
                    ModelState.AddModelError("Author", "Author is required");
                }
                DateTime timeCheck;
                if (!DateTime.TryParse(PubDate, out timeCheck))
                {
                    ModelState.AddModelError("PubDate", "Date Published is invalid");
                }

                int id = -1;
                int.TryParse(DocumentId, out id);
                var docToUpdate = _db.Documents.First(m => m.DocumentId == id);
                if (ModelState.IsValid)
                {
                    //Hard coded here.  Would normally use authenticated User.Identity.Name
                    Document model = new Document
                    {
                        Author = Author,
                        Description = Description,
                        PubDate = Convert.ToDateTime(PubDate),
                        Title = Title
                    };
                    docToUpdate.LastChangedBy = "mspTest";
                    docToUpdate.Author = Author;
                    docToUpdate.Description = Description;
                    docToUpdate.Title = Title;
                    docToUpdate.PubDate = Convert.ToDateTime(PubDate);
                    docToUpdate.LastChangeDate = DateTime.Now;
                    _db.SaveChanges();
                    msg = Title + " saved";
                }
                else
                {
                    StringBuilder sb = new StringBuilder("Record was not updated:<br/>");
                    ModelState.Values.ToList().ForEach(er =>
                        {
                            er.Errors.ToList().ForEach(erMsg =>
                                {
                                    sb.AppendLine("*" + erMsg.ErrorMessage + "<br/>");
                                }
                            );
                        });

                    msg = sb.ToString();

                }
            }
            catch
            {
                msg = Title + " not saved";
            }
            return msg;
        }


    }
}
