using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

public class Http
{
	private string host = "http://185.185.40.242/api/";

	public Http()
	{

	}

	public JObject getMods()
    {
        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        var response = client.GetAsync(this.host + "?action=get_mods").Result;
        var responseBody = response;

        var responseContent = response.Content;

        string responseString = responseContent.ReadAsStringAsync().Result;

        JObject json = JObject.Parse(responseString);

        return json;
    }
}
