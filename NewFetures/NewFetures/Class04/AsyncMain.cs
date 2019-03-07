using System.Net.Http;
using System.Threading.Tasks;
using static System.Console;

namespace NewFetures.Class04
{
    internal class AsyncMain : MenuItem
    {
        public override async void Main()
        {
            //obs: O método acima seria o Main do programa: static void Main(string[] args)
            WriteLine(await GetGoogleAsync());
        }

        public static async Task<string> GetGoogleAsync()
        {
            return await new HttpClient().GetStringAsync("http://www.google.com");
        }
    }
}