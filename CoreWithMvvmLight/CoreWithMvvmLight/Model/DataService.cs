using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoreWithMvvmLight.Model
{
    public class DataService : IDataService
    {
        private const string Url = "https://lbxamsample.azurewebsites.net/api/add/num1/{num1}/num2/{num2}?code=HKRojipnkEV6eq06YdVM/Negiz0swhg2Emb9/0pDBDRUZaz7na7AYw==";

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
