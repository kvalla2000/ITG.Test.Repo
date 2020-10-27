using System;
using System.Collections.Generic;
using System.Linq;
using ITG.Test.NewsFeed.ViewModels;
using ITG.Test.NewsFeed.Entities;

namespace ITG.Test.Data.NewsFeed.Repository
{
	public class NewsFeedRepository
	{
		public List<NewsFeedModel> newsFeedlst = new List<NewsFeedModel>()
		{
			new NewsFeedModel { Id = 1,NewsFeedDesc="newsfeed1",Date=DateTime.Now},
			new NewsFeedModel { Id = 2,NewsFeedDesc="newsFeed2",Date=DateTime.Now},
			new NewsFeedModel { Id = 3, NewsFeedDesc = "newsFeed3", Date = DateTime.Now },
			new NewsFeedModel { Id = 4, NewsFeedDesc = "newsFeed4", Date = DateTime.Now },
			new NewsFeedModel { Id = 5, NewsFeedDesc = "newsFeed5", Date = DateTime.Now },
			new NewsFeedModel { Id = 6, NewsFeedDesc = "newsFeed6", Date = DateTime.Now },
			new NewsFeedModel { Id = 7, NewsFeedDesc = "newsFeed7", Date = DateTime.Now },
			new NewsFeedModel { Id = 8, NewsFeedDesc = "newsFeed8", Date = DateTime.Now },
			new NewsFeedModel { Id = 9, NewsFeedDesc = "newsFeed9", Date = DateTime.Now },
			new NewsFeedModel { Id = 10, NewsFeedDesc = "newsFeed10", Date = DateTime.Now },
			new NewsFeedModel { Id = 11, NewsFeedDesc = "newsFeed11", Date = DateTime.Now },
			new NewsFeedModel { Id = 12, NewsFeedDesc = "newsFeed12", Date = DateTime.Now },
			new NewsFeedModel { Id = 13, NewsFeedDesc = "newsFeed13", Date = DateTime.Now },
			new NewsFeedModel { Id = 14, NewsFeedDesc = "newsFeed14", Date = DateTime.Now },
			new NewsFeedModel { Id = 15, NewsFeedDesc = "newsFeed15", Date = DateTime.Now }
		};

		public IEnumerable<NewsFeedViewModel> GetNewsFeed()
		{
			var lstNewFeedModels = newsFeedlst
				.OrderByDescending(x => x.Id)
				.Take(5)
				.Select(x=>new NewsFeedViewModel {
					Id=x.Id,
					Description=x.NewsFeedDesc
				});


			return lstNewFeedModels;
		}


		public IEnumerable<NewsFeedViewModel> GetMoreNewsFeed()
		{
			var lstNewFeedModels = newsFeedlst
				.OrderByDescending(x => x.Id)				
				.Select(x => new NewsFeedViewModel
				{
					Id = x.Id,
					Description = x.NewsFeedDesc
				});


			return lstNewFeedModels;
		}
	}
}
