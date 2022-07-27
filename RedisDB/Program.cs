using ServiceStack.Redis;
using RedisDB;

var person = new Person
{
    FirstName = "Mohammad",
    LastName = "Zamani"
};

var myID = Guid.NewGuid().ToString();

using (var client = new RedisClient("localhost", 6379))
{
    client.Set<Person>(myID, person);
}


Console.WriteLine("Added item in redis database with this key: " + myID);
