using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus05b
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Hent().Wait();

            async Task Hent()
            {
                try
                {
                    string url = "http://www.jp.dk";
                    System.Net.WebClient client = new System.Net.WebClient();
                    string result = await client.DownloadStringTaskAsync(url);
                    Console.WriteLine($"{result.Length:N0} tegn modtaget");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadLine();
        }
        
        
    }
}
