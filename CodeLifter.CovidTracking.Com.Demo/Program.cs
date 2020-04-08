using System.Collections.Generic;
using System.Threading.Tasks;
using CodeLifter.CovidTracking.Com;
using CodeLifter.CovidTracking.Com.Models;
using CodeLifter.CovidTracking.Com.Models.Enums;

namespace CodeLifter.CovidTrackingCom.Demo
{
    class Program
    {
        private static CovidTrackingComAPI api;

        static void Main(string[] args)
        {
            api = new CovidTrackingComAPI();

            Task t = useCovidTrackingComAPI();
            t.Wait();

            Task t2 = useCovidTrackingComAPI();
            t2.Wait();
        }

        private static async Task useCovidTrackingComAPI()
        {
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
