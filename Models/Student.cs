using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dotnetreact.Models
{
    [BsonIgnoreExtraElements]
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; } = string.Empty;
[BsonElement("firstname")]
        public string Firstname { get; set; } = "Student First Name";
[BsonElement("lastname")]
        public string Lastname { get; set; } = "Student Last Name";
[BsonElement("department")]
        public string Department { get; set; } = "Department";
[BsonElement("class")]
        public string Class { get; set; } = "Class Name";
[BsonElement("gender")]
        public byte Gender { get; set; } = 1;
[BsonElement("birthday")]
public DateTime DateofBirth { get; set; } 

[BsonElement("age")]
        public int Age { get; set; } = 0;

[BsonElement("graduated")]
        public bool IsGraduated { get; set; } 
    }}