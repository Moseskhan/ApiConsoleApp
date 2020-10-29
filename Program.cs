using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiCallConsoleApp
{
	class Program
	{
	

		static async Task Main(string[] args)
		{
			Console.WriteLine("Kanja");
			var httpCalls = new HttpCalls();
			var addOns = await httpCalls.GetConfigurations();
			Console.WriteLine(JsonConvert.SerializeObject(addOns));
			
		}

		

		
	}

	class HttpCalls
	{
		public async Task<List<ConfigCategory>> GetConfigurations()
		{
			using (var client = new HttpClient())
			{
				var url = "https://ecgcm-dev-eastus2.azurewebsites.net/api/config-category";
				var content = await client.GetStringAsync(url);
				client.Dispose();
				return JsonConvert.DeserializeObject<List<ConfigCategory>>(content);
			
			}
		}
	}
}
