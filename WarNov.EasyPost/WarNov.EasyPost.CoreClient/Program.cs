using System;
using WarNov.EasyPost.NetStandard;

class Program
{
    static void Main()
    {
        string url = "https://webhook.site/946815b8-50ea-4e2e-8315-4a3e45094f03";
        var payload = new { Name = "John Doe", Age = 30 };

        var response = EasyPost.Post(url, payload);
        Console.WriteLine(response.StatusCode);
    }
}
