
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Infrastructure.TestsDoubles.Stubs
{
    public static class DutyStubs
    {
        public static readonly Duty Task1 = new Duty
        {
            Title = "Complete Project Documentation",
            Description = "Finalize the documentation for the project and submit it for review.",
            DueDate = DateTime.Now.AddDays(7),
            Status = {
                Completed = false,
                InProgress = true,
                Pending = false,
            }
        };

        public static readonly Duty Task2 = new Duty
        {
            Title = "Complete Project Documentation",
            Description = "Finalize the documentation for the project and submit it for review.",
            DueDate = DateTime.Now.AddDays(7),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly Duty Task3 = new Duty
        {
            Title = "Complete Project Documentation",
            Description = "Finalize the documentation for the project and submit it for review.",
            DueDate = DateTime.Now.AddDays(7),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly Duty Task4 = new Duty
        {
            Title = "Review Codebase",
            Description = "Go through the codebase and identify areas for refactoring.",
            DueDate = DateTime.Now.AddDays(3),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly Duty Task5 = new Duty
        {
            Title = "Submit Expense Report",
            Description = "Submit the monthly expense report to the finance department.",
            DueDate = DateTime.Now.AddDays(-2),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly Duty Task6 = new Duty
        {
            Title = "Organize Team Meeting",
            Description = "Schedule and organize a team meeting to discuss project milestones, blockers, and next steps. Ensure all team members are available and send out calendar invites.",
            DueDate = DateTime.Now.AddDays(5),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly Duty Task7 = new Duty
        {
            Title = "Fix Bug",
            Description = "Resolve the login issue reported by QA.",
            DueDate = DateTime.Now.AddDays(1),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly Duty Task8 = new Duty
        {
            Title = "Deploy to Production",
            DueDate = DateTime.Now.AddDays(2),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly Duty Task9 = new Duty
        {
            Title = "Plan Annual Retreat",
            Description = "Start planning for the annual company retreat.",
            DueDate = DateTime.Now.AddYears(1),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly Duty Task10 = new Duty
        {
            Title = "",
            Description = "This Duty has an empty title.",
            DueDate = DateTime.Now.AddDays(10),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly Duty Task11 = new Duty
        {
            Title = "Update README.md!",
            Description = "Add badges and update the documentation in README.md.",
            DueDate = DateTime.Now.AddDays(4),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly Duty Task12 = new Duty
        {
            Title = "Daily Standup",
            Description = "Attend the daily standup meeting.",
            DueDate = DateTime.Today,
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static readonly Duty Task13 = new Duty
        {
            Title = "Archive Old Tasks",
            Description = "Move completed Tasks older than 6 months to the archive.",
            DueDate = DateTime.Now.AddDays(15),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            }
        };

        public static List<Duty> GetAll()
        {
            return new List<Duty>
            {
                Task13,
                Task12,
                Task11,
                Task10,
                Task9,
                Task8,
                Task7,
                Task6,
                Task5,
                Task3,
                Task2,
                Task1,
                Task4
            };
        }

    }
}