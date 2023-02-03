using MongoDB.Driver;
using MongoDB.Bson;
internal class Program
{
    private static void Main(string[] args)
    {


        var dbClient = new MongoClient("mongodb://127.0.0.1:27017");
        var dbList = dbClient.ListDatabases().ToList();

        Console.WriteLine("The list of databases are:");

        foreach (var item in dbList)
        {
           // Console.WriteLine(item);
        }


        var database = dbClient.GetDatabase("vishwa_db");
        var collection = database.GetCollection<BsonDocument>("users");
        var documents = collection.Find(new BsonDocument()).ToList();
        foreach (BsonDocument doc in documents)
        {
            Console.WriteLine(doc.ToString());
        }
    }
}