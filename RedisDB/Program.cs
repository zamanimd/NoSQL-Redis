using ServiceStack.Redis;
using RedisDB;

var person = new Person
{
    FirstName = "Mohammad",
    LastName = "Zamani"
};

var myID = Guid.NewGuid().ToString();
string myData="";

using (var client = new RedisClient("localhost", 6379))
{
    client.Set<Person>(myID, person);
    myData = client.Get<string>(myID);
}


Console.WriteLine("Added item with key: " + myID);
Console.WriteLine("Received data from redis: " + myData);

Console.ReadKey();
