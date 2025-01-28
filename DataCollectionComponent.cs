namespace DataCollectionWorld.wit.exports.edgee.protocols;

/*
    This is the main class that you will need to implement. It should inherit from
    IDataCollection and implement the following methods:
    Page, Track, User
    These functions are called by the Edgee runtime to get the HTTP request to make to the provider's API for each event type.
*/
public class DataCollectionImpl: IDataCollection {
    public static IDataCollection.EdgeeRequest Page(IDataCollection.Event e, List<(string, string)> creds) {
        /*
            cred is a list of tuple, which contains each key and secret for the provider
            for example, if your component is set to use
                [[components.data_collection]]
                name = "my_component"
                component = "outpout.wasm"
                credentials.test_project_id = "123456789"
                credentials.test_write_key = "abcdefg"
            then
            foreach (var cred in creds)
            {
                Console.WriteLine($"{cred.Item1}: {cred.Item2}");
            }
            will print:
                test_project_id: 123456789
                test_write_key: abcdefg
         */
        string url = "https://example.com/";
        var headers = new List<(string, string)>
        {
            ("Authorization", "Bearer exampleToken123"),
            ("Content-Type", "application/json")
        };
        string body = "{\"event\": \"page\"}";
        return new IDataCollection.EdgeeRequest(IDataCollection.HttpMethod.POST, url, headers, body);
    }
    public static IDataCollection.EdgeeRequest Track(IDataCollection.Event e, List<(string, string)> creds) {
        string url = "https://example.com/";
        var headers = new List<(string, string)>
        {
            ("Authorization", "Bearer exampleToken123"),
            ("Content-Type", "application/json")
        };
        string body = "{\"event\": \"track\"}";
        return new IDataCollection.EdgeeRequest(IDataCollection.HttpMethod.POST, url, headers, body);
    }
    public static IDataCollection.EdgeeRequest User(IDataCollection.Event e, List<(string, string)> creds) {
        string url = "https://example.com/";
        var headers = new List<(string, string)>
        {
            ("Authorization", "Bearer exampleToken123"),
            ("Content-Type", "application/json")
        };
        string body = "{\"event\": \"user\"}";
        return new IDataCollection.EdgeeRequest(IDataCollection.HttpMethod.POST, url, headers, body);
    }
}

