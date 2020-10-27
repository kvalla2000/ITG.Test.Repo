using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ITG.Test;
using ITG.Test.Controllers;

namespace ITG.Test.Tests.Controllers
{
	[TestClass]
	public class HomeControllerTest
	{
		[TestMethod]
		public void Index()
		{
			// Arrange
			NewsFeedController controller = new NewsFeedController();

			// Act
			ViewResult result = controller.Index() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void GetMoreFeeds()
		{
			// Arrange
			NewsFeedController controller = new NewsFeedController();

			// Act
			JsonResult result = controller.GetMoreFeeds() as JsonResult;

			// Assert
			Assert.IsNotNull(result);
		}

		
	}
}
