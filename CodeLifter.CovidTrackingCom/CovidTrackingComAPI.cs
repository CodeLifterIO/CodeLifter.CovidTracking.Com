using System.Collections.Generic;
using System.Threading.Tasks;
using CodeLifter.CovidTrackingCom.Models;
using CodeLifter.CovidTrackingCom.Models.Enums;
using CodeLifter.Http;

namespace CodeLifter.CovidTrackingCom
{
    public interface ICovidTrackingComApi
    {
        Task<List<CurrentStateInfo>> GetCurrentStates();
        Task<List<DailyStateInfo>> GetDailyStates();
        Task<DailyStateInfo> GetDailyStates(StateCode state);
        Task<DailyStateInfo> GetDailyStates(string date);  //format YYYYMMDD
        Task<DailyStateInfo> GetDailyStates(StateCode state, string date);//format YYYYMMDD
        Task<StateDescription> GetStateDescription(StateCode state);
        Task<List<StateDescription>> GetStateDescriptions();
        Task<List<Country>> GetUnitedStatesCurrent();
        Task<List<Country>> GetUnitedStatesDaily();
        Task<List<County>> GetCounties();
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
            var response = await Client.Get<List<CurrentStateInfo>>(request);
            return response;
        }

        public async Task<List<DailyStateInfo>> GetDailyStates()
        {
            HttpRequest request = new HttpRequest("v1/states/daily.json");
            var response = await Client.Get<List<DailyStateInfo>>(request);
            return response;
        }

        public async Task<DailyStateInfo> GetDailyStates(StateCode state)
        {
            string source = $"states.json?state={state.ToString()}";
            HttpRequest request = new HttpRequest(source);
            var response = await Client.Get<DailyStateInfo>(request);
            return response;
        }

        public async Task<DailyStateInfo> GetDailyStates(string date)
        {
            string source = $"states.json?date={date}";
            HttpRequest request = new HttpRequest(source);
            var response = await Client.Get<DailyStateInfo>(request);
            return response;
        }

        public async Task<DailyStateInfo> GetDailyStates(StateCode state, string date)
        {
            string source = $"states.json?state={state.ToString()}&date={date}";
            HttpRequest request = new HttpRequest(source);
            var response = await Client.Get<DailyStateInfo>(request);
            return response;
        }

        public async Task<StateDescription> GetStateDescription(StateCode state)
        {
            string source = $"states/info.json?state={state.ToString()}";
            HttpRequest request = new HttpRequest(source);
            var response = await Client.Get<StateDescription>(request);
            return response;
        }

        public async Task<List<StateDescription>> GetStateDescriptions()
        {
            string source = $"states/info.json";
            HttpRequest request = new HttpRequest(source);
            var response = await Client.Get<List<StateDescription>>(request);
            return response;
        }

        public async Task<List<Country>> GetUnitedStatesCurrent()
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Country>> GetUnitedStatesDaily()
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<County>> GetCounties()
        {
            throw new System.NotImplementedException();
        }


    }
}
