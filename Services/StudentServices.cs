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

//get student by id
public async Task<Student> GetStudentById(string id){
    return await _studentCollection.Find<Student>(s => s.Id == id).FirstOrDefaultAsync();
    }

//create student
public async Task CreateStudent(Student newStudent){
    await _studentCollection.InsertOneAsync(newStudent);
    }

//update student
public async Task UpdateStudent(string id, Student updatedStudent){
    await _studentCollection.ReplaceOneAsync(s => s.Id == id, updatedStudent);
    }

//delete student
public async Task DeleteStudent(string id){
    await _studentCollection.DeleteOneAsync(s => s.Id == id);
    }
    
}}