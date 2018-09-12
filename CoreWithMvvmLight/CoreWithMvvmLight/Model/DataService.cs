using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoreWithMvvmLight.Model
{
    public class DataService : IDataService
    {
        private const string Url = "https://lbcalculator.azurewebsites.net/api/add/num1/{num1}/num2/{num2}?code=r9o3qY/Zy0slf4IddK0qq8dNxkDraglwGKaKaCp3D8PFGAorrWosIQ==";

        public async Task<string> GetResult(int num1, int num2)
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync(
                Url
                    .Replace("{num1}", num1.ToString())
                    .Replace("{num2}", num2.ToString()));

            return result;
        }
    }
}
