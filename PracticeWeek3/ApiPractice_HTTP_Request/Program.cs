using System.Text.Json;

namespace ApiPractice_HTTP_Request;
class Program
{
    static void Main (string[] args)
    {
        HttpClient client = new HttpClient();
        using (HttpResponseMessage response = client.GetAsync("https://data.police.uk/api/crimes-street-dates").Result)
        {
            using (HttpContent content = response.Content)
            {
                List<Police> police = new List<Police>();
                string result = content.ReadAsStringAsync().Result;
                Console.WriteLine(result);
                police = JsonSerializer.Deserialize<List<Police>>(result)!;
                System.Console.WriteLine("\nDog Message \n" + police[0].stopandsearch);
            }
        }
    }
}
