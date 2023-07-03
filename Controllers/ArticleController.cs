using crud.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    public class ArticleController : Controller
    {
        private List<Article> Articles { get; set; }

        public ArticleController()
        {
            Articles = new  List<Article>();

            Articles.Add(new Article(1, "Article 1", "Articles content 1"));
            Articles.Add(new Article(2, "Article 2", "Articles content 2"));
            Articles.Add(new Article(3, "Article 3", "Articles content 3"));
        }   
        // GET: ArticleController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: ArticleController1/Details/5
        public ActionResult Details(int id)
        {

            Article article = Articles.First(article => article.Id == id);
            return View(article);
        }

        // GET: ArticleController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArticleController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArticleController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ArticleController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArticleController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ArticleController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
