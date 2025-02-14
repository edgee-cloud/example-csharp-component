namespace DataCollectionWorld.wit.exports.edgee.protocols;

/*
    This is the main class that you will need to implement. It should inherit from
    IDataCollection and implement the following methods:
    Page, Track, User
    These functions are called by the Edgee runtime to get the HTTP request to make to the provider's API for each event type.
*/

public struct Settings {
    public string Example { get; }

    public Settings(List<(string, string)> settings) {
        Example = string.Empty;
        foreach (var setting in settings) {
            if (setting.Item1 == "example") {
                Example = setting.Item2;
            }
        }
    }
}

public class DataCollectionImpl: IDataCollection {
    public static IDataCollection.EdgeeRequest Page(IDataCollection.Event e, List<(string, string)> settings) {
        string url = "https://example.com/";
        Settings s = new Settings(settings);
        var headers = new List<(string, string)>
        {
            ("Authorization", "Bearer exampleToken123"),
            ("Content-Type", "application/json"),
            ("example", s.Example)
        };
        string body = "{\"event\": \"page\"}";
        bool forward_client_headers = true;
        return new IDataCollection.EdgeeRequest(IDataCollection.HttpMethod.POST, url, headers, forward_client_headers, body);
    }
    public static IDataCollection.EdgeeRequest Track(IDataCollection.Event e, List<(string, string)> settings) {
        string url = "https://example.com/";
        Settings s = new Settings(settings);
        var headers = new List<(string, string)>
        {
            ("Authorization", "Bearer exampleToken123"),
            ("Content-Type", "application/json"),
            ("example", s.Example)
        };
        string body = "{\"event\": \"track\"}";
        bool forward_client_headers = true;
        return new IDataCollection.EdgeeRequest(IDataCollection.HttpMethod.POST, url, headers, forward_client_headers, body);
    }
    public static IDataCollection.EdgeeRequest User(IDataCollection.Event e, List<(string, string)> settings) {
        string url = "https://example.com/";
        Settings s = new Settings(settings);
        var headers = new List<(string, string)>
        {
            ("Authorization", "Bearer exampleToken123"),
            ("Content-Type", "application/json"),
            ("example", s.Example)
        };
        string body = "{\"event\": \"user\"}";
        bool forward_client_headers = true;
        return new IDataCollection.EdgeeRequest(IDataCollection.HttpMethod.POST, url, headers, forward_client_headers, body);
    }
}

