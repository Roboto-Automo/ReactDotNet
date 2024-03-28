using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace dotnetreact.Models
{
    public class StudentServices
    {
private readonly IMongoCollection<Student> _studentCollection;

public StudentServices(IOptions<DatabaseSettings> settings){
    var mongoClient = new MongoClient(settings.Value.Connection);
    var mongoDB = mongoClient.GetDatabase(settings.Value.DatabaseName);
    _studentCollection = mongoDB.GetCollection<Student>(settings.Value.CollectionName);
}
//get all students

public async Task<List<Student>> GetAllStudents(){
    return await _studentCollection.Find(_ => true).ToListAsync();
    }
}}