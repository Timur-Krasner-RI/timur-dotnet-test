using Newtonsoft.Json;
using RestSharp;

var payload = JsonConvert.SerializeObject(new { ok = true });
Console.WriteLine(payload);
_ = new RestClient("https://example.com");
