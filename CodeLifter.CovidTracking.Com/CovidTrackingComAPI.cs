using System.Collections.Generic;
using System.Threading.Tasks;
using CodeLifter.CovidTracking.Com.Models;
using CodeLifter.CovidTracking.Com.Models.Enums;
using CodeLifter.Http;

namespace CodeLifter.CovidTracking.Com
{
    public interface ICovidTrackingComApi
    {
        Task<List<CurrentStateInfo>> GetCurrentStates();
        Task<List<DailyStateInfo>> GetDailyStates();
        Task<List<DailyStateInfo>> GetDailyStates(StateCode state);
        Task<List<DailyStateInfo>> GetDailyStates(string date);  //format YYYYMMDD
        Task<DailyStateInfo> GetDailyState(StateCode state, string date);//format YYYYMMDD
        Task<StateDescription> GetStateDescription(StateCode state);
        Task<List<StateDescription>> GetStateDescriptions();
        Task<Country> GetUnitedStates();
        Task<List<Country>> GetUnitedStatesHistorical();
        Task<Country> GetUnitedStates(string date);//format YYYYMMDD

        ///TODO - 
        //Task<List<County>> GetCounties();
    }


    public class CovidTrackingComAPI : ICovidTrackingComApi
    {
        private string BaseURI { get; set; }
        public IHttpClient Client { get; set; }

        public CovidTrackingComAPI()
        {
            BaseURI = "https://covidtracking.com/api";
            Client = new HttpClient(BaseURI, true, true);
        }

        public CovidTrackingComAPI(IHttpClient client)
        {
            Client = client;
        }

        public async Task<List<CurrentStateInfo>> GetCurrentStates()
        {
            HttpRequest request = new HttpRequest("v1/states/current.json");
            var response = await Client.GetFromCache<List<CurrentStateInfo>>(request, "all-current-states");
            return response;
        }

        public async Task<List<DailyStateInfo>> GetDailyStates()
        {
            HttpRequest request = new HttpRequest("v1/states/daily.json");
            var response = await Client.GetFromCache<List<DailyStateInfo>>(request, "all-daily-states");
            return response;
        }

        public async Task<List<DailyStateInfo>> GetDailyStates(StateCode state)
        {
            string source = $"states/daily.json?state={state.ToString()}";
            HttpRequest request = new HttpRequest(source);
            var response = await Client.GetFromCache<List<DailyStateInfo>>(request, $"all-dailies-for-{state.ToString()}");
            return response;
        }

        public async Task<List<DailyStateInfo>> GetDailyStates(string date)
        {
            string source = $"states/daily.json?date={date}";
            HttpRequest request = new HttpRequest(source);
            var response = await Client.GetFromCache<List<DailyStateInfo>>(request, $"get-all-states-for-{date}");
            return response;
        }

        public async Task<DailyStateInfo> GetDailyState(StateCode state, string date)
        {
            string source = $"states/daily.json?state={state.ToString()}&date={date}";
            HttpRequest request = new HttpRequest(source);
            var response = await Client.GetFromCache<DailyStateInfo>(request, $"get-state-data-for-{state.ToString()}-on-{date}");
            return response;
        }

        public async Task<StateDescription> GetStateDescription(StateCode state)
        {
            string source = $"states/info.json?state={state.ToString()}";
            HttpRequest request = new HttpRequest(source);
            var response = await Client.GetFromCache<StateDescription>(request, $"get-state-description-for-{state.ToString()}");
            return response;
        }

        public async Task<List<StateDescription>> GetStateDescriptions()
        {
            string source = $"states/info.json";
            HttpRequest request = new HttpRequest(source);
            var response = await Client.GetFromCache<List<StateDescription>>(request, "get-all-state-descriptions");
            return response;
        }

        public async Task<Country> GetUnitedStates()
        {
            string source = $"us.json";
            HttpRequest request = new HttpRequest(source);
            var response = await Client.GetFromCache<List<Country>>(request, "get-current-data-for-entire-US");
            return response[0];
        }

        public async Task<List<Country>> GetUnitedStatesHistorical()
        {
            string source = $"us/daily.json";
            HttpRequest request = new HttpRequest(source);
            var response = await Client.GetFromCache<List<Country>>(request, "get-historical-data-for-entire-US");
            return response;
        }

        public async Task<Country> GetUnitedStates(string date)
        {
            string source = $"us/daily.json?date={date}";
            HttpRequest request = new HttpRequest(source);
            var response = await Client.GetFromCache<Country>(request, $"get-data-for-entire-us--on-{date}");
            return response;
        }
    }
}
