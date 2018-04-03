using System.Threading.Tasks;

namespace CoreWithMvvmLight.Model
{
    public interface IDataService
    {
        Task<string> GetResult(int num1, int num2);
    }
}
