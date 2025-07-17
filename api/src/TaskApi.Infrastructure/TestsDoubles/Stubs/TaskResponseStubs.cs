
using TaskApi.Core.Application.DTOs.Responses;

namespace TaskApi.Infrastructure.TestsDoubles.Stubs
{
    public static class TaskResponseStubs
    {
        public static readonly TaskResponse task1 = new TaskResponse
        {
            IsCreated = true,
            Title = "Complete Project Documentation",
            Description = "Finalize the documentation for the project and submit it for review.",
            DueDate = DateTime.Now.AddDays(7),
            Status = {
                Completed = false,
                InProgress = true,
                Pending = false,
            }
        };

        public static readonly TaskResponse task2 = new TaskResponse
        {
            IsCreated = true,
            Title = "Complete Project Documentation",
            Description = "Finalize the documentation for the project and submit it for review.",
            DueDate = DateTime.Now.AddDays(7),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly TaskResponse task3 = new TaskResponse
        {
            IsCreated = true,
            Title = "Complete Project Documentation",
            Description = "Finalize the documentation for the project and submit it for review.",
            DueDate = DateTime.Now.AddDays(7),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly TaskResponse task4 = new TaskResponse
        {
            IsCreated = false,
            Title = "Review Codebase",
            Description = "Go through the codebase and identify areas for refactoring.",
            DueDate = DateTime.Now.AddDays(3),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly TaskResponse task5 = new TaskResponse
        {
            IsCreated = true,
            Title = "Submit Expense Report",
            Description = "Submit the monthly expense report to the finance department.",
            DueDate = DateTime.Now.AddDays(-2),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly TaskResponse task6 = new TaskResponse
        {
            IsCreated = true,
            Title = "Organize Team Meeting",
            Description = "Schedule and organize a team meeting to discuss project milestones, blockers, and next steps. Ensure all team members are available and send out calendar invites.",
            DueDate = DateTime.Now.AddDays(5),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly TaskResponse task7 = new TaskResponse
        {
            IsCreated = false,
            Title = "Fix Bug",
            Description = "Resolve the login issue reported by QA.",
            DueDate = DateTime.Now.AddDays(1),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly TaskResponse task8 = new TaskResponse
        {
            IsCreated = true,
            Title = "Deploy to Production",
            DueDate = DateTime.Now.AddDays(2),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly TaskResponse task9 = new TaskResponse
        {
            IsCreated = false,
            Title = "Plan Annual Retreat",
            Description = "Start planning for the annual company retreat.",
            DueDate = DateTime.Now.AddYears(1),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly TaskResponse task10 = new TaskResponse
        {
            IsCreated = true,
            Title = "",
            Description = "This task has an empty title.",
            DueDate = DateTime.Now.AddDays(10),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly TaskResponse task11 = new TaskResponse
        {
            IsCreated = false,
            Title = "Update README.md!",
            Description = "Add badges and update the documentation in README.md.",
            DueDate = DateTime.Now.AddDays(4),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly TaskResponse task12 = new TaskResponse
        {
            IsCreated = true,
            Title = "Daily Standup",
            Description = "Attend the daily standup meeting.",
            DueDate = DateTime.Today,
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly TaskResponse taskResponseWithDifferentStatus = new TaskResponse
        {
            IsCreated = false,
            Title = "Archive Old Tasks",
            Description = "Move completed tasks older than 6 months to the archive.",
            DueDate = DateTime.Now.AddDays(15),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static IEnumerable<TaskResponse> GetAll()
        {
            return new List<TaskResponse>
            {
                taskResponseWithDifferentStatus ,
                task12,
                task11,
                task10,
                task9,
                task8,
                task7,
                task6,
                task5,
                task3,
                task2,
                task1,
                task4
            };
        }

    }
}