A nice easy to use C# wrapper implementation of the [Health-api.com/api](https://health-api.com/api/v1/covid-19/total) API.

The HTTP client underneath it still needs a bit of work, so for now consider this a beta, but it's pretty solid a VERY easy to use as long as you remember to async all the way to the bottom.

1. Install the "CodeLifter.HealthAPI.Covid19" nuget package into your project
2. Then add the following code in an async method
    * ```Covid19Api api = new Covid19Api();```
    * ```Statistic GlobalStats = await api.GetGlobalStatistics();```
3. See below demo code for other calls 

```


```
