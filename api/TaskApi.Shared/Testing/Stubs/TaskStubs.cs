using TaskApi.Domain.Entities;
using Task = TaskApi.Domain.Entities.Task;

namespace TaskApi.Shared.Testing.Stubs
{
    public static class TaskStubs
    {
        public static readonly Task TaskEve = new Task
        {
            Id = Guid.NewGuid(),
            Title = "Complete Project Documentation",
            Description = "Finalize the documentation for the project and submit it for review.",
            DueDate = DateTime.Now.AddDays(7),
            Status = StatusStubs.StatusStub,
        };
        public static readonly Task TaskBob = new Task
        {
            Id = Guid.NewGuid(),
            Title = "Implement Authentication",
            Description = "Develop and integrate authentication module using JWT.",
            DueDate = DateTime.Now.AddDays(3),
            Status = StatusStubs.StatusStub,
        };

        public static readonly Task TaskAlice = new Task
        {
            Id = Guid.NewGuid(),
            Title = "Design Database Schema",
            Description = "Create and review the initial database schema for the application.",
            DueDate = DateTime.Now.AddDays(5),
            Status = StatusStubs.StatusStub,
        };

        public static readonly Task TaskCarol = new Task
        {
            Id = Guid.NewGuid(),
            Title = "Setup CI/CD Pipeline",
            Description = "Configure continuous integration and deployment pipeline.",
            DueDate = DateTime.Now.AddDays(10),
            Status = StatusStubs.StatusStub,
        };

        public static readonly Task TaskDave = new Task
        {
            Id = Guid.NewGuid(),
            Title = "Write Unit Tests",
            Description = "Write unit tests for the service layer.",
            DueDate = DateTime.Now.AddDays(4),
            Status = StatusStubs.StatusStub,
        };

        public static readonly Task TaskFrank = new Task
        {
            Id = Guid.NewGuid(),
            Title = "Refactor API Endpoints",
            Description = "Refactor and optimize existing API endpoints.",
            DueDate = DateTime.Now.AddDays(6),
            Status = StatusStubs.StatusStub,
        };

        public static readonly Task TaskGrace = new Task
        {
            Id = Guid.NewGuid(),
            Title = "Prepare Release Notes",
            Description = "Draft and review release notes for the upcoming version.",
            DueDate = DateTime.Now.AddDays(2),
            Status = StatusStubs.StatusStub,
        };

        public static readonly Task TaskHeidi = new Task
        {
            Id = Guid.NewGuid(),
            Title = "Conduct Code Review",
            Description = "Review code submissions and provide feedback.",
            DueDate = DateTime.Now.AddDays(1),
            Status = StatusStubs.StatusStub,
        };

        public static readonly Task TaskIvan = new Task
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
                TaskEve, TaskBob, TaskAlice, TaskCarol, TaskDave, TaskFrank, TaskGrace, TaskHeidi, TaskIvan
            };
        }
    }
}