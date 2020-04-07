A nice easy to use C# wrapper implementation of the [Health-api.com/api](https://health-api.com/api/v1/covid-19/total) API.

The HTTP client underneath it still needs a bit of work, so for now consider this a beta, but it's pretty solid a VERY easy to use as long as you remember to async all the way to the bottom.

1. Install the "CodeLifter.HealthAPI.Covid19" nuget package into your project
2. Then add the following code in an async method
    * ```Covid19Api api = new Covid19Api();```
    * ```Statistic GlobalStats = await api.GetGlobalStatistics();```
3. See below demo code for other calls 

```
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeLifter.CovidTracking.Com;
using CodeLifter.CovidTracking.Com.Models;
using CodeLifter.CovidTracking.Com.Models.Enums;

namespace CodeLifter.CovidTrackingCom.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = useCovidTrackingComAPI();
            t.Wait();
        }

        private static async Task useCovidTrackingComAPI()
        {
            CovidTrackingComAPI api = new CovidTrackingComAPI();
            List<CurrentStateInfo> currents = await api.GetCurrentStates();
            List<DailyStateInfo> dailies = await api.GetDailyStates();
            List<DailyStateInfo> dailyByState = await api.GetDailyStates(StateCode.WA);
            List<DailyStateInfo> dailyByDate = await api.GetDailyStates("20200316");
            DailyStateInfo dailyByStateAndDate = await api.GetDailyState(StateCode.WA, "20200316");
            StateDescription waDescription = await api.GetStateDescription(StateCode.WA);
            List<StateDescription> stateDescriptions = await api.GetStateDescriptions();
            Country UsaCurrentStatus = await api.GetUnitedStates();
            List<Country> UsaHistorical = await api.GetUnitedStatesHistorical();
            Country UsaApril3 = await api.GetUnitedStates("20200403");
        }
    }
}


```
