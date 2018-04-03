using CoreWithMvvmLight.Model;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreWithMvvmLight
{
    public static class OtherProgram
    {
        // Execute the query without a knowledge of the IDataService implementation
        public static async Task<string> Execute(int num1, int num2)
        {
            var service = SimpleIoc.Default.GetInstance<IDataService>();
            return await service.GetResult(num1, num2);
        }
    }
}
