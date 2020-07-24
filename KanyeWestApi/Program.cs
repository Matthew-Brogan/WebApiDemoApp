using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeWestApi
{
    class Program
    {
        static void Main(string[] args)
        {
            //var client = new HttpClient();
            //var kanyeURL = "https://api.kanye.rest";
            //var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            //var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            //Console.WriteLine("Lets see a kanye quote.");
            //Console.WriteLine(kanyeQuote);

            //var client1 = new HttpClient();
            //var swansonURl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            //var swansonRespose = client1.GetStringAsync(swansonURl).Result;
            //var swansonQuote = JArray.Parse(swansonRespose).ToString().Replace('[', ' ').Replace(']', ' ').Trim();


            //Console.WriteLine("Now lets see a Ron Swanson quote:");
            //Console.WriteLine(swansonQuote);

            for(int i = 0; i < 6; i++)
            {
                var client1 = new HttpClient();
                var swansonURl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
                var swansonRespose = client1.GetStringAsync(swansonURl).Result;
                var swansonQuote = JArray.Parse(swansonRespose).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
                Console.WriteLine(swansonQuote);
                Console.WriteLine();
                var client = new HttpClient();
                var kanyeURL = "https://api.kanye.rest";
                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
                var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
                Console.WriteLine(kanyeQuote);
                Console.WriteLine();
                var client2 = new HttpClient();
                var trump = " https://api.chucknorris.io/";
                var trumpresp = client2.GetStringAsync(trump).Result;
                var trumpQuote = JObject.Parse(trumpresp).GetValue("value").ToString();
                Console.WriteLine(trumpQuote);


            }

        }
    }
}
