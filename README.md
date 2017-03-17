# Search_Aggregator
This is a simple search aggregator that aggregates search results from Google and Bing. <br/>

-Built in .NET MVC<br/>
-For Google, I used NuGet for the visual studio API tool. Then I created a "simple google search engine" to allow *.com, *.net, *.org and *.ca searches which the API calls.<br/>
-For Bing, I parsed the json received after sending a GET request to their API.<br/>
-I put the API services into different service classes which implement the ISearchService interface. 
-Then, I used Visual Studio Unity tool to create a container that registers the different search services.
 After, I inject the list services into the controller which calls each of the services and appends the results.
 By doing this, modularity is increased and it becomes easy to add more or remove search services.
