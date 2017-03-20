# Search_Aggregator
This is a simple search aggregator that aggregates search results from Google and Bing. <br/>

Quick notes: <br/>
-Built in .NET MVC<br/>
-There are two Search Service classes that implement an ISearchService interface. <br/>
-Visual Studio Unity tool used to create a container that holds all the search services. This list of services is then injected into the controller. Doing this, modularity is increased incase of adding new searches.<br/>
-NuGet used to install the Google API tool into Visual Studio.<br/>

