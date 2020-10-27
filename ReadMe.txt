Thanks for giving me oppurtunity to take the test.

I have used MVC to write the newsfeed web application

I have seperated the code for the webapplication to 

ITG.Test.Entities -> This is the class library with defininition for entity NewFeedModel and ViewModels NewsFeedViewModel.

ITG.Test.Data -> This is the class Library with NewsFeedRepository with list of newsfeed and methods 
GetNewsFeed(): It will return the 5 last new feeds
GetMoreNewFeed(): It will return more news feed. I am returning all the news feed as I have kept the list only to 15 in descending oredr of the id.

ITG.Test -> It is the webapplication and the startup project with NewsFeedController with methods Index() and GetMoreFeeds().Index return the index view 
will display only last 5 feeds for the first time. The index view has the button LoadMore which willadd more the feed to the table .
I have written ajax call on clicking LoadMore button to populate more feed to the table.

ITG.Test.Tests: I have written some tests around the controller.

Note: Please do append /NewsFeed/Index to the url to open the index view with 5 top newsfeeds.
