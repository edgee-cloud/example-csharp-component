namespace DataCollectionWorld.wit.exports.edgee.protocols;

public class DataCollectionImpl: IDataCollection {
   public static IDataCollection.EdgeeRequest Page(IDataCollection.Event e, List<(string, string)> creds) {
      return new IDataCollection.EdgeeRequest(IDataCollection.HttpMethod.POST, "/page", creds, "");
   }
   public static IDataCollection.EdgeeRequest Track(IDataCollection.Event e, List<(string, string)> creds) {
      return new IDataCollection.EdgeeRequest(IDataCollection.HttpMethod.POST, "/page", creds, "");
   }
   public static IDataCollection.EdgeeRequest User(IDataCollection.Event e, List<(string, string)> creds) {
      return new IDataCollection.EdgeeRequest(IDataCollection.HttpMethod.POST, "/page", creds, "");
   }
}

