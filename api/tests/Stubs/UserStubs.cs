
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Api.Tests.Stubs
{
    public static class UserStubs
    {
        public static readonly User John = new User
        {
            Id = Guid.NewGuid(),
            Name = "John Doe",
            CorporateEmail = "john@yahoo.com",
            Job = "Software Engineer",
            Tasks = []
        };

        public static readonly User Jane = new User
        {
            Id = Guid.NewGuid(),
            Name = "Jane Smith",
            CorporateEmail = "jane@outlook.com",
            Job = "Product Manager",
            Tasks = []
        };
        public static readonly User Alice = new User
        {
            Id = Guid.NewGuid(),
            Name = "Alice Johnson",
            CorporateEmail = "alice@gmail.com",
            Job = "QA Analyst",
            Tasks = []
        };

        public static readonly User Bob = new User
        {
            Id = Guid.NewGuid(),
            Name = "Bob Brown",
            CorporateEmail = "bob@company.com",
            Job = "DevOps Engineer",
            Tasks = []
        };

        public static readonly User Carol = new User
        {
            Id = Guid.NewGuid(),
            Name = "Carol White",
            CorporateEmail = "carol@enterprise.com",
            Job = "UI Designer",
            Tasks = []
        };

        public static readonly User Dave = new User
        {
            Id = Guid.NewGuid(),
            Name = "Dave Green",
            CorporateEmail = "dave@startup.com",
            Job = "Backend Developer",
            Tasks = []
        };

        public static readonly User Eve = new User
        {
            Id = Guid.NewGuid(),
            Name = "Eve Black",
            CorporateEmail = "eve@security.com",
            Job = "Security Specialist",
            Tasks = []
        };

        public static readonly User Frank = new User
        {
            Id = Guid.NewGuid(),
            Name = "Frank Blue",
            CorporateEmail = "frank@cloud.com",
            Job = "Cloud Architect",
            Tasks = []
        };

        public static readonly User Grace = new User
        {
            Id = Guid.NewGuid(),
            Name = "Grace Pink",
            CorporateEmail = "grace@ai.com",
            Job = "AI Researcher",
            Tasks = []
        };
        
        public static IEnumerable<User> GetAll()
        {
            John.Tasks = [TaskStubs.Task8, TaskStubs.Task5];
            Jane.Tasks = [TaskStubs.Task7, TaskStubs.Task4];
            Alice.Tasks = [TaskStubs.Task1, TaskStubs.Task2];
            Bob.Tasks = [TaskStubs.Task3, TaskStubs.Task4];
            Carol.Tasks = [TaskStubs.Task5, TaskStubs.Task6];
            Dave.Tasks = [TaskStubs.Task7, TaskStubs.Task8];
            Eve.Tasks = [TaskStubs.Task9, TaskStubs.Task1];
            Frank.Tasks = [TaskStubs.Task2, TaskStubs.Task3];
            Grace.Tasks = [TaskStubs.Task4, TaskStubs.Task8];

            return new List<User>
            {
                John, Jane, Alice, Bob, Carol, Dave, Eve, Frank, Grace
            };
        }
    }
}