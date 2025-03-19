using DependencyInjection.Services;

namespace DependencyInjection.Manager
{
    public class Teacher : ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetInfo(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            
            return $"Teacher: {firstName} {lastName}";
        }
    }
}