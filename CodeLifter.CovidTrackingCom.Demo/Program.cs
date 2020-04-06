using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeLifter.CovidTrackingCom.Models;
using CodeLifter.CovidTrackingCom.Models.Enums;

namespace CodeLifter.CovidTrackingCom.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task t = useCovidTrackingComAPI();
            t.Wait();
        }

        private static async Task useCovidTrackingComAPI()
        {

            CovidTrackingComAPI api = new CovidTrackingComAPI();
            List<CurrentStateInfo> currents = await api.GetCurrentStates();
            List<DailyStateInfo> dailies = await api.GetDailyStates();
            DailyStateInfo dailyByState = await api.GetDailyStates(StateCode.WA);
            //DailyStateInfo dailyByDate = await api.GetDailyStates("20200316");
            //DailyStateInfo dailyByStateAndDate = await api.GetDailyStates(StateCode.WA, "20200316");
            StateDescription waDescription = await api.GetStateDescription(StateCode.WA);
            List<StateDescription> stateDescriptions = await api.GetStateDescriptions();
        }
    }
}
