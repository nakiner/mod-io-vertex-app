using System;

public class HttpWebClient
{
	private host = "";

	public HttpWebClient()
	{

	}

	void request()
    {
        HttpCLient client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        UserList user = new UserList();
        var response = await client.GetAsync("http://192.168.0.110/mh_api/v1/rooms/1");
        var responseBody = await response.Content.ReadAsStringAsync();
    }
}
}
