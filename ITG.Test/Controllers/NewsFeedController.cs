using ITG.Test.Data.NewsFeed.Repository;
using System.Web.Mvc;

namespace ITG.Test.Controllers
{
    public class NewsFeedController : Controller
    {
        // GET: NewsFeed
        public ActionResult Index()
        {
			var repo = new NewsFeedRepository();
			var lstNewsFeed = repo.GetNewsFeed();
            return View(lstNewsFeed);
        }

		public JsonResult GetMoreFeeds()
		{
			var repo = new NewsFeedRepository();
			var lstMoreNewsFeed = repo.GetMoreNewsFeed();
			return Json(lstMoreNewsFeed, JsonRequestBehavior.AllowGet);
		}
    }
}