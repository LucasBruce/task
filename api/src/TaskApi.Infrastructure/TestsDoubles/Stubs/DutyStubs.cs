
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
            },
            User = UserStubs.User1
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
            },
            User = UserStubs.User1
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
            },
            User = UserStubs.User1
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
            },
            User = UserStubs.User2
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
            },
            User = UserStubs.User2
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
            },
            User = UserStubs.User3
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
            },
            User = UserStubs.User4
        };

        public static readonly Duty Task8 = new Duty
        {
            Title = "Deploy to Production",
            DueDate = DateTime.Now.AddDays(2),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            },
            User = UserStubs.User5
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
            },
            User = UserStubs.User6
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
            },
            User = UserStubs.User7
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
            },
            User = UserStubs.User8
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
            },
            User = UserStubs.User9
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
            },
            User = UserStubs.User10
        };

        public static readonly Duty Task14 = new Duty
        {
            Title = "Conduct User Research",
            Description = "Plan and conduct user research sessions to gather feedback on the new feature.",
            DueDate = DateTime.Now.AddDays(20),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            },
            User = UserStubs.User11
        };

        public static readonly Duty Task15 = new Duty
        {
            Title = "Prepare Presentation",
            Description = "Create a presentation for the upcoming stakeholder meeting.",
            DueDate = DateTime.Now.AddDays(8),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            },
            User = UserStubs.User12
        };

        public static readonly Duty Task16 = new Duty
        {
            Title = "Conduct Code Review",
            Description = "Review the latest pull requests and provide feedback.",
            DueDate = DateTime.Now.AddDays(3),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            },
            User = UserStubs.User13
        };

        public static readonly Duty Task17 = new Duty
        {
            Title = "Implement Feedback",
            Description = "Incorporate feedback from the last sprint retrospective.",
            DueDate = DateTime.Now.AddDays(5),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            },
            User = UserStubs.User14
        };

        public static readonly Duty Task18 = new Duty
        {
            Title = "Conduct User Interviews",
            Description = "Schedule and conduct interviews with users to gather feedback.",
            DueDate = DateTime.Now.AddDays(10),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            },
            User = UserStubs.User15
        };

        public static readonly Duty Task19 = new Duty
        {
            Title = "Create User Personas",
            Description = "Develop user personas based on research findings.",
            DueDate = DateTime.Now.AddDays(12),
            Status = {
                Completed = true,
                InProgress = false,
                Pending = false,
            },
            User = UserStubs.User15
        };

        public static List<Duty> GetAll()
        {
            return new List<Duty>
            {
                Task19,
                Task18,
                Task17,
                Task16,
                Task15,
                Task14,
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