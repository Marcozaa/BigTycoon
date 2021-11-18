using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BigTycoon
{
    public class Scraper
    {
        public static double oro = 0;
        public static double argento = 0;
        HttpClient client = new HttpClient();
        static async Task Main(String[] args)
        {
            Scraper program = new Scraper();
            await program.cerca();

        }

        public async Task cerca()
        {
            String apiKey = "m55dblfl04cy6ntmiackqodovv6g9qrvw31bnp8hnd7gn2z38cx9ba05hz2r";

           

            String risposta = await client.GetStringAsync("https://metals-api.com/api/latest?access_key=" + apiKey + "&base=EUR&symbols=XAU%2CXAG");
            Console.WriteLine(risposta);

            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(risposta);


            oro = myDeserializedClass.rates.XAU;
            argento = myDeserializedClass.rates.XAG;
        }

        public double getOro()
        {
            return oro;
        }

        public double getArgento()
        {
            return argento;
        }

    }

    public class Rates
    {
        public int USD { get; set; }
        public double XAG { get; set; }
        public double XAU { get; set; }
        public double XPD { get; set; }
        public double XPT { get; set; }
        public double XRH { get; set; }
    }

    public class Root
    {
        Rates r = new Rates();
        public bool success { get; set; }
        public int timestamp { get; set; }
        public string date { get; set; }
        public string @base { get; set; }
        public Rates rates { get; set; }
        public string unit { get; set; }
    }

}

