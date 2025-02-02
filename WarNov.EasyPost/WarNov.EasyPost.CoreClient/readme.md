# `WarNov.EasyPost.NetStandard`

`WarNov.EasyPost.NetStandard` makes it extremely easy to send a JSON object to an HTTP Endpoint via POST.

## Installation

To install `WarNov.EasyPost.NetStandard`, run the following command in the Visual Studio terminal:

```sh
dotnet add package WarNov.EasyPost.NetStandard
```

## Usage

Here is an example of how to use the `EasyPost` class to send a JSON object to an HTTP endpoint via POST:

```csharp
using System;
using WarNov.EasyPost.NetStandard;

class Program 
{
    static void Main() 
    {
        string url = "https://example.com/api/endpoint"; 
        var payload = new { Name = "John Doe", Age = 30 };

        var response = EasyPost.Post(url, payload);
        Console.WriteLine(response.StatusCode);
    }
}
```

## Method

### `EasyPost.Post`

```csharp
public static HttpResponseMessage Post(string url, object payload)
```

#### Parameters

- `url` (*string*): The URL to send the info.
- `payload` (*object*): The info to be sent.

#### Returns

- `HttpResponseMessage`: The result of the operation.

## License

This project is licensed under the MIT License.
