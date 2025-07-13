using Task = TaskApi.Core.Domain.Entities.Task;

namespace TaskApi.Infrastructure.TestsDoubles.Stubs
{
    public static class TaskStubs
    {
        public static readonly Task Task1 = new Task
        {
            Id = Guid.NewGuid(),
            Title = "Complete Project Documentation",
            Description = "Finalize the documentation for the project and submit it for review.",
            DueDate = DateTime.Now.AddDays(7),
            Status = StatusStubs.StatusStub,
        };

        public static readonly Task Task2 = new Task
        {
            Id = Guid.NewGuid(),
            Title = "Implement Authentication",
            Description = "Develop and integrate authentication module using JWT.",
            DueDate = DateTime.Now.AddDays(3),
            Status = StatusStubs.StatusStub,
        };

        public static readonly Task Task3 = new Task
        {
            Id = Guid.NewGuid(),
            Title = "Design Database Schema",
            Description = "Create and review the initial database schema for the application.",
            DueDate = DateTime.Now.AddDays(5),
            Status = StatusStubs.StatusStub,
        };

        public static readonly Task Task4 = new Task
        {
            Id = Guid.NewGuid(),
            Title = "Setup CI/CD Pipeline",
            Description = "Configure continuous integration and deployment pipeline.",
            DueDate = DateTime.Now.AddDays(10),
            Status = StatusStubs.StatusStub,
        };

        public static readonly Task Task5 = new Task
        {
            Id = Guid.NewGuid(),
            Title = "Write Unit Tests",
            Description = "Write unit tests for the service layer.",
            DueDate = DateTime.Now.AddDays(4),
            Status = StatusStubs.StatusStub,
        };

        public static readonly Task Task6 = new Task
        {
            Id = Guid.NewGuid(),
            Title = "Refactor API Endpoints",
            Description = "Refactor and optimize existing API endpoints.",
            DueDate = DateTime.Now.AddDays(6),
            Status = StatusStubs.StatusStub,
        };

        public static readonly Task Task7 = new Task
        {
            Id = Guid.NewGuid(),
            Title = "Prepare Release Notes",
            Description = "Draft and review release notes for the upcoming version.",
            DueDate = DateTime.Now.AddDays(2),
            Status = StatusStubs.StatusStub,
        };

        public static readonly Task Task8 = new Task
        {
            Id = Guid.NewGuid(),
            Title = "Conduct Code Review",
            Description = "Review code submissions and provide feedback.",
            DueDate = DateTime.Now.AddDays(1),
            Status = StatusStubs.StatusStub,
        };

        public static readonly Task Task9 = new Task
        {
            Id = Guid.NewGuid(),
            Title = "Optimize Database Queries",
            Description = "Analyze and optimize slow database queries.",
            DueDate = DateTime.Now.AddDays(8),
            Status = StatusStubs.StatusStub,
        };

        public static IEnumerable<Task> GetAll()
        {
            return new List<Task>
            {
                Task1, Task2, Task3, Task4, Task5, Task6, Task7, Task8, Task9
            };
        }
    }
}