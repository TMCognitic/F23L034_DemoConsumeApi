using F23L034_DemoConsumeApi.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace F23L034_DemoConsumeApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (HttpClient client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("https://localhost:7262");

            //    using (HttpResponseMessage httpResponseMessage = client.GetAsync("/api/Contact").Result)
            //    {
            //        httpResponseMessage.EnsureSuccessStatusCode(); // => Exception
            //        //ou
            //        //if (httpResponseMessage.IsSuccessStatusCode) // => pas d'exception
            //        //{

            //        //}
            //        string content = httpResponseMessage.Content.ReadAsStringAsync().Result;
            //        Console.WriteLine(content);

            //        Contact[] contacts = JsonSerializer.Deserialize<Contact[]>(content, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true })!;

            //        foreach (Contact contact in contacts)
            //        {
            //            Console.WriteLine($"- {contact.Id} {contact.Nom}");
            //        }
            //    }
            //}


            //using (HttpClient client = new HttpClient())
            //{
            //    int id = 3;
            //    client.BaseAddress = new Uri("https://localhost:7262");

            //    using (HttpResponseMessage httpResponseMessage = client.GetAsync($"/api/Contact/{id}").Result)
            //    {
            //        httpResponseMessage.EnsureSuccessStatusCode(); // => Exception
            //        //ou
            //        //if (httpResponseMessage.IsSuccessStatusCode) // => pas d'exception
            //        //{

            //        //}
            //        string content = httpResponseMessage.Content.ReadAsStringAsync().Result;
            //        Console.WriteLine(content);

            //        Contact contact = JsonSerializer.Deserialize<Contact>(content, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true })!;

            //        Console.WriteLine($"- {contact.Id} {contact.Nom} {contact.Prenom}");
            //    }
            //}

            //using (HttpClient client = new HttpClient())
            //{
            //    var data = new { 
            //        Nom = "Geerts",
            //        Prenom = "Melanie",
            //        Email = "melanie.geerts@bstorm.be",
            //        Anniversaire = DateTime.Now.AddYears(-18)
            //    };

            //    HttpContent httpContent = JsonContent.Create(data);

            //    client.BaseAddress = new Uri("https://localhost:7262");

            //    using (HttpResponseMessage httpResponseMessage = client.PostAsync("/api/Contact/", httpContent).Result)
            //    {
            //        httpResponseMessage.EnsureSuccessStatusCode(); // => Exception
            //        //ou
            //        //if (httpResponseMessage.IsSuccessStatusCode) // => pas d'exception
            //        //{

            //        //}                    
            //        Console.WriteLine(httpResponseMessage.StatusCode);
            //    }
            //}

            //using (HttpClient client = new HttpClient())
            //{
            //    int id = 4;
            //    var data = new
            //    {
            //        Nom = "Geerts",
            //        Prenom = "Quentin",
            //        Email = "quentin.geerts@bstorm.be",
            //        Anniversaire = DateTime.Now.AddYears(-22)
            //    };

            //    HttpContent httpContent = JsonContent.Create(data);

            //    client.BaseAddress = new Uri("https://localhost:7262");

            //    using (HttpResponseMessage httpResponseMessage = client.PutAsync($"/api/Contact/{id}", httpContent).Result)
            //    {
            //        httpResponseMessage.EnsureSuccessStatusCode(); // => Exception
            //        //ou
            //        //if (httpResponseMessage.IsSuccessStatusCode) // => pas d'exception
            //        //{

            //        //}                    
            //        Console.WriteLine(httpResponseMessage.StatusCode);
            //    }
            //}

            //using (HttpClient client = new HttpClient())
            //{
            //    int id = 4;
            //    var data = new
            //    {
            //        Tel = "555-16396589"
            //    };

            //    HttpContent httpContent = JsonContent.Create(data);

            //    client.BaseAddress = new Uri("https://localhost:7262");

            //    using (HttpResponseMessage httpResponseMessage = client.PatchAsync($"/api/Contact/UpdatePhone/{id}", httpContent).Result)
            //    {
            //        httpResponseMessage.EnsureSuccessStatusCode(); // => Exception
            //        //ou
            //        //if (httpResponseMessage.IsSuccessStatusCode) // => pas d'exception
            //        //{

            //        //}                    
            //        Console.WriteLine(httpResponseMessage.StatusCode);
            //    }
            //}

            //using (HttpClient client = new HttpClient())
            //{
            //    int id = 4;

            //    client.BaseAddress = new Uri("https://localhost:7262");

            //    using (HttpResponseMessage httpResponseMessage = client.DeleteAsync($"/api/Contact/{id}").Result)
            //    {
            //        httpResponseMessage.EnsureSuccessStatusCode(); // => Exception
            //        //ou
            //        //if (httpResponseMessage.IsSuccessStatusCode) // => pas d'exception
            //        //{

            //        //}                    
            //        Console.WriteLine(httpResponseMessage.StatusCode);
            //    }
            //}
        }
    }
}