using System.Threading.Tasks;

namespace CoreWithMvvmLight.Model
{
    public class TestDataService : IDataService
    {
        public Task<string> GetResult(int num1, int num2)
        {
            var tcs = new TaskCompletionSource<string>();
            tcs.SetResult("I don't know how to count, I am just a test program");
            return tcs.Task;
        }
    }
}
